using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sayısalloto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int[] rastgelesayi = new int[6];
           
            for (int i = 0; i < 6; i++)
            {

                rastgelesayi[i] = r.Next(1, 50);
                

            }
            label1.Text = (rastgelesayi[0] + " ") + (rastgelesayi[1] + " ") + (rastgelesayi[2] + " ") + (rastgelesayi[3] + " ") + (rastgelesayi[4] + " ") + (rastgelesayi[5] + " ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Window1 d = new Window1();
            d.Show();
            this.Hide();
        }

       
    }
}