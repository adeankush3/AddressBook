using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddingContact
    {
        List<Contacts> addressBook = new List<Contacts>();
        public void CreateContact()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter Name");
            contacts.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            contacts.lastName = Console.ReadLine();
            addressBook.Add(contacts);
        }
    }
}
