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
using MaterialSkin.Controls;
using System.Windows.Forms.VisualStyles;

namespace Infinity.Forms
{
    public partial class frmCleaner : Form
    {
        public frmCleaner()
        {
            InitializeComponent();
        }

        Process cmd = new Process();
        Process cmd1 = new Process();
        Process cmd2 = new Process();
        Process cmd3= new Process();
        Process cmd4 = new Process();
        Process cmd5 = new Process();
        Process cmd6 = new Process();
        private void btnCleaner_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Infinity CLeaner will be Run.Do you Confirm?", "Infinity Cleaner", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int Totalchecked = 0;
                int TotalValue = 0;
                foreach (Control item in this.Controls)
                {
                    if (item is CheckBox)
                    {
                        if (((CheckBox)item).Checked)
                            Totalchecked++;
                    }

                }

                //If you consider, each check box value as a 5, just multiply Totalchecked * 5
                TotalValue = Totalchecked * 5;
               
                if(Totalchecked == 0) { MessageBox.Show("Please select at least one cleaning area");
                    return;
                }
                richTextBox2.Clear();
                

                materialLabel1.Text = "Infinity Cleaner Running...";
                
                if (checkBox6.Checked)
                {
                    try
                    {

                        cmd.StartInfo.FileName = "cmd.exe";
                        cmd.StartInfo.RedirectStandardInput = true;
                        cmd.StartInfo.RedirectStandardOutput = true;
                        cmd.StartInfo.CreateNoWindow = true;
                        cmd.StartInfo.UseShellExecute = false;
                        cmd.OutputDataReceived += Cmd_OutputDataReceived;
                        cmd.Start();                       
                        cmd.BeginOutputReadLine();


                        cmd.StandardInput.WriteLine($@"
del /s /f /q “%USERPROFILE%\Local Settings\History”*.*
rd /s /q “%USERPROFILE%\Local Settings\History”
md “%USERPROFILE%\Local Settings\History”
del /s /f /q “%USERPROFILE%\Local Settings\Temporary Internet Files”*.*
rd /s /q “%USERPROFILE%\Local Settings\Temporary Internet Files”
md “%USERPROFILE%\Local Settings\Temporary Internet Files”

del /s /f /q “%USERPROFILE%\Cookies”*.*
rd /s /q “%USERPROFILE%\Cookies”
md “%USERPROFILE%\Cookies”
");
                        richTextBox2.AppendText(Environment.NewLine);
                        richTextBox2.AppendText("Temporary Internet Files CLEANN");
                        cmd.StandardInput.Flush();
                        

                    }
                    catch (Exception)
                    {
                        richTextBox2.AppendText(Environment.NewLine);
                        richTextBox2.AppendText("Temporary Internet Files Cleaning FAILLL");
                    }
                    
                }
                if (checkBox3.Checked)
                {
                    try
                    {
                        cmd1.StartInfo.FileName = "cmd.exe";
                        cmd1.StartInfo.RedirectStandardInput = true;
                        cmd1.StartInfo.RedirectStandardOutput = true;
                        cmd1.StartInfo.CreateNoWindow = true;
                        cmd1.StartInfo.UseShellExecute = false;
                        cmd1.OutputDataReceived += Cmd_OutputDataReceived;
                        cmd1.Start();
                        cmd1.BeginOutputReadLine();


                        cmd1.StandardInput.WriteLine($@"del C:\Windows\prefetch\*.*/s/q

del /q/f/s %TEMP%\*");
                        richTextBox2.AppendText(Environment.NewLine);
                        richTextBox2.AppendText("Temporary Files (Temp,Prefetch,Cache) CLEANN");
                        cmd1.StandardInput.Flush();

                        
                    }
                    catch (Exception)
                    {
                        richTextBox2.AppendText(Environment.NewLine);
                        richTextBox2.AppendText("Temporary Files (Temp,Prefetch,Cache) FAILLL");
                    }
                    

                }
                if (checkBox4.Checked)
                {
                    try
                    {

                        cmd2.StartInfo.FileName = "cmd.exe";
                        cmd2.StartInfo.RedirectStandardInput = true;
                        cmd2.StartInfo.RedirectStandardOutput = true;
                        cmd2.StartInfo.CreateNoWindow = true;
                        cmd2.StartInfo.UseShellExecute = false;
                        cmd2.OutputDataReceived += Cmd_OutputDataReceived;
                        cmd2.Start();
                        cmd2.BeginOutputReadLine();


                        cmd2.StandardInput.WriteLine($@"rd /s /q %SYSTEMDRIVE%\$Recycle.bin");
                        richTextBox2.AppendText(Environment.NewLine);
                        richTextBox2.AppendText("Recyle Bin CLEANN");
                        cmd2.StandardInput.Flush();


                    }
                    catch (Exception)
                    {
                        richTextBox2.AppendText(Environment.NewLine);
                        richTextBox2.AppendText("Recyle Bin Cleaning FAILLL");
                    }
                    

                }
                if (checkBox7.Checked)
                {
                    try
                    {
                        string pw;
                        pw = "powershell -command " + label1.Text + "cleanmgr / sagerun:1 | out-Null" + label1.Text;


                        cmd3.StartInfo.FileName = "cmd.exe";
                        cmd3.StartInfo.RedirectStandardInput = true;
                        cmd3.StartInfo.RedirectStandardOutput = true;
                        cmd3.StartInfo.CreateNoWindow = true;
                        cmd3.StartInfo.UseShellExecute = false;
                        cmd3.OutputDataReceived += Cmd_OutputDataReceived;
                        cmd3.Start();
                        cmd3.BeginOutputReadLine();


                        cmd3.StandardInput.WriteLine($@"{pw}");
                        richTextBox2.AppendText(Environment.NewLine);
                        richTextBox2.AppendText("Windows CLEANN");
                        cmd3.StandardInput.Flush();


                        
                        

                    }
                    catch (Exception)
                    {
                        richTextBox2.AppendText(Environment.NewLine);
                        richTextBox2.AppendText("Windows Cleaning FAILLL");
                    }
                    

                }
                if (checkBox5.Checked)
                {
                    try
                    {

                        cmd4.StartInfo.FileName = "cmd.exe";
                        cmd4.StartInfo.RedirectStandardInput = true;
                        cmd4.StartInfo.RedirectStandardOutput = true;
                        cmd4.StartInfo.CreateNoWindow = true;
                        cmd4.StartInfo.UseShellExecute = false;
                        cmd4.OutputDataReceived += Cmd_OutputDataReceived;
                        cmd4.Start();
                        cmd4.BeginOutputReadLine();


                        cmd4.StandardInput.WriteLine($@"RD /S /Q %SystemDrive%\windows.old
 
del /f /s /q %systemdrive%\*.tmp 

del /f /s /q %systemdrive%\*._mp 

del /f /s /q %systemdrive%\*.log 

del /f /s /q %systemdrive%\*.gid 

del /f /s /q %systemdrive%\*.chk  

del /f /s /q %systemdrive%\*.old 

del /f /s /q %windir%\*.bak ");
                        richTextBox2.AppendText(Environment.NewLine);
                        richTextBox2.AppendText("Needless Windows Files (Extensions tmp,_mp,log,chk,old,bak) CLEANN");
                        cmd4.StandardInput.Flush();


                    }
                    catch (Exception)
                    {
                        richTextBox2.AppendText(Environment.NewLine);
                        richTextBox2.AppendText("Needless Windows Files (Extensions tmp,_mp,log,chk,old,bak) Cleaning FAILLL");
                    }
                    
                }
                if (checkBox2.Checked)
                {
                    try
                    {
                        cmd5.StartInfo.FileName = "cmd.exe";
                        cmd5.StartInfo.RedirectStandardInput = true;
                        cmd5.StartInfo.RedirectStandardOutput = true;
                        cmd5.StartInfo.CreateNoWindow = true;
                        cmd5.StartInfo.UseShellExecute = false;
                        cmd5.OutputDataReceived += Cmd_OutputDataReceived;
                        cmd5.Start();
                        cmd5.BeginOutputReadLine();


                        cmd5.StandardInput.WriteLine($@"attrib -h -r -s %windir%\system32\catroot2
attrib -h -r -s %windir%\system32\catroot2.
net stop wuauserv
net stop cryptSvc
net stop bits
net stop msiserver
Ren C:\Windows\SoftwareDistribution SoftwareDistribution.old
Ren C:\Windows\System32\catroot2 Catroot2.old
net start wuauserv
net start cryptSvc
net start bits
net start msiserver");
                        richTextBox2.AppendText(Environment.NewLine);
                        richTextBox2.AppendText("Windows System (SoftwareDistribution.old,Catroot2.old) CLEANN");
                        cmd5.StandardInput.Flush();


                    }
                    catch (Exception)
                    {
                        richTextBox2.AppendText(Environment.NewLine);
                        richTextBox2.AppendText("Windows System (SoftwareDistribution.old,Catroot2.old) Cleaning FAILLL");
                    }
                    

                }
                materialLabel1.Text = "Cleaning Completed...";


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
                    int pos = richTextBox2.Find("Temporary Internet Files CLEANN", RichTextBoxFinds.MatchCase);
                    if (pos != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        pictureBox7.Image = Properties.Resources.ok;
                        checkBox6.Checked = false;
                        checkBox6.Enabled= false;
                        


                    }
                    int pos8 = richTextBox2.Find("Temporary Internet Files Cleaning FAILLL", RichTextBoxFinds.MatchCase);
                    if (pos8 != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos8);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        pictureBox7.Image = Properties.Resources.fail;

                    }
                    int pos2 = richTextBox2.Find("Temporary Files (Temp,Prefetch,Cache) CLEANN", RichTextBoxFinds.MatchCase);
                    if (pos2 != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos2);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        pictureBox8.Image = Properties.Resources.ok;
                        checkBox3.Enabled = false;
                        checkBox3.Checked = false;

                    }
                    int pos20 = richTextBox2.Find("Temporary Files (Temp,Prefetch,Cache) FAILLL", RichTextBoxFinds.MatchCase);
                    if (pos20 != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos20);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        pictureBox8.Image = Properties.Resources.fail;

                    }
                    int pos3 = richTextBox2.Find("Recyle Bin CLEANN", RichTextBoxFinds.MatchCase);
                    if (pos3 != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos3);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        pictureBox9.Image = Properties.Resources.ok;
                        checkBox4.Enabled = false;
                        checkBox4.Checked = false;

                    }
                    int pos30 = richTextBox2.Find("Recyle Bin Cleaning FAILLL", RichTextBoxFinds.MatchCase);
                    if (pos30 != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos30);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        pictureBox9.Image = Properties.Resources.fail;

                    }
                    int pos4 = richTextBox2.Find("Windows CLEANN", RichTextBoxFinds.MatchCase);
                    if (pos4 != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos4);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        pictureBox10.Image = Properties.Resources.ok;
                        checkBox7.Enabled = false;
                        checkBox7.Checked = false;
                    }
                    int pos40 = richTextBox2.Find("Windows Cleaning FAILLL", RichTextBoxFinds.MatchCase);
                    if (pos40 != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos40);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        pictureBox10.Image = Properties.Resources.fail;
                    }
                    int pos5 = richTextBox2.Find("Needless Windows Files (Extensions tmp,_mp,log,chk,old,bak) CLEANN", RichTextBoxFinds.MatchCase);
                    if (pos5 != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos5);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        pictureBox11.Image = Properties.Resources.ok;
                        checkBox5.Enabled = false;
                        checkBox5.Checked = false;

                    }
                    int pos50 = richTextBox2.Find("Needless Windows Files (Extensions tmp,_mp,log,chk,old,bak) Cleaning FAILLL", RichTextBoxFinds.MatchCase);
                    if (pos50 != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos50);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        pictureBox11.Image = Properties.Resources.fail;

                    }
                    int pos6 = richTextBox2.Find("Windows System (SoftwareDistribution.old,Catroot2.old) CLEANN", RichTextBoxFinds.MatchCase);
                    if (pos6 != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos6);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        pictureBox12.Image = Properties.Resources.ok;
                        checkBox2.Enabled = false;
                        checkBox2.Checked = false;
                    }
                    int pos60 = richTextBox2.Find("Windows System (SoftwareDistribution.old,Catroot2.old) Cleaning FAILLL", RichTextBoxFinds.MatchCase);
                    if (pos60 != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos60);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        pictureBox12.Image = Properties.Resources.fail;
                    }



                    richTextBox2.AppendText(text);





                }

            }
        }

        private void frmCleaner_Load(object sender, EventArgs e)
        {

            

        }


    }
}
