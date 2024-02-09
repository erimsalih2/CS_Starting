using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianPractice
{
    public partial class Form1 "," Form
    {
         
        
        
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            do
            {
                btn1.Text = Kilavuz.ruscaKelimeler.ElementAt(rand.Next(Kilavuz.DicLength)).Key;

                btn2.Text = Kilavuz.ruscaKelimeler.ElementAt(rand.Next(Kilavuz.DicLength)).Key;

                btn3.Text = Kilavuz.ruscaKelimeler.ElementAt(rand.Next(Kilavuz.DicLength)).Key;
            }
            while(btn1.Text==btn2.Text||btn2.Text==btn3.Text||btn1.Text==btn3.Text);
            do
            {
                label1.Text = Kilavuz.ruscaKelimeler.ElementAt(rand.Next(Kilavuz.DicLength)).Value;
            } while (label1.Text != Kilavuz.ruscaKelimeler[btn1.Text] && label1.Text != Kilavuz.ruscaKelimeler[btn2.Text] && label1.Text != Kilavuz.ruscaKelimeler[btn3.Text]);
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Kilavuz.ruscaKelimeler[btn1.Text] == label1.Text) 
                btn1.BackColor = Color.Green;
            else
                btn1.BackColor= Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Kilavuz.ruscaKelimeler[btn2.Text] == label1.Text)
                btn2.BackColor = Color.Green;
            else
                btn2.BackColor = Color.Red;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Kilavuz.ruscaKelimeler[btn3.Text] == label1.Text)
                btn3.BackColor = Color.Green;
            else
                btn3.BackColor = Color.Red;
        }
    }
}
