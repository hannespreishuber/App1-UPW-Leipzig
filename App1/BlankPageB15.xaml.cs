﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace App1
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class BlankPageB15 : Page
    {
        public BlankPageB15()
        {
            this.InitializeComponent();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BlankPageA15));
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Text1.Text = $"Hallo {e.Parameter.ToString()}!";
            base.OnNavigatedTo(e);
        }

        }
    }
