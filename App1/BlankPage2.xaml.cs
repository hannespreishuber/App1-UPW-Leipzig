using System;
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
using Windows.Web.Syndication;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace App1
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {
        public BlankPage2()
        {
            this.InitializeComponent();
        }

        private async void Button_ClickAsync(object sender, RoutedEventArgs e)
        {

            var client = new SyndicationClient();
            Uri feedUri = new Uri("https://www.langweiledich.net/feed/");
            SyndicationFeed feed = await client.RetrieveFeedAsync(feedUri);
            rssOutput.Text = feed.Title.Text + Environment.NewLine;
            foreach (SyndicationItem item in feed.Items)
            {
                rssOutput.Text += item.Title.Text + ", " + item.PublishedDate.ToString() + Environment.NewLine;
            }
        }


    }
}

