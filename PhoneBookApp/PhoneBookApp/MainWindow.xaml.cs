using PhoneBookApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PhoneBookApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _mainViewModel;
        public MainWindow()
        {
            InitializeComponent();
            /*            MainViewModel mainViewModel = new MainViewModel();
                        this.DataContext = mainViewModel;*/
            /*            viewModel = new ContactsViewModel();
                        this.DataContext = viewModel;*/
            _mainViewModel = new MainViewModel();
            DataContext = _mainViewModel;           
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataList.SelectedIndex != -1)
            {
                _mainViewModel.DeleteContact();
            }
        }
    }
}
