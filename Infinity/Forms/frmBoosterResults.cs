using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infinity.Forms
{
    public partial class frmBoosterResults : Form
    {
        public frmBoosterResults()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Your Computer will restart. Do you confirm?", "Restart", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(@"C:\Windows\system32\shutdown.exe", "-r -f -t 60");
            }
            else if (dialogResult == DialogResult.No)
            {

                return;
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
