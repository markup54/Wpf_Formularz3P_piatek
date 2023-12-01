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

namespace Wpf_Formularz3P_piatek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wpisano do pola "+bok_txt.Text,
                "Informacja wstępna",MessageBoxButton.OK, MessageBoxImage.Information);
            //odczyt txt jako liczba rzeczywista
            double bok;
            if(double.TryParse(bok_txt.Text, out bok))
            {
                double pole = Math.Pow(bok, 2);
                pole_label.Content = pole;
                double obwod = 4 * bok;
                obwod_txt.Text = obwod.ToString();
                kwadrat2.Height = bok;
                kwadrat2.Width = bok;
          
            }
            else
            {
                MessageBox.Show("Należy wpisać liczbę");
            }

            kwadrat2.Fill = (SolidColorBrush)new BrushConverter()
                .ConvertFromString(kolor.Text);

        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //kwadrat3.Height = sliderrrr.Value;
            //kwadrat3.Width = slider.Value;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(przezroczysty.IsChecked == true) {
                kwadrat1.Opacity = 0.2;
                    }
            else
            {
                kwadrat1.Opacity = 1;
            }
        }

        private void przezroczysty_Checked(object sender, RoutedEventArgs e)
        {
            kwadrat1.Opacity = 0.2;
        }

        private void przezroczysty_Unchecked(object sender, RoutedEventArgs e)
        {
            kwadrat1.Opacity = 1;
        }
    }
}
