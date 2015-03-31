﻿/**********************************************************************
 * VLC for WinRT
 **********************************************************************
 * Copyright © 2013-2014 VideoLAN and Authors
 *
 * Licensed under GPLv2+ and MPLv2
 * Refer to COPYING file of the official project for license
 **********************************************************************/

using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using VLC_WinRT.Helpers;
using VLC_WinRT.Model;
using VLC_WinRT.ViewModels;

namespace VLC_WinRT.Views.MainPages
{
    public sealed partial class MainPageVideos : Page
    {
        public MainPageVideos()
        {
            InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
        }

        private void MainPageVideoContentPresenter_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (MainPageVideoContentPresenter.Content == null)
            {
                Locator.MainVM.ChangeMainPageVideoViewCommand.Execute((int)Locator.SettingsVM.VideoView);
            }
        }
    }
}