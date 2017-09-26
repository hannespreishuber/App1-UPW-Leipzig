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
    public sealed partial class BlankPage14 : Page
    {
        public BlankPage14()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var list = new List<Customer>();
            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///northwind.json"));
           
            string result = await FileIO.ReadTextAsync(file);

             list = await JsonConvert.DeserializeObjectAsync<List<Customer>>(result);

            //var serializer = new JsonSerializer();
 //var data = await file.OpenStreamForReadAsync();
            //using (var sr = new StreamReader(data.AsRandomAccessStream().AsStream()))
            //using (var jsonTextReader = new JsonTextReader(sr))
            //{
            //  list=serializer.Deserialize<List<Customer>>(jsonTextReader);
            //}
        }


    }
    }

