using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading.Classes
{
    public class Person
    {
        private int age;
        private string name;
        private string lastName;
        private string address;
        private string phone;

        public Person(string lastName, string address, string phone)
        {
            this.lastName = lastName;
            this.address = address;
            this.phone = phone;
        }

        public Person(int age, string name, string lastName)
        {
            this.age = age;
            this.name = name;
            this.lastName = lastName;
        }

        public Person(string name, string lastName, string address, string phone)
        {
            this.name = name;
            this.lastName = lastName;
            this.address = address;
            this.phone = phone;
        }

        public Person(int age,string name, string lastName,string address,string phone)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.address = address;
            this.phone = phone;
        }

        
    }
}
