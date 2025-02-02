//Application development in popular integrated development environments © 2023 by Myrsini Stasinou is licensed under CC-BY-4.0 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DataForm48
{
    public partial class AddContactList : Form
    {
        MySqlConnection connectionDB = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=contacts_form; SslMode=none;");

        public AddContactList()
        {
            InitializeComponent();
        }

        private void nameTB_Leave(object sender, EventArgs e)
        {
            nameTB.Text = nameTB.Text.ToUpper();
        }

        private void surnameTB_Leave(object sender, EventArgs e)
        {
            surnameTB.Text = surnameTB.Text.ToUpper();
        }


        private void emailTB_Leave(object sender, EventArgs e)
        {
            Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");

            if ((!(String.IsNullOrEmpty(emailTB.Text))) & (validateEmailRegex.IsMatch(emailTB.Text) == false))
            {
                MessageBox.Show("Please enter a valid email address", "Unvalid email address", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                emailTB.Clear();
                emailTB.Focus();
            }
        }

        private void addressTB_Leave(object sender, EventArgs e)
        {
            addressTB.Text = addressTB.Text.ToUpper();
        }

        private void cityTB_Leave(object sender, EventArgs e)
        {
            cityTB.Text = cityTB.Text.ToUpper();
        }

        private void notesTB_Leave(object sender, EventArgs e)
        {
            notesTB.Text = notesTB.Text.ToUpper();
        }

        private void nextEntryButton_Click(object sender, EventArgs e)
        {
           
            String name, surname, dateOfBirth, phoneNumber, email, address, city, notes;

            String today = DateTime.Today.Date.ToString("yyyy-MM-dd");

            name = (string.IsNullOrEmpty(nameTB.Text) ? "-" : nameTB.Text );
            surname = (string.IsNullOrEmpty(surnameTB.Text) ?  "-" : surnameTB.Text );
            dateOfBirth= (dateOfBirthTB.Text != today ?  dateOfBirthTB.Text :  "-");
            phoneNumber = (string.IsNullOrEmpty(phoneTB.Text) ?  "-" : phoneTB.Text);
            email = (string.IsNullOrEmpty(emailTB.Text) ? "-" : emailTB.Text);
            address = (string.IsNullOrEmpty(addressTB.Text) ? "-" : addressTB.Text);
            city = (string.IsNullOrEmpty(cityTB.Text) ? "-" : cityTB.Text);
            notes = (string.IsNullOrEmpty(notesTB.Text) ? "-" : notesTB.Text);


           try
            {
                MySqlCommand sqlCommand = new MySqlCommand("insert into contacts (name, surname, date_of_birth, phone_number, email, address, city, notes) " +
                    " values('" + name + "' , '" + surname + "','" + dateOfBirth + "','" + phoneNumber + "','" + email + "','" + address + "','" + city + "','" + notes + "'); ", connectionDB);
                connectionDB.Open();
                sqlCommand.ExecuteNonQuery();
                connectionDB.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Inserting Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           clearAllFields();

            }

        private void backToListButton_Click(object sender, EventArgs e)
        {
            clearAllFields();

            this.Hide();
            ContactList f2 = new ContactList();
            f2.ShowDialog();
            this.Close();
        }
        private void clearAllFields()
        {
            nameTB.Clear();
            surnameTB.Clear();
            dateOfBirthTB.Value = DateTime.Today;
            phoneTB.Clear();
            emailTB.Clear();
            addressTB.Clear();
            cityTB.Clear();
            notesTB.Clear();
        }

        private void phoneTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 8 && e.KeyChar != 32) && !Char.IsDigit(e.KeyChar))
            {
                if (!Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void AddContactList_Load(object sender, EventArgs e)
        {
            dateOfBirthTB.MaxDate = DateTime.Today;
            dateOfBirthTB.Value = DateTime.Today;
        }
    }
}
