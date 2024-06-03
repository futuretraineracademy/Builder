using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingBuilder.Classes
{
    public class Person
    {
        private int age;
        private string name;
        private string lastName;
        private string address;
        private string phone;

        public Person(int age, string name, string lastName, string address, string phone)
        {
            this.age = age;
            this.name = name;
            this.lastName = lastName;
            this.address = address;
            this.phone = phone;
        }

        public int Age { get => age;}
        public string Name { get => name;}
        public string LastName { get => lastName;}
        public string Address { get => address;}
        public string Phone { get => phone;}
    }





    public class PersonBuilder
    {
        private int age;
        private string name;
        private string lastName;
        private string address;
        private string phone;
  
        public static PersonBuilder Builder()
        {
            return new PersonBuilder();
        }
        public PersonBuilder SetAge(int age)
        {
            this.age = age;
            return this;
        }
        public PersonBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }
        public PersonBuilder SetLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }
        public PersonBuilder SetAddress(string address)
        {
            this.address = address;
            return this;
        }
        public PersonBuilder SetPhone(string phone)
        {
            this.phone = phone;
            return this;
        }

        public Person Build()
        {
            return new Person(age, name, lastName, address, phone);
        }
    }
}
