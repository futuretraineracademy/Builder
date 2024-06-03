using UsingBuilder.Classes;

 ;

Person person = PersonBuilder.Builder()
    .SetName("Serkan")
    .SetLastName("Şahin")
    .SetAddress("Türkiye")
    .Build();

MesajGonder(person);

void MesajGonder(Person person)
{
    Console.WriteLine("Merabalar..."+person.Address);
}