namespace WindowsFormsApplication1
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.cmbSprite = new System.Windows.Forms.ComboBox();
            this.cmbCharacter = new System.Windows.Forms.ComboBox();
            this.panelLine1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLine1
            // 
            this.panelLine1.Controls.Add(this.txtLine);
            this.panelLine1.Controls.Add(this.cmbSprite);
            this.panelLine1.Controls.Add(this.cmbCharacter);
            this.panelLine1.Location = new System.Drawing.Point(0, 0);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(587, 23);
            this.panelLine1.TabIndex = 5;
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(136, 3);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(445, 19);
            this.txtLine.TabIndex = 5;
            //this.txtLine.TextChanged += new System.EventHandler(this.txtLine_TextChanged);
            // 
            // cmbSprite
            // 
            this.cmbSprite.FormattingEnabled = true;
            this.cmbSprite.Location = new System.Drawing.Point(66, 3);
            this.cmbSprite.Name = "cmbSprite";
            this.cmbSprite.Size = new System.Drawing.Size(67, 20);
            this.cmbSprite.TabIndex = 4;
            // 
            // cmbCharacter
            // 
            this.cmbCharacter.FormattingEnabled = true;
            this.cmbCharacter.Location = new System.Drawing.Point(3, 3);
            this.cmbCharacter.Name = "cmbCharacter";
            this.cmbCharacter.Size = new System.Drawing.Size(67, 20);
            this.cmbCharacter.TabIndex = 3;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLine1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(587, 25);
            this.panelLine1.ResumeLayout(false);
            this.panelLine1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.ComboBox cmbSprite;
        private System.Windows.Forms.ComboBox cmbCharacter;
    }
}
