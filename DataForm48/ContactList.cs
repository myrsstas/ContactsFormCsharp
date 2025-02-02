//Application development in popular integrated development environments © 2023 by Myrsini Stasinou is licensed under CC-BY-4.0 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace DataForm48
{
    public partial class ContactList : Form
    {
        MySqlConnection connectionDB = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=contacts_form; SslMode=none;");
 
        public ContactList()
        {
            InitializeComponent();
        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddContactList f3 = new AddContactList();
            f3.ShowDialog();
        }

        private void exportDataButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "Text File|*.txt";
            saveFile.FileName = "ExportedContacts.txt";
            saveFile.Title = "Save Text File";
            

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFile.FileName))
                {
                    File.Delete(saveFile.FileName);
                }

                String path = saveFile.FileName;
                path = path.Replace("\\", "/");

                String commandString = "select * into outfile'" + path + "' fields terminated by ';' lines terminated by ';\n' from contacts; ";

                MySqlCommand sqlCommand = new MySqlCommand(commandString, connectionDB);
                connectionDB.Open();
                sqlCommand.ExecuteReader();
                connectionDB.Close();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ContactList_VisibleChanged(object sender, EventArgs e)
        {
            MySqlCommand  sqlCommand = new MySqlCommand("select * from contacts;", connectionDB);
            MySqlDataReader  dataReader;
            DataTable  sqlDataTable = new DataTable();
            
            try{
                connectionDB.Open();
                dataReader = sqlCommand.ExecuteReader();
                sqlDataTable.Load(dataReader);
                dataReader.Close();
                connectionDB.Close();

                contactsDataGridView.DataSource = sqlDataTable;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Contact List", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
