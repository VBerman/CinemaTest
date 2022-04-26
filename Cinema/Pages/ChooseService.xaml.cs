using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Cinema.Pages
{
    /// <summary>
    /// Interaction logic for ChooseService.xaml
    /// </summary>
    public partial class ChooseService : Page
    {
        public DB Connection { get; set; } = new DB();
        public ObservableCollection<Service> Services { get; set; }
        public Service SelectedService { get; set; }

        public ChooseService()
        {
            InitializeComponent();
            Services = new ObservableCollection<Service>(Connection.Service.ToList());

            ComboboxService.ItemsSource = Services;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Trash.Add(new ReceiptService() { Service = SelectedService, Quantity = 1 });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Receipt());
        }
    }
}
