//Copyright 2013 Usmar A Padow (amigojapan) usmpadow@gmail.com
//this program is distributed under the terms of the GNU General Public License

using System;
using System.Collections.Generic;
//using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
    [Serializable]
    public class AppSettings : ICloneable
    {
        public String pathToESpeak;
        public String pathToFfmpeg;
        public String pathToWorkDir;
        public String pathToMkvmerge;
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    [Serializable]
    public class SpriteState : ICloneable
    {
        public double fps;
        public int offsetx;
        public int offsety;
        public int row;
        public int col;
        public int frame_counter;
        public Bitmap sprite_sheet;
        public String filename;
        //public frmMain parent;
        public int sprite_height;
        public int sprite_width;
        public String name;
        public int FrameCount;
        public int Rows;
        public int Columbs;
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    [Serializable]
    public class Character : ICloneable
    { 
        public Bitmap sprite_sheet;
        public String parameters_to_espeak;
        public String name;
        public int x;
        public int y;
        public int width;
        public int height;
        public int frame_counter = -1;
        public int row = 0;
        public int offsetx = 0;
        public int col = 0;
        public int offsety = 0;
        public int FrameCount;
        public int Rows;
        public int Columbs;
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

namespace PictureFunctions
{
    public class helpers
    {
        public static Bitmap CropImage(Bitmap source, Rectangle section)
        {
            // An empty bitmap which will hold the cropped image
            Bitmap bmp = new Bitmap(section.Width, section.Height);

            Graphics g = Graphics.FromImage(bmp);

            // Draw the given area (section) of the source image
            // at location 0,0 on the empty bitmap (bmp)
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);

            return bmp;
        }
        
        public static void CompositeImageBackGroundAndSprite(Bitmap background, Bitmap sprite_sheet, int destination_on_bg_x, int destination_on_bg_y, int spritesheet_offsetx, int spritesheet_offsety, int sprite_width, int sprite_height){

            //var target = new Bitmap(background.Width, background.Height, PixelFormat.Format32bppArgb);//make target global or pass it in, but keep overwriting the old variable.
            //Globals.RenderingBuffer = new Bitmap(background.Width, background.Height, PixelFormat.Format32bppArgb);//make target global or pass it in, but keep overwriting the old variable.
            //I dont think that line is nessesary cause when the background is rendered it will be the same as clearin teh background
            var graphics = Graphics.FromImage(Globals.RenderingBuffer);
            graphics.CompositingMode = CompositingMode.SourceOver; // this is the default, but just to be clear
            graphics.Clear(Color.Transparent);//clears the buffer
            //render backgrownd
            graphics.DrawImage(background, 0, 0);//this is often complaining about lack of memory and crashing the program, not wure why, possibly in some loop where it is repetedly called? but why...yeah, I confirmed it happens when I add more than 3 birds to the scence, at the moment I am draggin the fourth one on...
            //get section of bitmap
            Rectangle section = new Rectangle(new Point(spritesheet_offsetx, spritesheet_offsety), new Size(sprite_width, sprite_height));
            Bitmap CroppedImage = PictureFunctions.helpers.CropImage(sprite_sheet, section);
            //draw sprite
            graphics.DrawImage(CroppedImage, destination_on_bg_x, destination_on_bg_y);
            //return target;//don't return, juse the global
        }
        
        /*
        public static Bitmap CompositeImageBackGroundAndSprite(Bitmap background, Bitmap sprite_sheet, int destination_on_bg_x, int destination_on_bg_y, int spritesheet_offsetx, int spritesheet_offsety, int sprite_width, int sprite_height)
        {

            var target = new Bitmap(background.Width, background.Height, PixelFormat.Format32bppArgb);//make target global or pass it in, but keep overwriting the old variable.
            //Globals.RenderingBuffer = new Bitmap(background.Width, background.Height, PixelFormat.Format32bppArgb);//make target global or pass it in, but keep overwriting the old variable.
            //I dont think that line is nessesary cause when the background is rendered it will be the same as clearin teh background
            var graphics = Graphics.FromImage(target);
            graphics.CompositingMode = CompositingMode.SourceOver; // this is the default, but just to be clear
            graphics.Clear(Color.Transparent);//clears the buffer
            //render backgrownd
            graphics.DrawImage(background, 0, 0);//this is often complaining about lack of memory and crashing the program, not wure why, possibly in some loop where it is repetedly called? but why...yeah, I confirmed it happens when I add more than 3 birds to the scence, at the moment I am draggin the fourth one on...
            //get section of bitmap
            Rectangle section = new Rectangle(new Point(spritesheet_offsetx, spritesheet_offsety), new Size(sprite_width, sprite_height));
            Bitmap CroppedImage = PictureFunctions.helpers.CropImage(sprite_sheet, section);
            //draw sprite
            graphics.DrawImage(CroppedImage, destination_on_bg_x, destination_on_bg_y);
            return target;
        }
        */
        public static void SetBMtoBM(Bitmap target, Bitmap source)//this is terrible because it is low quality, especially after many writes
        {

            //var target = new Bitmap(background.Width, background.Height, PixelFormat.Format32bppArgb);//make target global or pass it in, but keep overwriting the old variable.
            //Globals.RenderingBuffer = new Bitmap(background.Width, background.Height, PixelFormat.Format32bppArgb);//make target global or pass it in, but keep overwriting the old variable.
            //I dont think that line is nessesary cause when the background is rendered it will be the same as clearin teh background
            var graphics = Graphics.FromImage(target);
            graphics.CompositingMode = CompositingMode.SourceCopy; // this is the default, but just to be clear
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.Clear(Color.Transparent);//clears the buffer
            //render backgrownd
            graphics.DrawImage(source, 0, 0);//this is often complaining about lack of memory and crashing the program, not wure why, possibly in some loop where it is repetedly called? but why...yeah, I confirmed it happens when I add more than 3 birds to the scence, at the moment I am draggin the fourth one on...
        }

    }
    public static class Globals
    {
        public static Bitmap RenderingBuffer= new Bitmap(640, 360, PixelFormat.Format32bppArgb);
        public static Bitmap TmpBuffer = new Bitmap(640, 360, PixelFormat.Format32bppArgb);
        public static WindowsFormsApplication1.AppSettings AppSettings = new WindowsFormsApplication1.AppSettings();
    }
}
