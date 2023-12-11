using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn=new Button();
            Point btnpoint = new Point();
            btn.Location = btnpoint;
            btn.Name = "Button2";
            btn.Text = "Tikla";
            btn.Size = new Size(150,100);
            btn.BackColor = Color.Green;

            Label lbl = new Label();
            Point lblpoint = new Point(300,25);
            lbl.Text = "Oha yaZİ";
            lbl.Name = "label1";
            lbl.Size = new Size(150, 150);
            lbl.Location = lblpoint;
            lbl.BackColor= Color.Red;
            lbl.AutoSize = true;


            for(int i = 0; i < 5; i++) { 
                TextBox txt = new TextBox();
                Point txtkonum= new Point(350,i*30);
                txt.Location= txtkonum;
                txt.Name= "label2";
                txt.Text = i.ToString();
                txt.AutoSize=true;
                this.Controls.Add(txt);
            }

            this.Controls.Add(lbl);
            this.Controls.Add(btn);
        }
    }
}
