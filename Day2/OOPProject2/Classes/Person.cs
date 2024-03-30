using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject2.Classes
{
    public class Person
    {
        public string firstName = null;
        public string lastName;
        public int AgeCalculate(int birthDayYear)
        {
            int result;
            result = DateTime.Now.Year - birthDayYear;
            return AgeDescription(result);


        }
        public int AgeDescription(int age)
        {
            if (age > 1 && age <= 18)
            {
                Console.WriteLine("you are Younger");
            }
            else if (age > 19 && age <= 35)
            {
                Console.WriteLine("You are Youth");
            }
            else if (age > 36 && age <= 55)
            {
                Console.WriteLine("You are Middle age");
            }
            else if (age > 56 && age <= 99)
            {
                Console.WriteLine("You are Old");
            }
            else
            {
                Console.WriteLine("Enter a Valid Date of Birth");
            }
            return age;
        }

        public Person()
        {
            
        }
        public Person(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
