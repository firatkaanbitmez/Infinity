using System;
using System.Diagnostics;
using System.Drawing;
using System.Management.Automation.Runspaces;
using System.Management.Automation;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic.Devices;


namespace Infinity.Forms
{
    public partial class frmPerformanceBooster : Form
    {
        public frmPerformanceBooster()
        {
            InitializeComponent();          
            

        }

        

        private void frmPerformanceBooster_Load(object sender, EventArgs e)
        {
                        
        }
               
        

        //Next back Buttonssss
        #region
        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;

        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(step1radio1.Checked==true || step1radio2.Checked==true || step1radio3.Checked ==true)
            {
                
            }
            else
            {
                MessageBox.Show("Please choose from Step 1");
                return;
            }
            if (step2radio1.Checked == true || step2radio2.Checked == true )
            {
               
            }
            else
            {
                MessageBox.Show("Please choose from Step 2");
                return;
            }
            if (step3radio1.Checked == true || step3radio2.Checked == true)
            {

                
            }
            else
            {
                MessageBox.Show("Please choose from Step 3");
                return;
            }
            tabControl1.SelectedTab = tabPage3;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (step4radio1.Checked == true || step4radio2.Checked == true )
            {

            }
            else
            {
                MessageBox.Show("Please choose from Step 4");
                return;
            }
            if (step5radio1.Checked == true || step5radio2.Checked == true || step5radio3.Checked == true)
            {

            }
            else
            {
                MessageBox.Show("Please choose from Step 5");
                return;
            }
            
            tabControl1.SelectedTab = tabPage4;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (step6radio1.Checked == true || step6radio2.Checked == true )
            {

            }
            else
            {
                MessageBox.Show("Please choose from Step 6");
                return;
            }
            if (step7radio1.Checked == true || step7radio2.Checked == true)
            {

            }
            else
            {
                MessageBox.Show("Please choose from Step 7");
                return;
            }
            if (step8radio1.Checked == true || step8radio2.Checked == true)
            {


            }
            else
            {
                MessageBox.Show("Please choose from Step 8");
                return;
            }
            tabControl1.SelectedTab = tabPage6;
        }        

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (step9radio1.Checked == true || step9radio2.Checked == true )
            {

            }
            else
            {
                MessageBox.Show("Please choose from Step 9");
                return;
            }
            if (step10radio1.Checked == true || step10radio2.Checked == true)
            {

            }
            else
            {
                MessageBox.Show("Please choose from Step 10");
                return;
            }
            
