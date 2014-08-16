namespace WindowsFormsApplication1
{
    partial class frmAppSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppSettings));
            this.btnESpeakBrowse = new System.Windows.Forms.Button();
            this.txteSpeakPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFfmpegBrowse = new System.Windows.Forms.Button();
            this.txtffmpegPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWorkDirBrowse = new System.Windows.Forms.Button();
            this.txtWorkingDir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMkvmergeBrowse = new System.Windows.Forms.Button();
            this.txtPathToMkvmerge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnESpeakBrowse
            // 
            this.btnESpeakBrowse.Location = new System.Drawing.Point(521, 106);
            this.btnESpeakBrowse.Name = "btnESpeakBrowse";
            this.btnESpeakBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnESpeakBrowse.TabIndex = 6;
            this.btnESpeakBrowse.Text = "browse";
            this.btnESpeakBrowse.UseVisualStyleBackColor = true;
            this.btnESpeakBrowse.Click += new System.EventHandler(this.btnESpeakBrowse_Click);
            // 
            // txteSpeakPath
            // 
            this.txteSpeakPath.Location = new System.Drawing.Point(13, 106);
            this.txteSpeakPath.Name = "txteSpeakPath";
            this.txteSpeakPath.Size = new System.Drawing.Size(502, 19);
            this.txteSpeakPath.TabIndex = 5;
            this.txteSpeakPath.Text = "C:\\Users\\anonymous\\Documents\\Visual Studio 2010\\Projects\\Gekijou\\Gekijou\\bin\\Debu" +
                "g\\even.png";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path to eSpeak binary(setup provided in Binaries dir for win and mac, in Linux us" +
                "e package manager)";
            // 
            // btnFfmpegBrowse
            // 
            this.btnFfmpegBrowse.Location = new System.Drawing.Point(521, 154);
            this.btnFfmpegBrowse.Name = "btnFfmpegBrowse";
            this.btnFfmpegBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnFfmpegBrowse.TabIndex = 9;
            this.btnFfmpegBrowse.Text = "browse";
            this.btnFfmpegBrowse.UseVisualStyleBackColor = true;
            this.btnFfmpegBrowse.Click += new System.EventHandler(this.btnFfmpegBrowse_Click);
            // 
            // txtffmpegPath
            // 
            this.txtffmpegPath.Location = new System.Drawing.Point(13, 154);
            this.txtffmpegPath.Name = "txtffmpegPath";
            this.txtffmpegPath.Size = new System.Drawing.Size(502, 19);
            this.txtffmpegPath.TabIndex = 8;
            this.txtffmpegPath.Text = "C:\\Users\\anonymous\\Documents\\Visual Studio 2010\\Projects\\Gekijou\\Gekijou\\bin\\Debu" +
                "g\\even.png";
            this.txtffmpegPath.TextChanged += new System.EventHandler(this.txtffmpegPath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Path to ffmpeg binary (Must be a newer version of ffmpeg)(Binary provided in Bina" +
                "ries subdirectory)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(14, 332);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(583, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Important:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(14, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 84);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(99, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 52);
            this.label4.TabIndex = 13;
            this.label4.Text = "You must install eSpeak and ffmpeg\r\nand set the proper paths to their binary file" +
                "s (executable files)\r\nand a working directory\r\nbefore it is possible to use Geki" +
                "jou";
            // 
            // btnWorkDirBrowse
            // 
            this.btnWorkDirBrowse.Location = new System.Drawing.Point(522, 303);
            this.btnWorkDirBrowse.Name = "btnWorkDirBrowse";
            this.btnWorkDirBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnWorkDirBrowse.TabIndex = 15;
            this.btnWorkDirBrowse.Text = "browse";
            this.btnWorkDirBrowse.UseVisualStyleBackColor = true;
            this.btnWorkDirBrowse.Click += new System.EventHandler(this.btnWorkDirBrowse_Click);
            // 
            // txtWorkingDir
            // 
            this.txtWorkingDir.Location = new System.Drawing.Point(14, 307);
            this.txtWorkingDir.Name = "txtWorkingDir";
            this.txtWorkingDir.Size = new System.Drawing.Size(502, 19);
            this.txtWorkingDir.TabIndex = 14;
            this.txtWorkingDir.Text = "C:\\Users\\anonymous\\Documents\\Visual Studio 2010\\Projects\\Gekijou\\Gekijou\\bin\\Debu" +
                "g\\even.png";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(589, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // btnMkvmergeBrowse
            // 
            this.btnMkvmergeBrowse.Location = new System.Drawing.Point(522, 213);
            this.btnMkvmergeBrowse.Name = "btnMkvmergeBrowse";
            this.btnMkvmergeBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnMkvmergeBrowse.TabIndex = 18;
            this.btnMkvmergeBrowse.Text = "browse";
            this.btnMkvmergeBrowse.UseVisualStyleBackColor = true;
            this.btnMkvmergeBrowse.Click += new System.EventHandler(this.mkvbrowser_click);
            // 
            // txtPathToMkvmerge
            // 
            this.txtPathToMkvmerge.Location = new System.Drawing.Point(14, 213);
            this.txtPathToMkvmerge.Name = "txtPathToMkvmerge";
            this.txtPathToMkvmerge.Size = new System.Drawing.Size(502, 19);
            this.txtPathToMkvmerge.TabIndex = 17;
            this.txtPathToMkvmerge.Text = "C:\\Users\\anonymous\\Documents\\Visual Studio 2010\\Projects\\Gekijou\\Gekijou\\bin\\Debu" +
                "g\\even.png";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(416, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Path to mkvmerge binary (Binary provided in Binaries subdirectory for windows)\r\no" +
                "n linux install the mkvtoolnix toolkit, and put the path to mkvmerge here";
            // 
            // frmAppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 372);
            this.Controls.Add(this.btnMkvmergeBrowse);
            this.Controls.Add(this.txtPathToMkvmerge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnWorkDirBrowse);
            this.Controls.Add(this.txtWorkingDir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnFfmpegBrowse);
            this.Controls.Add(this.txtffmpegPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnESpeakBrowse);
            this.Controls.Add(this.txteSpeakPath);
            this.Controls.Add(this.label1);
            this.Name = "frmAppSettings";
            this.Text = "App Settings";
            this.Load += new System.EventHandler(this.frmAppSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnESpeakBrowse;
        private System.Windows.Forms.TextBox txteSpeakPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFfmpegBrowse;
        private System.Windows.Forms.TextBox txtffmpegPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWorkDirBrowse;
        private System.Windows.Forms.TextBox txtWorkingDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMkvmergeBrowse;
        private System.Windows.Forms.TextBox txtPathToMkvmerge;
        private System.Windows.Forms.Label label6;

    }
}