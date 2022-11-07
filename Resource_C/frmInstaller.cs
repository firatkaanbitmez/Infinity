using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Xml.Linq;
using System.Diagnostics;

namespace Infinity.Forms
{
    public partial class frmInstaller : Form
    {
        public frmInstaller()
        {
            InitializeComponent();
        }

        private void frmInstaller_Load(object sender, EventArgs e)
        {

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            

                listView1.Items.Clear();
            
            listBox1.Items.Clear();
            richTextBox1.Clear();
            listBox1.ClearSelected();
            string yyy;

            yyy = "class Software {\r\n    [string]$Name\r\n    [string]$Id\r\n    [string]$Version\r\n    [string]$Match\r\n\t[string]$Source\r\n}\r\n\r\n$upgradeResult = winget search "+textBox1.Text+" | Out-String\r\n\r\n$lines = $upgradeResult.Split([Environment]::NewLine)\r\n\r\n# Find the line that starts with Name, it contains the header\r\n$fl = 0\r\nwhile (-not $lines[$fl].StartsWith(\"Name\"))\r\n{\r\n    $fl++\r\n}\r\n\r\n# Line $i has the header, we can find char where we find ID and Version\r\n$idStart = $lines[$fl].IndexOf(\"Id\")\r\n$versionStart = $lines[$fl].IndexOf(\"Version\")\r\n$MatchStart = $lines[$fl].IndexOf(\"Match\")\r\n$sourceStart = $lines[$fl].IndexOf(\"Source\")\r\n\r\n# Now cycle in real package and split accordingly\r\n$upgradeList = @()\r\nFor ($i = $fl + 1; $i -le $lines.Length; $i++) \r\n{\r\n    $line = $lines[$i]\r\n    if ($line.Length -gt ($SourceStart + 1) -and -not $line.StartsWith('-'))\r\n    {\r\n        $name = $line.Substring(0, $idStart).TrimEnd()\r\n        $id = $line.Substring($idStart, $versionStart - $idStart).TrimEnd()\r\n        $version = $line.Substring($versionStart, $MatchStart - $versionStart).TrimEnd()\r\n        $Match = $line.Substring($MatchStart, $sourceStart - $MatchStart).TrimEnd()\t\t\r\n\t\t$Source = $line.Substring($SourceStart ).TrimEnd()\r\n        $software = [Software]::new()\r\n        $software.Name = $name+\",\";\r\n        $software.Id = $id+\",\";\r\n        $software.Version = $version+\",\";\r\n        $software.Match = $Match+\",\";\r\n\t\t$software.Source = $Source+\",\";\r\n        $upgradeList += $software\r\n    }\r\n}\r\n\r\n$upgradeList | Format-Table";
            richTextBox1.Text = Runscript(yyy);



            richTextBox1.Text = richTextBox1.Text.Replace("Name", String.Empty);
            richTextBox1.Text = richTextBox1.Text.Replace("Id", String.Empty);
            richTextBox1.Text = richTextBox1.Text.Replace("Version", String.Empty);
            richTextBox1.Text = richTextBox1.Text.Replace("AvailableVersio", String.Empty);
            richTextBox1.Text = richTextBox1.Text.Replace("--", String.Empty);



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
        //Runscript("winget install --accept-package-agreements --accept-source-agreements --silent " + list);

        private void btnInstall_Click(object sender, EventArgs e)
        {


            this.listView1.Focus();
            if (this.listView1.SelectedItems.Count > 0)
            {
                string snamex;
                snamex = listView1.SelectedItems[0].SubItems[0].Text;

                DialogResult dialogResult = MessageBox.Show(snamex + " will be Install.Do you Confirm?", "Software Install", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (ListViewItem eachItem in listView1.SelectedItems)
                    {
                        string zzz;
                        zzz = listView1.SelectedItems[0].SubItems[1].Text;
                        string xxx;
                        xxx = Runscript("winget install --accept-package-agreements --accept-source-agreements --silent " + zzz);
                        string sname;
                        sname = listView1.SelectedItems[0].SubItems[0].Text;
                        listView1.Items.Remove(eachItem);
                        MessageBox.Show(sname + " Install Successful");


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
    }
}
