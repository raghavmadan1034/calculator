using CalculatorApp.ViewModel.Common;

using Windows.System.Profile;
using Windows.UI.ViewManagement;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace CalculatorApp
{
    public sealed partial class TitleBar : UserControl
    {
        public TitleBar()
        {
            // A desktop window has no CoreApplicationView; the title bar belongs to the window that shows it.
            m_window = global::CalculatorApp.App.MainWindow;
            m_uiSettings = new UISettings();
            // AccessibilitySettings events need a CoreWindow; ThemeSettings reports the owning window's high-contrast state.
            m_themeSettings = Microsoft.UI.System.ThemeSettings.CreateForWindowId(m_window.AppWindow.Id);
            InitializeComponent();

            m_window.ExtendsContentIntoTitleBar = true;
            m_window.SetTitleBar(BackgroundElement);

            Loaded += OnLoaded;
            Unloaded += OnUnloaded;
#if IS_STORE_BUILD
            AppName.Text = AppResourceProvider.GetInstance().GetResourceString("AppName");

#else
            AppName.Text = AppResourceProvider.GetInstance().GetResourceString("DevAppName");
#endif
        }

        public bool IsAlwaysOnTopMode
        {
            get => (bool)GetValue(IsAlwaysOnTopModeProperty);
            set => SetValue(IsAlwaysOnTopModeProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsAlwaysOnTopMode.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsAlwaysOnTopModeProperty =
            DependencyProperty.Register(nameof(IsAlwaysOnTopMode), typeof(bool), typeof(TitleBar), new PropertyMetadata(default(bool), (sender, args) =>
            {
                var self = (TitleBar)sender;
                self.OnIsAlwaysOnTopModePropertyChanged((bool)args.OldValue, (bool)args.NewValue);
            }));

        public event Microsoft.UI.Xaml.RoutedEventHandler AlwaysOnTopClick;

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            // Register events
            // AppWindow.Changed reports the presenter and size changes CoreApplicationViewTitleBar raised as
            // IsVisibleChanged and LayoutMetricsChanged.
            m_window.AppWindow.Changed += OnAppWindowChanged;

            m_uiSettings.ColorValuesChanged += ColorValuesChanged;
            m_themeSettings.Changed += OnHighContrastChanged;
            m_window.Activated += OnWindowActivated;

            // Register RequestedTheme changed callback to update title bar system button colors.
            m_rootFrameRequestedThemeCallbackToken =
                Utils.ThemeHelper.RegisterAppThemeChangedCallback(RootFrame_RequestedThemeChanged);

            // Set properties
            SetTitleBarControlColors();
            SetTitleBarHeightAndPadding();

            // As of Windows 10 1903: when an app runs on a PC (without Tablet mode activated)
            // properties of CoreApplicationViewTitleBar aren't initialized during the first seconds after launch.
            var forceDisplay = AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Desktop"
                && UIViewSettingsInterop.GetForWindow(WinRT.Interop.WindowNative.GetWindowHandle(m_window)).UserInteractionMode == UserInteractionMode.Mouse;

            SetTitleBarVisibility(forceDisplay);
        }

        private void OnUnloaded(object sender, RoutedEventArgs e)
        {
            // Unregister events
            // A closing window has already released its AppWindow, and the AppWindow's events with it.
            var appWindow = m_window.AppWindow;
            if (appWindow != null)
            {
                appWindow.Changed -= OnAppWindowChanged;
            }

            m_uiSettings.ColorValuesChanged -= ColorValuesChanged;
            m_themeSettings.Changed -= OnHighContrastChanged;
            m_window.Activated -= OnWindowActivated;

            Utils.ThemeHelper.
                UnregisterAppThemeChangedCallback(m_rootFrameRequestedThemeCallbackToken);
        }

        private void RootFrame_RequestedThemeChanged(DependencyObject sender, DependencyProperty dp)
        {
            if (Frame.RequestedThemeProperty == dp)
            {
                _ = DispatcherQueue.TryEnqueue(SetTitleBarControlColors);
            }
        }

        private void OnAppWindowChanged(AppWindow sender, AppWindowChangedEventArgs args)
        {
            if (args.DidPresenterChange)
            {
                SetTitleBarVisibility(false);
            }

            if (args.DidPresenterChange || args.DidSizeChange)
            {
                SetTitleBarHeightAndPadding();
            }
        }

        // The system title bar disappears only in full screen, which is when UWP reported it not visible.
        private bool IsSystemTitleBarVisible => m_window.AppWindow.Presenter.Kind != AppWindowPresenterKind.FullScreen;

        private void SetTitleBarVisibility(bool forceDisplay)
        {
            LayoutRoot.Visibility =
                forceDisplay || IsSystemTitleBarVisible || IsAlwaysOnTopMode ? Visibility.Visible : Visibility.Collapsed;
        }

        private void SetTitleBarHeightAndPadding()
        {
            var titleBar = m_window.AppWindow.TitleBar;
            if (titleBar.Height == 0)
            {
                // The titlebar isn't init
                return;
            }

            // AppWindowTitleBar measures in physical pixels; CoreApplicationViewTitleBar measured in DIPs.
            var scale = XamlRoot?.RasterizationScale ?? 1.0;
            double leftAddition;
            double rightAddition;

            if (FlowDirection == FlowDirection.LeftToRight)
            {
                leftAddition = titleBar.LeftInset / scale;
                rightAddition = titleBar.RightInset / scale;
            }
            else
            {
                leftAddition = titleBar.RightInset / scale;
                rightAddition = titleBar.LeftInset / scale;
            }

            LayoutRoot.Padding = new Thickness(leftAddition, 0, rightAddition, 0);
            this.Height = titleBar.Height / scale;
        }

        private void ColorValuesChanged(Windows.UI.ViewManagement.UISettings sender, object e)
        {
            _ = DispatcherQueue.TryEnqueue(SetTitleBarControlColors);
        }

        private void SetTitleBarControlColors()
        {
            var applicationTitleBar = m_window.AppWindow.TitleBar;
            if (applicationTitleBar == null)
            {
                return;
            }

            if (m_themeSettings.HighContrast)
            {
                // Reset to use default colors.
                applicationTitleBar.ButtonBackgroundColor = null;
                applicationTitleBar.ButtonForegroundColor = null;
                applicationTitleBar.ButtonInactiveBackgroundColor = null;
                applicationTitleBar.ButtonInactiveForegroundColor = null;
                applicationTitleBar.ButtonHoverBackgroundColor = null;
                applicationTitleBar.ButtonHoverForegroundColor = null;
                applicationTitleBar.ButtonPressedBackgroundColor = null;
                applicationTitleBar.ButtonPressedForegroundColor = null;
            }
            else
            {
                applicationTitleBar.ButtonBackgroundColor = ButtonBackground?.Color;
                applicationTitleBar.ButtonForegroundColor = ButtonForeground?.Color;
                applicationTitleBar.ButtonInactiveBackgroundColor = ButtonInactiveBackground?.Color;
                applicationTitleBar.ButtonInactiveForegroundColor = ButtonInactiveForeground?.Color;
                applicationTitleBar.ButtonHoverBackgroundColor = ButtonHoverBackground?.Color;
                applicationTitleBar.ButtonHoverForegroundColor = ButtonHoverForeground?.Color;
                applicationTitleBar.ButtonPressedBackgroundColor = ButtonPressedBackground?.Color;
                applicationTitleBar.ButtonPressedForegroundColor = ButtonPressedForeground?.Color;
            }
        }

        private void OnHighContrastChanged(Microsoft.UI.System.ThemeSettings sender, object args)
        {
            _ = DispatcherQueue.TryEnqueue(() =>
            {
                SetTitleBarControlColors();
                SetTitleBarVisibility(false);
            });
        }

        private void OnWindowActivated(object sender, Microsoft.UI.Xaml.WindowActivatedEventArgs e)
        {
            VisualStateManager.GoToState(
                this, e.WindowActivationState == Microsoft.UI.Xaml.WindowActivationState.Deactivated ? WindowNotFocused.Name : WindowFocused.Name, false);
        }

        private void OnIsAlwaysOnTopModePropertyChanged(bool oldValue, bool newValue)
        {
            SetTitleBarVisibility(false);
            VisualStateManager.GoToState(this, newValue ? "AOTMiniState" : "AOTNormalState", false);
        }

        private void AlwaysOnTopButton_Click(object sender, RoutedEventArgs e)
        {
            AlwaysOnTopClick?.Invoke(this, e);
        }

        // Dependency properties for the color of the system title bar buttons
        public Microsoft.UI.Xaml.Media.SolidColorBrush ButtonBackground
        {
            get => (Microsoft.UI.Xaml.Media.SolidColorBrush)GetValue(ButtonBackgroundProperty);
            set => SetValue(ButtonBackgroundProperty, value);
        }
        public static readonly DependencyProperty ButtonBackgroundProperty =
            DependencyProperty.Register(nameof(ButtonBackground), typeof(Microsoft.UI.Xaml.Media.SolidColorBrush), typeof(TitleBar), new PropertyMetadata(null));

        public Microsoft.UI.Xaml.Media.SolidColorBrush ButtonForeground
        {
            get => (Microsoft.UI.Xaml.Media.SolidColorBrush)GetValue(ButtonForegroundProperty);
            set => SetValue(ButtonForegroundProperty, value);
        }
        public static readonly DependencyProperty ButtonForegroundProperty =
            DependencyProperty.Register(nameof(ButtonForeground), typeof(Microsoft.UI.Xaml.Media.SolidColorBrush), typeof(TitleBar), new PropertyMetadata(null));

        public Microsoft.UI.Xaml.Media.SolidColorBrush ButtonInactiveBackground
        {
            get => (Microsoft.UI.Xaml.Media.SolidColorBrush)GetValue(ButtonInactiveBackgroundProperty);
            set => SetValue(ButtonInactiveBackgroundProperty, value);
        }
        public static readonly DependencyProperty ButtonInactiveBackgroundProperty =
            DependencyProperty.Register(nameof(ButtonInactiveBackground), typeof(Microsoft.UI.Xaml.Media.SolidColorBrush), typeof(TitleBar), new PropertyMetadata(null));

        public Microsoft.UI.Xaml.Media.SolidColorBrush ButtonInactiveForeground
        {
            get => (Microsoft.UI.Xaml.Media.SolidColorBrush)GetValue(ButtonInactiveForegroundProperty);
            set => SetValue(ButtonInactiveForegroundProperty, value);
        }
        public static readonly DependencyProperty ButtonInactiveForegroundProperty =
            DependencyProperty.Register(nameof(ButtonInactiveForeground), typeof(Microsoft.UI.Xaml.Media.SolidColorBrush), typeof(TitleBar), new PropertyMetadata(null));

        public Microsoft.UI.Xaml.Media.SolidColorBrush ButtonHoverBackground
        {
            get => (Microsoft.UI.Xaml.Media.SolidColorBrush)GetValue(ButtonHoverBackgroundProperty);
            set => SetValue(ButtonHoverBackgroundProperty, value);
        }
        public static readonly DependencyProperty ButtonHoverBackgroundProperty =
            DependencyProperty.Register(nameof(ButtonHoverBackground), typeof(Microsoft.UI.Xaml.Media.SolidColorBrush), typeof(TitleBar), new PropertyMetadata(null));

        public Microsoft.UI.Xaml.Media.SolidColorBrush ButtonHoverForeground
        {
            get => (Microsoft.UI.Xaml.Media.SolidColorBrush)GetValue(ButtonHoverForegroundProperty);
            set => SetValue(ButtonHoverForegroundProperty, value);
        }
        public static readonly DependencyProperty ButtonHoverForegroundProperty =
            DependencyProperty.Register(nameof(ButtonHoverForeground), typeof(Microsoft.UI.Xaml.Media.SolidColorBrush), typeof(TitleBar), new PropertyMetadata(null));

        public Microsoft.UI.Xaml.Media.SolidColorBrush ButtonPressedBackground
        {
            get => (Microsoft.UI.Xaml.Media.SolidColorBrush)GetValue(ButtonPressedBackgroundProperty);
            set => SetValue(ButtonPressedBackgroundProperty, value);
        }
        public static readonly DependencyProperty ButtonPressedBackgroundProperty =
            DependencyProperty.Register(nameof(ButtonPressedBackground), typeof(Microsoft.UI.Xaml.Media.SolidColorBrush), typeof(TitleBar), new PropertyMetadata(null));

        public Microsoft.UI.Xaml.Media.SolidColorBrush ButtonPressedForeground
        {
            get => (Microsoft.UI.Xaml.Media.SolidColorBrush)GetValue(ButtonPressedForegroundProperty);
            set => SetValue(ButtonPressedForegroundProperty, value);
        }
        public static readonly DependencyProperty ButtonPressedForegroundProperty =
            DependencyProperty.Register(nameof(ButtonPressedForeground), typeof(Microsoft.UI.Xaml.Media.SolidColorBrush), typeof(TitleBar), new PropertyMetadata(null));

        public bool BackButtonSpaceReserved
        {
            get => (bool)GetValue(BackButtonSpaceReservedProperty);
            set => SetValue(BackButtonSpaceReservedProperty, value);
        }
        public static readonly DependencyProperty BackButtonSpaceReservedProperty =
            DependencyProperty.Register(
                nameof(BackButtonSpaceReserved), typeof(bool), typeof(TitleBar),
                new PropertyMetadata(false, (sender, args) =>
                {
                    var self = sender as TitleBar;
                    VisualStateManager.GoToState(
                        self, (bool)args.NewValue ? self.BackButtonVisible.Name : self.BackButtonCollapsed.Name, true);
                }));

        private readonly Microsoft.UI.Xaml.Window m_window;
        private readonly Windows.UI.ViewManagement.UISettings m_uiSettings;
        private readonly Microsoft.UI.System.ThemeSettings m_themeSettings;
        private Utils.ThemeHelper.ThemeChangedCallbackToken m_rootFrameRequestedThemeCallbackToken;
    }
}
