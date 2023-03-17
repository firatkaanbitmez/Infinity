namespace Infinity.Forms
{
    partial class frmWindowsUpdate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelectUpdate = new MaterialSkin.Controls.MaterialButton();
            this.btnAllUpdate = new MaterialSkin.Controls.MaterialButton();
            this.btnCheckForUpdates = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.btnSelectUpdate);
            this.panel1.Controls.Add(this.btnAllUpdate);
            this.panel1.Controls.Add(this.btnCheckForUpdates);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(391, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 450);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Infinity.Properties.Resources.icons8_refresh_50px_1;
            this.pictureBox1.Location = new System.Drawing.Point(170, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(39, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(566, 210);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 290;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 255;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Source";
            this.columnHeader3.Width = 99;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Available";
            this.columnHeader4.Width = 97;
            // 
            // btnSelectUpdate
            // 
            this.btnSelectUpdate.AutoSize = false;
            this.btnSelectUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelectUpdate.Depth = 0;
            this.btnSelectUpdate.HighEmphasis = true;
            this.btnSelectUpdate.Icon = null;
            this.btnSelectUpdate.Location = new System.Drawing.Point(437, 310);
            this.btnSelectUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectUpdate.Name = "btnSelectUpdate";
            this.btnSelectUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSelectUpdate.Size = new System.Drawing.Size(168, 47);
            this.btnSelectUpdate.TabIndex = 13;
            this.btnSelectUpdate.Text = "Select Update";
            this.btnSelectUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelectUpdate.UseAccentColor = false;
            this.btnSelectUpdate.UseVisualStyleBackColor = true;
            this.btnSelectUpdate.Click += new System.EventHandler(this.btnSelectUpdate_Click);
            // 
            // btnAllUpdate
            // 
            this.btnAllUpdate.AutoSize = false;
            this.btnAllUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAllUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAllUpdate.Depth = 0;
            this.btnAllUpdate.HighEmphasis = true;
            this.btnAllUpdate.Icon = null;
            this.btnAllUpdate.Location = new System.Drawing.Point(247, 310);
            this.btnAllUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAllUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAllUpdate.Name = "btnAllUpdate";
            this.btnAllUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAllUpdate.Size = new System.Drawing.Size(168, 47);
            this.btnAllUpdate.TabIndex = 12;
            this.btnAllUpdate.Text = "All Update";
            this.btnAllUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAllUpdate.UseAccentColor = false;
            this.btnAllUpdate.UseVisualStyleBackColor = true;
            this.btnAllUpdate.Click += new System.EventHandler(this.btnAllUpdate_Click);
            // 
            // btnCheckForUpdates
            // 
            this.btnCheckForUpdates.AutoSize = false;
            this.btnCheckForUpdates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckForUpdates.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCheckForUpdates.Depth = 0;
            this.btnCheckForUpdates.HighEmphasis = true;
            this.btnCheckForUpdates.Icon = null;
            this.btnCheckForUpdates.Location = new System.Drawing.Point(225, 15);
            this.btnCheckForUpdates.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCheckForUpdates.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheckForUpdates.Name = "btnCheckForUpdates";
            this.btnCheckForUpdates.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCheckForUpdates.Size = new System.Drawing.Size(229, 40);
            this.btnCheckForUpdates.TabIndex = 11;
            this.btnCheckForUpdates.Text = "Check for Updates";
            this.btnCheckForUpdates.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCheckForUpdates.UseAccentColor = false;
            this.btnCheckForUpdates.UseVisualStyleBackColor = true;
            this.btnCheckForUpdates.Click += new System.EventHandler(this.btnCheckForUpdates_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "\"";
            this.label2.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(225, 484);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 173);
            this.listBox1.TabIndex = 3;
            this.listBox1.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(184, 481);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(144, 64);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // frmWindowsUpdate
            // 
            this.AcceptButton = this.btnCheckForUpdates;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWindowsUpdate";
            this.Text = "frmWindowsUpdate";
            this.Load += new System.EventHandler(this.frmWindowsUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton btnCheckForUpdates;
        private MaterialSkin.Controls.MaterialButton btnSelectUpdate;
        private MaterialSkin.Controls.MaterialButton btnAllUpdate;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}