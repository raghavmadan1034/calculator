using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;

using Windows.ApplicationModel.UserActivities;
using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Automation;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Controls;

using CalculatorApp.Common;
using CalculatorApp.Converters;
using CalculatorApp.JsonUtils;
using CalculatorApp.ViewModel;
using CalculatorApp.ViewModel.Common;
using CalculatorApp.ViewModel.Common.Automation;

using wuxc = Microsoft.UI.Xaml.Controls;

namespace CalculatorApp
{
    public sealed partial class MainPage : wuxc.Page
    {
        public static readonly DependencyProperty NavViewCategoriesSourceProperty =
            DependencyProperty.Register(nameof(NavViewCategoriesSource), typeof(List<object>), typeof(MainPage), new PropertyMetadata(default));

        public List<object> NavViewCategoriesSource
        {
            get => (List<object>)GetValue(NavViewCategoriesSourceProperty);
            set => SetValue(NavViewCategoriesSourceProperty, value);
        }

        public ApplicationViewModel ViewModel { get; }

        public MainPage()
        {
            ViewModel = new ApplicationViewModel();
            ViewModel.AppWindow = global::CalculatorApp.App.MainWindow.AppWindow;
            InitializeNavViewCategoriesSource();
            InitializeComponent();

            KeyboardShortcutManager.Initialize(this);

            // Decision D8: the always-on-top size UWP saved on Suspending is saved when the window is asked to close.
            global::CalculatorApp.App.MainWindow.AppWindow.Closing += OnMainWindowClosing;
            ViewModel.PropertyChanged += OnAppPropertyChanged;
            // AccessibilitySettings events need a CoreWindow; ThemeSettings reports the main window's high-contrast state.
            m_themeSettings = Microsoft.UI.System.ThemeSettings.CreateForWindowId(global::CalculatorApp.App.MainWindow.AppWindow.Id);
            m_isHighContrast = m_themeSettings.HighContrast;

            if (Utilities.GetIntegratedDisplaySize(WinRT.Interop.WindowNative.GetWindowHandle(global::CalculatorApp.App.MainWindow), out var sizeInInches))
            {
                if (sizeInInches < 7.0) // If device's display size (diagonal length) is less than 7 inches then keep the calc always in Portrait mode only
                {
                    DisplayInformation.AutoRotationPreferences = DisplayOrientations.Portrait | DisplayOrientations.PortraitFlipped;
                }
            }

            var userActivityRequestManager = TryGetUserActivityRequestManager(global::CalculatorApp.App.MainWindow);
            if (userActivityRequestManager != null)
            userActivityRequestManager.UserActivityRequested += async (_, args) =>
            {
                using (var deferral = args.GetDeferral())
                {
                    if (deferral == null)
                    {
                        // FIXME: https://microsoft.visualstudio.com/DefaultCollection/OS/_workitems/edit/47775705/
                        TraceLogger.GetInstance().LogRecallError("55e29ba5-6097-40ec-8960-458750be3039");
                        return;
                    }
                    var channel = UserActivityChannel.GetDefault();
                    var activity = await channel.GetOrCreateUserActivityAsync($"{Guid.NewGuid()}");
                    string embeddedData;
                    try
                    {
                        var json = JsonSerializer.Serialize(new ApplicationSnapshotAlias(ViewModel.Snapshot));
                        embeddedData = Convert.ToBase64String(DeflateUtils.Compress(json));
                    }
                    catch (Exception ex)
                    {
                        TraceLogger.GetInstance().LogRecallError($"Error occurs during the serialization of Snapshot. Exception: {ex}");
                        deferral.Complete();
                        return;
                    }
                    activity.ActivationUri = new Uri($"ms-calculator:snapshot/{embeddedData}");
                    activity.IsRoamable = false;
                    var resProvider = AppResourceProvider.GetInstance();
                    activity.VisualElements.DisplayText =
                        $"{resProvider.GetResourceString("AppName")} - {resProvider.GetResourceString(NavCategoryStates.GetNameResourceKey(ViewModel.Mode))}";
                    await activity.SaveAsync();
                    args.Request.SetUserActivity(activity);
                    deferral.Complete();
                    TraceLogger.GetInstance().LogRecallSnapshot(ViewModel.Mode);
                }
            };
        }

