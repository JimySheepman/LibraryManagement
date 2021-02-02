using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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

namespace LibraryManagement
{
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }
        
        private void BttnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        private void BttnRegister2_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=library_management_system.accdb;Persist Security Info=False;");
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO login([username],[id],[mail],[password]) VALUES (@uname,@sid,@gmail,@pass)";
            try
            {
                command.Parameters.AddWithValue("@uname", userbx.Text);
                command.Parameters.AddWithValue("@sid", sidbx.Text);
                command.Parameters.AddWithValue("@gmail", mailbx.Text);
                command.Parameters.AddWithValue("@pass", Convert.ToString(passbx.Password));
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Registration is successful.");
            }
            catch 
            {

                MessageBox.Show("The name has already been taken.");
            }
        }

        private void BttnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

    }
}
