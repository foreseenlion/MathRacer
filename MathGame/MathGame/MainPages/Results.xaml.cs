﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MathGame.Classes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MathGame.MainPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Results : Page
    {
        List<PlayerResult> results_add_2 = new List<PlayerResult>();
        List<PlayerResult> results_add_3 = new List<PlayerResult>();
        List<PlayerResult> results_sub_2 = new List<PlayerResult>();
        List<PlayerResult> results_sub_3 = new List<PlayerResult>();
        List<PlayerResult> results_mul_2 = new List<PlayerResult>();
        List<PlayerResult> results_mul_3 = new List<PlayerResult>();
        List<PlayerResult> results_div_2 = new List<PlayerResult>();
        List<PlayerResult> results_div_3 = new List<PlayerResult>();
        public Results()
        {
            this.InitializeComponent();
        }
        private void Go_Training(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Training));
        }
        private void Go_Play(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Play));
        }

        private void Go_Results(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Results));
        }

        private void Go_Settings(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Settings));
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            this.RequestedTheme = (ElementTheme)ApplicationData.Current.LocalSettings.Values["AppTheme"];

            results_add_2 = sqlConnection.Select("addition", "digits_2");
            results_add_3 = sqlConnection.Select("addition", "digits_3");
            results_sub_2 = sqlConnection.Select("subtraction", "digits_2");
            results_sub_3 = sqlConnection.Select("subtraction", "digits_3");
            results_mul_2 = sqlConnection.Select("multiplication", "digits_2");
            results_mul_3 = sqlConnection.Select("multiplication", "digits_3");
            results_div_2 = sqlConnection.Select("division", "digits_2");
            results_div_3 = sqlConnection.Select("division", "digits_3");

        }

    }
}
