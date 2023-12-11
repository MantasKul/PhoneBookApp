using PhoneBookApp.Commands;
using PhoneBookApp.Models;
using PhoneBookApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;

namespace PhoneBookApp.ViewModel
{
    public class AddContactViewModel
    {
        public string Name { get; set; }
        public String PhoneNo { get; set; }
        public DateTime BirthDate { get; set; }
        public RelayCommand addContactCommand { get; private set; }

        private ContactManager _contactManager;
        private String PhoneNoRegex = "^[+]?[(]?[0-9]{1,4}[)]?[-\\s\\./0-9]*$";

        public AddContactViewModel()
        {
            _contactManager = new ContactManager();
            // Setting date picker to show current day by default
            BirthDate = DateTime.Today;
            addContactCommand = new RelayCommand(AddContact);
        }


        private void AddContact(object placeHolder)
        {
            
            if (Name == null || PhoneNo == null || Name == "" || PhoneNo == "")
            {
                MessageBox.Show("Name and Phone No. fields must be filled in", "Empty fields detected");
            }else
            {
                _contactManager.AddContact(new Contact() { Name = Name, PhoneNo = PhoneNo, BirthDate = BirthDate });
            }
        }
    }
}
