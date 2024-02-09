using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Doviz_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            var XmlDosya = new XmlDocument();
            XmlDosya.Load(bugun);
            string dolaralis = XmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying ").InnerXml;
            DolarAlıs_Lbl.Text = dolaralis;
            string dolarsatis = XmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling ").InnerXml;
            DolarSatıs_Lbl.Text = dolarsatis;
            string euroalis= XmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying ").InnerXml;
            Euro_Alıs_Lbl.Text = euroalis;
            string eurosatis= XmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling ").InnerXml;
            Euro_Satıs_Lbl.Text = eurosatis;
        }

        private void BTN_DOLAR_AL_Click(object sender, EventArgs e)
        {
            txtKur.Text = DolarAlıs_Lbl.Text;
        }

        private void BTN_DOLAR_SAT_Click(object sender, EventArgs e)
        {
            txtKur.Text = DolarSatıs_Lbl.Text;
        }

        private void BTN_EURO_AL_Click(object sender, EventArgs e)
        {
            txtKur.Text = Euro_Alıs_Lbl.Text;
        }

        private void BTN_EURO_SAT_Click(object sender, EventArgs e)
        {
            txtKur.Text = Euro_Satıs_Lbl.Text;
        }

        private void btnDovizAl_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur=Convert.ToDouble(txtKur.Text);
            kur = kur / 10000;
            miktar =Convert.ToDouble(txtMiktar.Text);
            tutar = kur * miktar;
            txtTutar.Text = tutar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double kur=Convert.ToDouble(txtKur.Text);
            kur = kur / 10000;
            int miktar = Convert.ToInt32(txtMiktar.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            txtTutar.Text=tutar.ToString();
            double kalan = miktar % kur;
            kalan=Math.Round(kalan,2);
            txtKalan.Text = kalan.ToString();
        }
    }
}
