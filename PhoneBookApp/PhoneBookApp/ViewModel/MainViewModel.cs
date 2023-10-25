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

namespace PhoneBookApp.ViewModel
{
    
    public class MainViewModel
    {
        public ObservableCollection<Contact> contacts { get; set; }
        public Contact selectedContact { get; set; }
        public ICommand ShowAddWindowCommand { get; set; }

        private ContactManager contactManager { get; set; }

        public MainViewModel()
        {
            contactManager = new ContactManager();
            contacts = contactManager.GetContacts();
            ShowAddWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        public void DeleteContact()
        {
            contactManager.DeleteContact(selectedContact);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            AddContact addContactWindow = new AddContact();
            addContactWindow.Show();
        }
    }
}
