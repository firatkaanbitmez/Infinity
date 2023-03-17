using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Tulpep.NotificationWindow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Media;
using SharpCompress.Common;
using System.Threading;

namespace Infinity.Forms
{
    public partial class frmKnightGB : Form
    {
        public frmKnightGB()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        

        private void frmKnightGB_Load(object sender, EventArgs e)
        {
            panel2.Visible = true;
            backgroundWorker1.RunWorkerAsync();
            btnStop.Enabled= false;
            timer1.Interval=30000;

            



        }
        private SoundPlayer unacabeza = new SoundPlayer();
        
        private void btnStart_Click(object sender, EventArgs e)
        {
           


            btnStop.Enabled= true;
            btnStart.Enabled= false;
            timer1.Start();
        }
        int counter;
        private void timer1_Tick(object sender, EventArgs e)
        {
            double sitealis = double.Parse(materialTextBox1.Text);
            double sitesatis = double.Parse(materialTextBox2.Text);
            double sitealis2 = double.Parse(materialTextBox4.Text);
            double sitesatis2 = double.Parse(materialTextBox3.Text);
            double sitealis3 = double.Parse(materialTextBox6.Text);
            double sitesatis3 = double.Parse(materialTextBox5.Text);
            double takipalis = double.Parse(txtTakipAlıs.Text);
            double takipsatis = double.Parse(txtTaskipSatıs.Text);
            


            counter++;           
            materialLabel3.Text = counter.ToString();
            Goldbar();

            if (sitealis == takipalis || sitealis > takipalis || sitealis2 == takipalis || sitealis2 > takipalis || sitealis3 == takipalis || sitealis3 > takipalis)
            {
                
                               
                SoundPlayer unacabeza = new SoundPlayer(Infinity.Properties.Resources.gb_yükseldi_sound); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
                
                unacabeza.Play();
                Thread.Sleep(10000);

            }
            if (sitesatis == takipsatis || sitesatis < takipsatis || sitesatis2 == takipsatis || sitesatis2 < takipsatis || sitesatis3 == takipsatis || sitesatis3 < takipsatis)
            {

                
                SoundPlayer unacabeza = new SoundPlayer(Infinity.Properties.Resources.gb_düstü_cek); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name

                unacabeza.Play();
                
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            timer1.Stop();
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Goldbar();
        }




        private void Goldbar()
        {
            materialTextBox1.Clear();
            materialTextBox2.Clear();
            materialTextBox3.Clear();
            materialTextBox4.Clear();
            materialTextBox5.Clear();
            materialTextBox6.Clear();

            if (materialComboBox1.Text == "PANDORA")
            {
               
                HtmlWeb web = new HtmlWeb();

                HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.kopazar.com/knight-online-gold-bar");

                foreach (var item in doc.DocumentNode.SelectNodes("//*[@id=\'FormGold66\']/div/div/div/div[4]/div/div[1]/strong"))
                {

                    materialTextBox1.AppendText(item.InnerText);
                }
                foreach (var item in doc.DocumentNode.SelectNodes("//*[@id=\'FormGold66\']/div/div/div/div[4]/div/div[3]/strong"))
                {

                    materialTextBox2.AppendText(item.InnerText);
                }
                materialTextBox1.Text = materialTextBox1.Text.Replace(" ₺", String.Empty);
                materialTextBox2.Text = materialTextBox2.Text.Replace(" ₺", String.Empty);



                HtmlAgilityPack.HtmlDocument doc2 = web.Load("https://www.bynogame.com/tr/oyunlar/knight-online/gold-bar");

                foreach (var item in doc2.DocumentNode.SelectNodes("//*[@id=\"scrollItems\"]/div/div[3]/div/div/div[2]/div/div[2]/div/div/div/p/span"))
                {

                    materialTextBox3.AppendText(item.InnerText);
                }
                foreach (var item in doc2.DocumentNode.SelectNodes("//*[@id=\"scrollItems\"]/div/div[3]/div/div/div[2]/div/div[4]/div/div[4]/form/button"))
                {

                    materialTextBox4.AppendText(item.InnerText);
                }
                materialTextBox3.Text = materialTextBox3.Text.Replace(",", ".");
                materialTextBox4.Text = materialTextBox4.Text.Replace(" TL'den BİZE SAT ", String.Empty);
                materialTextBox4.Text = materialTextBox4.Text.Replace(",", ".");

                double doubleVal = Convert.ToDouble(materialTextBox3.Text)/1000;
                materialTextBox3.Clear();
                materialTextBox3.Text = string.Format("{0:0.00}", doubleVal);

                double doubleVal2 = Convert.ToDouble(materialTextBox4.Text)/10;
                materialTextBox4.Clear();
                materialTextBox4.Text = string.Format("{0:0.00}", doubleVal2);


                materialTextBox3.Text = materialTextBox3.Text.Replace(",", ".");                
                materialTextBox4.Text = materialTextBox4.Text.Replace(",", ".");



                HtmlAgilityPack.HtmlDocument doc3 = web.Load("https://www.enucuzgb.com");

                foreach (var item in doc3.DocumentNode.SelectNodes("//*[@id=\"table\"]/table/tbody/tr[4]/td[7]"))
                {

                    materialTextBox5.AppendText(item.InnerText);
                }
                foreach (var item in doc3.DocumentNode.SelectNodes("//*[@id=\"table\"]/table/tbody/tr[4]/td[8]"))
                {

                    materialTextBox6.AppendText(item.InnerText);
                }
                materialTextBox5.Text = materialTextBox5.Text.Replace(" ₺", String.Empty);
                materialTextBox6.Text = materialTextBox6.Text.Replace(" ₺", String.Empty);



                double doubleVal3 = Convert.ToDouble(materialTextBox5.Text) / 10;
                materialTextBox5.Clear();
                materialTextBox5.Text = string.Format("{0:0.00}", doubleVal3);

                double doubleVal4 = Convert.ToDouble(materialTextBox6.Text) / 10;
                materialTextBox6.Clear();
                materialTextBox6.Text = string.Format("{0:0.00}", doubleVal4);


                materialTextBox5.Text = materialTextBox5.Text.Replace(",", ".");
                materialTextBox6.Text = materialTextBox6.Text.Replace(",", ".");















            }
            if (materialComboBox1.Text == "DESTAN")
            {
                
                HtmlWeb web = new HtmlWeb();

                HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.kopazar.com/knight-online-gold-bar");

                foreach (var item in doc.DocumentNode.SelectNodes("//*[@id=\'FormGold9\']/div/div/div/div[4]/div/div[1]/strong"))
                {

                    materialTextBox1.AppendText(item.InnerText);
                }
                foreach (var item in doc.DocumentNode.SelectNodes("//*[@id=\'FormGold9\']/div/div/div/div[4]/div/div[3]/strong"))
                {

                    materialTextBox2.AppendText(item.InnerText);
                }
                materialTextBox1.Text = materialTextBox1.Text.Replace(" ₺", String.Empty);
                materialTextBox2.Text = materialTextBox2.Text.Replace(" ₺", String.Empty);



                HtmlAgilityPack.HtmlDocument doc2 = web.Load("https://www.bynogame.com/tr/oyunlar/knight-online/gold-bar");

                foreach (var item in doc2.DocumentNode.SelectNodes("//*[@id=\"scrollItems\"]/div/div[8]/div/div/div[2]/div/div[2]/div/div/div/p/span"))
                {

                    materialTextBox3.AppendText(item.InnerText);
                }
                foreach (var item in doc2.DocumentNode.SelectNodes("//*[@id=\"scrollItems\"]/div/div[8]/div/div/div[2]/div/div[4]/div/div[4]/form/button"))
                {

                    materialTextBox4.AppendText(item.InnerText);
                }
                materialTextBox3.Text = materialTextBox3.Text.Replace(",", ".");
                materialTextBox4.Text = materialTextBox4.Text.Replace(" TL'den BİZE SAT ", String.Empty);
                materialTextBox4.Text = materialTextBox4.Text.Replace(",", ".");

                double doubleVal = Convert.ToDouble(materialTextBox3.Text) / 1000;
                materialTextBox3.Clear();
                materialTextBox3.Text = string.Format("{0:0.00}", doubleVal);

                double doubleVal2 = Convert.ToDouble(materialTextBox4.Text) / 10;
                materialTextBox4.Clear();
                materialTextBox4.Text = string.Format("{0:0.00}", doubleVal2);


                materialTextBox3.Text = materialTextBox3.Text.Replace(",", ".");
                materialTextBox4.Text = materialTextBox4.Text.Replace(",", ".");






                HtmlAgilityPack.HtmlDocument doc3 = web.Load("https://www.enucuzgb.com");

                foreach (var item in doc3.DocumentNode.SelectNodes("//*[@id=\"table\"]/table/tbody/tr[4]/td[15]"))
                {

                    materialTextBox5.AppendText(item.InnerText);
                }
                foreach (var item in doc3.DocumentNode.SelectNodes("//*[@id=\"table\"]/table/tbody/tr[4]/td[16]"))
                {

                    materialTextBox6.AppendText(item.InnerText);
                }
                materialTextBox5.Text = materialTextBox5.Text.Replace(" ₺", String.Empty);
                materialTextBox6.Text = materialTextBox6.Text.Replace(" ₺", String.Empty);



                double doubleVal3 = Convert.ToDouble(materialTextBox5.Text) / 10;
                materialTextBox5.Clear();
                materialTextBox5.Text = string.Format("{0:0.00}", doubleVal3);

                double doubleVal4 = Convert.ToDouble(materialTextBox6.Text) / 10;
                materialTextBox6.Clear();
                materialTextBox6.Text = string.Format("{0:0.00}", doubleVal4);


                materialTextBox5.Text = materialTextBox5.Text.Replace(",", ".");
                materialTextBox6.Text = materialTextBox6.Text.Replace(",", ".");
















            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Goldbar();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panel2.Visible = false;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
