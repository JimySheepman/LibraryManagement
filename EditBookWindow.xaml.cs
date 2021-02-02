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
    /// Interaction logic for EditBookWindow.xaml
    /// </summary>
    public partial class EditBookWindow : Window
    {
        public EditBookWindow()
        {
            InitializeComponent();
        }
        private void PieceBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
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
            this.Close();
        }

        private void AddBttn_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=library_management_system.accdb;Persist Security Info=False;");
            connection.Open();
            OleDbCommand command = new OleDbCommand("update book set [book_name]=@name,[author_name]=@athr,[publisher]=@pub,[print_id]=@pid,[book_kind]=@bkind,[number_of_page]=@nop,[language]=@lang,[piece]= @piece where [id]=" + IdBox.Text+ "", connection);
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
            MessageBox.Show("Your update has been successful.");
        }
       
    }
}
