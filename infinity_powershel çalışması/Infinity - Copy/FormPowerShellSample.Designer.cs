namespace Infinity
{
    partial class FormPowerShellSample
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
            this.comboBoxSampleScripts = new System.Windows.Forms.ComboBox();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.buttonStartScript = new System.Windows.Forms.Button();
            this.buttonStopScript = new System.Windows.Forms.Button();
            this.textBoxScript = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBoxSampleScripts
            // 
            this.comboBoxSampleScripts.FormattingEnabled = true;
            this.comboBoxSampleScripts.Location = new System.Drawing.Point(107, 58);
            this.comboBoxSampleScripts.Name = "comboBoxSampleScripts";
            this.comboBoxSampleScripts.Size = new System.Drawing.Size(528, 21);
            this.comboBoxSampleScripts.TabIndex = 0;
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(116, 146);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(565, 134);
            this.listBoxOutput.TabIndex = 1;
            // 
            // buttonStartScript
            // 
            this.buttonStartScript.Location = new System.Drawing.Point(367, 328);
            this.buttonStartScript.Name = "buttonStartScript";
            this.buttonStartScript.Size = new System.Drawing.Size(75, 23);
            this.buttonStartScript.TabIndex = 3;
            this.buttonStartScript.Text = "button1";
            this.buttonStartScript.UseVisualStyleBackColor = true;
            this.buttonStartScript.Click += new System.EventHandler(this.buttonStartScript_Click);
            // 
            // buttonStopScript
            // 
            this.buttonStopScript.Location = new System.Drawing.Point(571, 328);
            this.buttonStopScript.Name = "buttonStopScript";
            this.buttonStopScript.Size = new System.Drawing.Size(75, 23);
            this.buttonStopScript.TabIndex = 4;
            this.buttonStopScript.Text = "Stop";
            this.buttonStopScript.UseVisualStyleBackColor = true;
            this.buttonStopScript.Click += new System.EventHandler(this.buttonStopScript_Click);
            // 
            // textBoxScript
            // 
            this.textBoxScript.Location = new System.Drawing.Point(199, 310);
            this.textBoxScript.Name = "textBoxScript";
            this.textBoxScript.Size = new System.Drawing.Size(100, 96);
            this.textBoxScript.TabIndex = 5;
            this.textBoxScript.Text = "";
            // 
            // FormPowerShellSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxScript);
            this.Controls.Add(this.buttonStopScript);
            this.Controls.Add(this.buttonStartScript);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.comboBoxSampleScripts);
            this.Name = "FormPowerShellSample";
            this.Text = "FormPowerShellSample";
            this.Load += new System.EventHandler(this.FormPowerShellSample_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSampleScripts;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button buttonStartScript;
        private System.Windows.Forms.Button buttonStopScript;
        private System.Windows.Forms.RichTextBox textBoxScript;
    }
}