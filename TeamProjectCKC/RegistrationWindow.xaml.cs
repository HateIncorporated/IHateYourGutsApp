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
using LibraryV1;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using LibraryV1;

namespace TeamProjectCKC
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            Close();
        }

        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new Context())
            {
                if (textBoxLogin.Text == "" ||
                    textBoxLastName.Text == "" ||
                    textBoxFirstName.Text == "" ||
                    passwordBox.Password == "")
                {
                    MessageBox.Show("Please fill in all information.");
                    return;
                }
                if (passwordBox.Password != passwordBoxConfirm.Password)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }
            
                
                //if (context.Users.First(x => x.Login == textBoxLogin.Text) != null)
                //{
                //    MessageBox.Show("User with such login already exists. Please enter another login.");
                //    return;
                //}
                
                context.Users.Add(new User
                {
                    Name = textBoxLastName.Text + " " + textBoxFirstName.Text,
                    Login = textBoxLogin.Text,
                    Password = passwordBox.Password
                });
                context.SaveChanges();
            }
            MainWindow mainWindow = new MainWindow(textBoxLogin.Text);
            mainWindow.Show();
            this.Close();
        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxLogin.Text = "";
            passwordBox.Password = "";
            passwordBoxConfirm.Password = "";
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
