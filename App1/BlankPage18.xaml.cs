using Newtonsoft.Json;
using System;
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

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace App1
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class BlankPage18 : Page
    {
        public BlankPage18()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            LayoutRoot.DataContext = new KundenVM();
            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///northwind.json"));
            string result = await FileIO.ReadTextAsync(file);

            var liste=JsonConvert.DeserializeObject<List<Customer>>(result);
            foreach (var item in liste)
            {
                ((KundenVM)LayoutRoot.DataContext).Customers.Add(item);
            }
          
        }
    }
}
