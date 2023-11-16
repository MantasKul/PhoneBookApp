using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookApp.Views;
using System.Windows;
using System.Windows.Input;
using PhoneBookApp.Commands;
using System.ComponentModel;

namespace PhoneBookApp.ViewModel
{
    
    public class MainViewModel
    {
        public ObservableCollection<Contact> contacts { get; set; }
        public Contact selectedContact { get; set; }
        public ICommand ShowAddWindowCommand { get; set; }
        public ICommand ShowEditWindowCommand { get; set; }

        private ContactManager contactManager { get; set; }

        public MainViewModel()
        {
            contactManager = new ContactManager();
            contacts = contactManager.GetContacts();
            ShowAddWindowCommand = new RelayCommand(ShowAddWindow, CanShowAddWindow);
            ShowEditWindowCommand = new RelayCommand(ShowEdiWindow, CanShowEditWindow);
        }

        public void DeleteContact()
        {
            contactManager.DeleteContact(selectedContact);
        }

        private bool CanShowAddWindow(object obj)
        {
            return true;
        }

        private void ShowAddWindow(object obj)
        {
            AddContact addContactWindow = new AddContact();
            addContactWindow.Show();
        }

        // Change to be true only if there's something selected in the gridview, otherwise shouldn't allow to open edit window
        private bool CanShowEditWindow(object obj)
        {
            return true;
        }

        private void ShowEdiWindow(object obj)
        {
            EditContact editContactWindow = new EditContact(selectedContact);
            editContactWindow.Show();
        }
    }
}
