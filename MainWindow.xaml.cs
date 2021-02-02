using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data.OleDb;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace LibraryManagement
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BttnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            this.Close();
        }

        private void BttnLogin_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=library_management_system.accdb;Persist Security Info=False;");
            OleDbCommand command = new OleDbCommand();
            try
            {
                connection.Open();
                command = new OleDbCommand("select *from login where username='" + TxtBoxUser.Text + "'AND password='" + TxtBoxPass.Password + "'", connection);
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MenuWindow menuWindow = new MenuWindow();
                    menuWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The Username or Password is wrong!!!!");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
