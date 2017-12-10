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

namespace TeamProjectCKC
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            Close();
        }

        private void buttonSubmit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxLogin.Text = "";
            passwordBox.Password = "";
            passwordBoxConfirm.Password = "";
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
