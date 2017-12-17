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

namespace TeamProjectCKC
{
    /// <summary>
    /// Логика взаимодействия для SlidersWindow.xaml
    /// </summary>
    public partial class SlidersWindow : Window
    {
        private UnitOfWork _unitOfWork;
        private int _questionCounter = 1;
        private List<int> _userAnswers;
        private int _totalQuestions;

        public SlidersWindow(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _totalQuestions = _unitOfWork.Questions.Count();
            UpdateWindow();
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            _questionCounter--;
            UpdateWindow();
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            if (_totalQuestions == _questionCounter)
            {
                string _strUsersAnswers = string.Join(";", _userAnswers);              
            }
            else
            _questionCounter++;
            ButtonBack.IsEnabled = true;
            UpdateWindow();

        }

        private void UpdateWindow()
        {
            var Question = _unitOfWork.Questions.First(x => x.QuestionId == _questionCounter);
            QuestionLabel.Content = Question.QuestionText;
            Slider.Value = Question.Answer;
            _userAnswers.Add(Question.Answer);
            if (_totalQuestions == _questionCounter)
            {
                ButtonNext.Content = "Done";
            }
            else ButtonNext.Content = "Next";
        }

    }
}
