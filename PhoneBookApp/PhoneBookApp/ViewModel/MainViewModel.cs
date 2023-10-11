using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PhoneBookApp.Commands;
using PhoneBookApp.Models;
using PhoneBookApp.Views;

namespace PhoneBookApp.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<Contact> Contacts { get; set; }
        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel()
        {
            Contacts = ContactManager.GetContacts();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
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
