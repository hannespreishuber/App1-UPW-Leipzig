using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace App1
{
    class KundenVM
    {
        public ObservableCollection<Customer> Customers { get; set; } = new ObservableCollection<Customer>();
        public KundenVM()
        {
       
       
        }
    }
}
