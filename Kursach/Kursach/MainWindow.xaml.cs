using Kursach.Model;
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

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoginText.TextChanged += TextChangedEvent;
        }
        private void TextChangedEvent(object sender, EventArgs e)
        {
            AutorizationBut.IsEnabled = !string.IsNullOrWhiteSpace(LoginText.Text);
        }

        private void AutorizationBut_Click(object sender, RoutedEventArgs e)
        {
            SECEntities context = new SECEntities();
            List<users> user = context.users.SqlQuery($"SELECT * FROM users WHERE login='{LoginText.Text}' AND password='{PasswordText.Password}'").ToList();
            try
            {
                users activeUser = user.First();
                this.Hide();
                Main main = new Main(activeUser);
                main.Show();
            }
            catch {
                MessageBox.Show("Введено неправильний логін або пароль");
            }
        }
    }
}
