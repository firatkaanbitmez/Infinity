using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Management.Automation;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Tulpep.NotificationWindow;


namespace Infinity.Forms
{
    public partial class frmWindowsUpdate : Form
    {
        public frmWindowsUpdate()
        {
            InitializeComponent();

        }

        Process cmd = new Process();
        private void frmWindowsUpdate_Load(object sender, EventArgs e)
        {
            btnAllUpdate.Enabled = false;
            btnSelectUpdate.Enabled = false;
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.OutputDataReceived += Cmd_OutputDataReceived;
            cmd.Start();
            cmd.BeginOutputReadLine();
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


                if (listBox1.InvokeRequired)
                {
                    StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    if (listBox1.Items.Contains("Successfully installed"))
                    {
                        PopupNotifier popup = new PopupNotifier();
                        popup.Image = Properties.Resources.popupinfinity;
                        popup.ContentFont = new System.Drawing.Font("Tahoma", 14F);
                        popup.ShowGrip = false;
                        popup.HeaderHeight = 20;
                        popup.TitlePadding = new Padding(3);
                        popup.ContentPadding = new Padding(1);
                        popup.ImagePadding = new Padding(30);
                        popup.AnimationDuration = 1000;
                        popup.AnimationInterval = 30;
                        popup.HeaderColor = Color.FromArgb(252, 164, 2);
                        popup.Scroll = true;
                        popup.TitleFont = new System.Drawing.Font("Tahoma", 14F);
                        popup.TitleColor = Color.DeepSkyBlue;
                        popup.ShowCloseButton = false;
                        popup.Size = new Size(400, 150);
                        popup.TitleText = "Infinity";
                        popup.ContentText = insName + " Updated was Successfull.";
                        popup.Popup();
                    }

                    listBox1.Items.Add(text);


                }

            }
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

        private void btnCheckForUpdates_Click(object sender, EventArgs e)
        {
            try
            {

                if (listView1.Items.Count != 0)
                {

                    listView1.Items.Clear();
                }
                btnSelectUpdate.Enabled = true;
                btnAllUpdate.Enabled = true;

                listBox1.Items.Clear();
                richTextBox1.Clear();
                listBox1.ClearSelected();
                string yyy;
                yyy = "class Software {\r\n    [string]$Name\r\n    [string]$Id\r\n    [string]$Version\r\n    [string]$AvailableVersion\r\n\t\r\n\t\r\n}\r\n\r\n$upgradeResult = winget upgrade | Out-String\r\n\r\n$lines = $upgradeResult.Split([Environment]::NewLine)\r\n\r\n# Find the line that starts with Name, it contains the header\r\n$fl = 0\r\nwhile (-not $lines[$fl].StartsWith(\"Name\"))\r\n{\r\n    $fl++\r\n}\r\n\r\n# Line $i has the header, we can find char where we find ID and Version\r\n$NameStart = $lines[$fl].IndexOf(\"Name\")\r\n$idStart = $lines[$fl].IndexOf(\"Id\")\r\n$versionStart = $lines[$fl].IndexOf(\"Version\")\r\n$availableStart = $lines[$fl].IndexOf(\"Available\")\r\n$sourceStart = $lines[$fl].IndexOf(\"Source\")\r\n\r\n# Now cycle in real package and split accordingly\r\n$upgradeList = @()\r\nFor ($i = $fl + 1; $i -le $lines.Length; $i++) \r\n{\r\n    $line = $lines[$i]\r\n    if ($line.Length -gt ($sourceStart + 1) -and -not $line.StartsWith('-'))\r\n    {\r\n\t\t\r\n        $name = $line.Substring(0, $idStart).TrimEnd()\r\n        $id = $line.Substring($idStart, $versionStart - $idStart).TrimEnd()\r\n        $version = $line.Substring($versionStart, $availableStart - $versionStart).TrimEnd()\r\n        $available = $line.Substring($availableStart, $sourceStart - $availableStart).TrimEnd()\r\n\t\t\r\n        $software = [Software]::new()\r\n        $software.Name = $name+\",\";\r\n        $software.Id = $id+\",\";\r\n        $software.Version = $version+\",\";\r\n        $software.AvailableVersion = $available;\t\t\r\n\t\t\r\n\t\t\r\n        $upgradeList += $software\r\n\t\t\r\n    }\r\n}\r\n\r\n$upgradeList | Format-Table";
                richTextBox1.Text = Runscript(yyy);


                richTextBox1.Text = richTextBox1.Text.Replace("Name", String.Empty);
                richTextBox1.Text = richTextBox1.Text.Replace("Id", String.Empty);
                richTextBox1.Text = richTextBox1.Text.Replace("Version", String.Empty);
                richTextBox1.Text = richTextBox1.Text.Replace("AvailableVersio", String.Empty);
                richTextBox1.Text = richTextBox1.Text.Replace("--", String.Empty);

                string correct = Encoding.UTF8.GetString(Encoding.GetEncoding("Windows-1254").GetBytes(richTextBox1.Text));
                richTextBox1.Text = correct;
                Encoding iso = Encoding.GetEncoding("Windows-1254");
                Encoding utf8 = Encoding.UTF8;
                byte[] utfBytes = utf8.GetBytes(richTextBox1.Text);
                byte[] isoBytes = Encoding.Convert(utf8, iso, utfBytes);
                string msg = iso.GetString(isoBytes);
                richTextBox1.Text = msg;
                richTextBox1.Text = richTextBox1.Text.Replace("?", String.Empty);


                List<string> Lines = richTextBox1.Lines.ToList();
                //using forr
                for (int i = Lines.Count - 1; i >= 0; i--)
                {
                    if (Lines[i].Trim() == string.Empty)
                    {
                        Lines.RemoveAt(i);
                    }
                }
                richTextBox1.Lines = Lines.ToArray();

                string[] items = richTextBox1.Text.Split('\n');
                listBox1.Items.AddRange(items);


                foreach (string a in listBox1.Items)
                {
                    var arr = a.Replace(" ", "").Split(',');

                    ListViewItem lvi = new ListViewItem(arr[0]);

                    for (int i = 1; i < arr.Length; i++)
                    {

                        lvi.SubItems.Add(arr[i]);
                    }
                    listView1.Items.Add(lvi);


                }
                if (this.listView1.Items.Count > 0)
                {
                    this.listView1.Focus();
                    this.listView1.Items[0].Focused = true;
                    this.listView1.Items[0].Selected = true;
                    this.listView1.Items[1].Focused = true;
                    this.listView1.Items[1].Selected = true;
                    foreach (ListViewItem eachItem in listView1.SelectedItems)
                    {
                        listView1.Items.Remove(eachItem);
                    }

                }


            }
            catch
            {
                listView1.Items.Add(new ListViewItem("No Update Available"));
            }
        }
        public string insName;

