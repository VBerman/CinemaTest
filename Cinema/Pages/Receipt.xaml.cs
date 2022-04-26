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
    /// Interaction logic for Receipt.xaml
    /// </summary>
    public partial class Receipt : Page
    {
        public DB Connection { get; set; } = new DB();

        public Models.Receipt NewReceipt { get; set; } = new Models.Receipt();

        public ObservableCollection<Service> Services { get; set; } 

        public Receipt()
        {
            InitializeComponent();
            Services = new ObservableCollection<Service>(Connection.Service.ToList());
            NewReceipt.ReceiptService = App.Trash;
            DataGrid1.ItemsSource = NewReceipt.ReceiptService;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
 
        }
    }
}
