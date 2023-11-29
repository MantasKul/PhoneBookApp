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
        //public Contact selectedContact { get; set; }
        public AddContactCommand addContactCommand { get; private set; }
        public EditContactCommand editContactCommand { get; private set; }
        public DeleteContactCommand deleteContactCommand { get; private set; }

        private ContactManager contactManager { get; set; }

        public MainViewModel()
        {
            contactManager = new ContactManager();
            contacts = contactManager.GetContacts();
            addContactCommand = new AddContactCommand(OpenAddContactWindow);
            editContactCommand = new EditContactCommand(OpenEditContactWindow);
            deleteContactCommand = new DeleteContactCommand(DeleteContact);
        }

        public void OpenAddContactWindow()
        {
            AddContact addContactWindow = new AddContact();
            addContactWindow.Show();
        }
        
        public void OpenEditContactWindow(Contact selectedContact)
        {
            if (selectedContact != null)
            {
                EditContact editContactWindow = new EditContact(selectedContact);
                editContactWindow.Show();
            } else
            {
                MessageBox.Show("Please select a row to edit");
            }
        }

        public void DeleteContact(Contact selectedContact)
        {
            if (selectedContact != null)
                contactManager.DeleteContact(selectedContact);
            else
                MessageBox.Show("Please select a row to delete");
        }
    }
}
