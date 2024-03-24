using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Classes
{
    public class Car
    {
        public int CarID { get; set; }
        public string Brand { get; set; }
        public string CarDescription { get; set; }

        public void CarGo(string brand, string description)
        {
            Console.WriteLine(brand + " " + description + " The car is going...");
        }
    }
}
