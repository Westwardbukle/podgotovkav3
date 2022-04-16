using Services;
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

namespace podgotovkav3
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            bool a = double.TryParse(TextBoxA.Text, out double result1 );
            bool b = double.TryParse(TextBoxB.Text, out double result2);
            bool c = double.TryParse(TextBoxC.Text, out double result3);
            if (!(a && b && c))
            {
                MessageBox.Show("Нужно вводить числа");
            }
            else
            {
               AnswerLabel.Content= Square.Calculate(result1,result2,result3);
            }
        }
    }
}
