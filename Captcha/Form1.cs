using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "+", "-", "*", "/", "#" };
            int sembol3;
            Random rnd= new Random();
            int sayi1, sayi2, sayi3;
            sayi1 = rnd.Next(0, sembol1.Length);
            sayi2 = rnd.Next(0, sembol2.Length);
            sayi3 = rnd.Next(0, 10);


            label1.Text = sembol1[sayi1]+sembol2[sayi2]+sayi3.ToString();
        }
    }
}
