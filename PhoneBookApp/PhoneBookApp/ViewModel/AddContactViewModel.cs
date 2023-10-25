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
        public ICommand AddContactCommand { get; set; }

        private ContactManager _contactManager;

        public AddContactViewModel()
        {
            _contactManager = new ContactManager();
            AddContactCommand = new RelayCommand(AddContact, CanAddContact);
        }

        private bool CanAddContact(object obj)
        {
            return true;
        }

        private void AddContact(object obj)
        {
            _contactManager.AddContact(new Contact() { Name = Name, PhoneNo = PhoneNo, BirthDate = BirthDate });
        }
    }
}