        public void UnregisterEventHandlers()
        {
            global::CalculatorApp.App.MainWindow.SizeChanged -= WindowSizeChanged;
            m_themeSettings.Changed -= OnHighContrastChanged;

            if (m_calculator != null)
            {
                m_calculator.UnregisterEventHandlers();
            }
        }

        public void SetDefaultFocus()
        {
            if (m_calculator != null && m_calculator.Visibility == Visibility.Visible)
            {
                m_calculator.SetDefaultFocus();
            }
            if (m_dateCalculator != null && m_dateCalculator.Visibility == Visibility.Visible)
            {
                m_dateCalculator.SetDefaultFocus();
            }
            if (m_converter != null && m_converter.Visibility == Visibility.Visible)
            {
                m_converter.SetDefaultFocus();
            }
        }

        public void SetHeaderAutomationName()
        {
            ViewMode mode = ViewModel.Mode;
            var resProvider = AppResourceProvider.GetInstance();

            string name;
            if (NavCategory.IsDateCalculatorViewMode(mode))
            {
                name = resProvider.GetResourceString("HeaderAutomationName_Date");
            }
            else
            {
                string full = string.Empty;
                if (NavCategory.IsCalculatorViewMode(mode) || NavCategory.IsGraphingCalculatorViewMode(mode))
                {
                    full = resProvider.GetResourceString("HeaderAutomationName_Calculator");
                }
                else if (NavCategory.IsConverterViewMode(mode))
                {
                    full = resProvider.GetResourceString("HeaderAutomationName_Converter");
                }
                name = LocalizationStringUtil.GetLocalizedString(full, ViewModel.CategoryName);
            }

            AutomationProperties.SetName(Header, name);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var initialMode = ViewMode.Standard;
            var localSettings = ApplicationData.Current.LocalSettings;
            if (localSettings.Values.ContainsKey(nameof(ApplicationViewModel.Mode)))
            {
                initialMode = NavCategoryStates.Deserialize(localSettings.Values[nameof(ApplicationViewModel.Mode)]);
            }

            if (e.Parameter == null)
            {
                ViewModel.Initialize(initialMode);
                return;
            }

            if (e.Parameter is string legacyArgs)
            {
                if (legacyArgs.Length > 0)
                {
                    initialMode = (ViewMode)Convert.ToInt32(legacyArgs);
                }
                ViewModel.Initialize(initialMode);
            }
            else if (e.Parameter is SnapshotLaunchArguments snapshotArgs)
            {
                ViewModel.Initialize(initialMode);
                bool restored = false;
                if (!snapshotArgs.HasError)
                {
                    try
                    {
                        ViewModel.RestoreFromSnapshot(snapshotArgs.Snapshot);
                        restored = true;
                        TraceLogger.GetInstance().LogRecallRestore((ViewMode)snapshotArgs.Snapshot.Mode);
                    }
                    catch (Exception ex)
                    {
                        TraceLogger.GetInstance().LogRecallError($"OnNavigatedTo:Restore failed. {ex.Message}");
                    }
                }

                if (!restored)
                {
                    _ = DispatcherQueue.TryEnqueue(async () => await ShowSnapshotLaunchErrorAsync());
                    if (snapshotArgs.HasError)
                    {
                        TraceLogger.GetInstance().LogRecallError("OnNavigatedTo:Found errors.");
                    }
                }
            }
            else
            {
                Environment.FailFast("cd75d5af-0f47-4cc2-910c-ed792ed16fe6");
            }
        }

        private void InitializeNavViewCategoriesSource()
        {
            NavViewCategoriesSource = ExpandNavViewCategoryGroups(ViewModel.Categories);
            _ = DispatcherQueue.TryEnqueue(Microsoft.UI.Dispatching.DispatcherQueuePriority.Low, () =>
            {
                var graphCategory = (NavCategory)NavViewCategoriesSource.Find(x =>
                {
                    if (x is NavCategory category)
                    {
                        return category.ViewMode == ViewMode.Graphing;
                    }
                    else
                    {
                        return false;
                    }
                });
                // Graphing is not part of the WinUI 3 build: its GraphControl is C++/CX, which WinUI 3 cannot host.
                graphCategory.IsEnabled = false;
            });
        }

