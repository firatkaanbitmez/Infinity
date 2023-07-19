namespace Infinity.Forms
{
    partial class frmShutdowntimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.radioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.checkBox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.hours = new MaterialSkin.Controls.MaterialComboBox();
            this.minutes = new MaterialSkin.Controls.MaterialComboBox();
            this.seconds = new MaterialSkin.Controls.MaterialComboBox();
            this.btnStart = new MaterialSkin.Controls.MaterialButton();
            this.btnPause = new MaterialSkin.Controls.MaterialButton();
            this.btnStop = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Infinity.Properties.Resources.icons8_shutdown_48px;
            this.pictureBox1.Location = new System.Drawing.Point(300, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Infinity.Properties.Resources.icons8_restart_48px;
            this.pictureBox2.Location = new System.Drawing.Point(464, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Infinity.Properties.Resources.icons8_Logout_Rounded_48px;
            this.pictureBox3.Location = new System.Drawing.Point(606, 177);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(362, 233);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(276, 24);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Depth = 0;
            this.radioButton1.Location = new System.Drawing.Point(352, 186);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Ripple = true;
            this.radioButton1.Size = new System.Drawing.Size(109, 37);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ShutDown";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Depth = 0;
            this.radioButton2.Location = new System.Drawing.Point(516, 186);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Ripple = true;
            this.radioButton2.Size = new System.Drawing.Size(85, 37);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Restart";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Depth = 0;
            this.radioButton3.Location = new System.Drawing.Point(658, 186);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Ripple = true;
            this.radioButton3.Size = new System.Drawing.Size(87, 37);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "LogOut";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Depth = 0;
            this.checkBox1.Location = new System.Drawing.Point(335, 269);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.ReadOnly = false;
            this.checkBox1.Ripple = true;
            this.checkBox1.Size = new System.Drawing.Size(320, 37);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Send me a notification one minute away";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.label1.Location = new System.Drawing.Point(422, 116);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 58);
            this.label1.TabIndex = 19;
            this.label1.Text = "00:00:00";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(382, 53);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(44, 24);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "Hour";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(474, 53);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 24);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "Minute";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(562, 53);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(67, 24);
            this.materialLabel3.TabIndex = 23;
            this.materialLabel3.Text = "Second";
            // 
            // hours
            // 
            this.hours.AutoResize = false;
            this.hours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hours.Depth = 0;
            this.hours.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.hours.DropDownHeight = 118;
            this.hours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hours.DropDownWidth = 121;
            this.hours.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.hours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hours.FormattingEnabled = true;
            this.hours.IntegralHeight = false;
            this.hours.ItemHeight = 29;
            this.hours.Location = new System.Drawing.Point(362, 80);
            this.hours.MaxDropDownItems = 4;
            this.hours.MouseState = MaterialSkin.MouseState.OUT;
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(90, 35);
            this.hours.StartIndex = 0;
            this.hours.TabIndex = 24;
            this.hours.UseTallSize = false;
            // 
            // minutes
            // 
            this.minutes.AutoResize = false;
            this.minutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minutes.Depth = 0;
            this.minutes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.minutes.DropDownHeight = 118;
            this.minutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minutes.DropDownWidth = 121;
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.minutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.minutes.FormattingEnabled = true;
            this.minutes.IntegralHeight = false;
            this.minutes.ItemHeight = 29;
            this.minutes.Location = new System.Drawing.Point(458, 81);
            this.minutes.MaxDropDownItems = 4;
            this.minutes.MouseState = MaterialSkin.MouseState.OUT;
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(90, 35);
            this.minutes.StartIndex = 0;
            this.minutes.TabIndex = 25;
            this.minutes.UseTallSize = false;
            // 
            // seconds
            // 
            this.seconds.AutoResize = false;
            this.seconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.seconds.Depth = 0;
            this.seconds.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.seconds.DropDownHeight = 118;
            this.seconds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seconds.DropDownWidth = 121;
            this.seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.seconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seconds.FormattingEnabled = true;
            this.seconds.IntegralHeight = false;
            this.seconds.ItemHeight = 29;
            this.seconds.Location = new System.Drawing.Point(554, 80);
            this.seconds.MaxDropDownItems = 4;
            this.seconds.MouseState = MaterialSkin.MouseState.OUT;
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(90, 35);
            this.seconds.StartIndex = 0;
            this.seconds.TabIndex = 26;
            this.seconds.UseTallSize = false;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = false;
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStart.Depth = 0;
            this.btnStart.HighEmphasis = true;
            this.btnStart.Icon = null;
            this.btnStart.Location = new System.Drawing.Point(311, 324);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStart.Name = "btnStart";
            this.btnStart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStart.Size = new System.Drawing.Size(115, 36);
            this.btnStart.TabIndex = 27;
            this.btnStart.Text = "START";
            this.btnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStart.UseAccentColor = false;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.AutoSize = false;
            this.btnPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPause.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPause.Depth = 0;
            this.btnPause.HighEmphasis = true;
            this.btnPause.Icon = null;
            this.btnPause.Location = new System.Drawing.Point(434, 324);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPause.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPause.Name = "btnPause";
            this.btnPause.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPause.Size = new System.Drawing.Size(115, 36);
            this.btnPause.TabIndex = 28;
            this.btnPause.Text = "PAUSE";
            this.btnPause.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPause.UseAccentColor = false;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = false;
            this.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStop.Depth = 0;
            this.btnStop.HighEmphasis = true;
            this.btnStop.Icon = null;
            this.btnStop.Location = new System.Drawing.Point(554, 324);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStop.Name = "btnStop";
            this.btnStop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStop.Size = new System.Drawing.Size(115, 36);
            this.btnStop.TabIndex = 29;
            this.btnStop.Text = "STOP";
            this.btnStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStop.UseAccentColor = false;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frmShutdowntimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 562);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShutdowntimer";
            this.Text = "frmShutdowntimer";
            this.Load += new System.EventHandler(this.frmShutdowntimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MaterialSkin.Controls.MaterialRadioButton radioButton1;
        private MaterialSkin.Controls.MaterialRadioButton radioButton2;
        private MaterialSkin.Controls.MaterialRadioButton radioButton3;
        private MaterialSkin.Controls.MaterialCheckbox checkBox1;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox hours;
        private MaterialSkin.Controls.MaterialComboBox minutes;
        private MaterialSkin.Controls.MaterialComboBox seconds;
        private MaterialSkin.Controls.MaterialButton btnStart;
        private MaterialSkin.Controls.MaterialButton btnPause;
        private MaterialSkin.Controls.MaterialButton btnStop;
    }
}