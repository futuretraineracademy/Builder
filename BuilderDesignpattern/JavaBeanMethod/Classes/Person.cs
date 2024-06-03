using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaBeanMethod.Classes
{
    public class Person
    {
        private int age;
        private string name;
        private string lastName;
        private string address;
        private string phone;

       

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