        private List<object> ExpandNavViewCategoryGroups(IEnumerable<NavCategoryGroup> groups)
        {
            var result = new List<object>();
            foreach (var group in groups)
            {
                result.Add(group);
                foreach (var category in group.Categories)
                {
                    result.Add(category);
                }
            }
            return result;
        }

        private void UpdatePopupSize(Microsoft.UI.Xaml.WindowSizeChangedEventArgs e)
        {
            if (PopupContent != null)
            {
                PopupContent.Width = e.Size.Width;
                PopupContent.Height = e.Size.Height;
            }
        }

        private void WindowSizeChanged(object sender, Microsoft.UI.Xaml.WindowSizeChangedEventArgs e)
        {
            // We don't use layout aware page's view states, we have our own
            UpdateViewState();
            UpdatePopupSize(e);
        }

        private void OnAppPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            string propertyName = e.PropertyName;
            if (propertyName == nameof(ApplicationViewModel.Mode))
            {
                ViewMode newValue = ViewModel.Mode;
                ViewMode previousMode = ViewModel.PreviousMode;

                KeyboardShortcutManager.DisableShortcuts(false);

                switch (newValue)
                {
                    case ViewMode.Standard:
                        EnsureCalculator();
                        ViewModel.CalculatorViewModel.HistoryVM.AreHistoryShortcutsEnabled = true;
                        m_calculator.AnimateCalculator(NavCategory.IsConverterViewMode(previousMode));
                        ViewModel.CalculatorViewModel.HistoryVM.ReloadHistory(newValue);
                        break;
                    case ViewMode.Scientific:
                        EnsureCalculator();
                        ViewModel.CalculatorViewModel.HistoryVM.AreHistoryShortcutsEnabled = true;
                        if (ViewModel.PreviousMode != ViewMode.Scientific)
                        {
                            m_calculator.AnimateCalculator(NavCategory.IsConverterViewMode(previousMode));
                        }
                        ViewModel.CalculatorViewModel.HistoryVM.ReloadHistory(newValue);
                        break;
                    case ViewMode.Programmer:
                        ViewModel.CalculatorViewModel.HistoryVM.AreHistoryShortcutsEnabled = false;
                        EnsureCalculator();
                        if (ViewModel.PreviousMode != ViewMode.Programmer)
                        {
                            m_calculator.AnimateCalculator(NavCategory.IsConverterViewMode(previousMode));
                        }
                        break;
                    default:
                        if (NavCategory.IsDateCalculatorViewMode(newValue))
                        {
                            if (ViewModel.CalculatorViewModel != null)
                            {
                                ViewModel.CalculatorViewModel.HistoryVM.AreHistoryShortcutsEnabled = false;
                            }
                            EnsureDateCalculator();
                        }
                        else if (NavCategory.IsConverterViewMode(newValue))
                        {
                            if (ViewModel.CalculatorViewModel != null)
                            {
                                ViewModel.CalculatorViewModel.HistoryVM.AreHistoryShortcutsEnabled = false;
                            }

                            EnsureConverter();
                            if (!NavCategory.IsConverterViewMode(previousMode))
                            {
                                m_converter.AnimateConverter();
                            }
                        }
                        break;
                }

                ShowHideControls(newValue);

                UpdateViewState();
                SetDefaultFocus();
            }
            else if (propertyName == nameof(ApplicationViewModel.CategoryName))
            {
                SetHeaderAutomationName();
                AnnounceCategoryName();
            }
        }

        private void SelectNavigationItemByModel()
        {
            var menuItems = (List<object>)NavView.MenuItemsSource;
            var itemCount = menuItems.Count;
            var flatIndex = NavCategoryStates.GetFlatIndex(ViewModel.Mode);

            if (flatIndex >= 0 && flatIndex < itemCount)
            {
                NavView.SelectedItem = menuItems[flatIndex];
            }
        }

        private void OnNavLoaded(object sender, RoutedEventArgs e)
        {
            if (NavView.SelectedItem == null)
            {
                SelectNavigationItemByModel();
            }

            var acceleratorList = new List<MyVirtualKey>();
            NavCategoryStates.GetCategoryAcceleratorKeys(acceleratorList);

            foreach (var accelerator in acceleratorList)
            {
                NavView.SetValue(KeyboardShortcutManager.VirtualKeyAltChordProperty, accelerator);
            }
            // Special case logic for Ctrl+E accelerator for Date Calculation Mode
            NavView.SetValue(KeyboardShortcutManager.VirtualKeyControlChordProperty, MyVirtualKey.E);
        }

