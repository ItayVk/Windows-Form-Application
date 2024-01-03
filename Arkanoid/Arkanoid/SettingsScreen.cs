using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class SettingsScreen : Form
    {
        public SettingsScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            instLabel.Parent = pictureBox1;
            instLabel.BackColor = Color.Transparent;

            BrickLabel.Parent = pictureBox1;
            BrickLabel.BackColor = Color.Transparent;

            GreenLabel.Parent = pictureBox1;
            GreenLabel.BackColor = Color.Transparent;

            BlueLabel.Parent = pictureBox1;
            BlueLabel.BackColor = Color.Transparent;

            YellowLabel.Parent = pictureBox1;
            YellowLabel.BackColor = Color.Transparent;

            RedLabel.Parent = pictureBox1;
            RedLabel.BackColor = Color.Transparent;

            RowsLabel.Parent = pictureBox1;
            RowsLabel.BackColor = Color.Transparent;

            Bricks1.Parent = pictureBox1;
            Bricks1.BackColor = Color.Transparent;

            Bricks2.Parent = pictureBox1;
            Bricks2.BackColor = Color.Transparent;

            Rows1.Parent = pictureBox1;
            Rows1.BackColor = Color.Transparent;

            Rows2.Parent = pictureBox1;
            Rows2.BackColor = Color.Transparent;

            greenLabel2.Parent = pictureBox1;
            greenLabel2.BackColor = Color.Transparent;

            blueLabel2.Parent = pictureBox1;
            blueLabel2.BackColor = Color.Transparent;

            yellowLabel2.Parent = pictureBox1;
            yellowLabel2.BackColor = Color.Transparent;

            redLabel2.Parent = pictureBox1;
            redLabel2.BackColor = Color.Transparent;

            greenHit.Parent = pictureBox1;
            greenHit.BackColor = Color.Transparent;

            blueHit.Parent = pictureBox1;
            blueHit.BackColor = Color.Transparent;

            yellowHit.Parent = pictureBox1;
            yellowHit.BackColor = Color.Transparent;

            redHit.Parent = pictureBox1;
            redHit.BackColor = Color.Transparent;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            int count = Convert.ToInt32(greenBrick.Value + blueBrick.Value + yellowBrick.Value + redBrick.Value);
            bool gLines, bLines, yLines, rLines;
            gLines = bLines = yLines = rLines = true;

            if (count == 0)
            {
                const string message = "The game CAN'T start because a mininmum number of Bricks has not been set!\n\nPlease set at least one Brick with a value between 1-12.";
                const string caption = "Error";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Properties.Settings.Default.GreenBricks = Convert.ToInt32(greenBrick.Value);
                Properties.Settings.Default.BlueBricks = Convert.ToInt32(blueBrick.Value);
                Properties.Settings.Default.YellowBricks = Convert.ToInt32(yellowBrick.Value);
                Properties.Settings.Default.RedBricks = Convert.ToInt32(redBrick.Value);

                if ((Convert.ToInt32(greenBrick.Value) > 0) && (Convert.ToInt32(greenLines.Value) == 0))
                {
                    const string message = "The game CAN'T start because you haven't set the number of GREEN Bricks!\n\n" +
                        "Please set number of lines with a value between 1-3.";
                    const string caption = "Error";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gLines = false;
                }

                else
                    Properties.Settings.Default.GreenLines = Convert.ToInt32(greenLines.Value);


                if ((Convert.ToInt32(blueBrick.Value) > 0) && (Convert.ToInt32(blueLines.Value) == 0))
                {
                    const string message = "The game CAN'T start because you haven't set the number of BLUE Bricks!\n\n" +
                        "Please set number of lines with a value between 1-3.";
                    const string caption = "Error";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLines = false;
                }

                else
                    Properties.Settings.Default.BlueLines = Convert.ToInt32(blueLines.Value);


                if ((Convert.ToInt32(yellowBrick.Value) > 0) && (Convert.ToInt32(yellowLines.Value) == 0))
                {
                    const string message = "The game CAN'T start because you haven't set the number of YELLOW Bricks!\n\n" +
                        "Please set number of lines with a value between 1-3.";
                    const string caption = "Error";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    yLines = false;
                }

                else
                    Properties.Settings.Default.YellowLines = Convert.ToInt32(yellowLines.Value);


                if ((Convert.ToInt32(redBrick.Value) > 0) && (Convert.ToInt32(redLines.Value) == 0))
                {
                    const string message = "The game CAN'T start because you haven't set the number of RED Bricks!\n\n" +
                        "Please set number of lines with a value between 1-3.";
                    const string caption = "Error";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rLines = false;
                }

                else
                    Properties.Settings.Default.RedLines = Convert.ToInt32(redLines.Value);

                if (gLines && bLines && yLines && rLines)
                {
                    Properties.Settings.Default.Save();
                    f.Show();
                    this.Close();
                }
            }
        }
    }
}
