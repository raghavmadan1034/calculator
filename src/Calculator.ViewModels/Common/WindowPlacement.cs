// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Globalization;
using Microsoft.UI.Windowing;
using Windows.Storage;

namespace CalculatorApp.ViewModel.Common
{
    /// <summary>
    /// UWP reopened a window where it was last closed (PreferredLaunchWindowingMode.Auto); a desktop window opens at a
    /// system default size, so the main window's last normal placement is kept in local settings.
    /// </summary>
    public static class WindowPlacement
    {
        private const string SettingsKey = "MainWindowPlacement";

        // "x,y,width,height,maximized" in physical pixels.
        private static string s_placement;
        private static bool s_paused;

        /// <summary>Records the window's normal placement; ignored while paused or outside the overlapped presenter.</summary>
        public static void Track(AppWindow appWindow)
        {
            if (s_paused || appWindow.Presenter is not OverlappedPresenter presenter)
            {
                return;
            }

            if (presenter.State == OverlappedPresenterState.Restored)
            {
                s_placement = FormattableString.Invariant(
                    $"{appWindow.Position.X},{appWindow.Position.Y},{appWindow.Size.Width},{appWindow.Size.Height},0");
            }
            else if (presenter.State == OverlappedPresenterState.Maximized && s_placement != null)
            {
                // A maximized window does not report its normal bounds, so keep the last ones.
                s_placement = s_placement.Substring(0, s_placement.LastIndexOf(',')) + ",1";
            }
        }

        /// <summary>
        /// Records the placement and stops tracking until <see cref="Resume"/>. Always-on-top uses this because the
        /// window is resized while it still reports the overlapped presenter.
        /// </summary>
        public static void Pause(AppWindow appWindow)
        {
            Track(appWindow);
            s_paused = true;
        }

        public static void Resume()
        {
            s_paused = false;
        }

        public static void Save(AppWindow appWindow)
        {
            Track(appWindow);
            if (s_placement != null)
            {
                ApplicationData.Current.LocalSettings.Values[SettingsKey] = s_placement;
            }
        }

        public static void Restore(AppWindow appWindow)
        {
            if (ApplicationData.Current.LocalSettings.Values[SettingsKey] is not string saved)
            {
                return;
            }

            var parts = saved.Split(',');
            if (parts.Length != 5)
            {
                return;
            }

            var numbers = new int[4];
            for (var i = 0; i < numbers.Length; i++)
            {
                if (!int.TryParse(parts[i], NumberStyles.Integer, CultureInfo.InvariantCulture, out numbers[i]))
                {
                    return;
                }
            }

            // Keep the window on a display that still exists.
            var workArea = DisplayArea.GetFromRect(
                new global::Windows.Graphics.RectInt32(numbers[0], numbers[1], numbers[2], numbers[3]), DisplayAreaFallback.Nearest).WorkArea;
            var width = Math.Min(numbers[2], workArea.Width);
            var height = Math.Min(numbers[3], workArea.Height);
            var x = Math.Clamp(numbers[0], workArea.X, workArea.X + workArea.Width - width);
            var y = Math.Clamp(numbers[1], workArea.Y, workArea.Y + workArea.Height - height);
            appWindow.MoveAndResize(new global::Windows.Graphics.RectInt32(x, y, width, height));

            if (parts[4] == "1" && appWindow.Presenter is OverlappedPresenter presenter)
            {
                presenter.Maximize();
            }
        }
    }
}