        private void OnNavPaneOpened(NavigationView sender, object args)
        {
            KeyboardShortcutManager.HonorShortcuts(false);
            TraceLogger.GetInstance().LogNavBarOpened();
        }

        private void OnNavPaneClosed(NavigationView sender, object args)
        {
            if (Popup.IsOpen)
            {
                return;
            }

            if (ViewModel.Mode != ViewMode.Graphing)
            {
                KeyboardShortcutManager.HonorShortcuts(true);
            }

            SetDefaultFocus();
        }

        private void EnsurePopupContent()
        {
            if (PopupContent == null)
            {
                FindName("PopupContent");

                var windowBounds = global::CalculatorApp.App.MainWindow.Bounds;
                PopupContent.Width = windowBounds.Width;
                PopupContent.Height = windowBounds.Height;
            }
        }

        private void ShowSettingsPopup()
        {
            EnsurePopupContent();
            Popup.IsOpen = true;
        }

        private void CloseSettingsPopup()
        {
            Popup.IsOpen = false;
            SelectNavigationItemByModel();
            SetDefaultFocus();
        }

        private void Popup_Opened(object sender, object e)
        {
            KeyboardShortcutManager.IgnoreEscape(false);
            KeyboardShortcutManager.HonorShortcuts(false);
        }

        private void Popup_Closed(object sender, object e)
        {
            KeyboardShortcutManager.HonorEscape();
            KeyboardShortcutManager.HonorShortcuts(!NavView.IsPaneOpen);
        }

        private void OnNavSelectionChanged(object sender, NavigationViewSelectionChangedEventArgs e)
        {
            if (e.IsSettingsSelected)
            {
                ShowSettingsPopup();
                return;
            }

            if (e.SelectedItemContainer is NavigationViewItem item)
            {
                ViewModel.Mode = (ViewMode)item.Tag;
            }
        }

