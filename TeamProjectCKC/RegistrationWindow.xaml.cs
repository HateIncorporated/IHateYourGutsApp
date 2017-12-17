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
using Logic;

namespace TeamProjectCKC
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private UnitOfWork unitOfWork;
        public RegistrationWindow()
        {
            unitOfWork = new UnitOfWork();
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow(unitOfWork);
            login.Show();
            Close();
        }

        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {
            User user;
            using (unitOfWork)
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
                
                if (AuthorizationLogic.LoginExists(textBoxLogin.Text, unitOfWork))
                {
                    MessageBox.Show("User with such login already exists. Please enter another login.");
                    return;
                }
                
                unitOfWork.Users.Add(new User
                {
                    Name = textBoxLastName.Text + " " + textBoxFirstName.Text,
                    Login = textBoxLogin.Text,
                    Password = passwordBox.Password,
                    Answers = "50;50;50;50;50;50;50;50;50;50"
                });
                unitOfWork.SaveChanges();
                user = AuthorizationLogic.GetUser(textBoxLogin.Text, unitOfWork);
            }
            MainWindow mainWindow = new MainWindow(user, unitOfWork);
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