        private void btnSelectUpdate_Click(object sender, EventArgs e)
        {

            this.listView1.Focus();
            if (this.listView1.SelectedItems.Count > 0)
            {
                string snamex;
                snamex = listView1.SelectedItems[0].SubItems[0].Text;

                DialogResult dialogResult = MessageBox.Show(snamex + " will be updated.Do you Confirm?", "Software Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (ListViewItem eachItem in listView1.SelectedItems)
                    {
                        string zzz;
                        zzz = listView1.SelectedItems[0].SubItems[1].Text;


                        //string xxx;
                        //xxx = Runscript(" winget upgrade --accept-package-agreements --accept-source-agreements --silent " + zzz);
                        string sname;
                        sname = listView1.SelectedItems[0].SubItems[0].Text;
                        insName = listView1.SelectedItems[0].SubItems[0].Text;
                        listView1.Items.Remove(eachItem);

                        string ccc = "powershell -command " + label2.Text + "winget upgrade --accept-package-agreements --accept-source-agreements --silent " + zzz + label2.Text;
                        cmd.StandardInput.WriteLine($@"{ccc}");
                        cmd.StandardInput.Flush();




                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

            }
            else
            {
                return;
            }




        }

        private void btnAllUpdate_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("All System will be updated. Do you Confirm?", "Software Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (ListViewItem eachItem in listView1.Items)
                {
                    string zzz;
                    zzz = listView1.Items[0].SubItems[1].Text;
                    //string xxx;
                    //xxx = Runscript(" winget upgrade --accept-package-agreements --accept-source-agreements --silent " + zzz);
                    insName = listView1.Items[0].SubItems[1].Text;
                    string ccc = "powershell -command " + label2.Text + "winget upgrade --accept-package-agreements --accept-source-agreements --silent " + zzz + label2.Text;
                    cmd.StandardInput.WriteLine($@"{ccc}");
                    cmd.StandardInput.Flush();

                    listView1.Items.Remove(eachItem);


                }


            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }


    }
}