        private void OnNavItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs e)
        {
            NavView.IsPaneOpen = false;
        }

        private void AlwaysOnTopButtonClick(object sender, RoutedEventArgs e)
        {
            ViewModel.ToggleAlwaysOnTop(0, 0);
        }

        private void TitleBarAlwaysOnTopButtonClick(object sender, RoutedEventArgs e)
        {
            var bounds = global::CalculatorApp.App.MainWindow.Bounds;
            ViewModel.ToggleAlwaysOnTop(bounds.Width, bounds.Height);
        }

        private void ShowHideControls(ViewMode mode)
        {
            var isCalcViewMode = NavCategory.IsCalculatorViewMode(mode);
            var isDateCalcViewMode = NavCategory.IsDateCalculatorViewMode(mode);
            var isConverterViewMode = NavCategory.IsConverterViewMode(mode);

            if (m_calculator != null)
            {
                m_calculator.Visibility = BooleanToVisibilityConverter.Convert(isCalcViewMode);
                m_calculator.IsEnabled = isCalcViewMode;
            }

            if (m_dateCalculator != null)
            {
                m_dateCalculator.Visibility = BooleanToVisibilityConverter.Convert(isDateCalcViewMode);
                m_dateCalculator.IsEnabled = isDateCalcViewMode;
            }

            if (m_converter != null)
            {
                m_converter.Visibility = BooleanToVisibilityConverter.Convert(isConverterViewMode);
                m_converter.IsEnabled = isConverterViewMode;
            }
        }

        private void UpdateViewState()
        {
            // All layout related view states are now handled only inside individual controls (standard, scientific, programmer, date, converter)
            if (NavCategory.IsConverterViewMode(ViewModel.Mode))
            {
                int modeIndex = NavCategoryStates.GetIndexInGroup(ViewModel.Mode, CategoryGroupType.Converter);
                if (ViewModel.ConverterViewModel != null && modeIndex >= 0 && modeIndex < (ViewModel.ConverterViewModel.Categories?.Count ?? 0))
                {
                    ViewModel.ConverterViewModel.CurrentCategory = ViewModel.ConverterViewModel.Categories[modeIndex];
                }
            }
        }

        private void UpdatePanelViewState()
        {
            if (m_calculator != null)
            {
                m_calculator.UpdatePanelViewState();
            }
        }

        private void OnHighContrastChanged(Microsoft.UI.System.ThemeSettings sender, object args)
        {
            _ = DispatcherQueue.TryEnqueue(() =>
            {
                // ThemeSettings reports every theme change; UWP raised this handler only when high contrast changed.
                if (m_isHighContrast == sender.HighContrast)
                {
                    return;
                }

                m_isHighContrast = sender.HighContrast;

                if (ViewModel.IsAlwaysOnTop && ActualHeight < 394)
                {
                    // Sets to default always-on-top size to force re-layout
                    var appWindow = global::CalculatorApp.App.MainWindow.AppWindow;
                    appWindow.ResizeClient(CalculatorApp.ViewModel.Common.Utils.ToPhysicalSize(appWindow, new Size(320, 394)));
                }
            });
        }

        private void OnPageLoaded(object sender, RoutedEventArgs args)
        {
            if (m_converter == null && m_calculator == null && m_dateCalculator == null)
            {
                // We have just launched into our default mode (standard calc) so ensure calc is loaded
                EnsureCalculator();
                ViewModel.CalculatorViewModel.IsStandard = true;
            }

            global::CalculatorApp.App.MainWindow.SizeChanged += WindowSizeChanged;
            m_themeSettings.Changed += OnHighContrastChanged;
            UpdateViewState();

            SetHeaderAutomationName();
            SetDefaultFocus();

            // Delay load things later when we get a chance.
            _ = DispatcherQueue.TryEnqueue(() =>
                {
                    if (TraceLogger.GetInstance().IsWindowIdInLog(Utilities.GetWindowId()))
                    {
                        AppLifecycleLogger.GetInstance().LaunchUIResponsive();
                        AppLifecycleLogger.GetInstance().LaunchVisibleComplete();
                    }
                });
        }

        private void OnMainWindowClosing(AppWindow sender, AppWindowClosingEventArgs e)
        {
            if (ViewModel.IsAlwaysOnTop)
            {
                ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
                localSettings.Values[ApplicationViewModel.WidthLocalSettingsKey] = ActualWidth;
                localSettings.Values[ApplicationViewModel.HeightLocalSettingsKey] = ActualHeight;
            }
        }

        // A desktop window has no current view; the request manager is obtained for the owning window
        // through the interop factory that IUserActivityRequestManagerInterop documents.
        private static UserActivityRequestManager TryGetUserActivityRequestManager(Window window)
        {
            try
            {
                var factory = WinRT.ActivationFactory.Get("Windows.ApplicationModel.UserActivities.UserActivityRequestManager");
                var interop = (IUserActivityRequestManagerInterop)Marshal.GetObjectForIUnknown(factory.ThisPtr);
                var iid = new Guid("0C30BE4E-903D-48D6-82D4-4043ED57791B"); // IUserActivityRequestManager
                var abi = interop.GetForWindow(WinRT.Interop.WindowNative.GetWindowHandle(window), ref iid);
                try
                {
                    return UserActivityRequestManager.FromAbi(abi);
                }
                finally
                {
                    Marshal.Release(abi);
                }
            }
            catch (Exception ex)
            {
                TraceLogger.GetInstance().LogRecallError($"UserActivityRequestManager is unavailable for this window. Exception: {ex}");
                return null;
            }
        }

        [ComImport]
        [Guid("DD69F876-9699-4715-9095-E37EA30DFA1B")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IUserActivityRequestManagerInterop
        {
            // The IInspectable slots that precede GetForWindow in the vtable.
            void GetIids();
            void GetRuntimeClassName();
            void GetTrustLevel();
            IntPtr GetForWindow(IntPtr appWindow, ref Guid riid);
        }

        private void EnsureCalculator()
        {
            if (m_calculator == null)
            {
                var calcVM = ViewModel.CalculatorViewModel;

                // In C#, CalculatorViewModel is lazily created in OnModeChanged.
                // If EnsureCalculator is called before mode is set, force creation.
                if (calcVM == null)
                {
                    ViewModel.Mode = ViewMode.Standard;
                    calcVM = ViewModel.CalculatorViewModel;
                }

                m_calculator = new Calculator();
                m_calculator.ViewModel = calcVM;
                m_calculator.Name = "Calculator";
                m_calculator.DataContext = calcVM;
                Binding isStandardBinding = new Binding
                {
                    Path = new PropertyPath("IsStandard")
                };
                m_calculator.SetBinding(Calculator.IsStandardProperty, isStandardBinding);
                Binding isScientificBinding = new Binding
                {
                    Path = new PropertyPath("IsScientific")
                };
                m_calculator.SetBinding(Calculator.IsScientificProperty, isScientificBinding);
                Binding isProgramerBinding = new Binding
                {
                    Path = new PropertyPath("IsProgrammer")
                };
                m_calculator.SetBinding(Calculator.IsProgrammerProperty, isProgramerBinding);
                Binding isAlwaysOnTopBinding = new Binding
                {
                    Path = new PropertyPath("IsAlwaysOnTop")
                };
                m_calculator.SetBinding(Calculator.IsAlwaysOnTopProperty, isAlwaysOnTopBinding);
                m_calculator.Style = CalculatorBaseStyle;

                CalcHolder.Child = m_calculator;

                // Calculator's "default" state is visible, but if we get delay loaded
                // when in converter, we should not be visible. This is not a problem for converter
                // since its default state is hidden.
                ShowHideControls(ViewModel.Mode);
            }

            if (m_dateCalculator != null)
            {
                m_dateCalculator.CloseCalendarFlyout();
            }
        }

        private void EnsureDateCalculator()
        {
            if (m_dateCalculator == null)
            {
                m_dateCalculator = new DateCalculator();
                m_dateCalculator.ViewModel = ViewModel.DateCalcViewModel;
                m_dateCalculator.DataContext = ViewModel.DateCalcViewModel;
                m_dateCalculator.Name = "dateCalculator";
                DateCalcHolder.Child = m_dateCalculator;
            }

            if (m_calculator != null)
            {
                m_calculator.CloseHistoryFlyout();
                m_calculator.CloseMemoryFlyout();
            }
        }

        private void EnsureConverter()
        {
            if (m_converter == null)
            {
                // delay loading converter
                m_converter = new CalculatorApp.UnitConverter
                {
                    Name = "unitConverter",
                    Style = UnitConverterBaseStyle
                };
                m_converter.ViewModel = ViewModel.ConverterViewModel;
                m_converter.DataContext = ViewModel.ConverterViewModel;
                ConverterHolder.Child = m_converter;
            }
        }

        private void AnnounceCategoryName()
        {
            string categoryName = AutomationProperties.GetName(Header);
            NarratorAnnouncement announcement = CalculatorAnnouncement.GetCategoryNameChangedAnnouncement(categoryName);
            NarratorNotifier.Announce(announcement);
        }

        private bool ShouldShowBackButton(bool isAlwaysOnTop, bool isPopupOpen)
        {
            return !isAlwaysOnTop && isPopupOpen;
        }

        private double NavigationViewOpenPaneLength(bool isAlwaysOnTop)
        {
            return isAlwaysOnTop ? 0 : (double)Application.Current.Resources["SplitViewOpenPaneLength"];
        }

        private GridLength DoubleToGridLength(double value)
        {
            return new GridLength(value);
        }

        private void Settings_BackButtonClick(object sender, RoutedEventArgs e)
        {
            CloseSettingsPopup();
        }

        private async Task ShowSnapshotLaunchErrorAsync()
        {
            var resProvider = AppResourceProvider.GetInstance();
            var dialog = new wuxc.ContentDialog
            {
                Title = resProvider.GetResourceString("AppName"),
                Content = new wuxc.TextBlock { Text = resProvider.GetResourceString("SnapshotRestoreError") },
                CloseButtonText = resProvider.GetResourceString("ErrorButtonOk"),
                DefaultButton = wuxc.ContentDialogButton.Close
            };
            await dialog.ShowAsync();
        }

        private Calculator m_calculator;
        private UnitConverter m_converter;
        private DateCalculator m_dateCalculator;
        private readonly Microsoft.UI.System.ThemeSettings m_themeSettings;
        private bool m_isHighContrast;
    }
}
