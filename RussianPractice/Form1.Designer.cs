﻿namespace RussianPractice
{
    partial class Form1
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
            this.KelimeButon = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KelimeButon
            // 
            this.KelimeButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.KelimeButon.Location = new System.Drawing.Point(298, 12);
            this.KelimeButon.Name = "KelimeButon";
            this.KelimeButon.Size = new System.Drawing.Size(158, 74);
            this.KelimeButon.TabIndex = 0;
            this.KelimeButon.Text = "Generate";
            this.KelimeButon.UseVisualStyleBackColor = true;
            this.KelimeButon.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(80, 227);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(144, 106);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(332, 227);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(124, 106);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(587, 227);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(113, 106);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "button3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label1.Location = new System.Drawing.Point(307, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.KelimeButon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KelimeButon;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label1;
    }
}

