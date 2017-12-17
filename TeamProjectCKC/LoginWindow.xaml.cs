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
using Logic;
using LibraryV1;

namespace TeamProjectCKC
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private UnitOfWork _unitOfWork = new UnitOfWork();
        public LoginWindow(UnitOfWork unitOfWork)
        {
            //_unitOfWork = unitOfWork;
            InitializeComponent();
        }

        private void ButtonLoginWindow_Click(object sender, RoutedEventArgs e)
        {          
            string LoginCheck = textBoxLogin.Text;
            string PasswordCheck = passwordBox1.Password;
            using (_unitOfWork)
            {
                if (textBoxLogin.Text == "" ||
                    passwordBox1.Password == "")
                {
                    MessageBox.Show("Please, fill in all the information");
                }
                if (AuthorizationLogic.LoginCheking(LoginCheck, PasswordCheck, _unitOfWork))
                {
                    AuthorizationLogic.GetUser(LoginCheck, _unitOfWork);
                    MainWindow mainWindow = new MainWindow(AuthorizationLogic.GetUser(LoginCheck, _unitOfWork), _unitOfWork);
                    mainWindow.Show();
                    this.Close();
                }
                else MessageBox.Show("Incorrect User login or password.");
            }
        }

        private void ButtonRegisterLoginWindow_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registration = new RegistrationWindow();
            registration.Show();
            this.Close();
        }
    }
}
