using PhoneBookApp.Commands;
using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PhoneBookApp.ViewModel
{
    public class EditContactViewModel
    {
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public DateTime BirthDate { get; set; }
        public EditCommand editCommand { get; private set; }

        private int ID;

        private ContactManager _contactManager;

        public EditContactViewModel(Contact contactInfo)
        {
            this.ID = contactInfo.ID;
            this.Name = contactInfo.Name;
            this.PhoneNo = contactInfo.PhoneNo;
            this.BirthDate = contactInfo.BirthDate;
            _contactManager = new ContactManager();
            editCommand = new EditCommand(EditContact);
        }

        private void EditContact(object obj)
        {
            _contactManager.EditContact(new Contact() { ID = ID, Name = Name, PhoneNo = PhoneNo, BirthDate = BirthDate });
        }
    }
}
