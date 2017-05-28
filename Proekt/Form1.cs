using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Proekt
{
    public partial class Form1 : Form
    {
        GameDoc GameDoc;
        Timer t1;
        bool Play = true;
        bool newWord = true;

        System.Media.SoundPlayer missedSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");
        System.Media.SoundPlayer hitSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");
        System.Media.SoundPlayer kSoundPlayer = new System.Media.SoundPlayer("killed.wav");

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            GameDoc = new GameDoc();
            DoubleBuffered = true;
            Timer t = new Timer();
            t1 = new Timer();
            t1.Tick += T1_Tick; 
            t.Tick += T_Tick; 
            t1.Interval = 50;
            t.Interval = 100;
            t.Start();
            button1.Text = "PAUSE";
            label2.Text = string.Format("SCORE: {0}", GameDoc.score);
            Assembly _assembly;
            Stream _imageStream1;
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream1 = _assembly.GetManifestResourceStream("Proekt.zivot3.png");
            pbLives.Image = new Bitmap(_imageStream1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;
            this.MaximumSize = new Size(Width,Height);
            this.MinimumSize = new Size(Width, Height);
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            Assembly _assembly;
            Stream _imageStream1;
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream1 = _assembly.GetManifestResourceStream("Proekt.AliveKid.png");
            pbKid.Image = new Bitmap(_imageStream1);
            t1.Stop();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            if (Play)
            {
                if (pbCrocodile.Location.X < 228)
                {
                    Assembly _assembly;
                    Stream _imageStream;
                    _assembly = Assembly.GetExecutingAssembly();
                    _imageStream = _assembly.GetManifestResourceStream("Proekt.DeadKid.png");
                    pbKid.Image = new Bitmap(_imageStream);
                    pbCrocodile.Location = new Point(1038, 357);
                    newWord = true;
                    bool result = GameDoc.IsGameOver();
                    if (result)
                    {
                        _assembly = Assembly.GetExecutingAssembly();
                        System.IO.Stream str = _assembly.GetManifestResourceStream("Proekt.killed.wav");
                        System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                        snd.Play();
                        GameOver gameOver = new GameOver(GameDoc.score);
                        gameOver.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Stream _imageStream2;            
                        if (GameDoc.lives==2)
                        {
                            _assembly = Assembly.GetExecutingAssembly();
                            _imageStream2 = _assembly.GetManifestResourceStream("Proekt.zivot2.png");
                            pbLives.Image = new Bitmap(_imageStream2);
                        }
                        else if(GameDoc.lives==1)
                        {
                            _assembly = Assembly.GetExecutingAssembly();
                            _imageStream2 = _assembly.GetManifestResourceStream("Proekt.zivot1.png");
                            pbLives.Image = new Bitmap(_imageStream2);
                        }
                        t1.Start();
                    }
                }
                label2.Text = string.Format("SCORE: {0}", GameDoc.score);
                pbCrocodile.Location = new Point(pbCrocodile.Location.X - 10, pbCrocodile.Location.Y);
                Invalidate(true);
            }
        }

        private void pbCrocodile_Paint(object sender, PaintEventArgs e)
        {
            if (newWord)
            {
                label1.Text = "";
                Bitmap bmp = new Bitmap(pbCrocodile.Width, pbCrocodile.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    GameDoc.Draw(g);
                    if (newWord) newWord = false;
                }
                pbCrocodile.Image = bmp;
                newWord = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (GameDoc.CheckHit((char)e.KeyValue))
            {
                label1.Text += (char)e.KeyValue;
                if (GameDoc.CheckEmpty())
                {
                    hitSoundPlayer.Play();
                    newWord = true;
                }
            }
            else
            {
                missedSoundPlayer.Play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Play = !Play;
            if (Play)
            {
                button1.Text = "PAUSE";
            }
            else
            {
                button1.Text = "PLAY";
            }
        }
    }
}
