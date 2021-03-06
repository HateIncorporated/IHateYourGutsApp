﻿using System;
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
            string name = String.Empty;
            using (_unitOfWork = new UnitOfWork())
            {
                
                match = Math.Max(1, MatchingLogic.FindMatch(_user.GetList(), _unitOfWork));
                var u = _unitOfWork.Users.First(x => x.UserId == match);
                if (u != null)
                {
                    name = u.Name;
                }
               
            }

            MessageBox.Show($"You are mathced with {name}");
        }
    }
}