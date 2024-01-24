using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cboLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(cboLocation.Text);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void ButtonForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
                
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cboLocation.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "";
            Text="SalihBrowser "+webBrowser1.Document.Title;
        }
    }
}
