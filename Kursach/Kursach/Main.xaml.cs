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
using System.Windows.Shapes;

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {

        SECEntities context = new SECEntities();
        private users activeUser;
        public Main(users user)
        {
            activeUser = user;
            InitializeComponent();
            DataContext = activeUser;
        }

        private void SurnameEditButton_Click(object sender, RoutedEventArgs e)
        {
            SurnameTextbox.Visibility=Visibility.Visible;
            SurnameButton.Visibility = Visibility.Visible;
        }

        private void NameEditButton_Click(object sender, RoutedEventArgs e)
        {
            NameTextbox.Visibility = Visibility.Visible;
            NameButton.Visibility = Visibility.Visible;
        }

        private void PatronymicEditButton_Click(object sender, RoutedEventArgs e)
        {
            PatronimycTextbox.Visibility = Visibility.Visible;
            PatronimycButton.Visibility = Visibility.Visible;
        }

        private void PhoneNumberEditButton_Click(object sender, RoutedEventArgs e)
        {
            PhoneNumberTextbox.Visibility = Visibility.Visible;
            PhoneNumberButton.Visibility = Visibility.Visible;
        }

        private void EmailEditButton_Click(object sender, RoutedEventArgs e)
        {
            EmailTextbox.Visibility = Visibility.Visible;
            EmailButton.Visibility = Visibility.Visible;
        }
        private void SurnameButton_Click(object sender, RoutedEventArgs e)
        {
            context.Database.ExecuteSqlCommand($"UPDATE users SET surname = '{SurnameTextbox.Text}' WHERE id='{activeUser.id}'");
            activeUser = context.users.Find(activeUser.id);
            SurnameTextbox.Visibility = Visibility.Hidden;
            SurnameButton.Visibility = Visibility.Hidden;

        }

        private void NameButton_Click(object sender, RoutedEventArgs e)
        {
            context.Database.ExecuteSqlCommand($"UPDATE users SET name = '{NameTextbox.Text}' WHERE id='{activeUser.id}'");
            activeUser = context.users.Find(activeUser.id);
            NameTextbox.Visibility = Visibility.Hidden;
            NameButton.Visibility = Visibility.Hidden;

        }

        private void PatronimycButton_Click(object sender, RoutedEventArgs e)
        {
            context.Database.ExecuteSqlCommand($"UPDATE users SET patronimyc = '{PatronimycTextbox.Text}' WHERE id='{activeUser.id}'");
            activeUser = context.users.Find(activeUser.id);
            Console.WriteLine($"UPDATE users SET patronimyc = '{PatronimycTextbox.Text}' WHERE id='{activeUser.id}'");
            Console.WriteLine(activeUser.patronimyc);
            PatronimycTextbox.Visibility = Visibility.Hidden;
            PatronimycButton.Visibility = Visibility.Hidden;

        }

        private void PhoneNumberButton_Click(object sender, RoutedEventArgs e)
        {
            context.Database.ExecuteSqlCommand($"UPDATE users SET phone_number = '{PhoneNumberTextbox.Text}' WHERE id='{activeUser.id}'");
            activeUser = context.users.Find(activeUser.id);
            PhoneNumberTextbox.Visibility = Visibility.Hidden;
            PhoneNumberButton.Visibility = Visibility.Hidden;
        }

        private void EmailButton_Click(object sender, RoutedEventArgs e)
        {
            context.Database.ExecuteSqlCommand($"UPDATE users SET email = '{EmailTextbox.Text}' WHERE id='{activeUser.id}'");
            activeUser = context.users.Find(activeUser.id);
            EmailTextbox.Visibility = Visibility.Hidden;
            EmailButton.Visibility = Visibility.Hidden;
        }

       
    }
}
