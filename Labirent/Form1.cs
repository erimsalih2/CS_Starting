using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent
{
    
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer startSoundPlayer=new System.Media.SoundPlayer("C:\\Windows\\Media\\ding.wav");
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer("C:\\Windows\\Media\\tada.wav");
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void FinishLabel_MouseEnter(object sender, EventArgs e)
        {
            finishSoundPlayer.Play();
            MessageBox.Show("Tebrikler");
            Close();
        }
        private void MoveToStart()
        {
            startSoundPlayer.Play();
            Point StartingPoint = panel1.Location;
            StartingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(StartingPoint);
        }

        private void wall_Crash(object sender, EventArgs e)
        {
            MoveToStart();
            
        }
    }
}
