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

namespace _4
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

        private void X_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double x = double.Parse(X.Text);

                if (x > 0)
                {
                    double b = Math.Pow(10, x + Math.Log(x));

                    double a = 1.0 / Math.Cos(x) + Math.Log(Math.Abs(Math.Tan(x / 2))) + Math.Pow(b, 2);

                    A.Content = $"{a}";
                }

                else
                {
                    A.Content = "вне области допуст. знач.";
                }

            }

            catch (Exception)
            {
                A.Content = "-";
            }
        }
    }
}
