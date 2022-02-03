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
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter First Name");
            contacts.firstName=Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            contacts.lastName = Console.ReadLine();
            Console.WriteLine("Enter Email");
            contacts.email = Console.ReadLine();
            Console.WriteLine("Enter Phone");
            contacts.phone = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contacts.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contacts.state = Console.ReadLine();
            Console.WriteLine("Enter ZIP");
            contacts.zip = Convert.ToInt32(Console.ReadLine());
            AddingContact add = new AddingContact();
            add.CreateContact();


        }
    }
}