            tabControl1.SelectedTab = tabPage5;
        }

        #endregion

        //Solid Color Control
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


            }

        }

    


        #endregion
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

        //Public Strings for Resultss
        #region
        public string s1r1;
        public string s1r2;
        public string s1r3;
        public string s2r1;
        public string s2r2;
        public string s3r1;            
        public string s3r2;
        public string s4r1;
        public string s4r2;
        public string s5r1;
        public string s5r2;
        public string s5r3;
        public string s6r1;
        public string s6r2;
        public string s7r1;
        public string s7r2;
        public string s8r1;
        public string s8r2;
        public string s9r1;
        public string s9r2;
        public string s10r1;
        public string s10r2;
        #endregion
        //Defender İnfo start button
        private void button7_Click(object sender, EventArgs e)
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
        }
        //restart button
        private void btnRestart_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\system32\shutdown.exe", "-r -f -t 60");
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("The actions you choose will be taken to increase the performance of your computer. Do you approve the start of Process.Do you Confirm?", "Performance Booster", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ///////// PowerCFG -STEP 1
                #region

                if (step1radio1.Checked)//Ultimate
                {
                    s1r1= groupBox1.Text + step1radio1.Text;
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
                    


                }
                if (step1radio2.Checked)//High
                {
                    s1r2= groupBox1.Text + step1radio2.Text;
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
                    


                }
                if (step1radio3.Checked)//PowerSaver
                {
                    s1r3= groupBox1.Text + step1radio3.Text;
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
                    


                }
                #endregion
                ///////////

                ////Sleep Plan -STEP 2
                #region
                if (step2radio1.Checked)//Default
                {
                    s2r1= groupBox2.Text + step2radio1.Text;

                }
                if (step2radio2.Checked)//Never Sleep
                {
                    s2r2= groupBox2.Text + step2radio2.Text;
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
                    

                }
                #endregion
                //////

                /////////Clean -STEP 3
                #region
                if (step3radio1.Checked)//All traash delete
                {
                    s3r1 = groupBox3.Text + step3radio1.Text;
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

                }
                if (step3radio2.Checked)//Only cache delete
                {
                    s3r2= groupBox3.Text+ step3radio2.Text;
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


                }
                #endregion
                ////////
                //////////Windows Security -STEP 4
                #region
                if (step4radio1.Checked)//Disable
                {
                    s4r1= groupBox4.Text + step4radio1.Text;
                    try
                    {
                        Computer myComputer = new Computer();
                        string pdata = myComputer.FileSystem.SpecialDirectories.Temp;
                        string pp = (pdata + ".bat");
                        System.IO.File.WriteAllText(pp, Properties.Resources.DefenderDisable);
                        System.Diagnostics.Process.Start(pp);
                        

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Process failed.");
                    }

                }
                if (step4radio2.Checked)//Enable
                {
                    s4r2= groupBox4.Text + step4radio2.Text;
                    try
                    {
                        Computer myComputer = new Computer();
                        string pdata = myComputer.FileSystem.SpecialDirectories.Temp;
                        string pp = (pdata + ".bat");
                        System.IO.File.WriteAllText(pp, Properties.Resources.DefenderEnable);
                        System.Diagnostics.Process.Start(pp);
                        

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Process failed.");
                    }

                }

                #endregion
                ////////
                //Windows Visual Effects  -STEP 5
                #region

                if (step5radio1.Checked)//default
                {
                    s5r1= groupBox5.Text + step5radio1.Text;
                    string xx;
                    xx = "$path = 'HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\VisualEffects'\r\ntry {\r\n    $s = (Get-ItemProperty -ErrorAction stop -Name visualfxsetting -Path $path).visualfxsetting \r\n    if ($s -ne 0) {\r\n        Set-ItemProperty -Path $path -Name 'VisualFXSetting' -Value 0 \r\n        }\r\n    }\r\ncatch {\r\n    New-ItemProperty -Path $path -Name 'VisualFXSetting' -Value 0 -PropertyType 'DWORD'\r\n    }\r\n\r\n";
                    Runscript(xx);

                }
                if (step5radio2.Checked)//best apperance
                {
                    s5r2= groupBox5.Text + step5radio2.Text;
                    string xx;
                    xx = "$path = 'HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\VisualEffects'\r\ntry {\r\n    $s = (Get-ItemProperty -ErrorAction stop -Name visualfxsetting -Path $path).visualfxsetting \r\n    if ($s -ne 1) {\r\n        Set-ItemProperty -Path $path -Name 'VisualFXSetting' -Value 1 \r\n        }\r\n    }\r\ncatch {\r\n    New-ItemProperty -Path $path -Name 'VisualFXSetting' -Value 1 -PropertyType 'DWORD'\r\n    }\r\n\r\n";
                    Runscript(xx);
                }
                if (step5radio3.Checked)//best performance
                {
                    s5r3= groupBox5.Text + step5radio3.Text;
                    string xx;
                    xx = "\r\n$path = 'HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\VisualEffects'\r\ntry {\r\n    $s = (Get-ItemProperty -ErrorAction stop -Name visualfxsetting -Path $path).visualfxsetting \r\n    if ($s -ne 2) {\r\n        Set-ItemProperty -Path $path -Name 'VisualFXSetting' -Value 2 \r\n        }\r\n    }\r\ncatch {\r\n    New-ItemProperty -Path $path -Name 'VisualFXSetting' -Value 2 -PropertyType 'DWORD'\r\n    }\r\n\r\n";
                    Runscript(xx);

                }
                #endregion
                ////////
                /////////xbox gamebar - STEP 6
                #region
                if (step6radio1.Checked)//disable
                {
                    s6r1= groupBox6.Text + step6radio1.Text;
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

                }
                if (step6radio2.Checked)//enable
                {
                    s6r2= groupBox6.Text + step6radio2.Text;
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

                }
                #endregion
                /////
                /////windows background apps -STEP 7
                #region
                if (step7radio1.Checked)//disable
                {
                    s7r1= groupBox8.Text + step7radio1.Text;
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

                }
                if (step7radio2.Checked)//enable
                {
                    s7r2=groupBox8.Text+ step7radio2.Text;
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
                }
                #endregion
                ////////
                ///////////windows feature internet and defender - STEP 8
                #region
                if (step8radio1.Checked)//disable
                {
                    s8r1= groupBox7.Text + step8radio1.Text;
                    try
                    {
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
                        MessageBox.Show("Process failed");
                    }
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
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Process failed");
                    }

                }
                if (step8radio2.Checked)//enable
                {
                    s8r2= groupBox7.Text + step8radio2.Text;
                    try
                    {
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
                        MessageBox.Show("Process failed");
                    }
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

                }
                #endregion
                ///////
                //////////desktop back COLOR - STEP 9
                #region
                if (step9radio1.Checked)//Solid color
                {
                    s9r1= groupBox11.Text + step9radio1.Text;
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
                            Arguments = @"/K "+colorx,
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

                }
                if (step9radio2.Checked)//Default
                {
                    s9r2= groupBox11.Text +step9radio2.Text;

                }
                #endregion
                /////
                ////////Transparanfey Effect - STEP 10
                #region
                if (step10radio1.Checked)//Disable
                {
                    s10r1= groupBox9.Text+step10radio1.Text;
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

                }
                if (step10radio2.Checked)///Enable
                {
                        s10r2= groupBox9.Text+step10radio2.Text;
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

                }

                #endregion


                ////// RESULTS PAGE
                #region
                tabControl1.SelectedTab = tabPage7;
                string xs=("Process Completed" + "\n" + "\n" + "Processes Done" + "\n" + "\n" + s1r1 + s1r2 + s1r3 + "\n" + s2r1 + s2r2 + "\n" + s3r1 + s3r2 + "\n" + s4r1 + s4r2 + "\n" + s5r1 + s5r2 + s5r3 + "\n" + s6r1 + s6r2 + "\n" + s7r1 + s7r2 + "\n" + s8r1 + s8r2 + "\n" + s9r1 + s9r2 + "\n" + s10r1 + s10r2 + "\n" + "\n" );
                richTextBox1.Text = xs;
               
                
                richTextBox1.Text = richTextBox1.Text.Replace("(Recommended)", String.Empty);
                string mystring = "\n" + "PLEASE RESTART COMPUTER";
                int length = richTextBox1.TextLength;  
                richTextBox1.AppendText(mystring);
                richTextBox1.SelectionStart = length;
                richTextBox1.SelectionLength = mystring.Length;
                richTextBox1.SelectionColor = Color.Red;

                #endregion


            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        

        
    }
}