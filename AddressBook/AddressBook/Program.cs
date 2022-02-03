using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Create create = new Create();
            Console.WriteLine("Enter First Name");
            create.firstName=Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            create.lastName = Console.ReadLine();
            Console.WriteLine("Enter Email");
            create.email = Console.ReadLine();
            Console.WriteLine("Enter Phone");
            create.phone = Console.ReadLine();
            Console.WriteLine("Enter Address");
            create.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            create.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            create.state = Console.ReadLine();
            Console.WriteLine("Enter ZIP");
            create.zip = Convert.ToInt32(Console.ReadLine());


        }
    }
}
