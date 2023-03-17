using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;
using System.Threading;

namespace Infinity
{
    public partial class frmWFeatures : Form
    {
        public frmWFeatures()
        {
            InitializeComponent();

        }




        private void frmMain_Load(object sender, EventArgs e)
        {

            Enablelist();
            Disablelist();

        }
        // Enablelist Disablelist
        #region 
        public void Enablelist()
        {
            string xcom;

            xcom = lblenablelist.Text.ToString();
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = @"/c " + xcom,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });




            richTextBox1.Text = process.StandardOutput.ReadToEnd();
            richTextBox1.Text = richTextBox1.Text.Replace("FeatureName", String.Empty);
            richTextBox1.Text = richTextBox1.Text.Replace("-----------", String.Empty);
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


        }

        public void Disablelist()
        {
            string xcom;

            xcom = lbldisablelist.Text.ToString();
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = @"/c " + xcom,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });




            richTextBox2.Text = process.StandardOutput.ReadToEnd();
            richTextBox2.Text = richTextBox2.Text.Replace("FeatureName", String.Empty);
            richTextBox2.Text = richTextBox2.Text.Replace("-----------", String.Empty);
            List<string> Lines = richTextBox2.Lines.ToList();
            //using forr
            for (int i = Lines.Count - 1; i >= 0; i--)
            {
                if (Lines[i].Trim() == string.Empty)
                {
                    Lines.RemoveAt(i);
                }
            }
            richTextBox2.Lines = Lines.ToArray();

            string[] items = richTextBox2.Text.Split('\n');
            listBox2.Items.AddRange(items);


        }
        #endregion


        private void listenable()
        {
            foreach (string item in listBox2.SelectedItems)
            {
                              
                
                    Process process = Process.Start(new ProcessStartInfo
                    {

                        FileName = "cmd",
                        Arguments = @"/c DISM /online /enable-feature /featurename:" + item + " /Norestart",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        WindowStyle = ProcessWindowStyle.Hidden

                    });
                MessageBox.Show(item + " feature has been activated.");

                
                
            }     
                        

        }
        private void listdisable()
        {
            foreach (var list in listBox1.SelectedItems)
            {

                Process process = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = @"/c DISM /online /disable-feature /featurename:" + list + " /Norestart",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    WindowStyle = ProcessWindowStyle.Hidden


                });
                MessageBox.Show(list + " feature has been disabled.");
                


            }
        }

        //Enable Disable Click BUtton
        #region
        private void btnEnable_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("The Windows Feature you selected will be Activated.Do you Confirm?", "Features Activated", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                listenable();
                string item = listBox2.SelectedItems[0].ToString();
                listBox2.Items.Remove(item);
                listBox1.Items.Add(item);

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
                        

        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("The Windows Feature you selected will be Disabled.Do you Confirm?", "Features Disabled", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                listdisable();
                string list = listBox1.SelectedItems[0].ToString();
                listBox1.Items.Remove(list);
                listBox2.Items.Add(list);

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }


        }

        #endregion




    }
}
