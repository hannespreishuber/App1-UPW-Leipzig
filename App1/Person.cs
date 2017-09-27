using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
   public class Person:INotifyPropertyChanged
    {
        public int ID { get; set; }
        private string name;

        public string Name
        {
            get { return name; }
            set {
                name = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName="")
        {
           
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
           
        }
    }
}
