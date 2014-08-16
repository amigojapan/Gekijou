using System.Collections.Generic;
namespace WindowsFormsApplication1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.render_scene = new System.Windows.Forms.Button();
            this.lstviewSprites = new System.Windows.Forms.ListView();
            this.btnAddSprite = new System.Windows.Forms.Button();
            this.picboxPreview = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.picboxTest = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtInputFPS = new System.Windows.Forms.TextBox();
            this.txtOutputFPS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOuputFilePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openSpriteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScreenplayFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSpriteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveScreenplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cooperateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendYourSpriteListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.becomeADeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGekijouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGekijouToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPreview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTest)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // render_scene
            // 
            this.render_scene.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.render_scene.Location = new System.Drawing.Point(3, 29);
            this.render_scene.Name = "render_scene";
            this.render_scene.Size = new System.Drawing.Size(145, 28);
            this.render_scene.TabIndex = 2;
            this.render_scene.Text = "render scene";
            this.render_scene.UseVisualStyleBackColor = true;
            this.render_scene.Click += new System.EventHandler(this.render_scene_Click_1);
            // 
            // lstviewSprites
            // 
            this.lstviewSprites.Location = new System.Drawing.Point(3, 85);
            this.lstviewSprites.Name = "lstviewSprites";
            this.lstviewSprites.Size = new System.Drawing.Size(75, 338);
            this.lstviewSprites.TabIndex = 4;
            this.lstviewSprites.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddSprite
            // 
            this.btnAddSprite.Location = new System.Drawing.Point(3, 63);
            this.btnAddSprite.Name = "btnAddSprite";
            this.btnAddSprite.Size = new System.Drawing.Size(75, 23);
            this.btnAddSprite.TabIndex = 5;
            this.btnAddSprite.Text = "Add Sprite";
            this.btnAddSprite.UseVisualStyleBackColor = true;
            this.btnAddSprite.Click += new System.EventHandler(this.btnAddSprite_Click);
            // 
            // picboxPreview
            // 
            this.picboxPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.picboxPreview.Image = ((System.Drawing.Image)(resources.GetObject("picboxPreview.Image")));
            this.picboxPreview.Location = new System.Drawing.Point(84, 63);
            this.picboxPreview.Name = "picboxPreview";
            this.picboxPreview.Size = new System.Drawing.Size(640, 360);
            this.picboxPreview.TabIndex = 10;
            this.picboxPreview.TabStop = false;
            this.picboxPreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picboxPreview_MouseUp);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 166);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(69, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sprite";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(142, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Line";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character";
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(633, 425);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(91, 23);
            this.btnAddLine.TabIndex = 5;
            this.btnAddLine.Text = "Add Line";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // picboxTest
            // 
            this.picboxTest.BackColor = System.Drawing.Color.Yellow;
            this.picboxTest.Location = new System.Drawing.Point(546, 11);
            this.picboxTest.Name = "picboxTest";
            this.picboxTest.Size = new System.Drawing.Size(100, 50);
            this.picboxTest.TabIndex = 13;
            this.picboxTest.TabStop = false;
            this.picboxTest.Visible = false;
            this.picboxTest.Click += new System.EventHandler(this.picboxTest_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rendering FPS";
            // 
            // txtInputFPS
            // 
            this.txtInputFPS.Location = new System.Drawing.Point(241, 33);
            this.txtInputFPS.Name = "txtInputFPS";
            this.txtInputFPS.Size = new System.Drawing.Size(27, 19);
            this.txtInputFPS.TabIndex = 15;
            this.txtInputFPS.Text = "3";
            // 
            // txtOutputFPS
            // 
            this.txtOutputFPS.Location = new System.Drawing.Point(371, 33);
            this.txtOutputFPS.Name = "txtOutputFPS";
            this.txtOutputFPS.Size = new System.Drawing.Size(27, 19);
            this.txtOutputFPS.TabIndex = 17;
            this.txtOutputFPS.Text = "24";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "Output FPS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtOuputFilePath
            // 
            this.txtOuputFilePath.Location = new System.Drawing.Point(307, 6);
            this.txtOuputFilePath.Name = "txtOuputFilePath";
            this.txtOuputFilePath.Size = new System.Drawing.Size(339, 19);
            this.txtOuputFilePath.TabIndex = 19;
            this.txtOuputFilePath.Text = "video.mkv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "Video File:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Change Background";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.settingsToolStripMenuItem,
            this.cooperateToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 26);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSpriteFileToolStripMenuItem,
            this.openScreenplayFileToolStripMenuItem,
            this.saveSpriteFileToolStripMenuItem,
            this.saveScreenplayToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(40, 22);
            this.mnuFile.Text = "File";
            // 
            // openSpriteFileToolStripMenuItem
            // 
            this.openSpriteFileToolStripMenuItem.Name = "openSpriteFileToolStripMenuItem";
            this.openSpriteFileToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.openSpriteFileToolStripMenuItem.Text = "Open Sprite List File";
            this.openSpriteFileToolStripMenuItem.Click += new System.EventHandler(this.openSpriteFileToolStripMenuItem_Click);
            // 
            // openScreenplayFileToolStripMenuItem
            // 
            this.openScreenplayFileToolStripMenuItem.Name = "openScreenplayFileToolStripMenuItem";
            this.openScreenplayFileToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.openScreenplayFileToolStripMenuItem.Text = "Open Screenplay File";
            // 
            // saveSpriteFileToolStripMenuItem
            // 
            this.saveSpriteFileToolStripMenuItem.Name = "saveSpriteFileToolStripMenuItem";
            this.saveSpriteFileToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.saveSpriteFileToolStripMenuItem.Text = "Save Sprite List File";
            this.saveSpriteFileToolStripMenuItem.Click += new System.EventHandler(this.saveSpriteFileToolStripMenuItem_Click);
            // 
            // saveScreenplayToolStripMenuItem
            // 
            this.saveScreenplayToolStripMenuItem.Name = "saveScreenplayToolStripMenuItem";
            this.saveScreenplayToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.saveScreenplayToolStripMenuItem.Text = "Save Screenplay";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // appSettingsToolStripMenuItem
            // 
            this.appSettingsToolStripMenuItem.Name = "appSettingsToolStripMenuItem";
            this.appSettingsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.appSettingsToolStripMenuItem.Text = "App Settings";
            this.appSettingsToolStripMenuItem.Click += new System.EventHandler(this.appSettingsToolStripMenuItem_Click);
            // 
            // cooperateToolStripMenuItem
            // 
            this.cooperateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendYourSpriteListToolStripMenuItem,
            this.bugReportToolStripMenuItem,
            this.becomeADeveloperToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.cooperateToolStripMenuItem.Name = "cooperateToolStripMenuItem";
            this.cooperateToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.cooperateToolStripMenuItem.Text = "Cooperate";
            // 
            // sendYourSpriteListToolStripMenuItem
            // 
            this.sendYourSpriteListToolStripMenuItem.Name = "sendYourSpriteListToolStripMenuItem";
            this.sendYourSpriteListToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.sendYourSpriteListToolStripMenuItem.Text = "Send your Sprite List";
            // 
            // bugReportToolStripMenuItem
            // 
            this.bugReportToolStripMenuItem.Name = "bugReportToolStripMenuItem";
            this.bugReportToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.bugReportToolStripMenuItem.Text = "Bug Report";
            // 
            // becomeADeveloperToolStripMenuItem
            // 
            this.becomeADeveloperToolStripMenuItem.Name = "becomeADeveloperToolStripMenuItem";
            this.becomeADeveloperToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.becomeADeveloperToolStripMenuItem.Text = "Join the project (devs)";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutGekijouToolStripMenuItem,
            this.webPageToolStripMenuItem,
            this.aboutGekijouToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutGekijouToolStripMenuItem
            // 
            this.aboutGekijouToolStripMenuItem.Name = "aboutGekijouToolStripMenuItem";
            this.aboutGekijouToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutGekijouToolStripMenuItem.Text = "Google Group";
            // 
            // webPageToolStripMenuItem
            // 
            this.webPageToolStripMenuItem.Name = "webPageToolStripMenuItem";
            this.webPageToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.webPageToolStripMenuItem.Text = "Web Page";
            // 
            // aboutGekijouToolStripMenuItem1
            // 
            this.aboutGekijouToolStripMenuItem1.Name = "aboutGekijouToolStripMenuItem1";
            this.aboutGekijouToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.aboutGekijouToolStripMenuItem1.Text = "About Gekijou";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(730, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 588);
            this.label7.TabIndex = 23;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(730, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "See 3dpl homepage";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(730, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "See Mobile RAD IDE homepage";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(730, 593);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "email usmpadow@gmail.com";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 33);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(145, 24);
            this.progressBar1.TabIndex = 27;
            this.progressBar1.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 611);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOuputFilePath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOutputFPS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInputFPS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picboxTest);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picboxPreview);
            this.Controls.Add(this.btnAddSprite);
            this.Controls.Add(this.lstviewSprites);
            this.Controls.Add(this.render_scene);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Gekijou Copyright 2014 --  Usmar A. Padow (amigojapan) looking for telecommuting " +
                "job! hook me up please! usmpadow@gmail.com";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Enter += new System.EventHandler(this.frmMain_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxTest)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button render_scene;
        private System.Windows.Forms.ListView lstviewSprites;
        private System.Windows.Forms.Button btnAddSprite;
        private System.Windows.Forms.PictureBox picboxPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.PictureBox picboxTest;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInputFPS;
        private System.Windows.Forms.TextBox txtOutputFPS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOuputFilePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem openSpriteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openScreenplayFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSpriteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveScreenplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appSettingsToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem cooperateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendYourSpriteListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem becomeADeveloperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutGekijouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutGekijouToolStripMenuItem1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}



