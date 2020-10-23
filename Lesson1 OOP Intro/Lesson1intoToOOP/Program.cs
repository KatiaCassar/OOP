using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1intoToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            
            p.IdCard = "91602L"; //write

            p.Name = "Katia";
            p.Surname = "Cassar";

            Console.WriteLine("Please press a key to continue");
            Console.ReadLine(); //this expects that the user clicks on the Enter key on the keyboard

            Console.WriteLine($"Name: {p.Name}, Surname: {p.Surname}, Id: {p.IdCard}");
            Console.WriteLine($"{p.FullName}");

            Console.ReadKey(); //this expects the user clicks any key on the keyboard

            Console.WriteLine("Please input the Address: ");
            p.Address = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(p.DelimitAddress(','));
            Console.WriteLine("Press key to terminate app..");
            Console.ReadKey();
        }


    }
}
