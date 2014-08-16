//Copyright 2013 Usmar A Padow (amigojapan) usmpadow@gmail.com
//this program is distributed under the terms of the GNU General Public License


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System;
/*
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
*/
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

//for cloner and serialization
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

//regex
using System.Text.RegularExpressions;

//using NAudio.Wave;


namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public List<UserControl1> ScreenPlay = new List<UserControl1>();
        public frmMain()
        {
            InitializeComponent();
            if(File.Exists("AppSettings.bin")) {
                //Load settings
                try
                {
                    using (Stream stream = File.Open("AppSettings.bin", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();

                        PictureFunctions.Globals.AppSettings = (WindowsFormsApplication1.AppSettings)bin.Deserialize(stream);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Error while trying to read AppSetting.bin file.\nTry erasing the file and reloading Gekijou.");
                }
            } else {//This is the first time the app has been run probably. show AppSettings form, and force the user to configure his paths
                //Show form, the form will save the settings when OK is pressed.
                frmAppSettings objsptForm = new frmAppSettings();//this passes a refference of this form to the other form so that the aa() method can be addressed there
                objsptForm.Show();
            }
            //clear ruler
            //Bitmap bmp = new Bitmap(picboxTimeline.Width, picboxTimeline.Height);

            //Graphics g = Graphics.FromImage(bmp);

            // Draw the given area (section) of the source image
            // at location 0,0 on the empty bitmap (bmp)
            //g.Clear(Color.White);

            //picboxTimeline.Image = bmp;

            // Add event handlers for the required drag events.
            lstviewSprites.ItemDrag += new ItemDragEventHandler(lstviewSprites_ItemDrag);
            picboxPreview.AllowDrop = true;
            picboxPreview.DragEnter += new DragEventHandler(picboxPreview_DragEnter);
            picboxPreview.DragOver += new DragEventHandler(picboxPreview_DragOver);
            picboxPreview.DragDrop += new DragEventHandler(picboxPreview_DragDrop);

            Objects.bg = (Bitmap)picboxPreview.Image;
            //Objects.list = new List<SpriteState>();

            //List<String> l = new List<String>();
            //l.Add("test");


            //Graphics graphic = new Graphics .FromImage(picboxTimeline.Image);
            //graphic.Clear(Color.Red);//Color to fill the background and reset the box


            /*
            // Initialize a new instance of the SpeechSynthesizer.
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Output information about all of the installed voices. 
            foreach (InstalledVoice voice in synth.GetInstalledVoices())
            {
                VoiceInfo info = voice.VoiceInfo;


                ComboboxItem item = new ComboboxItem();
                item.Text = " Name:" + info.Name+" Gender:" + info.Gender+" Culture:" + info.Culture;
                item.Value = info.Id;

                cmbLanguage.Items.Add(item);

                cmbLanguage.SelectedIndex = 0;

                //Console.WriteLine(" Name:          " + info.Name);
                //Console.WriteLine(" Culture:       " + info.Culture);
                //Console.WriteLine(" Age:           " + info.Age);
                //Console.WriteLine(" Gender:        " + info.Gender);
                //Console.WriteLine(" Description:   " + info.Description);
                //Console.WriteLine(" ID:            " + info.Id);
            }
             */

        }
        public void LoadSpriteList(String FilePath)
        {
            try
            {
                using (Stream stream = File.Open(FilePath, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    Objects.list = (List<SpriteState>)bin.Deserialize(stream);
                    lstviewSprites.Items.Clear();//clear the list view
                    foreach (SpriteState sprt in Objects.list)
                    {
                        Bitmap img = new Bitmap(sprt.sprite_width, sprt.sprite_height);
                        img = PictureFunctions.helpers.CropImage(sprt.sprite_sheet, new Rectangle(new Point(0, 0), new Size(sprt.sprite_width, sprt.sprite_height)));
                        ListViewItem item1 = new ListViewItem(sprt.name, lstviewSprites.Items.Count);
                        // Initialize the ImageList objects with bitmaps.
                        Objects.imageListLarge.Images.Add(img);
                        lstviewSprites.Items.AddRange(new ListViewItem[] { item1 });
                        lstviewSprites.LargeImageList = Objects.imageListLarge;
                        lstviewSprites.SmallImageList = Objects.imageListLarge;
                        foreach (UserControl1 line in ScreenPlay)
                        {
                            line.cmbSprite_pub.Items.Add(sprt.name);
                        }
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error while trying to read file.");
            }
        }
        public void aa(Bitmap image, SpriteState SpriteObject)
        {
            ListViewItem item1 = new ListViewItem(SpriteObject.name, lstviewSprites.Items.Count);
            // Initialize the ImageList objects with bitmaps.
            Objects.imageListLarge.Images.Add(image);
            lstviewSprites.Items.AddRange(new ListViewItem[] { item1 });
            lstviewSprites.LargeImageList = Objects.imageListLarge;
            lstviewSprites.SmallImageList = Objects.imageListLarge;
            //binary serialization of a list http://www.dotnetperls.com/serialize-list 
            Objects.list.Add(SpriteObject);
            foreach (UserControl1 line in ScreenPlay)
            {
                line.cmbSprite_pub.Items.Add(SpriteObject.name);
            }
        }

        /*
        public event EventHandler<SpeakCompletedEventArgs> SpeakCompleted
        {
           //("len="+AudioFunctions.helpers.duration("test.wav"));
            textBox1.Text="done";
        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process proc = new System.Diagnostics.Process {
                StartInfo = new System.Diagnostics.ProcessStartInfo {
                    FileName = "D:\\eSpeak\\command_line\\espeak.exe",
                    Arguments = "-v female3 -w test.wav \""+txtInputFPS.Text+"\"",
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
            
            System.Diagnostics.Process proc2 = new System.Diagnostics.Process
            {
                StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = PictureFunctions.Globals.AppSettings.pathToFfmpeg,
                    Arguments = "-i test.wav",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };

            string strRegex = @"Duration: [0-9]*:[0-9]*:([0-9.]*),";
            proc2.Start();
            //string line=null;
            while (!proc2.StandardError.EndOfStream)
            {
                string line = proc2.StandardError.ReadLine();
                Regex myRegex = new Regex(strRegex, RegexOptions.None);
                string strTargetString = line;
                foreach (Match myMatch in myRegex.Matches(strTargetString))
                {
                    if (myMatch.Success)
                    {
                        txtInputFPS.Text = myMatch.Groups[1].Value;
                    }
                }
                line = proc2.StandardOutput.ReadLine();
            }
            proc2.Close();


 
            /*
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                //I could make a client-server app that fetches wav files from a windows server that waits for a string and parameters for the voice, this would be a solution so the program could also be used on Linux and mac on mono
                //also return the length of hte wav file, that way I dont need to figure it out in Linux

                // Configure the audio output. 
                synth.SetOutputToDefaultAudioDevice();

                // Speak a string synchronously.
                //synth.Speak(textBox1.Text);
                //synth.SetOutputToAudioStream(

                // Configure the audio output. 
                synth.SetOutputToWaveFile(@"test.wav",
                  new SpeechAudioFormatInfo(32000, AudioBitsPerSample.Sixteen, AudioChannel.Mono));


                // Create a SoundPlayer instance to play output audio file.
                //System.Media.SoundPlayer m_SoundPlayer =
                //  new System.Media.SoundPlayer(@"C:\temp\test.wav");

                // Build a prompt.
                //PromptBuilder builder = new PromptBuilder();
                //builder.AppendText("This is sample output to a WAVE file.");

                // Speak the prompt.
                synth.Speak(textBox1.Text);
                //while(!synth.SpeakCompleted)//loop until 
                //synth.WaitUntilDone(System.Threading.Timeout.Infinite);
                //textBox1.Text = synth.State.ToString();
                //textBox1.Text = "len="+AudioFunctions.helpers.duration("test.wav");
            }
            */

        }

        private void render_scene_Click(object sender, System.EventArgs e)
        {
            //textBox1.Text = System.Environment.CurrentDirectory.ToString();
            Bitmap source1; // your source images - assuming they're the same size
            Bitmap source2;
            source1 = new Bitmap("bg.png");
            source2 = new Bitmap("sprite.png");

            var target = new Bitmap(source1.Width, source1.Height, PixelFormat.Format32bppArgb);
            var graphics = Graphics.FromImage(target);
            graphics.CompositingMode = CompositingMode.SourceOver; // this is the default, but just to be clear

            graphics.DrawImage(source1, 0, 0);
            graphics.DrawImage(source2, 0, 0);

            target.Save("filename.png", ImageFormat.Png);

        }

        private void btnAddSprite_Click(object sender, System.EventArgs e)
        {
            frmSprite objsptForm = new frmSprite(this);//this passes a refference of this form to the other form so that the aa() method can be addressed there
            objsptForm.Show();
        }

        private void render_scene_Click_1(object sender, System.EventArgs e)
        {
            const int NumberOfProssesess=3;
            progressBar1.Invoke((MethodInvoker)delegate { progressBar1.Visible = true; progressBar1.Value = 0; });
            //delete tmp directory
            //hhmm probably need to check if files are locked before doing this, cause hte program crashes when there is some file open by another program
            //Check for existance of work directory
            if (!Directory.Exists(PictureFunctions.Globals.AppSettings.pathToWorkDir))
            {
                MessageBox.Show("Invalud working directory.\nGo to Settings->App Settings and set a  propper working directory");
                return;
            }
            Directory.SetCurrentDirectory(PictureFunctions.Globals.AppSettings.pathToWorkDir);
            //Change directory to work directory
            String TmpPath = System.IO.Path.Combine(PictureFunctions.Globals.AppSettings.pathToWorkDir, @"tmp");
            try
            {
                if (Directory.Exists(TmpPath)) System.IO.Directory.Delete(TmpPath, true);
            }
            catch (IOException)
            {
                MessageBox.Show("A file is locked in the tmp sub-directory,\n Try to close the program which has it open");
                return;
            }
            //create tmp directory
            System.IO.Directory.CreateDirectory("tmp");
            int OutputFramecount = 0; ;
            Decimal DurationInSeconds;
            Decimal TotalFrames;
            Decimal CurrentLine=0;
            List<Decimal> DurationArray = new List<Decimal>();
            //init values
            foreach (Character _character in Objects.Characters) {
                _character.frame_counter = -1;//init to -1 because it starts calculating the frame from the next frame
                _character.row = 0;
                _character.offsetx = 0;
                _character.col = 0;
                _character.offsety = 0;
                //It is set to the original spritesheet further down.
            }
            StateVars.fps = Convert.ToDouble(txtInputFPS.Text);
            foreach (UserControl1 line in ScreenPlay)
            {
                CurrentLine++;
                String CurrentTmpSubfolderPath = System.IO.Path.Combine(TmpPath, "Line" + Convert.ToString(CurrentLine));
                String AudioFilePath = System.IO.Path.Combine(CurrentTmpSubfolderPath, "Speach.wav");
                System.IO.Directory.CreateDirectory(CurrentTmpSubfolderPath);
                String ParametersToEspeak="-v male1";
                foreach (Character _character in Objects.Characters)
                {
                    if (_character.name == line.cmbCharacter_pub.GetItemText(line.cmbCharacter_pub.SelectedItem)) {
                        ParametersToEspeak = _character.parameters_to_espeak;
                        break;
                    }
                }
                DurationInSeconds = AudioFunctions.helpers.SynthAndGetDuration(line.txtLine_pub.Text, "Speach.wav", ParametersToEspeak);
                DurationArray.Add(DurationInSeconds);
                System.IO.File.Move("Speach.wav", AudioFilePath);
                foreach (Character _character in Objects.Characters)
                {      
                    if (_character.name == line.cmbCharacter_pub.GetItemText(line.cmbCharacter_pub.SelectedItem))
                    {
                        //Objects.OriginalCharacter = ObjectCopier.Clone(_character);
                        Objects.OriginalCharacter = (Character)_character.Clone();
                          
                        //Objects.OriginalCharacter = _character;//store the original sprite sheet pointer
                        foreach (SpriteState sprt in Objects.list)
                            if (sprt.name == line.cmbSprite_pub.GetItemText(line.cmbSprite_pub.SelectedItem))
                            {
                                _character.sprite_sheet = sprt.sprite_sheet;//change to selected sprite sheet
                                _character.height = sprt.sprite_height;
                                _character.width = sprt.sprite_width;
                                _character.offsetx = 0;
                                _character.offsety = 0;
                                _character.Rows = sprt.Rows;
                                _character.Columbs = sprt.Columbs;
                                _character.FrameCount = sprt.FrameCount;
                                _character.frame_counter = -1;
                            }
                    }
                    }
                //TotalFrames = Math.Round(Math.Ceiling(DurationInSeconds)) * (int)StateVars.fps;
                TotalFrames = Math.Round(Math.Ceiling(DurationInSeconds * (decimal) StateVars.fps));
                for (int CurrentFrame = 0; CurrentFrame < TotalFrames; CurrentFrame++)
                {
                    RenderScreen();
                    String CurrentImageFile = System.IO.Path.Combine(CurrentTmpSubfolderPath, "img" + Convert.ToString(CurrentFrame) + ".png");
                    PictureFunctions.Globals.RenderingBuffer.Save(CurrentImageFile);
                    OutputFramecount++;
                    //render all characters in scene
                    foreach (Character _character in Objects.Characters)
                    {

                        //calculate next offset
                        if (_character.frame_counter != _character.FrameCount - 2)
                        {//take away 2 because it is for the next frame, and we dont have a next frame for the last sprite
                            _character.frame_counter++;
                        }
                        else
                        {
                            _character.frame_counter = -1;
                            _character.row = 0;
                            _character.offsetx = 0;
                            _character.col = 0;
                            _character.offsety = 0;
                            continue;//break;//return;
                        }
                        if (_character.row >= _character.Rows - 1)
                        {
                            _character.row = 0;
                            _character.col++;
                            _character.offsety = _character.offsety + _character.height;
                            _character.offsetx = 0;
                        }
                        else
                        {
                            _character.offsetx = _character.offsetx + _character.width;
                            _character.row++;
                        }
                        if (_character.col >= _character.Columbs)
                        {
                            _character.col = 0;
                            _character.offsety = 0;
                        }
                    }
                }
                //revert to the original character, after speaking, so that the sprite becomes the standing one
                int index = 0;
                foreach (Character _character in Objects.Characters)
                {
                    if (_character.name == line.cmbCharacter_pub.GetItemText(line.cmbCharacter_pub.SelectedItem))
                    {
                        break;
                        //Objects.Characters[index] = Objects.OriginalCharacter;//store the original sprite sheet pointer
                    }
                    index++;
                }
                Objects.Characters[index] = (Character)Objects.OriginalCharacter.Clone();//seems I had to write to the Character object outside of the foreachloop, it seems to have been in protected mode or something.

            }
            progressBar1.Invoke((MethodInvoker)delegate { progressBar1.Value = (1 / NumberOfProssesess) * 100; });
            CurrentLine=0;
            String StringWithPathsToAllVideos="";
            foreach (UserControl1 line in ScreenPlay)
            {
                CurrentLine++;
                String CurrentTmpSubfolderPath = System.IO.Path.Combine(TmpPath, "Line" + Convert.ToString(CurrentLine));
                String AudioFilePath = System.IO.Path.Combine(CurrentTmpSubfolderPath, "Speach.wav");
                String MagicNumberPath = System.IO.Path.Combine(CurrentTmpSubfolderPath, "img%d.png");
                String LineVideoOnlyFilePath = System.IO.Path.Combine(CurrentTmpSubfolderPath, "ThisLine_VideoOnly.mkv");
                String LineVideoWithSoundFilePath = System.IO.Path.Combine(CurrentTmpSubfolderPath, "ThisLine_WithSound.mkv");
                //***I think it may be OS specific to windows to add the double quotes around the full paths when there are spaces in the names, not sure, verify later
                //Also I dont think I need the .Replace(@"\\", @"\") junk, but it works with it...  when I have time, try getting rid of it...
                //Render this animation into an mkv: d:\ffmpeg\bin\ffmpeg.exe -r 3 -i img%d.png -r 24 video_only.mkv
                SystemFunctions.helpers.ExecuteAndWaitForEnd(PictureFunctions.Globals.AppSettings.pathToFfmpeg, "-r " + txtInputFPS.Text + " -i \"" + MagicNumberPath.Replace(@"\\", @"\") + "\" -r " + txtOutputFPS.Text + " \"" + LineVideoOnlyFilePath.Replace(@"\\", @"\") + "\"");
                //Add soundtrack (some warning about needing to guess that the audio track is mono): d:\ffmpeg\bin\ffmpeg.exe -i video_only.mkv -i Speach.wav output_video.mkv
                SystemFunctions.helpers.ExecuteAndWaitForEnd(PictureFunctions.Globals.AppSettings.pathToFfmpeg, "-i \"" + LineVideoOnlyFilePath.Replace(@"\\", @"\") + "\" -i \"" + AudioFilePath.Replace(@"\\", @"\") + "\" \"" + LineVideoWithSoundFilePath.Replace(@"\\", @"\") + "\"");
                //For video concatenation, Build the string that we will use to concatenate all the videos
                StringWithPathsToAllVideos += StringWithPathsToAllVideos == "" ? "" : "+";
                StringWithPathsToAllVideos += "\"" + LineVideoWithSoundFilePath.Replace(@"\\", @"\") + "\" ";
                //StringWithPathsToAllVideos += "duration " + Convert.ToString(DurationArray.ToArray()[Convert.ToInt32(CurrentLine)-1]) + "\n";                
                //if(CurrentLine<ScreenPlay.Count) StringWithPathsToAllVideos+="\n";//put | between every element except the last one
            }
            progressBar1.Invoke((MethodInvoker)delegate { progressBar1.Value = (2 / NumberOfProssesess) * 100; });
            //DurationArray.Clear();
            //System.IO.File.WriteAllText(@"concat.txt", StringWithPathsToAllVideos);
            //Concatenate all videos to generate final video: d:\ffmpeg\bin\ffmpeg.exe -i "concat:i1.mkv|i2.mkv" -c copy final_video.mkv
            //SystemFunctions.helpers.ExecuteAndWaitForEnd(PictureFunctions.Globals.AppSettings.pathToFfmpeg, "-i \"concat:" + StringWithPathsToAllVideos + "\" -c copy \"" + txtOuputFilePath.Text + "\"");
            if (File.Exists(txtOuputFilePath.Text)) File.Delete(txtOuputFilePath.Text);
            SystemFunctions.helpers.ExecuteAndWaitForEnd(PictureFunctions.Globals.AppSettings.pathToMkvmerge, "-o \"" + txtOuputFilePath.Text + "\" " + StringWithPathsToAllVideos );
            progressBar1.Invoke((MethodInvoker)delegate { progressBar1.Value = (3 / NumberOfProssesess) * 100; });
            progressBar1.Visible = false;
            MessageBox.Show("Done rendering!");
        }

        private void lstviewSprites_ItemDrag(object sender, ItemDragEventArgs e)
        {
            //lstviewSprites.DoDragDrop(e.Item, DragDropEffects.Move);
            //lstviewSprites.DoDragDrop(lstviewSprites.SelectedItems, DragDropEffects.Copy);
            lstviewSprites.DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void picboxPreview_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = e.AllowedEffect;
        }

        // Select the node under the mouse pointer to indicate the 
        // expected drop location.
        private void picboxPreview_DragOver(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the drop location.
            Point targetPoint = picboxPreview.PointToClient(new Point(e.X, e.Y));

            ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            RenderScreen();
            //picboxPreview.Image = PictureFunctions.Globals.RenderingBuffer;
            PictureFunctions.Globals.TmpBuffer = (Bitmap)PictureFunctions.Globals.RenderingBuffer.Clone();

            PictureFunctions.helpers.CompositeImageBackGroundAndSprite(
                            PictureFunctions.Globals.TmpBuffer,
                            Objects.list[draggedItem.ImageIndex].sprite_sheet,
                            targetPoint.X - (Objects.list[draggedItem.ImageIndex].sprite_width / 2),
                            targetPoint.Y - (Objects.list[draggedItem.ImageIndex].sprite_height / 2),
                            0,
                            0,
                            Objects.list[draggedItem.ImageIndex].sprite_width,
                            Objects.list[draggedItem.ImageIndex].sprite_height
                            );
            picboxPreview.Image = PictureFunctions.Globals.RenderingBuffer;

            //OK, next step is to add the objects to the list, and make them draggable somehow. and allow for rendering new objects together in the scence
        }

        private void RenderScreen()
        {//renders the screen for when the objects are being dragged and dropped
            if (Objects.Characters.Count == 0)
            {// hack for getting hte background to render into the rest when there is are no characters, it is low quality so this might not be hte best way to do it
                PictureFunctions.helpers.SetBMtoBM(PictureFunctions.Globals.RenderingBuffer, Objects.bg);//render the backgroud if there are no characters, otherwise it will be blank
                return;
            }
            PictureFunctions.Globals.TmpBuffer = (Bitmap)Objects.bg.Clone();
            foreach (Character _character in Objects.Characters)
            {
                PictureFunctions.helpers.CompositeImageBackGroundAndSprite(
                                PictureFunctions.Globals.TmpBuffer,
                                _character.sprite_sheet,
                                _character.x,
                                _character.y,
                                _character.offsetx,
                                _character.offsety,
                                _character.width,
                                _character.height
                                );
                PictureFunctions.Globals.TmpBuffer = (Bitmap)PictureFunctions.Globals.RenderingBuffer.Clone();
            }
            //picboxPreview.Image = PictureFunctions.Globals.RenderingBuffer;
        }
        private void picboxPreview_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the drop location.
            Point targetPoint = picboxPreview.PointToClient(new Point(e.X, e.Y));

            ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            Character newcharacter = new Character();
            newcharacter.sprite_sheet = Objects.list[draggedItem.ImageIndex].sprite_sheet;
            newcharacter.height = Objects.list[draggedItem.ImageIndex].sprite_height;
            newcharacter.width = Objects.list[draggedItem.ImageIndex].sprite_width;
            newcharacter.x = targetPoint.X - (Objects.list[draggedItem.ImageIndex].sprite_width / 2);
            newcharacter.y = targetPoint.Y - (Objects.list[draggedItem.ImageIndex].sprite_height / 2);
            newcharacter.FrameCount = Objects.list[draggedItem.ImageIndex].FrameCount;
            newcharacter.Rows = Objects.list[draggedItem.ImageIndex].Rows;
            newcharacter.Columbs = Objects.list[draggedItem.ImageIndex].Columbs;
            frmCharacterSettings objfrmCharacterSettings = new frmCharacterSettings(newcharacter, ScreenPlay);
            objfrmCharacterSettings.Show();
            Objects.Characters.Add(newcharacter);
            RenderScreen();
            picboxPreview.Image = PictureFunctions.Globals.RenderingBuffer;
        }

        private void picboxTest_Click(object sender, EventArgs e)
        {
        }

        private void picboxPreview_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (Character _character in Objects.Characters)
                {
                    if ((e.X >= _character.x && e.Y >= _character.y) && (e.X <= _character.x + _character.width && e.Y <= _character.y + _character.height))
                    {
                        foreach (UserControl1 line in ScreenPlay)
                        {
                            line.cmbCharacter_pub.Items.Remove(_character.name);
                        }
                        Objects.Characters.Remove(_character);
                        break;
                    }
                }
                RenderScreen();
                picboxPreview.Image = PictureFunctions.Globals.RenderingBuffer;
            }
        }
        private void picboxPreview_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lstviewSprites.DoDragDrop(e.Item, DragDropEffects.Move);
            //lstviewSprites.DoDragDrop(lstviewSprites.SelectedItems, DragDropEffects.Copy);
            //lstviewSprites.DoDragDrop(e.Item, DragDropEffects.Copy);
        }
        //Later add code for moving an object after it has been placed, since this can now be achived anyway by deleting a picture and placing it again

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            UserControl1 line = new WindowsFormsApplication1.UserControl1();
            if (ScreenPlay.Count == 0)
                line.Location = new System.Drawing.Point(0, 21);//set position for first instance of screenplay line
            else
                line.Top = ScreenPlay[ScreenPlay.Count - 1].Top + ScreenPlay[ScreenPlay.Count - 1].Height;//set under precious screenplay line
            foreach (Character _character in Objects.Characters)
            {
                line.cmbCharacter_pub.Items.Add(_character.name);
            }
            foreach (ListViewItem SpriteItem in lstviewSprites.Items)
            {
                line.cmbSprite_pub.Items.Add(SpriteItem.Text);
            }

            //is this even nessesay? 
            line.Name = "userControl11";
            line.Size = new System.Drawing.Size(587, 25);
            this.panel1.Controls.Add(line);
            ScreenPlay.Add(line);
        }

        private void picboxTest_Click_1(object sender, EventArgs e)
        {
            Bitmap bg = new Bitmap("C:\\Users\\anonymous\\Documents\\Visual Studio 2010\\Projects\\Gekijou\\Gekijou\\bin\\Debug\\bg.png");
            Bitmap sprt = new Bitmap("C:\\Users\\anonymous\\Documents\\Visual Studio 2010\\Projects\\Gekijou\\Gekijou\\bin\\Debug\\test sprite map.png");
            PictureFunctions.helpers.CompositeImageBackGroundAndSprite(
                bg,
                sprt,
                30,
                30,
                0,
                0,
                10,
                10
                );
            PictureFunctions.Globals.TmpBuffer = (Bitmap)PictureFunctions.Globals.RenderingBuffer.Clone();
            //PictureFunctions.helpers.SetBMtoBM(PictureFunctions.Globals.TmpBuffer, PictureFunctions.Globals.RenderingBuffer);

            PictureFunctions.helpers.CompositeImageBackGroundAndSprite(
                PictureFunctions.Globals.TmpBuffer,
                sprt,
                60,
                60,
                0,
                0,
                10,
                10
                );
            picboxPreview.Image = PictureFunctions.Globals.RenderingBuffer;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RenderScreen();
            picboxPreview.Image = PictureFunctions.Globals.RenderingBuffer;
            foreach (Character _character in Objects.Characters)
            {
                //calculate next offset
                if (_character.frame_counter != _character.FrameCount - 2)
                {//take away 2 because it is for the next frame, and we dont have a next frame for the last sprite
                    _character.frame_counter++;
                }
                else
                {
                    _character.frame_counter = -1;
                    _character.row = 0;
                    _character.offsetx = 0;
                    _character.col = 0;
                    _character.offsety = 0;
                    return;
                }
                if (_character.row >= _character.Rows - 1)
                {
                    _character.row = 0;
                    _character.col++;
                    _character.offsety = _character.offsety + _character.height;
                    _character.offsetx = 0;
                }
                else
                {
                    _character.offsetx = _character.offsetx + _character.width;
                    _character.row++;
                }
                if (_character.col >= _character.Columbs)
                {
                    _character.col = 0;
                    _character.offsety = 0;
                }
            }

        }
        [Serializable]
        public static class Objects
        {
            public static List<SpriteState> list = new List<SpriteState>();
            public static ImageList imageListLarge = new ImageList();
            public static List<Character> Characters = new List<Character>();
            public static Bitmap bg = new Bitmap(640, 360);
            public static Character OriginalCharacter = new Character();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "mkv files (*.mkv)|*.mkv";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file to read.
                txtOuputFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String PathToBG="";
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
                PathToBG = openFileDialog1.FileName;
            }
            Objects.bg = new Bitmap(PathToBG);
            RenderScreen();
            picboxPreview.Image = PictureFunctions.Globals.RenderingBuffer;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://amigojapan.github.com/3dpl");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://play.google.com/store/apps/details?id=com.usmpadow.MobileRADIDE");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:usmpadow@gmail.com?Subject=Gekijou Job");
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void saveSpriteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Stream stream = File.Open("SpritesFile.bin", FileMode.Create))
                {
                    List<SpriteState> savelist = new List<SpriteState>();
                    savelist = Objects.list;
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, savelist);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error while trying to write file.");
            }
        }

        private void openSpriteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSpriteList("SpritesFile.bin");//Made thid function do that it would be easier to impleement autoload later(2014/03/12)
            /*
            try
            {
                using (Stream stream = File.Open("SpritesFile.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    Objects.list = (List<SpriteState>)bin.Deserialize(stream);
                    lstviewSprites.Items.Clear();//clear the list view
                    foreach (SpriteState sprt in Objects.list)
                    {
                        Bitmap img = new Bitmap(sprt.sprite_width, sprt.sprite_height);
                        img = PictureFunctions.helpers.CropImage(sprt.sprite_sheet,new Rectangle(new Point(0,0), new Size(sprt.sprite_width,sprt.sprite_height)));
                        ListViewItem item1 = new ListViewItem(sprt.name, lstviewSprites.Items.Count);
                        // Initialize the ImageList objects with bitmaps.
                        Objects.imageListLarge.Images.Add(img);
                        lstviewSprites.Items.AddRange(new ListViewItem[] { item1 });
                        lstviewSprites.LargeImageList = Objects.imageListLarge;
                        lstviewSprites.SmallImageList = Objects.imageListLarge;
                        foreach (UserControl1 line in ScreenPlay)
                        {
                            line.cmbSprite_pub.Items.Add(sprt.name);
                        }
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error while trying to read file.");
            }
             */
        }

        private void appSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAppSettings objsptForm = new frmAppSettings();//this passes a refference of this form to the other form so that the aa() method can be addressed there
            objsptForm.Show();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if ((PictureFunctions.Globals.AppSettings.pathToESpeak == null || PictureFunctions.Globals.AppSettings.pathToFfmpeg == null || PictureFunctions.Globals.AppSettings.pathToWorkDir == null || PictureFunctions.Globals.AppSettings.pathToMkvmerge == null) || (PictureFunctions.Globals.AppSettings.pathToESpeak == "" || PictureFunctions.Globals.AppSettings.pathToFfmpeg == "" || PictureFunctions.Globals.AppSettings.pathToWorkDir == "" || PictureFunctions.Globals.AppSettings.pathToMkvmerge == ""))
            {
                if (Application.OpenForms["frmAppSettings"] == null)
                {
                    frmAppSettings objsptForm = new frmAppSettings();//this passes a refference of this form to the other form so that the aa() method can be addressed there
                    objsptForm.Show();
                }
                Application.OpenForms["frmAppSettings"].BringToFront();
            }
        }

        private void frmMain_Enter(object sender, EventArgs e)
        {
            //if (PictureFunctions.Globals.AppSettings.pathToESpeak == "" || PictureFunctions.Globals.AppSettings.pathToFfmpeg == "" || PictureFunctions.Globals.AppSettings.pathToWorkDir == "")
            //    Application.OpenForms["frmAppSettings"].BringToFront();
        }

    }
    namespace AudioFunctions
    {
        public class helpers
        {
            public static Decimal SynthAndGetDuration(String Text,string filename, String  ParametersToEspeak)
            {
                AudioFunctions.helpers.SynthesizeVoice(Text, filename, ParametersToEspeak);
                return AudioFunctions.helpers.duration(filename);
            }
            public static Decimal duration(string filename)
            {
                System.Diagnostics.Process proc2 = new System.Diagnostics.Process
                {
                    StartInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = PictureFunctions.Globals.AppSettings.pathToFfmpeg,//***OS specific! my system specific!
                        Arguments = "-i " + filename,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    }
                };

                string strRegex = @"Duration: [0-9]*:[0-9]*:([0-9.]*),";
                proc2.Start();
                //string line=null;
                while (!proc2.StandardError.EndOfStream)
                {
                    string line = proc2.StandardError.ReadLine();
                    Regex myRegex = new Regex(strRegex, RegexOptions.None);
                    string strTargetString = line;
                    foreach (Match myMatch in myRegex.Matches(strTargetString))
                    {
                        if (myMatch.Success)
                        {
                            return Convert.ToDecimal(myMatch.Groups[1].Value);
                        }
                    }
                    line = proc2.StandardOutput.ReadLine();
                }
                proc2.Close();
                return 9999M;//bah, I cant return null,  so I will return this to check if it failed
            }
            public static void SynthesizeVoice(String Text , string filename, String  ParametersToEspeak)
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process
                {
                    StartInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = PictureFunctions.Globals.AppSettings.pathToESpeak,
                        Arguments = ParametersToEspeak + " -w " + filename + " \"" + Text + "\"", 
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
    namespace SystemFunctions
    {
        public class helpers
        {
            public static void ExecuteAndWaitForEnd(String Program, String Parameters)
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process
                {
                    StartInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = Program,//***OS specific! my system specific!
                        Arguments = Parameters,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        //RedirectStandardError = true,
                        CreateNoWindow = true
                    }
                };

                proc.Start();
                //while (!proc.StandardOutput.EndOfStream || !proc.StandardError.EndOfStream)
                while (!proc.StandardOutput.EndOfStream)
                {
                    string line;
                    line = proc.StandardOutput.ReadLine();
                    //line = proc.StandardError.ReadLine();
                    // just loop until the process ends
                }
                proc.Close();
            }

        }

    }
 
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}

