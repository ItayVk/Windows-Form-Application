
namespace Arkanoid
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lifeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 1307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 76);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green\r\n1 Hit";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Lime;
            this.startButton.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(701, 806);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(302, 71);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "START GAME";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Aqua;
            this.saveButton.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(1029, 806);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(165, 71);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.BackColor = System.Drawing.Color.LightGreen;
            this.resumeButton.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeButton.Location = new System.Drawing.Point(342, 806);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(165, 71);
            this.resumeButton.TabIndex = 16;
            this.resumeButton.Text = "Resume";
            this.resumeButton.UseVisualStyleBackColor = false;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.Khaki;
            this.loadButton.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(1196, 807);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(165, 71);
            this.loadButton.TabIndex = 17;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pauseButton.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(510, 806);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(165, 71);
            this.pauseButton.TabIndex = 18;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Gold;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Black;
            this.scoreLabel.Location = new System.Drawing.Point(5, 806);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(196, 71);
            this.scoreLabel.TabIndex = 19;
            this.scoreLabel.Text = "Score: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = global::Arkanoid.Properties.Resources.Arkanoid2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1700, 801);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // lifeLabel
            // 
            this.lifeLabel.AutoSize = true;
            this.lifeLabel.BackColor = System.Drawing.Color.Red;
            this.lifeLabel.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifeLabel.ForeColor = System.Drawing.Color.White;
            this.lifeLabel.Location = new System.Drawing.Point(1540, 807);
            this.lifeLabel.Name = "lifeLabel";
            this.lifeLabel.Size = new System.Drawing.Size(159, 71);
            this.lifeLabel.TabIndex = 20;
            this.lifeLabel.Text = "Life: 3";
            this.lifeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 886);
            this.Controls.Add(this.lifeLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label lifeLabel;
    }
}

