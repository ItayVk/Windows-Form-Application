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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SettingsScreen s = new SettingsScreen();
            s.Show();
            //this.Close();
        }
    }
}
