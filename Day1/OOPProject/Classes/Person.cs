using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Classes
{
    public class Person
    { //initial scope

        //access modifiers dataType variableName
        public string firstName = null;
        public string lastName;
        public int age = 0;
        public double salary = 0.0;
        public bool gender = false;

        //Methods 
        public void Sleep(string name, string lastname)
        {
            Console.WriteLine(name + " " + lastname + " sleeping...");
        }

        public void Description(string name, string lastname)
        {
            Console.WriteLine("Person name : " + firstName + " Person lastname : " + lastName);
        }

    } //final scope
}
