using OOPProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Classes
{
    public class Car :ICarFeature
    {
        public int CarID { get; set; }
        public string Brand { get; set; }
        public string CarDescription { get; set; }

        public void CarBrandDescription(string brand, string description)
        {
            Console.WriteLine(brand + " " + description + " The car is feature...");
        }

        public void CarGo(string brand, string description)
        {
            Console.WriteLine(brand + " " + description + " The car is going...");
        }

      
    }
}
