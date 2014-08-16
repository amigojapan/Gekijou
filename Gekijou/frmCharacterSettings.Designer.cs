namespace WindowsFormsApplication1
{
    partial class frmCharacterSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnTestVoice = new System.Windows.Forms.Button();
            this.txtTestText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbParams = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character Name";
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(107, 12);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(254, 19);
            this.txtCharacterName.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(15, 135);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(346, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnTestVoice
            // 
            this.btnTestVoice.Location = new System.Drawing.Point(283, 106);
            this.btnTestVoice.Name = "btnTestVoice";
            this.btnTestVoice.Size = new System.Drawing.Size(75, 23);
            this.btnTestVoice.TabIndex = 6;
            this.btnTestVoice.Text = "Test Voice";
            this.btnTestVoice.UseVisualStyleBackColor = true;
            this.btnTestVoice.Click += new System.EventHandler(this.btnTestVoice_Click);
            // 
            // txtTestText
            // 
            this.txtTestText.Location = new System.Drawing.Point(15, 106);
            this.txtTestText.Name = "txtTestText";
            this.txtTestText.Size = new System.Drawing.Size(258, 19);
            this.txtTestText.TabIndex = 5;
            this.txtTestText.Text = "Hello World!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Please read eSpeak documentation for commandline\r\nfor how to add other voices or " +
                "change language";
            // 
            // cmbParams
            // 
            this.cmbParams.FormattingEnabled = true;
            this.cmbParams.Items.AddRange(new object[] {
            "-v male1",
            "-v male2",
            "-v male3",
            "-v male4",
            "-v male6",
            "-v male7",
            "-v female1",
            "-v female2",
            "-v female3",
            "-v female4",
            "-v female5",
            "-v croak",
            "-v klatt",
            "-v klatt2",
            "-v klatt3",
            "-v klatt4",
            "-v whisper",
            "-v female_whisper"});
            this.cmbParams.Location = new System.Drawing.Point(15, 68);
            this.cmbParams.Name = "cmbParams";
            this.cmbParams.Size = new System.Drawing.Size(343, 20);
            this.cmbParams.TabIndex = 8;
            this.cmbParams.Text = "-v male1";
            // 
            // frmCharacterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 177);
            this.Controls.Add(this.cmbParams);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTestVoice);
            this.Controls.Add(this.txtTestText);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.label1);
            this.Name = "frmCharacterSettings";
            this.Text = "Character Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnTestVoice;
        private System.Windows.Forms.TextBox txtTestText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbParams;
    }
}