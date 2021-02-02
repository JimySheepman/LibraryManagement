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
    /// <summary>
    /// Interaction logic for SearchBookWindow.xaml
    /// </summary>
    public partial class SearchBookWindow : Window
    {
        public SearchBookWindow()
        {
            InitializeComponent();
            viewListSearch();
        }
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=library_management_system.accdb;Persist Security Info=False;");
        OleDbDataAdapter dataAdapter;
        void viewListSearch()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("select *from book", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            SearchGrid.ItemsSource = dataTable.AsDataView();
            connection.Close();
        }
        private void ExitBttn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SearchBttn_Click(object sender, RoutedEventArgs e)
        {
            connection.Open();
            if (BookNameBx.Text.Length>0)
            {
                dataAdapter = new OleDbDataAdapter("select * from book where book_name='" + BookNameBx.Text + "'", connection);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                if (dt.AsDataView().Count == 0)
                {
                    MessageBox.Show("incorrect or incomplete input.");
                    connection.Close();
                }
                else
                {
                    SearchGrid.ItemsSource = dt.AsDataView();
                    connection.Close();
                }


            }
            else
            {
                MessageBox.Show("you must enter an entry");
                connection.Close();
            }
        }

        private void AuthorSearchBttn_Click(object sender, RoutedEventArgs e)
        {
            
            connection.Open();
            if (AuthorNameBx.Text.Length > 0)
            {
                dataAdapter = new OleDbDataAdapter("select * from book where author_name='" + AuthorNameBx.Text + "'", connection);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                if (dt.AsDataView().Count == 0)
                {
                    MessageBox.Show("incorrect or incomplete input.");
                    connection.Close();
                }
                else
                {
                    SearchGrid.ItemsSource = dt.AsDataView();
                    connection.Close();
                }


            }
            else
            {
                MessageBox.Show("you must enter an entry");
                connection.Close();
            }
        }

        private void RefreshSearchBttn_Click(object sender, RoutedEventArgs e)
        {
            AuthorNameBx.Clear();
            BookNameBx.Clear();
            viewListSearch();

        }
    }
}
