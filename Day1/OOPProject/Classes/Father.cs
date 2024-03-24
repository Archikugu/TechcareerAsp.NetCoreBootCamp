using OOPProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Classes
{
    public class Father : Person, IFeature
    {
        public void FatherRead(string name)
        {
            Console.WriteLine(name + " reading...");
        }

        public void Listen(string name)
        {
            Console.WriteLine(name + " listening...");
        }

        public void Read(string name)
        {
            Console.WriteLine(name + " reading...");
        }

        public void Write(string name)
        {
            Console.WriteLine(name + " writing...");
        }
    }
}
