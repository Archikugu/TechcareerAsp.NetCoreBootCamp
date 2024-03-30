using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject2.Constructors
{
    public class Human
    {
        public Head head;
        public string firstName;
        public string lastName;

        public Human(string lastName, string firstName, Head head)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.head = head;
        }
        public void Write()
        {
            Console.WriteLine("name of person making appointment : " + firstName + "lastname : " + lastName +" eyes color"+ head.eyes.color +" ear form" +head.ear.shape +"nose form: "+head.nose.form);
        }
    }
}
