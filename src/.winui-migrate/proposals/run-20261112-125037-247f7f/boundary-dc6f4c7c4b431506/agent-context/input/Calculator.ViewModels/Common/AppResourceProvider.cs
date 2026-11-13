// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Microsoft.Windows.ApplicationModel.Resources;

namespace CalculatorApp.ViewModel.Common
{
    public sealed class AppResourceProvider
    {
        private static readonly Lazy<AppResourceProvider> s_instance = new Lazy<AppResourceProvider>(() => new AppResourceProvider());

        private readonly ResourceLoader _stringResLoader;
        private readonly ResourceLoader _cEngineStringResLoader;

        private AppResourceProvider()
        {
            // MRT Core loaders read the app's resources.pri directly; they need no current view.
            try
            {
                _stringResLoader = new ResourceLoader();
            }
            catch
            {
                _stringResLoader = null;
            }

            try
            {
                _cEngineStringResLoader = new ResourceLoader(ResourceLoader.GetDefaultResourceFilePath(), "CEngineStrings");
            }
            catch
            {
                _cEngineStringResLoader = null;
            }
        }

        public static AppResourceProvider GetInstance() => s_instance.Value;

        public string GetResourceString(string key) => _stringResLoader?.GetString(key) ?? key;

        public string GetCEngineString(string key) => _cEngineStringResLoader?.GetString(key) ?? "";
    }
}
