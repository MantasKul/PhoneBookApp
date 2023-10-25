using PhoneBookApp.Models;
using PhoneBookApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PhoneBookApp.Views
{
    /// <summary>
    /// Interaction logic for EditContact.xaml
    /// </summary>
    public partial class EditContact : Window
    {
        public EditContact(Contact selectedContact)
        {
            InitializeComponent();
            EditContactViewModel editContactViewModel = new EditContactViewModel(selectedContact);
            this.DataContext = editContactViewModel;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
