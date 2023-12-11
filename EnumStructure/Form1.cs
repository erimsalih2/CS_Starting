using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumStructure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum sehirler { Adana,Adıyaman,Afyon,Ağrı,Amasya,Ankara,Antalya,Artvin,Aydın}
        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt32(textBox1.Text);
            sehirler can;
            can = (sehirler)plaka;
            label1.Text=can.ToString();
        }
    }
}
