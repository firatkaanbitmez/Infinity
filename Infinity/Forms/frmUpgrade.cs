using Squirrel;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

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
            btnUpdate.Enabled = false;
            AddVersionNumber();

            CFU();
           
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
            
            using (var mgr = await UpdateManager.GitHubUpdateManager("https://github.com/firatkaanbitmez/Infinity"))
            {
                //this.logger.Info("Checking for updates");

                try
                {
                    var updateInfo = await mgr.CheckForUpdate();

                    if (updateInfo.ReleasesToApply.Any())
                    {
                        var versionCount = updateInfo.ReleasesToApply.Count;
                        //this.logger.Info($"{versionCount} update(s) found.");
                        var x5 = updateInfo.FutureReleaseEntry.Version.ToString();
                        var versionWord = versionCount > 1 ? "versions" : "version";
                        var message = new StringBuilder().AppendLine($"App is {versionCount} {versionWord} behind. Latest version v.{x5}").
                                                          AppendLine("If you choose to update, changes won't take ").
                                                          AppendLine("effect until App is restarted.").
                                                          AppendLine("Would you like to download and install them?").
                                                          ToString();

                        DialogResult result = MessageBox.Show(message, "App Update", MessageBoxButtons.YesNo);
                        if (result != DialogResult.Yes)
                        {
                                                    
                            //this.logger.Info("update declined by user.");
                            return;
                        }

                        //this.logger.Info("Downloading updates");
                        
                        var updateResult = await mgr.UpdateApp();
                        
                        UpdateManager.RestartApp();
                        

                        

                        
                        //this.logger.Info($"Download complete. Version {updateResult.Version} will take effect when App is restarted.");
                    }
                    else
                    {
                        //this.logger.Info("No updates detected.");
                    }
                }
                catch (Exception )
                {
                    //this.logger.Warn($"There was an issue during the update process! {ex.Message}");
                }
            }

           

        }

        public async void CFU()//Verilen github linki üzerinden Updateleri kontrol edecek fonksiyon
        {

            using (var mgr = await UpdateManager.GitHubUpdateManager("https://github.com/firatkaanbitmez/Infinity"))
            {
                //this.logger.Info("Checking for updates");

                try
                {
                    var updateInfo = await mgr.CheckForUpdate();

                    if (updateInfo.ReleasesToApply.Any())
                    {
                        var versionCount = updateInfo.ReleasesToApply.Count;
                        //this.logger.Info($"{versionCount} update(s) found.");
                       
                        var x5=updateInfo.FutureReleaseEntry.Version.ToString();
                       
                        label5.Text ="v."+ x5;
                        var versionWord = versionCount > 1 ? "versions" : "version";
                        
                        btnUpdate.Enabled = true;

                        this.Text = "Infinity (New Version Available Please Update your Infinity)";
                        frmMain frmss = new frmMain();
                        frmss.Text= "Infinity (New Version Available Please Update your Infinity)";

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
                        popup.Size = new Size(400, 160);
                        popup.TitleText = "Infinity";
                        popup.ContentText = "New version is now available. App is " + versionCount + " " + versionWord + " behind.Please check the help/update menu. ";
                        popup.Popup();
                    }
                }
                catch (Exception)
                {
                    //this.logger.Warn($"There was an issue during the update process! {ex.Message}");
                }
            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckForUpdates();
        }

       
    }
}
