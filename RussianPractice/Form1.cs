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
    public partial class Form1 : Form
    {
        static public Random rand = new Random();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button RuscaKelime1 = new Button();
            Controls.Add(RuscaKelime1);
            
            Point kelimePoint= new Point(20,150); 
            RuscaKelime1.Size = new Size(100,100);
            RuscaKelime1.Location= kelimePoint;
            
            RuscaKelime1.Text = Kilavuz.ruscaKelimeler.ElementAt(rand.Next(Kilavuz.DicLength)).Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
