using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
   public class PersonVM
    {
        public Person Mitarbeiter { get; set; }
        public PersonVM()
        {

            Mitarbeiter = new Person();
            Mitarbeiter.ID = 1;
            Mitarbeiter.Name = "Hannes";
        }
    }
}
