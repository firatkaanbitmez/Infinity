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
    public partial class frmShutdowntimer : Form
    {
        public frmShutdowntimer()
        {
            InitializeComponent();
        }
        private int counter;
        private int choose;

        private void frmShutdowntimer_Load(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnStop.Enabled = false;

            for (int i = 0; i <= 59; i++)
            {
                if (i <= 24)
                {
                    hours.Items.Add(i);

                }

                seconds.Items.Add(i);
                minutes.Items.Add(i);
            }

            TimeSpan time = TimeSpan.FromSeconds(0);
            label1.Text = time.ToString(@"hh\:mm\:ss");
            hours.SelectedItem = 0;
            minutes.SelectedItem = 0;
            seconds.SelectedItem = 0;
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==false & radioButton2.Checked == false & radioButton3.Checked == false)
            {
                MessageBox.Show("Please Select a Operation type");
                return;
            }
            
            btnStart.Enabled = false;
            btnStop.Enabled=true;
            btnPause.Enabled = true;
            
            if(counter == 0)
            {
                int saat = int.Parse(hours.SelectedItem.ToString());
                int dakika = int.Parse(minutes.SelectedItem.ToString());
                int saniye = int.Parse(seconds.SelectedItem.ToString());
                counter = (saat * 3600) + (dakika * 60) + saniye;
                progressBar1.Maximum = counter;
                timer1.Enabled = true;
                progressBar1.Value = 0;

            }
            
            timer1.Start();
           

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnPause.Enabled = false;
            progressBar1.Value = 0;
            timer1.Stop();
            timer1.Enabled = false;
            counter = 0;
            TimeSpan time = TimeSpan.FromSeconds(counter);
            label1.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.choose = 1;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.choose = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.choose = 3;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan time = TimeSpan.FromSeconds(counter);
            label1.Text = time.ToString(@"hh\:mm\:ss");
            if(counter != 0)
            {
                progressBar1.Value++;
            }
            
            counter--;
            
            
            if (counter == -1)
            {
                
                timer1.Stop();
                timer1.Enabled = false;
                switch (this.choose)
                {
                    case 1:
                        System.Diagnostics.Process.Start(@"C:\Windows\system32\shutdown.exe", "-s -f -t 0");


                        //shutdown method
                        break;
                    case 2:
                        System.Diagnostics.Process.Start(@"C:\Windows\system32\shutdown.exe", "-r -f -t 0");
                        //reset method
                        break;
                    case 3:
                        //lock out method
                        System.Diagnostics.Process.Start(@"C:\Windows\system32\shutdown.exe", "-l -f -t 0");
                        break;

                }

            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = true;
            timer1.Stop();
            
            TimeSpan time = TimeSpan.FromSeconds(counter);
            
        }
    }
}
