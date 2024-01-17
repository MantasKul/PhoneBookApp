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
        public NoArgsRelayCommand addContactWindowCommand { get; private set; }
        public RelayCommand editContactWindowCommand { get; private set; }
        public RelayCommand deleteContactCommand { get; private set; }

        private ContactManager contactManager { get; set; }

        public MainViewModel()
        {
            contactManager = new ContactManager();
            contacts = contactManager.GetContacts();
            addContactWindowCommand = new NoArgsRelayCommand(OpenAddContactWindow);
            editContactWindowCommand = new RelayCommand(OpenEditContactWindow, CanOpenEditContactWindow);
            deleteContactCommand = new RelayCommand(DeleteContact, CanDeleteContact);
        }

        // argument should will be removed, new command class will be created for this
        public void OpenAddContactWindow()
        {
            AddContact addContactWindow = new AddContact();
            addContactWindow.Owner = Application.Current.MainWindow;
            addContactWindow.Show();
        }

        public bool CanOpenEditContactWindow(object selectedContact)
        {
            return selectedContact == null ? false : true;
        }


        public void OpenEditContactWindow(object selectedContact)
        {
            EditContact editContactWindow = new EditContact((Contact)selectedContact);
            editContactWindow.Owner = Application.Current.MainWindow;
            editContactWindow.Show();
        }

        public bool CanDeleteContact(object selectedContact)
        {
            return selectedContact == null ? false : true;
        }

        public void DeleteContact(object selectedContact)
        {
            contactManager.DeleteContact((Contact)selectedContact);
        }
    }
}
