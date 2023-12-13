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
        public string PhoneNo { get; set; }
        public DateTime BirthDate { get; set; }
        public RelayCommand addContactCommand { get; private set; }

        private ContactManager _contactManager;
        private string PhoneNoRegex = "^[+]?[(]?[0-9]{1,4}[)]?[-\\s\\./0-9]*$"; // Used to check Phone No format

        public AddContactViewModel()
        {
            _contactManager = new ContactManager();
            // Setting date picker to show current day by default
            BirthDate = DateTime.Today;
            addContactCommand = new RelayCommand(AddContact);
        }


        private void AddContact(object window)
        {
            // Ensuring that the input fields are not empty/null
            if (Name == null || PhoneNo == null || Name == "" || PhoneNo == "")
            {
                MessageBox.Show("Name and/or Phone No. fields must be filled in", "Empty fields detected");
            }
            // Ensuring that the Phone No format is acceptable
            else if (!Regex.IsMatch(PhoneNo, PhoneNoRegex))
            {
                MessageBox.Show("Please enter a valid Phone No.", "Invalid Phone No.");
            }else           
            {
                _contactManager.AddContact(new Contact() { Name = Name, PhoneNo = PhoneNo, BirthDate = BirthDate });
                Window win = window as Window;
                win.Close();
            }
        }
    }
}
