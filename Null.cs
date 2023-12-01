using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_conditionalOperator
{
    class Null
    {

        static int[] GetArray()
        {
            int[] myArray = {25,85,36,15 };
            return myArray;
        }
        static Person GetPerson() 
        {
            //Person person = new Person();

            Person person = new Person() { Contacts = new Contacts() { PhoneNumber = "927354555" }  };
            return person;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            Console.WriteLine("The sum of the Array elements " + (myArray?.Sum() ?? 0));

            Person person = GetPerson();
            string phoneNumber = person.Contacts.PhoneNumber;

            Console.WriteLine(phoneNumber);
        }



    }
}
