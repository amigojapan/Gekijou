//Copyright 2013 Usmar A Padow (amigojapan) usmpadow@gmail.com
//this program is distributed under the terms of the GNU General Public License


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class frmCharacterSettings : Form
    {
        public frmCharacterSettings(Character _character, List<UserControl1> _ScreenPlay)
        {
            InitializeComponent();
            Objects.character = _character;
            Objects.ScreenPlay = _ScreenPlay;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Objects.character.name = txtCharacterName.Text;
            Objects.character.parameters_to_espeak = cmbParams.Text;
            //update characters in screenplay
            //foreach (UserControl1 line in Objects.ScreenPlay) line.cmbCharacter_pub.Items.Clear();
            //***Need to add a way to remove a character form the combobox of the screenplay when it is removed
            foreach (UserControl1 line in Objects.ScreenPlay)
            {
                line.cmbCharacter_pub.Items.Add(txtCharacterName.Text);
            }

            this.Close();
        }
        public static class Objects
        {
            public static Character character;
            public static List<UserControl1> ScreenPlay;
        }

        private void btnTestVoice_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process
            {
                StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    
                    FileName = PictureFunctions.Globals.AppSettings.pathToESpeak,
                    Arguments = cmbParams.Text + " \"" + txtTestText.Text + "\"",
                    //Arguments = "-v female3 \"" + textBox1.Text + "\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                // just loop until the process ends
            }
            proc.Close();

        }
    }
}
