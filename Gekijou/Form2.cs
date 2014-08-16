//Copyright 2013 Usmar A Padow (amigojapan) usmpadow@gmail.com
//this program is distributed under the terms of the GNU General Public License


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using WindowsFormsApplication1;


namespace WindowsFormsApplication1
{
    public partial class frmSprite : Form
    {
        public frmSprite(frmMain parent)
        {
            InitializeComponent();
            StateVars.parent = parent;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (txtColumbs.Text == "" || txtRows.Text == "" || txtFrameCount.Text == "") {
                MessageBox.Show("You must fill in the Sprite Sheet Columbs,\n Sprite Sheet Rows And Frame Count \nbefore you can browse for the image");
                return;
            }
            //resize form to fit in the other information
            frmSprite.ActiveForm.Width = 698;
            frmSprite.ActiveForm.Height = 513;
            panelSpriteInfo.Visible = true;
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "PNG files (.png)|*.png|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file to read.
                txtFilePath.Text = openFileDialog1.FileName;
            }
            else
            {
                return;
            }
            this.calculate_hight_and_width();
            StateVars.sprite_sheet = new Bitmap(txtFilePath.Text);

            Bitmap source1; // your source images - assuming they're the same size
            source1 = new Bitmap(picboxPreview.Width, picboxPreview.Height);


            var target = new Bitmap(Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text), PixelFormat.Format32bppArgb);
            var graphics = Graphics.FromImage(target);
            graphics.CompositingMode = CompositingMode.SourceOver; // this is the default, but just to be clear

            graphics.DrawImage(source1, 0, 0);

            //get section of bitmap
            //Rectangle section = new Rectangle(new Point(offsetx, offsety), new Size(Convert.ToInt32(txtHeight.Text), Convert.ToInt32(txtWidth.Text)));
            Rectangle section = new Rectangle(new Point(0, 0), new Size(Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text)));
            //Rectangle section = new Rectangle(new Point(0, 0), new Size(80, 80));
            Bitmap CroppedImage = PictureFunctions.helpers.CropImage(StateVars.sprite_sheet, section);

            graphics.DrawImage(CroppedImage, 0, 0);
            picboxPreview.Image = target;
        }


        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                //init values
                StateVars.frame_counter = -1;//init to -1 because it starts calculating the frame from the next frame
                StateVars.row = 0;
                StateVars.offsetx = 0;
                StateVars.col = 0;
                StateVars.offsety = 0;
                // Start the animation loop
                timer1.Enabled = !timer1.Enabled;
                btnPreview.Text = timer1.Enabled ? "Stop" : "Animate";

                StateVars.fps = Convert.ToDouble(txtFPS.Text);
                timer1.Interval = Convert.ToInt32(1000 / StateVars.fps);
                StateVars.offsetx = 0;
                StateVars.offsety = 0;
                StateVars.row = 0;
                StateVars.col = 0;
                StateVars.sprite_sheet = new Bitmap(txtFilePath.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err);
            }
        }
        public void calculate_hight_and_width()
        {
            //then just divide the width with how many sprites are there in a column and
            //divide the height with how many sprites are there in a row.
            Bitmap tmp;
            tmp = new Bitmap(txtFilePath.Text);
            txtWidth.Text = Convert.ToString(tmp.Width / Convert.ToInt32(txtRows.Text));
            txtHeight.Text = Convert.ToString(tmp.Height / Convert.ToInt32(txtColumbs.Text));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap background; // your source images - assuming they're the same size
            background = new Bitmap(picboxPreview.Width, picboxPreview.Height);

            
            PictureFunctions.helpers.CompositeImageBackGroundAndSprite(background, StateVars.sprite_sheet, 0, 0, StateVars.offsetx, StateVars.offsety, Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text));
            picboxPreview.Image = PictureFunctions.Globals.RenderingBuffer;
            // picboxPreview.Image = CroppedImage;
            //calculate next offset
            if (StateVars.frame_counter != Convert.ToInt32(txtFrameCount.Text)-2){//take away 2 because it is for the next frame, and we dont have a next frame for the last sprite
                StateVars.frame_counter++;
            }
            else {
                StateVars.frame_counter = -1;
                StateVars.row = 0;
                StateVars.offsetx = 0;
                StateVars.col = 0;
                StateVars.offsety = 0;
                return;
            }
            if (StateVars.row >= Convert.ToInt32(txtRows.Text) - 1) {
                StateVars.row = 0;
                StateVars.col++;
                StateVars.offsety = StateVars.offsety + Convert.ToInt32(txtHeight.Text);
                StateVars.offsetx = 0;
            } else            {
                StateVars.offsetx = StateVars.offsetx + Convert.ToInt32(txtWidth.Text);
                StateVars.row++;
            }
            if (StateVars.col >= Convert.ToInt32(txtColumbs.Text))            {
                StateVars.col = 0;
                StateVars.offsety = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSpriteName.Text == "")
            {
                MessageBox.Show("You must fill in the Sprite Name\nbefore you can add the sprite.");
                return;
            }

            if (StateVars.sprite_sheet == null) return;//prevent from adding a sprite before a file is opened(will crash teh program)
            Rectangle section = new Rectangle(new Point(0, 0), new Size(Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text)));
            Bitmap CroppedImage = PictureFunctions.helpers.CropImage(StateVars.sprite_sheet, section);
            SpriteState spritestate = new SpriteState();
            spritestate.fps = StateVars.fps;
            spritestate.frame_counter = StateVars.frame_counter;
            spritestate.filename = txtFilePath.Text;
            spritestate.sprite_sheet = StateVars.sprite_sheet;
            spritestate.sprite_height = Convert.ToInt32(txtHeight.Text);
            spritestate.sprite_width = Convert.ToInt32(txtWidth.Text);
            spritestate.name = txtSpriteName.Text;
            spritestate.FrameCount = Convert.ToInt32(txtFrameCount.Text);
            spritestate.Rows = Convert.ToInt32(txtRows.Text);
            spritestate.Columbs = Convert.ToInt32(txtColumbs.Text);
            StateVars.parent.aa(CroppedImage, spritestate);
            this.Close();
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


    public static class StateVars
    {
        public static double fps;
        public static int offsetx;
        public static int offsety;
        public static int row;
        public static int col;
        public static int frame_counter;
        public static Bitmap sprite_sheet;
        public static frmMain parent;
    }


}

//System.PlatformID.MacOSX== SystemInfo.Platform
//offer simple direction and speed for sprite window, later, offer path