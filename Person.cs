using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_conditionalOperator
{
    public class Contacts
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        // Приватное поле для хранения контактов
       
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }

        // Инициализация свойства Contacts в конструкторе
        public Person()
        {
            Contacts = new Contacts();
        }
        public Contacts Contacts { get; set; }

        public string GetFullName()
        {
            return Name;
        }

        public string GetPhoneNumber()
        {
            return SureName;
        }
    }
}
