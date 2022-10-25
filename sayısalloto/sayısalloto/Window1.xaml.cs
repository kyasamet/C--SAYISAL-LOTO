using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace sayısalloto
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        int[,] dizi = new int[2, 3];
        private void button2_Click(object sender, RoutedEventArgs e)
        {
           dizi [0,0] = Convert.ToInt16(textBox1.Text);
           dizi [0,1] = Convert.ToInt16(textBox2.Text);
           dizi [0,2] = Convert.ToInt16(textBox3.Text);
           dizi [1,0] = Convert.ToInt16(textBox4.Text);
           dizi [1,1] = Convert.ToInt16(textBox5.Text);
           dizi [1,2] = Convert.ToInt16(textBox6.Text);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    listBox1.Items.Add(dizi[i, j].ToString());
                }
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window2 a = new Window2();
            a.Show();
            this.Hide();
        }
    }
}
