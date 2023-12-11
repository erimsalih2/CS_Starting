using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTrain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd= new Random();
            int sayac = 1;
            
            Point pnt=new Point();
            
            while (sayac != 3)
            {
                int x = rnd.Next(1,100);
                switch (sayac)
                {
                    case 1:pnt.X=x; break;
                case 2:pnt.Y = x;break;
                }
                sayac++;
            }
            pictureBox1.Location= pnt;
        }
    }
}
