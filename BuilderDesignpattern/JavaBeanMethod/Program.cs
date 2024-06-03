using JavaBeanMethod.Classes;

Person person = new Person();
person.Name = "Serkan";
person.LastName = "Şahin";
person.Age = 24;
person.Phone = "05XXXXXX";

MesajGonder(person);

person.Address = "Türkiye";



void MesajGonder(Person person)
{
    Console.WriteLine("Merabalar...");
}