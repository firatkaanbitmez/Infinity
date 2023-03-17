using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.ObjectModel;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Reflection.Emit;
using Tulpep.NotificationWindow;

namespace Infinity.Forms
{
    public partial class frmPCBooster : Form
    {
        public frmPCBooster()
        {
            InitializeComponent();
        }
        public int counter;

        private void frmPCBooster_Load(object sender, EventArgs e)
        {
            panelChildForm.Visible = false;
            materialButton1.Visible = false;
            materialButton2.Visible = false;
            richTextBox1.Visible = false;

        }
        //Runscript powershell
        #region
        private string Runscript(string script)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(script);
            pipeline.Commands.Add("Out-String");
            Collection<PSObject> results = pipeline.Invoke();
            runspace.Close();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject pSObject in results)
                stringBuilder.AppendLine(pSObject.ToString());
            return string.Join(Environment.NewLine, stringBuilder.ToString());
        }

        #endregion

        
        //Listview Checkced Change COLOR AND BOLD /// listview One Choice CLick
        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            

            int n = e.Item.Index;
            if (listView1.Items[n].Checked)
            {
                
                listView1.Items[n].ForeColor= Color.Green;
                listView1.Items[n].Font = new Font(listView1.Items[n].Font, listView1.Font.Style | FontStyle.Bold);

            }
            else
            {
                listView1.Items[n].ForeColor = Color.Black;
                listView1.Items[n].Font = new Font(listView1.Items[n].Font, listView1.Font.Style | FontStyle.Regular);


            }

            //LİSTVİEW ONE CHOİCE CLİCK İFFF
            #region
            if (listView1.Items[n].Checked==true)
            {
                if(n==0)
                {
                    listView1.Items[1].Checked = false;
                    listView1.Items[2].Checked = false;
                    

                }
                if (n == 1)
                {
                    listView1.Items[0].Checked = false;
                    listView1.Items[2].Checked = false;
                    

                }
                if (n == 2)
                {
                    listView1.Items[1].Checked = false;
                    listView1.Items[0].Checked = false;
                    

                }
                if (n == 3)
                {
                    listView1.Items[4].Checked = false;
                    
                }
                if (n == 4)
                {
                    listView1.Items[3].Checked = false;
                    
                }
                if (n == 5)
                {
                    listView1.Items[6].Checked = false;
                    
                }
                if (n == 6)
                {
                    listView1.Items[5].Checked = false;
                    
                }
                if (n == 7)
                {
                    listView1.Items[8].Checked = false;

                }
                if (n == 8)
                {
                    listView1.Items[7].Checked = false;

                }
                if (n == 9)
                {
                    listView1.Items[10].Checked = false;
                    listView1.Items[11].Checked = false;



                }
                if (n == 10)
                {
                    listView1.Items[9].Checked = false;
                    listView1.Items[11].Checked = false;


                }
                if (n == 11)
                {
                    listView1.Items[9].Checked = false;
                    listView1.Items[10].Checked = false;

                }
                if (n == 12)
                {
                    
                    listView1.Items[13].Checked = false;

                }
                if (n == 13)
                {
                    listView1.Items[12].Checked = false;
                    

                }
                if (n == 14)
                {
                    listView1.Items[15].Checked = false;

                }
                if (n == 15)
                {
                    listView1.Items[14].Checked = false;

                }
                if (n == 16)
                {
                    listView1.Items[17].Checked = false;


                }

                if (n == 17)
                {
                    listView1.Items[16].Checked = false;

                }
                if (n == 19)
                {
                    listView1.Items[20].Checked = false;

                }
                if (n == 20)
                {
                    listView1.Items[19].Checked = false;

                }




            }
            #endregion

            

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (listView1.Items[7].Checked == true)//Windows Security Enable
            {
                frmWSecurityEnable frms = new frmWSecurityEnable();
                frms.ShowDialog();
            }
            if (listView1.Items[8].Checked == true)//Windows Security Enable
            {
                frmWSecurityDisable ff = new frmWSecurityDisable();
                ff.ShowDialog();
            }


            if (listView1.CheckedItems.Count > 0)
            {

                int pvalue = listView1.CheckedItems.Count;

                DialogResult dialogResult = MessageBox.Show("The actions you choose will be taken to increase the performance of your computer. Do you approve the start of Process ?", "Performance Booster", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    materialProgressBar1.Value = 0;
                    materialProgressBar1.Maximum= pvalue;
                    if (listView1.Items[0].Checked == true) //Ultimate Performace
                    {

                        string xx;
                        xx = "powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61";
                        Process process = Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments = @"/K " + xx,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true,
                            WindowStyle = ProcessWindowStyle.Hidden
                        });

                        string yy;
                        yy = "powercfg -S e9a42b02-d5df-448d-aa00-03f14749eb61";
                        Process process2 = Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments = @"/K " + yy,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true,
                            WindowStyle = ProcessWindowStyle.Hidden
                        });
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[1].Checked == true)//High Performance
                    {
                        string xx;
                        xx = "powercfg -duplicatescheme 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c";
                        Process process = Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments = @"/K " + xx,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true,
                            WindowStyle = ProcessWindowStyle.Hidden
                        });

                        string yy;
                        yy = "powercfg -S 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c";
                        Process process2 = Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments = @"/K " + yy,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true,
                            WindowStyle = ProcessWindowStyle.Hidden
                        });
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[2].Checked == true)//Power Saver
                    {
                        string xx;
                        xx = "powercfg -duplicatescheme a1841308-3541-4fab-bc81-f71556f20b4a";
                        Process process = Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments = @"/K " + xx,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true,
                            WindowStyle = ProcessWindowStyle.Hidden
                        });

                        string yy;
                        yy = "powercfg -S a1841308-3541-4fab-bc81-f71556f20b4a";
                        Process process2 = Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments = @"/K " + yy,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true,
                            WindowStyle = ProcessWindowStyle.Hidden
                        });
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[3].Checked == true)//Default (Sleep)
                    {
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[4].Checked == true)//Never Sleep
                    {
                        string x1;
                        x1 = "powercfg /change -monitor-timeout-ac 0";
                        string x2;
                        x2 = "powercfg /change -monitor-timeout-dc 0";
                        string x3;
                        x3 = "powercfg /change -standby-timeout-ac 0";
                        string x4;
                        x4 = "powercfg /change -standby-timeout-dc 0";
                        string x5;
                        x5 = "powercfg /change -hibernate-timeout-ac 0";
                        string x6;
                        x6 = "powercfg /change -hibernate-timeout-dc 0";
                        Process process1 = Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments = @"/K " + x1,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true,
                            WindowStyle = ProcessWindowStyle.Hidden
                        });

                        Process process2 = Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments = @"/K " + x2,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true,
                            WindowStyle = ProcessWindowStyle.Hidden
                        });

                        Process process3 = Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments = @"/K " + x3,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true,
                            WindowStyle = ProcessWindowStyle.Hidden
                        });

                        Process process4 = Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments = @"/K " + x4,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true,
                            WindowStyle = ProcessWindowStyle.Hidden
                        });

                        Process process5 = Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments = @"/K " + x5,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true,
                            WindowStyle = ProcessWindowStyle.Hidden
                        });

                        Process process6 = Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments = @"/K " + x6,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            RedirectStandardOutput = true,
                            WindowStyle = ProcessWindowStyle.Hidden
                        });
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[5].Checked == true)//All Trash Remove
                    {
                        try
                        {
                            Computer myComputer = new Computer();
                            string pdata = myComputer.FileSystem.SpecialDirectories.Temp;
                            string pp = (pdata + ".bat");
                            System.IO.File.WriteAllText(pp, Properties.Resources.All_cleaner);
                            System.Diagnostics.Process.Start(pp);


                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed.");
                        }
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[6].Checked == true)//Only Cache Remove
                    {
                        try
                        {
                            Computer myComputer = new Computer();
                            string pdata = myComputer.FileSystem.SpecialDirectories.Temp;
                            string pp = (pdata + ".bat");
                            System.IO.File.WriteAllText(pp, Properties.Resources.Temporary_Files__Temp_Prefetch_Cache_);
                            System.Diagnostics.Process.Start(pp);


                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed.");
                        }
                        try
                        {
                            string prs;
                            prs = "cleanmgr / sagerun:1 | out-Null";

                            Runscript(prs);

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed");
                        }
                        try
                        {
                            Process process = Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd",
                                Arguments = @"/K rd /s /q %SYSTEMDRIVE%\$Recycle.bin",
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                WindowStyle = ProcessWindowStyle.Hidden
                            });

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed");
                        }
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[7].Checked == true)//Windows Security Enable
                    {
                        try
                        {
                            Computer myComputer = new Computer();
                            string pdata = myComputer.FileSystem.SpecialDirectories.Temp;
                            string pp = (pdata + ".bat");
                            System.IO.File.WriteAllText(pp, Properties.Resources.DefenderEnable);
                            System.Diagnostics.Process.Start(pp);

                            Process process1 = Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd",
                                Arguments = @"/K DISM /online /enable-feature /featurename:Windows-Defender-Default-Definitions /Norestart",
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                WindowStyle = ProcessWindowStyle.Hidden
                            });
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed.");
                        }
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[8].Checked == true)//Windows Security Disable
                    {
                        try
                        {
                            Computer myComputer = new Computer();
                            string pdata = myComputer.FileSystem.SpecialDirectories.Temp;
                            string pp = (pdata + ".bat");
                            System.IO.File.WriteAllText(pp, Properties.Resources.DefenderDisable);
                            System.Diagnostics.Process.Start(pp);



                            Process process1 = Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd",
                                Arguments = @"/K DISM /online /disable-feature /featurename:Windows-Defender-Default-Definitions /Norestart",
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                WindowStyle = ProcessWindowStyle.Hidden
                            });



                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed.");
                        }
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[9].Checked == true)//Windows Default Performance
                    {
                        string xx;
                        xx = "$path = 'HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\VisualEffects'\r\ntry {\r\n    $s = (Get-ItemProperty -ErrorAction stop -Name visualfxsetting -Path $path).visualfxsetting \r\n    if ($s -ne 0) {\r\n        Set-ItemProperty -Path $path -Name 'VisualFXSetting' -Value 0 \r\n        }\r\n    }\r\ncatch {\r\n    New-ItemProperty -Path $path -Name 'VisualFXSetting' -Value 0 -PropertyType 'DWORD'\r\n    }\r\n\r\n";
                        Runscript(xx);
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[10].Checked == true)//Windows Best Apperance
                    {
                        string xx;
                        xx = "$path = 'HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\VisualEffects'\r\ntry {\r\n    $s = (Get-ItemProperty -ErrorAction stop -Name visualfxsetting -Path $path).visualfxsetting \r\n    if ($s -ne 1) {\r\n        Set-ItemProperty -Path $path -Name 'VisualFXSetting' -Value 1 \r\n        }\r\n    }\r\ncatch {\r\n    New-ItemProperty -Path $path -Name 'VisualFXSetting' -Value 1 -PropertyType 'DWORD'\r\n    }\r\n\r\n";
                        Runscript(xx);
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[11].Checked == true)//Windows Best Performance
                    {
                        string xx;
                        xx = "\r\n$path = 'HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\VisualEffects'\r\ntry {\r\n    $s = (Get-ItemProperty -ErrorAction stop -Name visualfxsetting -Path $path).visualfxsetting \r\n    if ($s -ne 2) {\r\n        Set-ItemProperty -Path $path -Name 'VisualFXSetting' -Value 2 \r\n        }\r\n    }\r\ncatch {\r\n    New-ItemProperty -Path $path -Name 'VisualFXSetting' -Value 2 -PropertyType 'DWORD'\r\n    }\r\n\r\n";
                        Runscript(xx);
                        materialProgressBar1.Value++;

                    }
                    if (listView1.Items[12].Checked == true)//BackgroundApps Enable
                    {
                        try
                        {
                            Process process = Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd",
                                Arguments = @"/K Reg Add HKCU\Software\Microsoft\Windows\CurrentVersion\BackgroundAccessApplications /v GlobalUserDisabled /t REG_DWORD /d 0 /f",
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                WindowStyle = ProcessWindowStyle.Hidden
                            });

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed");
                        }
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[13].Checked == true)//BackgroundApps Disable
                    {
                        try
                        {
                            Process process = Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd",
                                Arguments = @"/K Reg Add HKCU\Software\Microsoft\Windows\CurrentVersion\BackgroundAccessApplications /v GlobalUserDisabled /t REG_DWORD /d 1 /f",
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                WindowStyle = ProcessWindowStyle.Hidden
                            });

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed");
                        }
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[14].Checked == true)//Transperancy Effect Enable
                    {
                        try
                        {
                            Process process1 = Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd",
                                Arguments = @"/K Reg Add HKCU\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize /v EnableTransparency /t REG_DWORD /d 1 /f",
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                WindowStyle = ProcessWindowStyle.Hidden
                            });

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed");
                        }
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[15].Checked == true)//Transperancy Effect Disable
                    {
                        try
                        {
                            Process process1 = Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd",
                                Arguments = @"/K Reg Add HKCU\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize /v EnableTransparency /t REG_DWORD /d 0 /f",
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                WindowStyle = ProcessWindowStyle.Hidden
                            });

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed");
                        }
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[16].Checked == true)//Xbox Enable
                    {
                        try
                        {
                            Process process = Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd",
                                Arguments = @"/K reg.exe add ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\GameDVR"" /v ""AppCaptureEnabled"" /t REG_DWORD /d ""1"" /f",
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                WindowStyle = ProcessWindowStyle.Hidden
                            });

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed");
                        }
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[17].Checked == true)//Xbox Disable
                    {
                        try
                        {
                            Process process = Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd",
                                Arguments = @"/K reg.exe add ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\GameDVR"" /v ""AppCaptureEnabled"" /t REG_DWORD /d ""0"" /f",
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                WindowStyle = ProcessWindowStyle.Hidden
                            });

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed");
                        }
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[18].Checked == true)//Background Color
                    {
                        try
                        {
                            Process process1 = Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd",
                                Arguments = @"/K reg add ""HKEY_CURRENT_USER\Control Panel\Desktop"" /v WallPaper /t REG_SZ /d "" "" /f",
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                WindowStyle = ProcessWindowStyle.Hidden
                            });

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed");
                        }
                        try
                        {
                            string colorx;
                            colorx = "reg add " + label24.Text + "HKEY_CURRENT_USER\\Control Panel\\Colors" + label24.Text + " /v Background /t REG_SZ /d " + label24.Text + lblColor.Text + label24.Text + " /f";
                            Process process2 = Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd",
                                Arguments = @"/K " + colorx,
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                WindowStyle = ProcessWindowStyle.Hidden
                            });

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed");
                        }

                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[19].Checked == true)//Internet Explorer Enable
                    {
                        try
                        {
                            Process process2 = Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd",
                                Arguments = @"/K DISM /online /enable-feature /featurename:Internet-Explorer-Optional-amd64 /Norestart",
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                WindowStyle = ProcessWindowStyle.Hidden
                            });

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed");
                        }
                        materialProgressBar1.Value++;
                    }
                    if (listView1.Items[20].Checked == true)//Internet Explorer Disable
                    {
                        try
                        {
                            Process process2 = Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd",
                                Arguments = @"/K DISM /online /disable-feature /featurename:Internet-Explorer-Optional-amd64 /Norestart",
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                WindowStyle = ProcessWindowStyle.Hidden
                            });
                            Process process1 = Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd",
                                Arguments = @"/K Reg DELETE ""HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\IEXPLORE.EXE"" /f",
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true,
                                WindowStyle = ProcessWindowStyle.Hidden
                            });
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Process failed");
                        }
                        materialProgressBar1.Value++;
                    }

                    if (materialProgressBar1.Value ==materialProgressBar1.Maximum)
                    {
                        panelChildForm.Visible = true;
                        panelChildForm.Dock = DockStyle.Fill;

                        materialButton1.Visible = true;
                        materialButton2.Visible = true;
                        richTextBox1.Visible = true;

                    }

                    string xs = ("Process Completed" + "\n" + "\n" + "Processes Done" + "\n" + "\n" + "\n" + "\n");
                    richTextBox1.Text = xs;


                    richTextBox1.Text = richTextBox1.Text.Replace("(Recommended)", String.Empty);
                    string mystring = "\n" + "PLEASE RESTART COMPUTER";
                    int length = richTextBox1.TextLength;
                    richTextBox1.AppendText(mystring);
                    richTextBox1.SelectionStart = length;
                    richTextBox1.SelectionLength = mystring.Length;
                    richTextBox1.SelectionColor = Color.Red;
                }
                else if (dialogResult == DialogResult.No)
                {

                    return;
                }

            }
            else
            {
                MessageBox.Show("Please select at least one process!!");
                return;
            }

           






            

        }


        //HİDE MENU SPECS
        #region
        private void hideSubMenu()
        {
            
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


        //SOLİD COLOR CONTROL
        #region
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();


            if (dlg.ShowDialog() == DialogResult.OK)
            {

                lblColorcode.Text = dlg.Color.Name;
                lblColor.Text = dlg.Color.R + "  " + dlg.Color.G + " " + dlg.Color.B;
                lblColor.ForeColor = dlg.Color;
                lblColorcode.ForeColor = dlg.Color;
                listView1.Items[18].Text= "Windows Background Color (Color :"+lblColorcode.Text+")";


            }
        }



        #endregion

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        
    }
}
