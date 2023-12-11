using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1 insan1=new Class1();
            insan1.AdSoyad = "Duygu Balaban";
            insan1.CanliMi = true;

            Class1 insan2=new Class1();
            insan2.AdSoyad = "Can Boz";
            Class1 insan3=new Class1("Mesut gül");
            Class1 insan4 = new Class1("Caner Kırma");

            MessageBox.Show(insan2.AdiniSoyle());
            MessageBox.Show(Class1.SelamVer());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcVatandas vat1=new TcVatandas();
            vat1.DogumTarihi = Convert.ToDateTime("1990-03-05");
            MessageBox.Show(vat1.Vizeal());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbdVatandas abdvat1=new AbdVatandas();
            abdvat1.DogumTarihi = Convert.ToDateTime("1923-11-30");
            MessageBox.Show(Convert.ToString(abdvat1.Yas));
        }
    }
}
