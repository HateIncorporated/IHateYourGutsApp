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
using Logic;

namespace TeamProjectCKC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User _user;
        private UnitOfWork _unitOfWork;
        public MainWindow(User user, UnitOfWork unitOfWork)
        {
            _user = user;
            _unitOfWork = unitOfWork;
            InitializeComponent();
            TextBlockLoginSpace.Text = _user.Name;
        }

        private void ButtonQuestions_Click(object sender, RoutedEventArgs e)
        {
            SlidersWindow sliderwindow = new SlidersWindow(_unitOfWork);
            sliderwindow.Show();
            this.Close();
        }

        private void ButtonLogOut_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow logwindow = new LoginWindow(_unitOfWork);
            logwindow.Show();
            this.Close();
        }

        private void ButtonMatch_Click(object sender, RoutedEventArgs e)
        {
            int match;
            using (_unitOfWork)
            {
                match = MatchingLogic.FindMatch(_user.Answers, _unitOfWork);
            }
            MessageBox.Show($"You are mathced with {match}");
        }
    }
}