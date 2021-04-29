using BrokerageApp.Data;
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
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        Client contextClient;
        public ClientPage(Client client)
        {
            InitializeComponent();
            contextClient = client;
            ClintListView.ItemsSource = MainWindow.DB.Client.Where(c => c.Id == contextClient.Id).ToList();
            this.DataContext = contextClient;
        }
    }
}
