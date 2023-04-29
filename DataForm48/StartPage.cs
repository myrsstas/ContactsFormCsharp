using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataForm48
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        MySqlConnection connectionDB = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=contacts_form; AllowLoadLocalInfile=True ");


        private void letsStartButton_Click(object sender, EventArgs e)
        {
            removeAllRecords();

            this.Hide();
            ContactList f2 = new ContactList();
            f2.ShowDialog();
            this.Close();
        }
        private void removeAllRecords()
        {
            MySqlCommand command = new MySqlCommand("truncate table contacts;", connectionDB);
            try
            {
                connectionDB.Open();
                command.ExecuteNonQuery();
                connectionDB.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Start Page", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Multiselect = false;
            openFile.FileName = "Select a text file";
            openFile.Title = "Open Text File";
            openFile.Filter = "Text File | *.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {

                filepathTextBox.Text = openFile.FileName;

            }
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {

            removeAllRecords();

            String filepath = filepathTextBox.Text;

            MySqlBulkLoader bl = new MySqlBulkLoader(connectionDB);
            bl.Local = true;
            bl.TableName = "contacts";
            bl.FieldTerminator = ";";
            bl.LineTerminator = "\n";
            bl.FileName = filepath;
            bl.NumberOfLinesToSkip = 0;

            try
            {
                connectionDB.Open();
                bl.Load();

                connectionDB.Close();
            }
            catch (Exception ex)
		{
                MessageBox.Show(ex.Message,"Start Page", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            this.Hide();
            ContactList f2 = new ContactList();
            f2.ShowDialog();
            this.Close();

            }
        }
}
