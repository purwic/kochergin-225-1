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

namespace _3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void A_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                // x кг конфет стоит a руб. Сколько стоит 1 кг конфет и y кг конфет?
                // a / x = стоимость за 1 кг. Тогда стоимость за 1 кг * y = стоимость за y кг

                double x = double.Parse(X.Text);
                double y_in = double.Parse(Y_in.Text);
                double a = double.Parse(A.Text);

                if (x != 0.0)
                {
                    double one = a / x;
                    double y_out = one * y_in;
                    One.Content = $"{one}";
                    Y_out.Content = $"{y_out}";

                }
                else
                {

                    One.Content = "неизвестно (т.к. x = 0)";
                    Y_out.Content = "неизвестно (т.к. x = 0)";
                }


            }

            catch (Exception) { }


        }

        private void X_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                // x кг конфет стоит a руб. Сколько стоит 1 кг конфет и y кг конфет?
                // a / x = стоимость за 1 кг. Тогда стоимость за 1 кг * y = стоимость за y кг

                double x = double.Parse(X.Text);
                double y_in = double.Parse(Y_in.Text);
                double a = double.Parse(A.Text);

                if (x != 0.0)
                {
                    double one = a / x;
                    double y_out = one * y_in;
                    One.Content = $"{one}";
                    Y_out.Content = $"{y_out}";

                }
                else
                {

                    One.Content = "неизвестно (т.к. x = 0)";
                    Y_out.Content = "неизвестно (т.к. x = 0)";
                }


            }

            catch (Exception) { }


        }

        private void Y_in_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                // x кг конфет стоит a руб. Сколько стоит 1 кг конфет и y кг конфет?
                // a / x = стоимость за 1 кг. Тогда стоимость за 1 кг * y = стоимость за y кг

                double x = double.Parse(X.Text);
                double y_in = double.Parse(Y_in.Text);
                double a = double.Parse(A.Text);

                if (x != 0.0)
                {
                    double one = a / x;
                    double y_out = one * y_in;
                    One.Content = $"{one}";
                    Y_out.Content = $"{y_out}";

                }
                else
                {

                    One.Content = "неизвестно (т.к. x = 0)";
                    Y_out.Content = "неизвестно (т.к. x = 0)";
                }


            }

            catch (Exception) { }


        }
    }
}
