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
using System.Windows.Threading;

namespace LibraryManagement
{
    public partial class MenuWindow : Window
    {
 

        public MenuWindow()
        {
            InitializeComponent();
            StartClock();
        }

        private void StartClock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TickEvent;
            timer.Start();
        }

        private void TickEvent(object sender, EventArgs e)
        {
            TimerTxt.Text = DateTime.Now.ToString();
        }

        private void MenuCloseBttn_Click(object sender, RoutedEventArgs e)
        {
           this.WindowState = WindowState.Minimized;
        }

        private void MenuAltTabBttn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();

        }

        private void LinkedinBttn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/yusuf-ali-koyuncu-71266b192/");
        }

        private void GithubBttn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JimySheepman");
        }

        private void BlockBttn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.turkhackteam.org/members/844488.html");
        }


        private void hmbrMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (hmbrMenu.Width !=60)
            {
                GridLength grid = new GridLength(80, GridUnitType.Pixel);
                menu1.Visibility = Visibility.Hidden;
                menu2.Visibility = Visibility.Hidden;
                menu3.Visibility = Visibility.Hidden;
                menu4.Visibility = Visibility.Hidden;
                menu6.Visibility = Visibility.Hidden;

                programName.Width = 0;
                hmbrMenu.Width = 60;

                borderBttn.Width = 60;
                borderLogo.Width = 60;
                borderMenu.Width = 60;
                solust.Width = 60;
            }
            else
            {
                GridLength grid = new GridLength(80, GridUnitType.Pixel);
                menu1.Visibility = Visibility.Visible;
                menu2.Visibility = Visibility.Visible;
                menu3.Visibility = Visibility.Visible;
                menu4.Visibility = Visibility.Visible;
                menu6.Visibility = Visibility.Visible;

                programName.Width = 100;
                hmbrMenu.Width = 75;

                borderBttn.Width = 220;
                borderLogo.Width = 220;
                borderMenu.Width = 220;
                solust.Width = 220;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddBookWindow addBook = new AddBookWindow();
            addBook.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EditBookWindow window = new EditBookWindow();
            window.Show();
            
        }

        private void searchB_Click(object sender, RoutedEventArgs e)
        {
            SearchBookWindow searchBook = new SearchBookWindow();
            searchBook.Show();
        }

        private void HomeBttn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.loc.gov");
        }
    }
}
