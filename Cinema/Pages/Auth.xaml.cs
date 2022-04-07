using Cinema.Models;
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

namespace Cinema.Pages
{
    /// <summary>
    /// Interaction logic for Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            var connection = new DB();
            var user = connection.Staff.FirstOrDefault(s => s.Login == Login.Text & s.Password == Password.Text);
            // null если объект не найден
            if (user == null)
            {
                MessageBox.Show("Пользователь не найден", "Ошибка");

            }
            else
            {
                App.CurrentUser = user;
                NavigationService.Navigate(new MainMenu());
            }

        }
    }
}
