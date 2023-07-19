using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Infinity.Forms
{
    public partial class frmCleaner : Form
    {
        public frmCleaner()
        {
            InitializeComponent();
        }
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

        private void btnCleaner_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("All trash on Windows will be Deleted.Do you Confirm?", "Windows Cleaner", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (checkBox6.Checked)
                {
                    try
                    {
                        Computer myComputer = new Computer();
                        string pdata = myComputer.FileSystem.SpecialDirectories.Temp;
                        string pp = (pdata + ".bat");
                        System.IO.File.WriteAllText(pp, Properties.Resources.Internet_files_delete);
                        System.Diagnostics.Process.Start(pp);


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Process failed");
                    }
                    
                }
                if (checkBox3.Checked)
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
                        MessageBox.Show("Process failed");
                    }
                    

                }
                if (checkBox4.Checked)
                {
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
                if (checkBox7.Checked)
                {
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
                    

                }
                if (checkBox5.Checked)
                {
                    try
                    {
                        Computer myComputer = new Computer();
                        string pdata = myComputer.FileSystem.SpecialDirectories.Temp;
                        string pp = (pdata + ".bat");
                        System.IO.File.WriteAllText(pp, Properties.Resources.Needless_Windows_Files__Extensions_tmp__mp_log_chk_old_bak_);
                        System.Diagnostics.Process.Start(pp);


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Process failed");
                    }
                    
                }
                if (checkBox2.Checked)
                {
                    try
                    {
                        Computer myComputer = new Computer();
                        string pdata = myComputer.FileSystem.SpecialDirectories.Temp;
                        string pp = (pdata + ".bat");
                        System.IO.File.WriteAllText(pp, Properties.Resources.Windows_System__SoftwareDistribution_old_Catroot2_old_);
                        System.Diagnostics.Process.Start(pp);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Process failed");
                    }
                    

                }
                MessageBox.Show("Cleanining Completed...", "Cleaner", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
                checkBox5.Checked = true;
                checkBox6.Checked = true;
                checkBox7.Checked = true;
                
                
            }
            else
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                
            }

            
        }

        private void frmCleaner_Load(object sender, EventArgs e)
        {

        }

        
    }
}
