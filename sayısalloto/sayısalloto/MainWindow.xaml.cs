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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sayısalloto
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string a=textBox1.Text;
            string b = passwordBox1.Password.ToString();
            if (a == "000" && b =="000")
            {
                MessageBox.Show("Giriş Başarılı Yönlendiriliyorsunuz...");
                Form1 c = new Form1();
                c.Show();
            }
            else
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı");
           
        }

       
    }
}
