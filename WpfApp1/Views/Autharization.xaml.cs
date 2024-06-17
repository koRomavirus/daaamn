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
using System.Windows.Shapes;
using WpfApp1.Data;
using WpfApp1.Entities;

namespace WpfApp1.Views
{
    /// <summary>
    /// Логика взаимодействия для Autharization.xaml
    /// </summary>
    public partial class Autharization : Window
    {
        public Autharization()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string password = txtPassword.Password;
            string login = txtLogin.Text;

            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(login) ) 
            {
                MessageBox.Show("Неверно", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var admin = new Admin();
            using (var context = new ApplicationDbContext())
            {
                admin  = context.Admins.Where(c => c.Password == password && c.Login == login).FirstOrDefault();
            }
            if (admin != null)
            {
                var ObrOrder = new ObrOrder();
                ObrOrder.Show();
                Close();
            }
        }  
    }
}
