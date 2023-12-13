using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Configuration;
using System.IO;

namespace PhoneBookApp.Models
{
    
    public class ContactManager
    {
        static string connectionString = File.ReadAllText("ServerConnectionString.txt"); // ConfigurationManager.ConnectionStrings["ServerCon"].ConnectionString;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataSet? ds;
        private static ObservableCollection<Contact> contacts { get; set; }

        public ObservableCollection<Contact> GetContacts()
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("SelectEverything", con);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "PhoneBook");

                if (contacts == null) contacts = new ObservableCollection<Contact>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    contacts.Add(new Contact {  ID = Convert.ToInt32(dr[0].ToString()), 
                                                Name = dr[1].ToString(), 
                                                PhoneNo = dr[2].ToString(), 
                                                BirthDate = Convert.ToDateTime(dr[3].ToString()) });
                }
            }
            catch (Exception e)
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

            return contacts;
        }

        public void DeleteContact(Contact selectedContact)
        {
            // Removing row from Database
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("DeleteRowByID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = selectedContact.ID;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                con.Close();
                con.Dispose();
            }

            // Removing row from the data grid
            contacts.Remove(contacts.Where(i => i.ID == selectedContact.ID).Single());
        }

        public void AddContact(Contact newContact)
        {
            contacts.Add(newContact);

            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("InsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@FullName", SqlDbType.VarChar).Value = newContact.Name;
                cmd.Parameters.Add("@PhoneNo", SqlDbType.VarChar).Value = newContact.PhoneNo;
                cmd.Parameters.Add("@BirthDate", SqlDbType.Date).Value = newContact.BirthDate;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public void EditContact(Contact newContact)
        {
            // Editing row in the Data List
            int i = 0;
            foreach (Contact c in contacts)
            {
                if (c.ID == newContact.ID)
                {
                    contacts[i] = newContact;
                    break;
                }
                i++;
            }

            // Editing row in the database
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("UpdateRowByID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = newContact.ID;
                cmd.Parameters.Add("@FullName", SqlDbType.VarChar).Value = newContact.Name;
                cmd.Parameters.Add("@PhoneNo", SqlDbType.VarChar).Value = newContact.PhoneNo;
                cmd.Parameters.Add("@BirthDate", SqlDbType.Date).Value = newContact.BirthDate;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
