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

namespace _5
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

        private void A1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double a1 = double.Parse(A1.Text);
                double a2 = double.Parse(A2.Text);
                double b1 = double.Parse(B1.Text);
                double b2 = double.Parse(B2.Text);
                double c1 = double.Parse(C1.Text);
                double c2 = double.Parse(C2.Text);

                if (a1 * b2 == a2 * b1)
                {
                    X.Content = "не сущ. или не единств.";
                    Y.Content = "не сущ. или не единств.";

                } 
                
                else
                {
                    double D = a1 * b2 - a2 * b1;

                    double x = (c1 * b2 - c2 * b1) / D;
                    double y = (a1 * c2 - a2 * c1) / D;

                    X.Content = $"{x}";
                    Y.Content = $"{y}";

                }


            }
            catch (Exception)
            {

                X.Content = "-";
                Y.Content = "-";

            }
        }

        private void A2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void B1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void B2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void C1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void C2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
