namespace SQLFORM
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBolum = new System.Windows.Forms.TextBox();
            this.textBoxDogum = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.TboxDelete = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TboxUpdateName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.TboxUpdateMajor = new System.Windows.Forms.TextBox();
            this.TboxUpdateBirth = new System.Windows.Forms.TextBox();
            this.TboxUpdateLastName = new System.Windows.Forms.TextBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 232);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAd);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxBolum);
            this.groupBox1.Controls.Add(this.textBoxDogum);
            this.groupBox1.Controls.Add(this.textBoxSoyad);
            this.groupBox1.Location = new System.Drawing.Point(40, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(29, 19);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(113, 20);
            this.textBoxAd.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxBolum
            // 
            this.textBoxBolum.Location = new System.Drawing.Point(29, 97);
            this.textBoxBolum.Name = "textBoxBolum";
            this.textBoxBolum.Size = new System.Drawing.Size(113, 20);
            this.textBoxBolum.TabIndex = 2;
            // 
            // textBoxDogum
            // 
            this.textBoxDogum.Location = new System.Drawing.Point(29, 71);
            this.textBoxDogum.Name = "textBoxDogum";
            this.textBoxDogum.Size = new System.Drawing.Size(113, 20);
            this.textBoxDogum.TabIndex = 1;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(29, 45);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(113, 20);
            this.textBoxSoyad.TabIndex = 0;
            // 
            // TboxDelete
            // 
            this.TboxDelete.Location = new System.Drawing.Point(59, 28);
            this.TboxDelete.Name = "TboxDelete";
            this.TboxDelete.Size = new System.Drawing.Size(100, 20);
            this.TboxDelete.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.TboxDelete);
            this.groupBox2.Location = new System.Drawing.Point(231, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 188);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(59, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 37);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnReset);
            this.groupBox3.Controls.Add(this.TboxUpdateName);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.TboxUpdateMajor);
            this.groupBox3.Controls.Add(this.TboxUpdateBirth);
            this.groupBox3.Controls.Add(this.TboxUpdateLastName);
            this.groupBox3.Location = new System.Drawing.Point(442, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 188);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update";
            // 
            // TboxUpdateName
            // 
            this.TboxUpdateName.Location = new System.Drawing.Point(29, 19);
            this.TboxUpdateName.Name = "TboxUpdateName";
            this.TboxUpdateName.Size = new System.Drawing.Size(113, 20);
            this.TboxUpdateName.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(29, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 33);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // TboxUpdateMajor
            // 
            this.TboxUpdateMajor.Location = new System.Drawing.Point(29, 97);
            this.TboxUpdateMajor.Name = "TboxUpdateMajor";
            this.TboxUpdateMajor.Size = new System.Drawing.Size(113, 20);
            this.TboxUpdateMajor.TabIndex = 2;
            // 
            // TboxUpdateBirth
            // 
            this.TboxUpdateBirth.Location = new System.Drawing.Point(29, 71);
            this.TboxUpdateBirth.Name = "TboxUpdateBirth";
            this.TboxUpdateBirth.Size = new System.Drawing.Size(113, 20);
            this.TboxUpdateBirth.TabIndex = 1;
            // 
            // TboxUpdateLastName
            // 
            this.TboxUpdateLastName.Location = new System.Drawing.Point(29, 45);
            this.TboxUpdateLastName.Name = "TboxUpdateLastName";
            this.TboxUpdateLastName.Size = new System.Drawing.Size(113, 20);
            this.TboxUpdateLastName.TabIndex = 0;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(654, 286);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(35, 13);
            this.lblSelected.TabIndex = 7;
            this.lblSelected.Text = "label1";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(29, 163);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(113, 23);
            this.BtnReset.TabIndex = 6;
            this.BtnReset.Text = "Reset TextBoxes";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxBolum;
        private System.Windows.Forms.TextBox textBoxDogum;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox TboxDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TboxUpdateName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox TboxUpdateMajor;
        private System.Windows.Forms.TextBox TboxUpdateBirth;
        private System.Windows.Forms.TextBox TboxUpdateLastName;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button BtnReset;
    }
}

