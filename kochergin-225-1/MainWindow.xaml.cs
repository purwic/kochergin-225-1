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

namespace kochergin_225_1
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

        private void R_TextChanged(object sender, TextChangedEventArgs e)
        {
            double l, s = 0.0;
            try
            {

                double r = double.Parse(R.Text);


                l = 2 * 3.14 * r;
                s = 3.14 * Math.Pow(r, 2);

                L.Content = $"{l}";
                S.Content = $"{s}";

            } 

            catch (Exception)
            {

                L.Content = "-";
                S.Content = "-";

            }
        }
    }
}
