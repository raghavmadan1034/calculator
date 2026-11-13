// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.VisualStudio.TestPlatform.TestExecutor;
using Windows.ApplicationModel.Activation;
using Microsoft.UI.Xaml;

namespace Calculator.Tests
{
    sealed partial class App : global::Microsoft.UI.Xaml.Application
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected override async void OnLaunched(global::Microsoft.UI.Xaml.LaunchActivatedEventArgs e)
{
            
    __WinUiTestWindow = new global::Microsoft.UI.Xaml.Window { Content = new global::Microsoft.UI.Xaml.Controls.Grid() };
    __WinUiTestWindow.Activate();
    global::Microsoft.VisualStudio.TestTools.UnitTesting.AppContainer.UITestMethodAttribute.DispatcherQueue = __WinUiTestWindow.DispatcherQueue;
    try
    {
        var testArguments = global::System.Environment.GetCommandLineArgs()[1..];
        global::System.Environment.ExitCode =
            await global::Calculator.Tests.MicrosoftTestingPlatformApplication.RunAsync(testArguments);
    }
    catch (global::System.Exception error)
    {
        global::System.Console.Error.WriteLine(error);
        global::System.Environment.ExitCode = 1;
    }
    finally
    {
        __WinUiTestWindow.Close();
        Exit();
    }
}
private global::Microsoft.UI.Xaml.Window __WinUiTestWindow = null!;
    }
}
