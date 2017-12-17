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
        Questions Qinfo = new Questions();
        public SlidersWindow()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            //Slider.Value = Предылущее
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {           
            ButtonBack.IsEnabled = true;
            Slider.Value = 50;
            //QuestionLabel.Content = Questions.;
        }
    }
}
