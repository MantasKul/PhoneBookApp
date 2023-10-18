using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace PhoneBookApp.ViewModel
{
    internal class ContactsViewModel : INotifyPropertyChanged
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ServerCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;

        public ObservableCollection<Contact> contacts { get; set; }
        public string txtSelectedItem { get; set; }

        public ContactsViewModel()
        {
            FillList();
        }

        public void FillList()
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("select * from PhoneBook", con);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "PhoneBook");

                if (contacts == null) contacts = new ObservableCollection<Contact>();

                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    contacts.Add(new Contact { ID = Convert.ToInt32(dr[0].ToString()), Name = dr[1].ToString(), PhoneNo = dr[2].ToString(), BirthDate = Convert.ToDateTime(dr[3].ToString()) });
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                ds = null;
                adapter.Dispose();
                con.Close();
                con.Dispose();
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
