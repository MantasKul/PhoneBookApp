using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Models
{
    public class ContactManager
    {
        // Query this from database
        public static ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>()
        {
            new Contact{ ID = 0, Name = "Bob", PhoneNo = "123", BirthDate = new DateOnly(2010, 01, 01)},
            new Contact{ ID = 1, Name = "Two", PhoneNo = "123", BirthDate = new DateOnly(2010, 01, 01)},
            new Contact{ ID = 2, Name = "Third", PhoneNo = "123", BirthDate = new DateOnly(2010, 01, 01)}
        };

        public static ObservableCollection<Contact> GetContacts()
        {
            return Contacts;
        }

        public static void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
    }
}
