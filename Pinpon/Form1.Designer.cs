namespace Pinpon
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlayGround = new System.Windows.Forms.Panel();
            this.GameOver_lbl = new System.Windows.Forms.Label();
            this.point_lbl = new System.Windows.Forms.Label();
            this.Score_lbl = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.raket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayGround
            // 
            this.PlayGround.Controls.Add(this.GameOver_lbl);
            this.PlayGround.Controls.Add(this.point_lbl);
            this.PlayGround.Controls.Add(this.Score_lbl);
            this.PlayGround.Controls.Add(this.Ball);
            this.PlayGround.Controls.Add(this.raket);
            this.PlayGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayGround.Location = new System.Drawing.Point(0, 0);
            this.PlayGround.Name = "PlayGround";
            this.PlayGround.Size = new System.Drawing.Size(800, 450);
            this.PlayGround.TabIndex = 0;
            this.PlayGround.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GameOver_lbl
            // 
            this.GameOver_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.GameOver_lbl.Location = new System.Drawing.Point(330, 24);
            this.GameOver_lbl.Name = "GameOver_lbl";
            this.GameOver_lbl.Size = new System.Drawing.Size(264, 265);
            this.GameOver_lbl.TabIndex = 4;
            this.GameOver_lbl.Text = "Game Over\r\n\r\nF1-Restart Game\r\n\r\nESC-Exit\r\n\r\n\r\n";
            this.GameOver_lbl.Click += new System.EventHandler(this.GameOver_lbl_Click);
            // 
            // point_lbl
            // 
            this.point_lbl.AutoSize = true;
            this.point_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F);
            this.point_lbl.Location = new System.Drawing.Point(185, 24);
            this.point_lbl.Name = "point_lbl";
            this.point_lbl.Size = new System.Drawing.Size(52, 57);
            this.point_lbl.TabIndex = 3;
            this.point_lbl.Text = "0";
            this.point_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score_lbl
            // 
            this.Score_lbl.AutoSize = true;
            this.Score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F);
            this.Score_lbl.Location = new System.Drawing.Point(12, 24);
            this.Score_lbl.Name = "Score_lbl";
            this.Score_lbl.Size = new System.Drawing.Size(167, 57);
            this.Score_lbl.TabIndex = 2;
            this.Score_lbl.Text = "Score:";
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Red;
            this.Ball.Location = new System.Drawing.Point(282, 285);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(30, 30);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // raket
            // 
            this.raket.BackColor = System.Drawing.Color.Black;
            this.raket.Location = new System.Drawing.Point(282, 379);
            this.raket.Name = "raket";
            this.raket.Size = new System.Drawing.Size(200, 20);
            this.raket.TabIndex = 0;
            this.raket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayGround);
            this.Name = "GameForm";
            this.Text = "Pinpon Oyunu";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.PlayGround.ResumeLayout(false);
            this.PlayGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlayGround;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox raket;
        private System.Windows.Forms.Label point_lbl;
        private System.Windows.Forms.Label Score_lbl;
        private System.Windows.Forms.Label GameOver_lbl;
        private System.Windows.Forms.Timer timer1;
    }
}

