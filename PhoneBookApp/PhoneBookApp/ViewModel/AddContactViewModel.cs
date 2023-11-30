using PhoneBookApp.Commands;
using PhoneBookApp.Models;
using PhoneBookApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace PhoneBookApp.ViewModel
{
    public class AddContactViewModel
    {
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public DateTime BirthDate { get; set; }
        public AddCommand addCommand { get; private set; }

        private ContactManager _contactManager;

        public AddContactViewModel()
        {
            _contactManager = new ContactManager();
            addCommand = new AddCommand(AddContact);
        }

        private void AddContact(object obj)
        {
            _contactManager.AddContact(new Contact() { Name = Name, PhoneNo = PhoneNo, BirthDate = BirthDate });
        }
    }
}
