using Infinity.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;


namespace Infinity
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            hideSubMenu();
        }
        public int load_counter;
       
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            

            load_counter = Properties.Settings.Default.FirstMain;

            if (load_counter < 1)
            {
                load_counter++;

                Properties.Settings.Default.FirstMain = load_counter;
                Properties.Settings.Default.Save();

                frmFirstOpen frms = new frmFirstOpen();                
                frms.ShowDialog();
                this.Close(); // Close Application

                // Proceed With Normal Loading
            }
            


            this.Text = "Infinity";
            frmUpgrade frm = new frmUpgrade();
            frm.CFU();


            


        }




        //HİDE MENU SPECS
        #region
        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion


        //WİNDOWS
        #region
        private void btnWindows_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        
        private void btnFeatures_Click(object sender, EventArgs e)
        {
            openChildForm(new frmWFeatures());
            hideSubMenu();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            openChildForm(new frmWRemover());
            
            hideSubMenu();

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

            openChildForm(new frmWCustomize());
            hideSubMenu();

        }
        

        private void btnApps_Click(object sender, EventArgs e)
        {
            openChildForm(new frmInstaller());
            hideSubMenu();
        }

        private void btnWindowsUpdate_Click(object sender, EventArgs e)
        {
            openChildForm(new frmWindowsUpdate());
            hideSubMenu();
        }
        #endregion

        //TOOLS
        #region
        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        
        private void btnBooster_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPCBooster());
            hideSubMenu();
        }

        
        private void btnSolvers_Click(object sender, EventArgs e)
        {
            openChildForm(new frmProblemSolver());
            hideSubMenu();
        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCleaner());
            hideSubMenu();
        }
        private void btnShutdowntimer_Click(object sender, EventArgs e)
        {
            openChildForm(new frmShutdowntimer());
            hideSubMenu();
        }


        private void btnKnight_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKnightGB());
            hideSubMenu();

        }

        #endregion

        //HELP
        #region
        private void btnHelp_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAbout());
            hideSubMenu();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUpgrade());
            hideSubMenu();
        }

        #endregion

        //EXİT
        #region
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

















        #endregion

        //System Tray min
        #region
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {

                this.Hide();
                notifyIcon1.ShowBalloonTip(10, "Infinity Notice", "I'm not closed, I'm here ", ToolTipIcon.Info);
            }
        }
        
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {              
            this.Show();
            ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;

        }



        #endregion

    }
}



