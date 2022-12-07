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

namespace Практ6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Логика взаимодействия для MainWindow.xaml
        /// </summary>
   
            Pair firstpara = new Pair(); Pair secondpara = new Pair(); Pair thirdpara = new Pair();
            public MainWindow()
            {
                InitializeComponent();
            }



            private void AboutClick(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("Борькин Иван ИСП-31 \nИспользовать класс Pair (пара четных чисел). Разработать операцию инкремента - (а, b) = (а + b, b).Разработать операцию для вычисления произведения 2 пар чисел – (а, b) * (с, d) = (а * c, b * d)");
            }

            private void ExitClick(object sender, RoutedEventArgs e)
            {
                Close();
            }



            private void OneParaClick(object sender, RoutedEventArgs e)
            {
                Rez.Clear();
                int.TryParse(rd1.Text, out int ch1); int.TryParse(rd2.Text, out int ch2);
                if (ch1 % 2 == 0 && ch2 % 2 == 0)
                {
                    firstpara.Para1 = ch1; firstpara.Para2 = ch2;
                    Rez.Text = Convert.ToString($"Созданная пара ({firstpara.Para1};{firstpara.Para2})");
                }
                else
                {
                    firstpara.Para1 = ch1; firstpara.Para2 = ch2;
                }
            }
            private void Calculate_Click(object sender, RoutedEventArgs e)
            {
                int.TryParse(rd1.Text, out int ch1); int.TryParse(rd2.Text, out int ch2); int.TryParse(rd3.Text, out int ch3); int.TryParse(rd4.Text, out int ch4);
                if (ch1 % 2 == 0 && ch2 % 2 == 0 && ch3 % 2 == 0 && ch4 % 2 == 0)
                {
                firstpara.Para1 = ch1; firstpara.Para2 = ch2; secondpara.Para1 = ch3; secondpara.Para2 = ch4;
                thirdpara = firstpara * secondpara;
                Rez.Text = Convert.ToString($"Результат оператора умножения ({thirdpara.Para1};{thirdpara.Para2})  ");

            }
            else
                {
                    
                }
            }

            private void ClearClick(object sender, RoutedEventArgs e)
            {
                rd1.Clear(); rd2.Clear(); rd3.Clear(); rd4.Clear(); Rez.Clear();
            }

            private void MultiOnePairClick(object sender, RoutedEventArgs e)
            {
                Rez.Clear();
                int.TryParse(rd1.Text, out int ch1); int.TryParse(rd2.Text, out int ch2);
                if (ch1 % 2 == 0 && ch2 % 2 == 0)
                {
                    firstpara.Para1 = ch1; firstpara.Para2 = ch2;
                    thirdpara = firstpara.multiplication(firstpara);
                    Rez.Text = Convert.ToString($"Созданная пара ({firstpara.Para1};{firstpara.Para2}) \nРезультат умножения пары {thirdpara.Para1}");
                }
                else
                {
                MessageBox.Show("Данные введены не корректно");
                }
            }

        private void IncrementClick(object sender, RoutedEventArgs e)
        {
            Rez.Clear();
            int.TryParse(rd1.Text, out int ch1); int.TryParse(rd2.Text, out int ch2);
            if (ch1 != 0 && ch1 % 2 == 0 && ch2 != 0 && ch2 % 2 == 0)
            {
                firstpara.Para1 = ch1; firstpara.Para2 = ch2;
                firstpara ++;
                Rez.Text = Convert.ToString($"Результат инкремента ({firstpara.Para1};{firstpara.Para2})\nЗначение инкремента({firstpara.Para2})");
            }
            else
            {
                MessageBox.Show("Данные введены не корректно");
            }

        }
    }
    }

