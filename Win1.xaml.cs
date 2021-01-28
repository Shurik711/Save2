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
using System.Xml.Linq;
using System.Data;
using System.IO;

namespace Vygolov1
{
    /// <summary>
    /// Логика взаимодействия для Win1.xaml
    /// </summary>
    public partial class Win1 : Window
    {
        public Win1()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (rb1.IsChecked == true)
            {
                Class1.cl2 += 0;
            }
            else if (rb2.IsChecked == true)
            {
                Class1.cl2 += 2;
            }
            else if (rb3.IsChecked == true)
            {
                Class1.cl2 += 3;
            }
            if (rb4.IsChecked == true)
            {
                Class1.cl2 += 0;
            }
            else if (rb5.IsChecked == true)
            {
                Class1.cl2 += 2;
            }
            else if (rb6.IsChecked == true)
            {
                Class1.cl2 += 3;
            }
            if (rb7.IsChecked == true)
            {
                Class1.cl2 += 0;
            }
            else if (rb8.IsChecked == true)
            {
                Class1.cl2 += 2;
            }
            else if (rb9.IsChecked == true)
            {
                Class1.cl2 += 3;
            }
            this.Hide();
            Win2 Window = new Win2();
            Window.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
