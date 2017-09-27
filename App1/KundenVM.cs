using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace App1
{
   public class KundenVM
    {
        public ObservableCollection<Customer> Customers { get; set; } = new ObservableCollection<Customer>();
        public KundenVM()
        {
       
       
        }
        public async void LadeDaten()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///northwind.json"));
            string result = await FileIO.ReadTextAsync(file);

            var liste = JsonConvert.DeserializeObject<List<Customer>>(result);
            foreach (var item in liste)
            {
               Customers.Add(item);
            }
        }
    }
}
