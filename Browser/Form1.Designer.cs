namespace Browser
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ButtonBack = new System.Windows.Forms.ToolStripButton();
            this.ButtonForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cboLocation = new System.Windows.Forms.ToolStripComboBox();
            this.GoButton = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonBack,
            this.ButtonForward,
            this.toolStripSeparator1,
            this.cboLocation,
            this.GoButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.ContextMenuStrip = this.contextMenuStrip1;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 425);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // ButtonBack
            // 
            this.ButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBack.Image")));
            this.ButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(36, 22);
            this.ButtonBack.Text = "Back";
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonForward
            // 
            this.ButtonForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonForward.Image = ((System.Drawing.Image)(resources.GetObject("ButtonForward.Image")));
            this.ButtonForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonForward.Name = "ButtonForward";
            this.ButtonForward.Size = new System.Drawing.Size(54, 22);
            this.ButtonForward.Text = "Forward";
            this.ButtonForward.Click += new System.EventHandler(this.ButtonForward_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cboLocation
            // 
            this.cboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(121, 25);
            this.cboLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboLocation_KeyDown);
            // 
            // GoButton
            // 
            this.GoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GoButton.Image = ((System.Drawing.Image)(resources.GetObject("GoButton.Image")));
            this.GoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(26, 22);
            this.GoButton.Text = "Go";
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "SalihBrowser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton ButtonBack;
        private System.Windows.Forms.ToolStripButton ButtonForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cboLocation;
        private System.Windows.Forms.ToolStripButton GoButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

