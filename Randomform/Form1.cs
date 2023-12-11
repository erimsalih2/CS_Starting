using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand =new Random();
            int sayi1,sayi2,sayi3;
            sayi1 = rand.Next(1,10);
            sayi2 = rand.Next(1, 10);
            sayi3 = rand.Next(1, 10);
            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
