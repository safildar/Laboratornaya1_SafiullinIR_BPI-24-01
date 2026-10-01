using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Laboratornaya1_SafiullinIR_BPI_24_01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public myDate dateA { get; set; }

        public void GetDate(myDate target)
        {
            try
            {
                target.Day = Convert.ToInt32(day.Text);
                target.Month = Convert.ToInt32(month.Text);
                target.Year = Convert.ToInt32(year.Text);
            }
            catch (ArgumentException)
            { MessageBox.Show("Введены не корректные данные", "Ошибка"); }
            catch (FormatException) { }
        }



        public MainWindow()
        {
            InitializeComponent();
            dateA = new myDate();
        }

        private void CheckEqual(myDate target)
        {
            GetDate(target);
            MessageBox.Show(target.equalMonthAndDay(), "Результат проверки");
        }
        private void equalMonthandDay_r(object sender, RoutedEventArgs e)
        {
            CheckEqual(dateA);
        }

        private void myDateA(object sender, RoutedEventArgs e)
        {
            GetDate(dateA);
            dateA.increaseMonth();
            month.Text = dateA.Month.ToString();
            year.Text = dateA.Year.ToString();
            {
                var result = dateA.showDate();
                dateTextBox.Text = Convert.ToString(result);
                dateTextBox.IsEnabled = false;
            }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!Int32.TryParse(e.Text, out val))
            {
                e.Handled = true; // отклоняем ввод
            }
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true; // если пробел, отклоняем ввод 
            }
        }

        private void ButtonShowDate_Click(object sender, RoutedEventArgs e)
        {
            GetDate(dateA);
            {
                var result = dateA.showDate();
                dateTextBox.Text = result;
                dateTextBox.IsEnabled = false;
            }
        }
    }
}
 
