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
    /// Логика взаимодействия для Win2.xaml
    /// </summary>
    public partial class Win2 : Window
    {
        public Win2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (rb1.IsChecked == true)
            {
                Class1.cl3 += 0;
            }
            else if (rb2.IsChecked == true)
            {
                Class1.cl3 += 2;
            }
            else if (rb3.IsChecked == true)
            {
                Class1.cl3 += 3;
            }
            if (rb4.IsChecked == true)
            {
                Class1.cl3 += 0;
            }
            else if (rb5.IsChecked == true)
            {
                Class1.cl3 += 2;
            }
            else if (rb6.IsChecked == true)
            {
                Class1.cl3 += 3;
            }
            if (rb7.IsChecked == true)
            {
                Class1.cl3 += 0;
            }
            else if (rb8.IsChecked == true)
            {
                Class1.cl3 += 2;
            }
            else if (rb9.IsChecked == true)
            {
                Class1.cl3 += 3;
            }
            Class1.fcl = Class1.cl1 + Class1.cl2 + Class1.cl3;
            StreamWriter writer = new StreamWriter(@"C:\Users\student\source\repos\Vygolov1\Res\Result.csv");
            writer.WriteLine("result1; result2; result3; finalresult");
            writer.WriteLine(Class1.cl1 + ";" + Class1.cl2 + ";" + Class1.cl3 + ";" + Class1.fcl);
            writer.Close();


        }
    }
}
