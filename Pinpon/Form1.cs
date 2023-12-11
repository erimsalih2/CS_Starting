using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinpon
{
    public partial class GameForm : Form
    {


        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;
        public GameForm()
        {

            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds=Screen.PrimaryScreen.Bounds;
            raket.Top = PlayGround.Bottom-(PlayGround.Bottom/10);

            GameOver_lbl.Left = (PlayGround.Width / 2)-(GameOver_lbl.Width/2);

            GameOver_lbl.Top = (PlayGround.Height / 2)-(GameOver_lbl.Height/2);
            GameOver_lbl.Visible = false;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            raket.Left = Cursor.Position.X-(raket.Width/2);
            Ball.Left += speed_left;
            Ball.Top += speed_top;
            if (Ball.Left <= PlayGround.Left)
            {
                speed_left = -speed_left;
            }
            if (Ball.Right >= PlayGround.Right)
            {
                speed_left = -speed_left;
            }
            if (Ball.Top <= PlayGround.Top)
            {
                speed_top = -speed_top;
            }
            if(Ball.Bottom>= PlayGround.Bottom)
            {
                GameOver_lbl.Visible = true;
                timer1.Enabled = false;
            }
            if(Ball.Bottom>=raket.Top&&Ball.Bottom<=raket.Bottom&&Ball.Left>=raket.Left&&Ball.Right<=raket.Right) {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                point_lbl.Text=points.ToString();
                Random rnd= new Random();
                PlayGround.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) {
                this.Close();
            }
            if(e.KeyCode == Keys.F1) {

                Ball.Top = 50;
                Ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                point_lbl.Text = "0";
                timer1.Enabled = true;
                GameOver_lbl.Visible = false;
                PlayGround.BackColor = Color.White;
            }
        }

        private void GameOver_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
