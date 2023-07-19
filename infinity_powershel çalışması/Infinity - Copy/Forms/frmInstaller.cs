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
using System.Text.RegularExpressions;
using Tulpep.NotificationWindow;
using MenuItem = System.Windows.Forms.MenuItem;
using ListView = System.Windows.Forms.ListView;

namespace Infinity.Forms
{
    public partial class frmInstaller : Form
    {
        public frmInstaller()
        {
            InitializeComponent();
            listView1.MouseDown += new MouseEventHandler(listView1_MouseDown);
            listView1.MouseDoubleClick += new MouseEventHandler(listView1_MouseDoubleClick);
        }
        Process cmd = new Process();
        private void frmInstaller_Load(object sender, EventArgs e)
        {
            listView1.MouseUp += new MouseEventHandler(listView1_MouseClick);
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.OutputDataReceived += Cmd_OutputDataReceived;
            cmd.Start();
            cmd.BeginOutputReadLine();
        }

        
        /*********************************************************************************************************************************************/
        /*********************************************************************************************************************************************/
        //TEST Listview Right CLİCK
        #region
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string id = "xxx";//extra value

            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem != null && listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    ContextMenu m = new ContextMenu();
                    MenuItem cashMenuItem = new MenuItem("Edit");
                    cashMenuItem.Click += delegate (object sender2, EventArgs e2)
                    {
                        ActionClick(sender, e, id);
                    };// your action here 
                    m.MenuItems.Add(cashMenuItem);

                    MenuItem cashMenuItem2 = new MenuItem("-");
                    m.MenuItems.Add(cashMenuItem2);

                    MenuItem delMenuItem = new MenuItem("Delete");
                    delMenuItem.Click += delegate (object sender2, EventArgs e2)
                    {
                        DelectAction(sender, e, id);
                    };// your action here
                    m.MenuItems.Add(delMenuItem);

