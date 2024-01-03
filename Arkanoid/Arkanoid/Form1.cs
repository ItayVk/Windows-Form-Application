using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        Ball cir;
        Racket r;
        ShapeList shapes;
        bool chose = false;
        bool isPause = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            shapes = new ShapeList();

            r = new Racket(pictureBox1.Width / 2, pictureBox1.Height - 35, 120, 15);
            cir = new Ball(pictureBox1.Width / 2, pictureBox1.Height - 53, 10, Color.Orange);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            SettingsScreen settings = new SettingsScreen();

            if (chose && !isPause)
            {
                scoreLabel.Text = $"Score: {shapes.Score}";
                lifeLabel.Text = $"Life: {shapes.Life}";

                ((Ball)shapes[1]).move_ball(pictureBox1.Height, pictureBox1.Width - 10);
                ((Ball)shapes[1]).IsTouchRacket((Racket)shapes[0]);

                if (shapes.checkIsTouchBall())
                    shapes.Score += 10;

                shapes.moveObjects(pictureBox1.Height, pictureBox1.Width);
                shapes.checkIsObjectTouchRacket();
                shapes.changeBallColor();
                shapes.checkIsObjectPassLine(pictureBox1.Height - 35);

                if (shapes.checkIsPassLine(pictureBox1.Height - 35) == 0)
                {
                    chose = false;
                    string s = shapes.Score.ToString();
                    string text = "Game Over!\n Your score is: " + s;
                    MessageBox.Show(text);
                    this.Close();
                }

                if (shapes.countBricks() == 0)
                {
                    chose = false;
                    string s = shapes.Score.ToString();
                    string text = "Congratulations!\nYou finished the game!\nYour score is: " + s;
                    MessageBox.Show(text);
                    this.Close();
                    settings.Show();
                }

                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(new Pen(Color.White, 2), new Point(pictureBox1.Left, pictureBox1.Height - 35), new Point(pictureBox1.Width, pictureBox1.Height - 35));

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (chose)
            {
                shapes.DrawAll(g);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int height = pictureBox1.Top + 10;

            chose = true;

            shapes.Add(r);
            shapes.Add(cir);

            if (Properties.Settings.Default.RedBricks > 0)
            {
                for (int i = 0; i < Properties.Settings.Default.RedLines; i++)
                {
                    shapes.createList(Properties.Settings.Default.RedBricks, pictureBox1.Width, height, 4, Color.Red);
                    height += 22;
                }
            }

            if (Properties.Settings.Default.YellowBricks > 0)
            {
                for (int i = 0; i < Properties.Settings.Default.YellowLines; i++)
                {
                    shapes.createList(Properties.Settings.Default.YellowBricks, pictureBox1.Width, height, 3, Color.Khaki);
                    height += 22;
                }
            }

            if (Properties.Settings.Default.BlueBricks > 0)
            {
                for (int i = 0; i < Properties.Settings.Default.BlueLines; i++)
                {
                    shapes.createList(Properties.Settings.Default.BlueBricks, pictureBox1.Width, height, 2, Color.Blue);
                    height += 22;
                }
            }

            if (Properties.Settings.Default.GreenBricks > 0)
            {
                for (int i = 0; i < Properties.Settings.Default.GreenLines; i++)
                {
                    shapes.createList(Properties.Settings.Default.GreenBricks, pictureBox1.Width, height, 1, Color.Green);
                    height += 22;
                }
            }
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            isPause = false;
        }

        
        private void pauseButton_Click(object sender, EventArgs e)
        {
            isPause = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    //!!!!
                    formatter.Serialize(stream, shapes);
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                //!!!!
                shapes = (ShapeList)binaryFormatter.Deserialize(stream);
                chose = true;
                isPause = true;
                pictureBox1.Invalidate();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (chose)
            {
                if ((e.KeyCode == Keys.A) && (shapes[0].X > 60))
                    shapes[0].X -= 10;

                if ((e.KeyCode == Keys.D) && (shapes[0].X < pictureBox1.Width - 60))
                    shapes[0].X += 10;

                if (e.KeyCode == Keys.Escape)
                    isPause = true;
            }
        }
    }
}
