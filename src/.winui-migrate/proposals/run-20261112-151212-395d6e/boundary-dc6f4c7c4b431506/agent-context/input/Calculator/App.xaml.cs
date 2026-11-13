// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

//
// App.xaml.h
// Declaration of the App class.
//

using System;
using System.Diagnostics;
using System.Threading.Tasks;

using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Storage;
using Windows.UI.StartScreen;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Windows.AppLifecycle;

using CalculatorApp.Utils;
using CalculatorApp.ViewModel.Common;
using CalculatorApp.ViewModel.Common.Automation;

namespace CalculatorApp
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public sealed partial class App
    {
        /// <summary>
        /// Initializes the singleton application object. This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            InitializeComponent();
            NarratorNotifier.RegisterDependencyProperties();

            // TODO: MSFT 14645325: Set this directly from XAML.
            // Currently this is bugged so the property is only respected from code-behind.
            HighContrastAdjustment = ApplicationHighContrastAdjustment.None;
#if DEBUG
            DebugSettings.IsBindingTracingEnabled = true;
            DebugSettings.BindingFailed += (sender, args) =>
            {
                if (Debugger.IsAttached)
                {
                    _ = args.Message; // Inspect in debugger
                    Debugger.Break();
                }
            };
#endif
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user. Other entry points
        /// will be used when the application is launched to open a specific file, to display
        /// search results, and so forth.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            MainWindow ??= new global::Microsoft.UI.Xaml.Window();
            // UWP titled the view with the app's display name; a desktop window would show "WinUI Desktop".
#if IS_STORE_BUILD
            MainWindow.Title = global::CalculatorApp.ViewModel.Common.AppResourceProvider.GetInstance().GetResourceString("AppName");
#else
            MainWindow.Title = global::CalculatorApp.ViewModel.Common.AppResourceProvider.GetInstance().GetResourceString("DevAppName");
#endif
            // Decision D8: the work UWP ran on Suspending runs when the primary window is asked to close.
            MainWindow.AppWindow.Closing += OnMainWindowClosing;
            MainWindow.AppWindow.Changed += OnMainWindowChanged;

            // A desktop launch carries no UWP user. The stored ID only fed the graphing policy, which this build leaves out.
            NavCategoryStates.SetCurrentUser(string.Empty);

            // It takes time to check GraphingMode at the very first time. Warm up in a background thread.
            Task.Run(() => NavCategoryStates.IsViewModeEnabled(ViewMode.Graphing));

            // Protocol activation (ms-calculator:snapshot/...) arrived through OnActivated in UWP; a desktop
            // process receives every activation kind here and reads it from its AppInstance.
            var activation = Microsoft.Windows.AppLifecycle.AppInstance.GetCurrent().GetActivatedEventArgs();
            if (activation.Kind == ExtendedActivationKind.Protocol && activation.Data is IProtocolActivatedEventArgs protocolArgs)
            {
                OnAppLaunch(protocolArgs.TryGetSnapshotProtocol(out var protoArgs) ? protoArgs.GetSnapshotLaunchArgs() : null);
            }
            else
            {
                OnAppLaunch(args.Arguments);
            }
        }

        private void OnAppLaunch(object arguments)
        {
            // Uncomment the following lines to display frame-rate and per-frame CPU usage info.
            //#if DEBUG
            //    if (IsDebuggerPresent())
            //    {
            //        DebugSettings.EnableFrameRateCounter = true;
            //    }
            //#endif

            var minWindowWidth = Convert.ToSingle(Resources["AppMinWindowWidth"]);
            var minWindowHeight = Convert.ToSingle(Resources["AppMinWindowHeight"]);
            var minWindowSize = SizeHelper.FromDimensions(minWindowWidth, minWindowHeight);
            var appWindow = global::CalculatorApp.App.MainWindow.AppWindow;
            var localSettings = ApplicationData.Current.LocalSettings;

            // SetPreferredMinSize should always be called before Window.Activate.
            // The presenter's preferred minimum is in physical pixels; the resource values are DIPs.
            var minPhysicalSize = CalculatorApp.ViewModel.Common.Utils.ToPhysicalSize(appWindow, minWindowSize);
            if (appWindow.Presenter is OverlappedPresenter presenter)
            {
                presenter.PreferredMinimumWidth = minPhysicalSize.Width;
                presenter.PreferredMinimumHeight = minPhysicalSize.Height;
            }

            // For very first launch, set the size of the calc as size of the default standard mode
            if (!localSettings.Values.ContainsKey("VeryFirstLaunch"))
            {
                localSettings.Values["VeryFirstLaunch"] = false;
                appWindow.ResizeClient(minPhysicalSize); // the requested size must not be less than the min size.
            }
            else
            {
                // UWP set PreferredLaunchWindowingMode to Auto, which reopens the window where it was last closed.
                WindowPlacement.Restore(appWindow);
            }

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            var rootFrame = global::CalculatorApp.App.MainWindow.Content as Frame;
            if (rootFrame == null)
            {
                rootFrame = new Frame
                {
                    FlowDirection = LocalizationSettings.GetInstance().GetFlowDirection()
                };
            }

            // When the navigation stack isn't restored navigate to the first page,
            // configuring the new page by passing required information as a navigation
            // parameter
            if (rootFrame.Content == null && !rootFrame.Navigate(typeof(MainPage), arguments))
            {
                // We couldn't navigate to the main page, kill the app so we have a good
                // stack to debug
                throw new SystemException("6d430286-eb5d-4f8d-95d2-3d1059552968");
            }

            // Place the frame in the current Window
            global::CalculatorApp.App.MainWindow.Content = rootFrame;
            ThemeHelper.InitializeAppTheme();
            global::CalculatorApp.App.MainWindow.Activate();

            // UWP deferred this until its splash screen was dismissed; a desktop window has no splash screen.
            _ = SetupJumpListAsync();
        }

        private void OnMainWindowClosing(AppWindow sender, AppWindowClosingEventArgs args)
        {
            TraceLogger.GetInstance().LogButtonUsage();
            WindowPlacement.Save(sender);
        }

        private static void OnMainWindowChanged(AppWindow sender, AppWindowChangedEventArgs args)
        {
            if (args.DidPositionChange || args.DidSizeChange || args.DidPresenterChange)
            {
                WindowPlacement.Track(sender);
            }
        }

        private async Task SetupJumpListAsync()
        {
            try
            {
                var calculatorOptions = NavCategoryStates.CreateCalculatorCategoryGroup();

                var jumpList = await JumpList.LoadCurrentAsync();
                jumpList.SystemGroupKind = JumpListSystemGroupKind.None;
                jumpList.Items.Clear();

                foreach (NavCategory option in calculatorOptions.Categories)
                {
                    // Graphing is not part of the WinUI 3 build: its GraphControl is C++/CX, which WinUI 3 cannot host.
                    if (!NavCategoryStates.IsViewModeEnabled(option.ViewMode) || NavCategory.IsGraphingCalculatorViewMode(option.ViewMode))
                    {
                        continue;
                    }
                    ViewMode mode = option.ViewMode;
                    var item = JumpListItem.CreateWithArguments(((int)mode).ToString(), "ms-resource:///Resources/" + NavCategoryStates.GetNameResourceKey(mode));
                    item.Description = "ms-resource:///Resources/" + NavCategoryStates.GetNameResourceKey(mode);
                    item.Logo = new Uri("ms-appx:///Assets/" + mode + ".png");
                    jumpList.Items.Add(item);
                }

                await jumpList.SaveAsync();
            }
            catch (Exception ex)
            {
                TraceLogger.GetInstance().LogError(ViewMode.None, nameof(SetupJumpListAsync), ex.ToString());
#if DEBUG
                throw;
#endif
            }
        }

    public static global::Microsoft.UI.Xaml.Window MainWindow { get; private set; } = null!;
    }
}

