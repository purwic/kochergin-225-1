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

namespace _2
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

        double x1, x2, y1, y2;

        private void X1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double l, s = 0.0;
            try
            {

                x1 = double.Parse(X1.Text);

                double distance_ = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);

                distance.Content = $"{distance_}";

                

            }

            catch (Exception)
            {


            }
        }

        private void Y1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void X2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Y2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
