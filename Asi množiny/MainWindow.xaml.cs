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

namespace Asi_množiny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a;
        int b;
        int[] pole = new int[100]; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            // a = random.Next(1, 100);
            // b = random.Next(1, 100);

            //Textbox.Text = a.ToString() + ";" + b.ToString();

            pole[69] = 69;
            pole[13] = 420;
            for(int i = 0; i < pole.Length; i++)
                {
                pole[i] = random.Next(1, 100);
                }
            //extbox.Text = "";
            //or(int i = 0; i < pole.Length; i++)
          //{
               //extbox.Text += pole[i].ToString() + "; ";
           //}
            //xtbox.Text += pole[99].ToString();

          Textbox.Text = string.Join("; ", pole);
        }
    }
}
