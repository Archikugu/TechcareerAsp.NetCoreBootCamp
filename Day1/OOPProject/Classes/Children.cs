using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Classes
{
    public class Children : Person
    {
        public string adjective { get; set; }
      
        public void DisplayChildInfo(string name, string lastname ,string adjective)
        {
            Console.WriteLine(name + " " + lastname + adjective);
        }
    }
}
