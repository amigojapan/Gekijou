namespace WindowsFormsApplication1
{
    partial class frmSprite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSprite));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtFrameDuration = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.picboxPreview = new System.Windows.Forms.PictureBox();
            this.txtColumbs = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtFPS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSpriteName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelSpriteInfo = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFrameCount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pctboxSpritesheetExplanation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPreview)).BeginInit();
            this.panelSpriteInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxSpritesheetExplanation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sprite sheet path";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 1;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(103, 223);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(502, 19);
            this.txtFilePath.TabIndex = 2;
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(611, 218);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(51, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sprite Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sprite Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Frame Duration";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(110, 0);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(34, 19);
            this.txtHeight.TabIndex = 8;
            this.txtHeight.Text = "80";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(110, 21);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(34, 19);
            this.txtWidth.TabIndex = 9;
            this.txtWidth.Text = "65";
            // 
            // txtFrameDuration
            // 
            this.txtFrameDuration.Location = new System.Drawing.Point(110, 69);
            this.txtFrameDuration.Name = "txtFrameDuration";
            this.txtFrameDuration.Size = new System.Drawing.Size(34, 19);
            this.txtFrameDuration.TabIndex = 11;
            this.txtFrameDuration.Text = "1";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(4, 140);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(217, 23);
            this.btnPreview.TabIndex = 12;
            this.btnPreview.Text = "Animate";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // picboxPreview
            // 
            this.picboxPreview.Location = new System.Drawing.Point(227, 0);
            this.picboxPreview.Name = "picboxPreview";
            this.picboxPreview.Size = new System.Drawing.Size(433, 206);
            this.picboxPreview.TabIndex = 13;
            this.picboxPreview.TabStop = false;
            // 
            // txtColumbs
            // 
            this.txtColumbs.Location = new System.Drawing.Point(212, 121);
            this.txtColumbs.Name = "txtColumbs";
            this.txtColumbs.Size = new System.Drawing.Size(38, 19);
            this.txtColumbs.TabIndex = 16;
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(140, -1);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(38, 19);
            this.txtRows.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtFPS
            // 
            this.txtFPS.Location = new System.Drawing.Point(110, 90);
            this.txtFPS.Name = "txtFPS";
            this.txtFPS.Size = new System.Drawing.Size(34, 19);
            this.txtFPS.TabIndex = 19;
            this.txtFPS.Text = "25";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "FPS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add This Sprite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSpriteName
            // 
            this.txtSpriteName.Location = new System.Drawing.Point(74, 115);
            this.txtSpriteName.Name = "txtSpriteName";
            this.txtSpriteName.Size = new System.Drawing.Size(147, 19);
            this.txtSpriteName.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "Sprite Name";
            // 
            // panelSpriteInfo
            // 
            this.panelSpriteInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSpriteInfo.Controls.Add(this.label11);
            this.panelSpriteInfo.Controls.Add(this.picboxPreview);
            this.panelSpriteInfo.Controls.Add(this.txtSpriteName);
            this.panelSpriteInfo.Controls.Add(this.label3);
            this.panelSpriteInfo.Controls.Add(this.button1);
            this.panelSpriteInfo.Controls.Add(this.btnPreview);
            this.panelSpriteInfo.Controls.Add(this.label10);
            this.panelSpriteInfo.Controls.Add(this.label4);
            this.panelSpriteInfo.Controls.Add(this.txtFPS);
            this.panelSpriteInfo.Controls.Add(this.label6);
            this.panelSpriteInfo.Controls.Add(this.label9);
            this.panelSpriteInfo.Controls.Add(this.txtHeight);
            this.panelSpriteInfo.Controls.Add(this.txtWidth);
            this.panelSpriteInfo.Controls.Add(this.txtFrameDuration);
            this.panelSpriteInfo.Location = new System.Drawing.Point(10, 260);
            this.panelSpriteInfo.Name = "panelSpriteInfo";
            this.panelSpriteInfo.Size = new System.Drawing.Size(667, 211);
            this.panelSpriteInfo.TabIndex = 23;
            this.panelSpriteInfo.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(150, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "Sprite Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "Spritesheet Columbus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "Spritesheet Rows";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtFrameCount);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.pctboxSpritesheetExplanation);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnBrowse);
            this.panel2.Controls.Add(this.txtRows);
            this.panel2.Controls.Add(this.txtFilePath);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtColumbs);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(10, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 248);
            this.panel2.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(521, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 12);
            this.label14.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "Frame Count";
            // 
            // txtFrameCount
            // 
            this.txtFrameCount.Location = new System.Drawing.Point(622, 190);
            this.txtFrameCount.Name = "txtFrameCount";
            this.txtFrameCount.Size = new System.Drawing.Size(34, 19);
            this.txtFrameCount.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(343, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "Sprite Sheet Info";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(285, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(331, 168);
            this.label13.TabIndex = 26;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // pctboxSpritesheetExplanation
            // 
            this.pctboxSpritesheetExplanation.Image = global::WindowsFormsApplication1.Properties.Resources.spritesheet_diagram;
            this.pctboxSpritesheetExplanation.Location = new System.Drawing.Point(9, 22);
            this.pctboxSpritesheetExplanation.Name = "pctboxSpritesheetExplanation";
            this.pctboxSpritesheetExplanation.Size = new System.Drawing.Size(172, 195);
            this.pctboxSpritesheetExplanation.TabIndex = 25;
            this.pctboxSpritesheetExplanation.TabStop = false;
            // 
            // frmSprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 257);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSpriteInfo);
            this.Controls.Add(this.label2);
            this.Name = "frmSprite";
            this.Text = "Sprite";
            ((System.ComponentModel.ISupportInitialize)(this.picboxPreview)).EndInit();
            this.panelSpriteInfo.ResumeLayout(false);
            this.panelSpriteInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxSpritesheetExplanation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtFrameDuration;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.PictureBox picboxPreview;
        private System.Windows.Forms.TextBox txtColumbs;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtFPS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSpriteName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelSpriteInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pctboxSpritesheetExplanation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFrameCount;
    }
}