                    m.Show(listView1, new System.Drawing.Point(e.X, e.Y));

                }
            }
        }

        private void DelectAction(object sender, MouseEventArgs e, string id)
        {
            ListView ListViewControl = sender as ListView;
            foreach (ListViewItem eachItem in ListViewControl.SelectedItems)
            {
                // you can use this idea to get the ListView header's name is 'Id' before delete
                Console.WriteLine(GetTextByHeaderAndIndex(ListViewControl, "Id", eachItem.Index));
                ListViewControl.Items.Remove(eachItem);

            }
        }

        private void ActionClick(object sender, MouseEventArgs e, string id)
        {
            //id is extra value when you need or delete it
            ListView ListViewControl = sender as ListView;
            foreach (ListViewItem tmpLstView in ListViewControl.SelectedItems)
            {
                Console.WriteLine(tmpLstView.Text);
                MessageBox.Show("NAME SURNAME : " + tmpLstView.SubItems[3].Text);
            }

        }

        public static string GetTextByHeaderAndIndex(ListView listViewControl, string headerName, int index)
        {
            int headerIndex = -1;
            foreach (ColumnHeader header in listViewControl.Columns)
            {
                if (header.Name == headerName)
                {
                    headerIndex = header.Index;
                    break;
                }
            }
            if (headerIndex > -1)
            {
                return listViewControl.Items[index].SubItems[headerIndex].Text;
            }
            return null;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;


            if (item != null)
            {
                MessageBox.Show("The selected Item Name is: " + item.Text);
                

            }
            else
            {
                this.listView1.SelectedItems.Clear();
                MessageBox.Show("No Item is selected");
            }
        }

        private void listView1_MouseRightClick(object sender, MouseEventArgs e)
        {

            MessageBox.Show("No Item is selected");

        }



        void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;


            ////if (item != null)
            ////{
            ////    this.searchbox.Text = item.Text;
            ////}
            ////else
            ////{
            ////    this.listView1.SelectedItems.Clear();
            ////    this.searchbox.Text = "No Item is Selected";
            ////}
        }







        #endregion

        /*********************************************************************************************************************************************/
        /*********************************************************************************************************************************************/











        ////// CMD +PS Download İnstall Block code
        #region

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
                    if (progressBar1.Value >1)
                    {
                        if(progressBar1.Value < 85)
                        {
                            progressBar1.Value+=1;
                        }
                        

                    }
                    
                }
                else
                {
                    if (listBox1.Items.Contains("Successfully installed"))
                    {
                        listView2.Items[0].SubItems[2].Text = "Installation Successful";
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
                        popup.ContentText =insName+ " Installation was Successful.";
                        popup.Popup();
                        if (progressBar1.Value < 100)
                        {
                            progressBar1.Value = 100;
                        }
                        materialLabel2.Text = " ";
                        



                    }
                    if (listBox1.Items.Contains("failed"))
                    {
                        listView2.Items[0].SubItems[2].Text = "Installation Failed";
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
        #endregion


        ////BUTON SEARCH 
        #region
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Regex.Replace(textBox1.Text, " ", "");

                listView1.Items.Clear();

                listBox1.Items.Clear();
                richTextBox1.Clear();
                listBox1.ClearSelected();
                string yyy;

                yyy = "class Software {\r\n    [string]$Name\r\n    [string]$Id\r\n    [string]$Version\r\n    [string]$Match\r\n\t[string]$Source\r\n}\r\n\r\n$upgradeResult = winget search " + textBox1.Text + " | Out-String\r\n\r\n$lines = $upgradeResult.Split([Environment]::NewLine)\r\n\r\n# Find the line that starts with Name, it contains the header\r\n$fl = 0\r\nwhile (-not $lines[$fl].StartsWith(\"Name\"))\r\n{\r\n    $fl++\r\n}\r\n\r\n# Line $i has the header, we can find char where we find ID and Version\r\n$idStart = $lines[$fl].IndexOf(\"Id\")\r\n$versionStart = $lines[$fl].IndexOf(\"Version\")\r\n$MatchStart = $lines[$fl].IndexOf(\"Match\")\r\n$sourceStart = $lines[$fl].IndexOf(\"Source\")\r\n\r\n# Now cycle in real package and split accordingly\r\n$upgradeList = @()\r\nFor ($i = $fl + 1; $i -le $lines.Length; $i++) \r\n{\r\n    $line = $lines[$i]\r\n    if ($line.Length -gt ($SourceStart + 1) -and -not $line.StartsWith('-'))\r\n    {\r\n        $name = $line.Substring(0, $idStart).TrimEnd()\r\n        $id = $line.Substring($idStart, $versionStart - $idStart).TrimEnd()\r\n        $version = $line.Substring($versionStart, $MatchStart - $versionStart).TrimEnd()\r\n        $Match = $line.Substring($MatchStart, $sourceStart - $MatchStart).TrimEnd()\t\t\r\n\t\t$Source = $line.Substring($SourceStart ).TrimEnd()\r\n        $software = [Software]::new()\r\n        $software.Name = $name+\",\";\r\n        $software.Id = $id+\",\";\r\n        $software.Version = $version+\",\";\r\n        $software.Match = $Match+\",\";\r\n\t\t$software.Source = $Source+\",\";\r\n        $upgradeList += $software\r\n    }\r\n}\r\n\r\n$upgradeList | Format-Table";
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
            catch 
            {
                listView1.Items.Add(new ListViewItem("No results search for " + textBox1.Text));
            }



            

        }

        #endregion


        //BUTON INSTALL
        #region
        public string insName;
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
                        progressBar1.Value = 10;
                        string zzz;
                        zzz = listView1.SelectedItems[0].SubItems[1].Text;
                        //string xxx;
                        //xxx = Runscript("winget install --accept-package-agreements --accept-source-agreements --silent " + zzz);
                        string sname;
                        sname = listView1.SelectedItems[0].SubItems[0].Text;
                        insName= listView1.SelectedItems[0].SubItems[0].Text;
                        string ccc = "powershell -command "+label2.Text+ "winget install --accept-package-agreements --accept-source-agreements --silent "+zzz+label2.Text;

                        ListViewItem lvi = new ListViewItem();
                        lvi.SubItems.Add(sname);
                        lvi.SubItems.Add("Downloading...");
                        lvi.SubItems.Add(zzz);
                        
                        listView2.Items.Add(lvi);


                        listBox1.Items.Clear();
                       
                        progressBar1.Value = 20;
                        materialLabel2.Text = insName+ " Background Download and Installation in progress.";
                        materialLabel3.Text = "Other You can download the programs you want to download.";
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
        #endregion

        
    }
}
