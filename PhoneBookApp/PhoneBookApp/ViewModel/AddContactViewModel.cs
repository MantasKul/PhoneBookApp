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
        public RelayCommand addContactCommand { get; private set; }

        private ContactManager _contactManager;

        public AddContactViewModel()
        {
            _contactManager = new ContactManager();
            addContactCommand = new RelayCommand(AddContact);
        }

        private void AddContact(object placeHolder)
        {
            _contactManager.AddContact(new Contact() { Name = Name, PhoneNo = PhoneNo, BirthDate = BirthDate });
        }
    }
}
