using System;
using System.Windows.Forms;

namespace Infinity
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {              

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("https://github.com/firatkaanbitmez/Infinity");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Email Address has been Copy");
            

            System.Windows.Forms.Clipboard.SetText("firatbitmez@outlook.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinkLabelLinkClickedEventArgs ex = new LinkLabelLinkClickedEventArgs(linkLabel2.Links[0]);
            linkLabel2_LinkClicked(sender, ex);

        }

        
    }
}
