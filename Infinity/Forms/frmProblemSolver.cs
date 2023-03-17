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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Windows.Forms.VisualStyles;
using System.Windows.Threading;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using MaterialSkin.Controls;
using Tulpep.NotificationWindow;

namespace Infinity.Forms
{
    public partial class frmProblemSolver : Form
    {
        public frmProblemSolver()
        {
            InitializeComponent();
            


        }
        Process cmd = new Process();
        private void frmProblemSolver_Load(object sender, EventArgs e)
        {
            //Panels visiblity
            #region
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            #endregion





        }



        private void Cmd_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            SetText(e.Data);

        }
        delegate void StringArgReturningVoidDelegate(string text);
        private void SetText(string text)
        {
            if (text != null)
            {


                if (richTextBox2.InvokeRequired)
                {
                    StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText);
                    this.Invoke(d, new object[] { text });
                    

                }
                else
                {

                    int pos = richTextBox2.Find("Healtly", RichTextBoxFinds.MatchCase);
                    if (pos != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);

                        label17.Text = "Your System is Healtly";
                    }
                    else
                    {
                        label17.Text = "None";
                    }

                    richTextBox2.AppendText(Environment.NewLine);
                    richTextBox2.AppendText(text);




                }

            }
        }






        //Firewall Block and Open Port
        #region
        private void btnPortOpen_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.ToString()==string.Empty || textBox2.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Please fill in the blank fields.");
                return;
            }
            string xin;
            xin = "netsh advfirewall firewall add rule name="+label2.Text+textBox2.Text+" "+ textBox1.Text + label2.Text+"  dir =in action = allow protocol = TCP localport ="+textBox1.Text;
            string xout;
            xout= "netsh advfirewall firewall add rule name=" + label2.Text +textBox2.Text+" " + textBox1.Text+ label2.Text + "  dir =out action = allow protocol = TCP localport =" + textBox1.Text;
            

            DialogResult dialogResult = MessageBox.Show("Port "+textBox1.Text + " will be Available for Input Network and Output Network.Do you Confirm?", "Firewall Port Open", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Process process = Process.Start(new ProcessStartInfo
                    {
                        FileName = "cmd",
                        Arguments = @"/K " + xin,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    });
                    Process process2 = Process.Start(new ProcessStartInfo
                    {
                        FileName = "cmd",
                        Arguments = @"/K " + xout,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    });

                    MessageBox.Show("Firewall Port Opening Successful");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                catch (Exception)
                {

                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }




        }

        private void btnPortBlock_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.ToString() == string.Empty || textBox4.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Please fill in the blank fields.");
                return;
            }
            string xin;
            xin = "netsh advfirewall firewall add rule name=" + label2.Text + textBox3.Text + " " + textBox4.Text + label2.Text + "  dir =in action = block protocol = TCP localport =" + textBox4.Text;
            string xout;
            xout = "netsh advfirewall firewall add rule name=" + label2.Text + textBox3.Text + " " + textBox4.Text + label2.Text + "  dir =out action = block protocol = TCP localport =" + textBox4.Text;
            
            DialogResult dialogResult = MessageBox.Show("Port " + textBox4.Text + " will be Blocked for Input Network and Output Network.Do you Confirm?", "Firewall Port Block", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Process process = Process.Start(new ProcessStartInfo
                    {
                        FileName = "cmd",
                        Arguments = @"/K " + xin,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    });
                    Process process2 = Process.Start(new ProcessStartInfo
                    {
                        FileName = "cmd",
                        Arguments = @"/K " + xout,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    });

                    MessageBox.Show("Firewall Port Blocking Successful");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                catch (Exception)
                {

                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }
        #endregion


        //Flat Panel System
        #region
        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible= true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == true)
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible = true;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == true)
            {
                panel4.Visible = false;
            }
            else
            {
                panel4.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (panel5.Visible == true)
            {
                panel5.Visible = false;
            }
            else
            {
                panel5.Visible = true;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (panel6.Visible == true)
            {
                panel6.Visible = false;
            }
            else
            {
                panel6.Visible = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (panel7.Visible == true)
            {
                panel7.Visible = false;
            }
            else
            {
                panel7.Visible = true;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (panel8.Visible == true)
            {
                panel8.Visible = false;
            }
            else
            {
                panel8.Visible = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://github.com/firatkaanbitmez/Infinity/blob/0dfcca4819fbdbe6b86afff1a8883bf694b16eb7/Resource/Active%20security.gif");
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = @"/K explorer windowsdefender://ThreatSettings",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });



        }

        private void btnDefenderEnable_Click(object sender, EventArgs e)
        {


            DialogResult dialogResult = MessageBox.Show("Windows Security will be Active.Do you Confirm?", "Windows Security Enable", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Computer myComputer = new Computer();
                    string pdata = myComputer.FileSystem.SpecialDirectories.Temp;
                    string pp = (pdata + ".bat");
                    System.IO.File.WriteAllText(pp, Properties.Resources.DefenderEnable);
                    System.Diagnostics.Process.Start(pp);
                    MessageBox.Show("Process Successful.");

                }
                catch (Exception)
                {
                    MessageBox.Show("Process failed.");
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }



            


        }

        private void button6_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Windows Security will be Deactived.Your Computer will be vulnerable.Do you Confirm?", "Windows Security Disable", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Computer myComputer = new Computer();
                    string pdata = myComputer.FileSystem.SpecialDirectories.Temp;
                    string pp = (pdata + ".bat");
                    System.IO.File.WriteAllText(pp, Properties.Resources.DefenderDisable);
                    System.Diagnostics.Process.Start(pp);
                    MessageBox.Show("Process Successful.");

                }
                catch (Exception)
                {
                    MessageBox.Show("Process failed.");
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private void button888_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/firatkaanbitmez/Infinity/blob/0dfcca4819fbdbe6b86afff1a8883bf694b16eb7/Resource/deactive%20security.gif");
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = @"/K explorer windowsdefender://ThreatSettings",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Windows clock will be reset and restarted..Do you Confirm?", "Windows Time Service", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Computer myComputer = new Computer();
                    string pdata = myComputer.FileSystem.SpecialDirectories.Temp;
                    string pp = (pdata + ".bat");
                    System.IO.File.WriteAllText(pp, Properties.Resources.Clock_restart);
                    System.Diagnostics.Process.Start(pp);
                    MessageBox.Show("Process Successful.");

                }
                catch (Exception)
                {
                    MessageBox.Show("Process failed.");
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Windows internet Connection Settings will be reset and restarted..Do you Confirm?", "Windows Internet Service", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Computer myComputer = new Computer();
                    string pdata = myComputer.FileSystem.SpecialDirectories.Temp;
                    string pp = (pdata + ".bat");
                    System.IO.File.WriteAllText(pp, Properties.Resources.Reset_an_Internet_Connection__Flush_DNS_);
                    System.Diagnostics.Process.Start(pp);
                    MessageBox.Show("Process Successful.");

                }
                catch (Exception)
                {
                    MessageBox.Show("Process failed.");
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }


        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox13.Text.ToString() == string.Empty || textBox14.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Please fill in the blank fields.");
                return;
            }
            string xbuild;
            xbuild = "netsh wlan set hostednetwork mode=allow ssid=" +textBox13.Text + " key=" + textBox14.Text;
            


            DialogResult dialogResult = MessageBox.Show("Hotspot name= "+textBox13.Text+" Password="+textBox14.Text +" .Do you Confirm?", "Hotspot Builder", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Process process = Process.Start(new ProcessStartInfo
                    {
                        FileName = "cmd",
                        Arguments = @"/K " + xbuild,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    });
                    
                    Process process2 = Process.Start(new ProcessStartInfo
                    {
                        FileName = "cmd",
                        Arguments = @"/K echo netsh wlan start hostednetwork >>%userprofile%\desktop\hotspotON.bat",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    });
                    Process process3 = Process.Start(new ProcessStartInfo
                    {
                        FileName = "cmd",
                        Arguments = @"/K echo netsh wlan stop hostednetwork >>%userprofile%\desktop\hotspotOFF.bat",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    });


                    MessageBox.Show("Hotspot creation successful and A file has been created so you can start and stop the hotspot on your desktop.");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Process failed.");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (panel9.Visible == true)
            {
                panel9.Visible = false;
            }
            else
            {
                panel9.Visible = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.OutputDataReceived += Cmd_OutputDataReceived;
            cmd.Start();
            cmd.BeginOutputReadLine();


            cmd.StandardInput.WriteLine($@"{richTextBox1.Text}");
            cmd.StandardInput.Flush();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Windows Context menu Change.Do you Confirm?", "Windows 11 Context Menu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Computer myComputer = new Computer();
                    string pdata = myComputer.FileSystem.SpecialDirectories.Temp;
                    string pp = (pdata + ".bat");
                    System.IO.File.WriteAllText(pp, Properties.Resources.Windows_11_Change_OldContextMenu);
                    System.Diagnostics.Process.Start(pp);
                    MessageBox.Show("Process Successful.");

                }
                catch (Exception)
                {
                    MessageBox.Show("Process failed.");
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (panel10.Visible == true)
            {
                panel10.Visible = false;
            }
            else
            {
                panel10.Visible = true;
            }
        }





        #endregion










        //    Computer myComputer = new Computer();
        //    string pdata = myComputer.FileSystem.SpecialDirectories.Temp;
        //    string pp = (pdata + ".bat");
        //    System.IO.File.WriteAllText(pp, Properties.Resources.Port);
        //    System.Diagnostics.Process.Start(pp);

        //        Process process = Process.Start(new ProcessStartInfo
        //        {
        //            FileName = "cmd",
        //            Arguments = @"/K cd %userprofile%\desktop & mkdir Dosyayi_Sources_icine_at",
        //            UseShellExecute = false,
        //            CreateNoWindow = true,
        //            RedirectStandardOutput = true,
        //            WindowStyle = ProcessWindowStyle.Hidden
        //        });










    }
}
