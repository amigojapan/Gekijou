//Copyright 2013 Usmar A Padow (amigojapan) usmpadow@gmail.com
//this program is distributed under the terms of the GNU General Public License


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//for cloner and serialization
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace WindowsFormsApplication1
{
    public partial class frmAppSettings : Form
    {
        public frmAppSettings()
        {
            InitializeComponent();
            txteSpeakPath.Text = PictureFunctions.Globals.AppSettings.pathToESpeak;
            txtffmpegPath.Text = PictureFunctions.Globals.AppSettings.pathToFfmpeg;
            txtWorkingDir.Text = PictureFunctions.Globals.AppSettings.pathToWorkDir;
            txtPathToMkvmerge.Text = PictureFunctions.Globals.AppSettings.pathToMkvmerge;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }
        //private String Browse(String Filter)

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtffmpegPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PictureFunctions.Globals.AppSettings.pathToESpeak = txteSpeakPath.Text;
            PictureFunctions.Globals.AppSettings.pathToFfmpeg = txtffmpegPath.Text;
            PictureFunctions.Globals.AppSettings.pathToWorkDir = txtWorkingDir.Text;
            PictureFunctions.Globals.AppSettings.pathToMkvmerge = txtPathToMkvmerge.Text;
            //save settings
            try
            {
                using (Stream stream = File.Open("AppSettings.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, PictureFunctions.Globals.AppSettings);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error while trying to write file.");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnESpeakBrowse_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "All Files (*.*)|*.*";//Make exe files for windows in the future, this wil do for any OS
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;
            
            // Call the ShowDialog method to show the dialog box.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file to read.
                txteSpeakPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnFfmpegBrowse_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "All Files (*.*)|*.*";//Make exe files for windows in the future, this wil do for any OS
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;
            
            // Call the ShowDialog method to show the dialog box.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file to read.
                txtffmpegPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnWorkDirBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtWorkingDir.Text = fbd.SelectedPath;
            }
        }

        private void frmAppSettings_Load(object sender, EventArgs e)
        {

        }

        private void mkvbrowser_click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "All Files (*.*)|*.*";//Make exe files for windows in the future, this wil do for any OS
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;
            
            // Call the ShowDialog method to show the dialog box.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file to read.
                txtPathToMkvmerge.Text = openFileDialog1.FileName;
            }
        }
    }
}