/// <summary>
/// Reference Article http://www.codeproject.com/KB/tips/SerializedObjectCloner.aspx
/// Provides a method for performing a deep copy of an object.
/// Binary Serialization is used to perform the copy.
/// </summary>
public static class ObjectCopier
{
    /// <summary>
    /// Perform a deep Copy of the object.
    /// </summary>
    /// <typeparam name="T">The type of object being copied.</typeparam>
    /// <param name="source">The object instance to copy.</param>
    /// <returns>The copied object.</returns>
    public static T Clone<T>(T source)
    {
        if (!typeof(T).IsSerializable)
        {
            throw new ArgumentException("The type must be serializable.", "source");
        }

        // Don't serialize a null object, simply return the default for that object
        if (Object.ReferenceEquals(source, null))
        {
            return default(T);
        }

        IFormatter formatter = new BinaryFormatter();
        Stream stream = new MemoryStream();
        using (stream)
        {
            formatter.Serialize(stream, source);
            stream.Seek(0, SeekOrigin.Begin);
            return (T)formatter.Deserialize(stream);
        }
    }
}

/*
 * greg: workflow
 *First drag characters onto the scene to select their positions
 *then have a "screenplay", where you select which character will speak for which line(perhaps use an editable grid(like a spreadsheet?))
 *then type each line for what each character is going to say, and select which sprite will happen while the character speaks,
 *In the future perhaps add paths, for characters following a path (for example, a character walks to a door, and then shuts it)
 *
 * how to know how many frames I need to animate to last X ammount of time
 * Frame rate(F=25) round(X/F)
 * 
 *Duration of sound(A=1.2) A/F-floor(A/F)///a number minus hte floor is the ammount which is less than 1 12.35-floor(12.35) will be .35
 *add that remainder as a pause
 *
 *for drawing a sprite of 5FPS at 25FPS just repeat the same sprite 25/5 times
 *for drawing a sprite of 25FPS at 5FPS show every multiple of 5 frame
 *
 *2014/03/05 Succesfully rendered an entire video with sound and everything!
 *
 * TODO:
 * 
 * (2014/03/15) I forced the user to enter a value in app settings
 * (done 2014/03/15)enable browse buttons in app settings
 * (done 2014/03/15)save settings when ok is clicked in app settings
 * (done 2014/03/15)load settings when program starts
 * (done 2014/03/15)Remove values for hte monster Sprite columbs, Sprite Rows and Frame Count, so they are empty.
 * 
 * Data Validation: 
 * Check to see if Name of character is not empty (Done 2014/03/08)
 * check to see if name of character it not duplicated (in character settings)
 * Make sure a value is entered for every field in each user control (character selected, sprite selected, text entered, return a meaningful error if not)
 * Change combo boxes to list boxes? for character and sprite, or verify that every value is valid(could be done when the combo box looses focus)
 * 
 * Add the windows for when a person clicks on browse for sprite sheets(Done 2014/03/08),
 * it should have the picture I drew explaining rows and columbs (Done 2014/03/08)
 * and how to determine framecount,  fields for entering all of that (must validate htey are not empry before 
 * allowing to browse for spritesheet)  (Done 2014/03/08)
 * mention that the spritesheets must be evenly spaced and that not all spritesheets are... (Done 2014/03/08)
 * 
 * All over system specific stuff repair, marked with //***
 * 
 * Add a progressbar to show the processes happening when rendering a video, perhaps 2 bars, one with the current process, one with a total percentage(just take all processes and divide by that number)
 * 
 * Make teh Save/Open Screenplay/Sprite File menus work.(2014/03/09 did open and save sprite list, but still need to prompt for a filename)
 * Also it would be good to have something like AutoLoadSpriteList.bin  once there is some ncie art made for Gekijou
 * 
 * Get Kindland or some other artist to make art for this program.... 2d art and 3d art would be goood
 * Several Male and Female Characters, with some mouth animation(the mouth can be the same mouth, maybe one mouth for men and one for women)
 * Several Backgrounds, offices, presentation rooms (with a whiteboard), fields, houses, and other backdrops
 * A new background for the new homepage for this program, I will reuse the same HTML for the 3dpl homepage, so we just need to
 * change the old background of the bage.
 * 
 * Implement duration for each sprite
 * 
 * Make website, try to get help from the guy that made the page for 3dpl(what was his name?) James?
 * 
 * Release Demo Videos, Tell Hack A Day or my new project
 * 
 * 
 * Get MAC address and OS of client computer and get a report of each video reneded to put into a table, so I can keep up with statistics of usage(this does not need to work if the computer is offline)
 * Perhaps request email address during the first use...  but why owuld I need this?
 * 
 * BUGS:
 * (Fiex, thanks to relaxed	on #ffmpeg 2014/03/11, I just changed for AVI files to MKV files) New bug found,  the background seems to get distorted when teh Rendering FPS is set to 7 and I make an animation with many lines... this did not seem to happen at 3 FPS,
 * or perhaps I need to test it again by setting it to 7 and rendering from scratch. (the video of VidoOnly for each line, is distorted, so the problem must be something around that code, the images are nto distorted, so it should be something in the image magic number portion of the code, possibly related with teh elimination of the checking of stderr in the shell caller) 
 * (Fixed)The mouth animation lags behind the sound, I suspect that the concatination is putting all the sounds together, where there should be some space between each line of the script... this is exactly what we tried to prevent by making seperate videos for each line of text
*/