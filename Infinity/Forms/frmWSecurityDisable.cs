using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infinity.Forms
{
    public partial class frmWSecurityDisable : Form
    {
        public frmWSecurityDisable()
        {
            InitializeComponent();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = @"/K explorer windowsdefender://ThreatSettings",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
            materialButton1.Enabled = true;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void frmWSecurityDisable_Load(object sender, EventArgs e)
        {
            materialButton1.Enabled = false;
        }
    }
}
