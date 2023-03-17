using Microsoft.VisualBasic.Devices;
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;


namespace Infinity.Forms
{
    public partial class frmFirstOpen : Form
    {
        public frmFirstOpen()
        {
            InitializeComponent();
            
        }
        public int load_counter;
        
        Process cmd = new Process();
        private void frmFirstOpen_Load(object sender, EventArgs e)
        {
            
            load_counter = Properties.Settings.Default.FirstOpen;

            if (load_counter < 1)
            {
                load_counter=1;

                Properties.Settings.Default.FirstOpen = load_counter;
                Properties.Settings.Default.Save();


                // Proceed With Normal Loading
            }
            else
            {
                
                frmMain frms = new frmMain();
                frms.ShowDialog();
                this.Close(); // Close Application
            }



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
                    int pos = richTextBox2.Find("curl", RichTextBoxFinds.MatchCase);
                    if (pos != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        
                        materialLabel2.Text = "The necessary packages for the ";
                        materialLabel3.Text = "Windows Installer are being Downloaded.";
                    }

                    int pos1 = richTextBox2.Find("powershell", RichTextBoxFinds.MatchCase);
                    if (pos1 != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos1);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        
                        materialLabel2.Text = "The Package is Loading...";
                        materialLabel3.Text = "     ";
                       
                    }
                    int pos2 = richTextBox2.Find("zoom", RichTextBoxFinds.MatchCase);
                    if (pos2 != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos2);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        
                        
                        materialLabel2.Text = "Necessary settings are being adjusted.";
                        materialLabel3.Text = "A little later, Infinity will open.";
                    }

                    int pos3 = richTextBox2.Find("XPDM1ZW6815MQM", RichTextBoxFinds.MatchCase);
                    if (pos3 != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos3);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                                               
                       


                    }
                    
                    int pos4= richTextBox2.Find("failed", RichTextBoxFinds.MatchCase);
                    if (pos4 != -1)
                    {
                        int line = richTextBox2.GetLineFromCharIndex(pos4);
                        string lineString = line.ToString();
                        string inside = string.Format(lineString);
                        materialLabel2.Text = "An unexpected error has occurred..";
                        materialLabel3.Text = "Please Restart.";

                        load_counter = 0;

                        Properties.Settings.Default.FirstOpen = load_counter;
                        Properties.Settings.Default.Save();
                        frmMain fmsss= new frmMain();                        
                        fmsss.load_counter = load_counter;
                    }



                    richTextBox2.AppendText(text);

                                     
                                        


                }

            }
        }


       

       
    }
}
