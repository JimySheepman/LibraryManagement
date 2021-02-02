using LibraryManagement.usercontrol;
using System;
using System.Collections.Generic;
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
    /// <summary>
    /// Interaction logic for AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        public AddBookWindow()
        {
            InitializeComponent();
        }

        private void PieceBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text,e.Text.Length-1))
            {
                e.Handled = true;
            }
        }

        private void PageNoBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void PIDBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void ClsBttn_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            menu.Show();
            this.Close();

        }

        private void AddBttn_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=library_management_system.accdb;Persist Security Info=False;");
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO book([id],[book_name],[author_name],[publisher],[print_id],[book_kind],[number_of_page],[language],[piece]) VALUES (@id,@name,@athr,@pub,@pid,@bkind,@nop,@lang,@piece)";
            command.Parameters.AddWithValue("@id", IdBox.Text);
            command.Parameters.AddWithValue("@name", BookNameBox.Text);
            command.Parameters.AddWithValue("@athr", AuthorBox.Text);
            command.Parameters.AddWithValue("@pub", PublisherBox.Text);
            command.Parameters.AddWithValue("@pid", PIDBox.Text);
            command.Parameters.AddWithValue("@bkind", BookKindBox.Text);
            command.Parameters.AddWithValue("@nop", PageNoBox.Text);
            command.Parameters.AddWithValue("@lang", LanguageBox.Text);
            command.Parameters.AddWithValue("@pice", PieceBox.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Your insertion has been successful.");

        }
    }
}