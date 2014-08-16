using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public ComboBox cmbCharacter_pub
        {
            get
            {
                return this.cmbCharacter;
            }

            set
            {
                this.cmbCharacter = value;
            }
        }
        public ComboBox cmbSprite_pub
        {
            get
            {
                return this.cmbSprite;
            }

            set
            {
                this.cmbSprite = value;
            }
        }
        public TextBox txtLine_pub
        {
            get
            {
                return this.txtLine;
            }

            set
            {
                this.txtLine = value;
            }
        }

    }
}
