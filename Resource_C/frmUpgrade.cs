using Squirrel;
using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace Infinity
{
    public partial class frmUpgrade : Form
    {
        public frmUpgrade()
        {
            InitializeComponent();
        }

        private void frmUpgrade_Load(object sender, EventArgs e)
        {
            AddVersionNumber();
            CheckForUpdates();
            label2.Text = versionNum;


        }

        public string versionNum;// Version numaramızı herhangi bir yere yansıtmak için public string
        private void AddVersionNumber()// Version numaramızı çekebileceğimiz bir fonksiyon
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            versionNum += $"v.{ versionInfo.FileVersion}";


        }// AddversionNumber ve CheckForUpdates fonksiyonlarını Formun Load kısmında başlatmayı unutma
        public string releaseversion;
        private async void CheckForUpdates()//Verilen github linki üzerinden Updateleri kontrol edecek fonksiyon
        {
            try
            {
                using (var mgr = await UpdateManager.GitHubUpdateManager("https://github.com/firatkaanbitmez/Infinity"))
                {
                    var release = await mgr.UpdateApp();

                }
                

            }
            catch (Exception e)
            {
                Debug.WriteLine("Failed check for updates" + e.ToString());
            }
        }


    }
}
