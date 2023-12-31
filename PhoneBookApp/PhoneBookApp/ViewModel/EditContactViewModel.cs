﻿using PhoneBookApp.Commands;
using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public RelayCommand editContactCommand { get; private set; }

        private int ID;
        private ContactManager _contactManager;
        private string PhoneNoRegex = "^[+]?[(]?[0-9]{1,4}[)]?[-\\s\\./0-9]*$"; // Used to check Phone No format

        public EditContactViewModel(Contact contactInfo)
        {
            this.ID = contactInfo.ID;
            this.Name = contactInfo.Name;
            this.PhoneNo = contactInfo.PhoneNo;
            this.BirthDate = contactInfo.BirthDate;
            _contactManager = new ContactManager();
            editContactCommand = new RelayCommand(EditContact);
        }

        private void EditContact(object window)
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
            }
            else
            {
                _contactManager.EditContact(new Contact() { ID = ID, Name = Name, PhoneNo = PhoneNo, BirthDate = BirthDate });
                Window win = window as Window;
                win.Close();
            }
        }
    }
}
