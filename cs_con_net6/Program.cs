// See https://aka.ms/new-console-template for more information

using System.Text;
using cs_con_net6;
using Tutorial;
using Google.Protobuf;


#region 



#endregion

ClassA objClassA = new ClassA(); //classA{}
ClassB objclassB = new ClassB(); //classB{}
ClassA target = new ClassA();

var stringBuilder = new StringBuilder();
//C2
Person john = new Person
{
    Id = 1234,
    Name = "John Doe",
    Email = "jdoe@example.com",
    Phones = { new Person.Types.PhoneNumber { Number = "555-4321", Type = Person.Types.PhoneType.Home } }
};

using (var output = File.Create("john.dat"))
{
    john.WriteTo(output);
}