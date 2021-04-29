using System;
using System.Collections.Generic;
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

namespace BrokerageApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void EnterBut_Click(object sender, RoutedEventArgs e)
        {

            var clients = MainWindow.DB.Client.FirstOrDefault(c => c.Login == LoginTB.Text && c.Password == PasswordPB.Password);
            var manager = MainWindow.DB.Manager.FirstOrDefault(m => m.Login == LoginTB.Text && m.Password == PasswordPB.Password);
            if (clients != null)
            {
                NavigationService.Navigate(new Pages.ClientPage(clients));

            }
            if (manager != null)
            {
                NavigationService.Navigate(new ManagerPage());
            }
            
        }

        private void RegBut_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClientRegPage());
        }
    }
}
