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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryManagement.usercontrol
{
    public partial class BookListUC : UserControl
    {
        public BookListUC()
        {
            InitializeComponent();
        }
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;

        void viewList() 
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=library_management_system.accdb;Persist Security Info=False;");
            connection.Open();
            dataAdapter = new OleDbDataAdapter("select *from book",connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            contantDataGrd.ItemsSource = dataTable.AsDataView();
            connection.Close();
        }

        private void ShowBttm_Click(object sender, RoutedEventArgs e)
        {
            viewList();
        }

        private void RefreshBttn_Click(object sender, RoutedEventArgs e)
        {
            viewList();
        }

        private void contantDataGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid data = (DataGrid)sender;
            DataRowView row_selected = data.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                EditBookWindow edit = new EditBookWindow();
                edit.IdBox.Text = row_selected["id"].ToString();
                edit.BookNameBox.Text = row_selected["book_name"].ToString();
                edit.AuthorBox.Text = row_selected["author_name"].ToString();
                edit.PublisherBox.Text = row_selected["publisher"].ToString();
                edit.PIDBox.Text = row_selected["print_id"].ToString();
                edit.BookKindBox.Text = row_selected["book_kind"].ToString();
                edit.PageNoBox.Text = row_selected["number_of_page"].ToString();
                edit.LanguageBox.Text = row_selected["language"].ToString();
                edit.PieceBox.Text = row_selected["piece"].ToString();
            }
        }

        private void contantDataGrd_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataRowView row_selected = contantDataGrd.SelectedItem as DataRowView;
            EditBookWindow edit = new EditBookWindow();
            edit.IdBox.Text = row_selected["id"].ToString();
            edit.BookNameBox.Text = row_selected["book_name"].ToString();
            edit.AuthorBox.Text = row_selected["author_name"].ToString();
            edit.PublisherBox.Text = row_selected["publisher"].ToString();
            edit.PIDBox.Text = row_selected["print_id"].ToString();
            edit.BookKindBox.Text = row_selected["book_kind"].ToString();
            edit.PageNoBox.Text = row_selected["number_of_page"].ToString();
            edit.LanguageBox.Text = row_selected["language"].ToString();
            edit.PieceBox.Text = row_selected["piece"].ToString();

            edit.Show();
        }

        private void DeleteBttn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure to take this action?", "Warning Message!", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                DataRowView row_selected = contantDataGrd.SelectedItem as DataRowView;
                OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=library_management_system.accdb;Persist Security Info=False;");
                connection.Open();
                OleDbCommand command = new OleDbCommand("delete from book where id=" + row_selected["id"].ToString() + "", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Your deletion has been successful.");
                viewList();
            }


        }
    }
}
