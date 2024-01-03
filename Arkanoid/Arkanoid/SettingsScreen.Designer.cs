
namespace Arkanoid
{
    partial class SettingsScreen
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
            this.BrickLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.redBrick = new System.Windows.Forms.NumericUpDown();
            this.RedLabel = new System.Windows.Forms.Label();
            this.yellowBrick = new System.Windows.Forms.NumericUpDown();
            this.YellowLabel = new System.Windows.Forms.Label();
            this.blueBrick = new System.Windows.Forms.NumericUpDown();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.greenBrick = new System.Windows.Forms.NumericUpDown();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.greenLines = new System.Windows.Forms.NumericUpDown();
            this.blueLines = new System.Windows.Forms.NumericUpDown();
            this.yellowLines = new System.Windows.Forms.NumericUpDown();
            this.redLines = new System.Windows.Forms.NumericUpDown();
            this.Bricks1 = new System.Windows.Forms.Label();
            this.Rows1 = new System.Windows.Forms.Label();
            this.Bricks2 = new System.Windows.Forms.Label();
            this.Rows2 = new System.Windows.Forms.Label();
            this.greenLabel2 = new System.Windows.Forms.Label();
            this.blueLabel2 = new System.Windows.Forms.Label();
            this.yellowLabel2 = new System.Windows.Forms.Label();
            this.redLabel2 = new System.Windows.Forms.Label();
            this.greenHit = new System.Windows.Forms.Label();
            this.blueHit = new System.Windows.Forms.Label();
            this.yellowHit = new System.Windows.Forms.Label();
            this.redHit = new System.Windows.Forms.Label();
            this.instLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBrick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBrick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBrick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBrick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLines)).BeginInit();
            this.SuspendLayout();
            // 
            // BrickLabel
            // 
            this.BrickLabel.AutoSize = true;
            this.BrickLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrickLabel.ForeColor = System.Drawing.Color.Orange;
            this.BrickLabel.Location = new System.Drawing.Point(45, 81);
            this.BrickLabel.Name = "BrickLabel";
            this.BrickLabel.Size = new System.Drawing.Size(282, 129);
            this.BrickLabel.TabIndex = 2;
            this.BrickLabel.Text = "Select the number of \r\nBricks for each color\r\n(between 0 to 12):";
            this.BrickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Arkanoid.Properties.Resources.Settings2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1230, 605);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // redBrick
            // 
            this.redBrick.Location = new System.Drawing.Point(248, 479);
            this.redBrick.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.redBrick.Name = "redBrick";
            this.redBrick.Size = new System.Drawing.Size(79, 26);
            this.redBrick.TabIndex = 16;
            this.redBrick.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLabel.ForeColor = System.Drawing.Color.White;
            this.RedLabel.Location = new System.Drawing.Point(255, 421);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(59, 38);
            this.RedLabel.TabIndex = 18;
            this.RedLabel.Text = "Red";
            this.RedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yellowBrick
            // 
            this.yellowBrick.Location = new System.Drawing.Point(57, 479);
            this.yellowBrick.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.yellowBrick.Name = "yellowBrick";
            this.yellowBrick.Size = new System.Drawing.Size(79, 26);
            this.yellowBrick.TabIndex = 15;
            this.yellowBrick.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // YellowLabel
            // 
            this.YellowLabel.AutoSize = true;
            this.YellowLabel.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowLabel.ForeColor = System.Drawing.Color.White;
            this.YellowLabel.Location = new System.Drawing.Point(51, 421);
            this.YellowLabel.Name = "YellowLabel";
            this.YellowLabel.Size = new System.Drawing.Size(86, 38);
            this.YellowLabel.TabIndex = 17;
            this.YellowLabel.Text = "Yellow";
            this.YellowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueBrick
            // 
            this.blueBrick.Location = new System.Drawing.Point(248, 300);
            this.blueBrick.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.blueBrick.Name = "blueBrick";
            this.blueBrick.Size = new System.Drawing.Size(79, 26);
            this.blueBrick.TabIndex = 14;
            this.blueBrick.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueLabel.ForeColor = System.Drawing.Color.White;
            this.BlueLabel.Location = new System.Drawing.Point(255, 240);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(63, 38);
            this.BlueLabel.TabIndex = 13;
            this.BlueLabel.Text = "Blue";
            this.BlueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenLabel.ForeColor = System.Drawing.Color.White;
            this.GreenLabel.Location = new System.Drawing.Point(53, 240);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(82, 38);
            this.GreenLabel.TabIndex = 12;
            this.GreenLabel.Text = "Green";
            this.GreenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenBrick
            // 
            this.greenBrick.Location = new System.Drawing.Point(57, 300);
            this.greenBrick.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.greenBrick.Name = "greenBrick";
            this.greenBrick.Size = new System.Drawing.Size(79, 26);
            this.greenBrick.TabIndex = 11;
            this.greenBrick.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // RowsLabel
            // 
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowsLabel.ForeColor = System.Drawing.Color.Orange;
            this.RowsLabel.Location = new System.Drawing.Point(906, 81);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(282, 129);
            this.RowsLabel.TabIndex = 19;
            this.RowsLabel.Text = "Select the number of \r\nROWS for each Brick\r\n(between 0 to 3):\r\n";
            this.RowsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Lime;
            this.startButton.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(450, 510);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(335, 82);
            this.startButton.TabIndex = 21;
            this.startButton.Text = "PLAY GAME";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // greenLines
            // 
            this.greenLines.Location = new System.Drawing.Point(916, 298);
            this.greenLines.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.greenLines.Name = "greenLines";
            this.greenLines.Size = new System.Drawing.Size(79, 26);
            this.greenLines.TabIndex = 22;
            this.greenLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // blueLines
            // 
            this.blueLines.Location = new System.Drawing.Point(1107, 298);
            this.blueLines.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.blueLines.Name = "blueLines";
            this.blueLines.Size = new System.Drawing.Size(79, 26);
            this.blueLines.TabIndex = 23;
            this.blueLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yellowLines
            // 
            this.yellowLines.Location = new System.Drawing.Point(916, 479);
            this.yellowLines.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.yellowLines.Name = "yellowLines";
            this.yellowLines.Size = new System.Drawing.Size(79, 26);
            this.yellowLines.TabIndex = 24;
            this.yellowLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // redLines
            // 
            this.redLines.Location = new System.Drawing.Point(1107, 479);
            this.redLines.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.redLines.Name = "redLines";
            this.redLines.Size = new System.Drawing.Size(79, 26);
            this.redLines.TabIndex = 25;
            this.redLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bricks1
            // 
            this.Bricks1.AutoSize = true;
            this.Bricks1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bricks1.ForeColor = System.Drawing.Color.White;
            this.Bricks1.Location = new System.Drawing.Point(154, 293);
            this.Bricks1.Name = "Bricks1";
            this.Bricks1.Size = new System.Drawing.Size(76, 35);
            this.Bricks1.TabIndex = 26;
            this.Bricks1.Text = "Bricks";
            this.Bricks1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rows1
            // 
            this.Rows1.AutoSize = true;
            this.Rows1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rows1.ForeColor = System.Drawing.Color.White;
            this.Rows1.Location = new System.Drawing.Point(1017, 291);
            this.Rows1.Name = "Rows1";
            this.Rows1.Size = new System.Drawing.Size(67, 35);
            this.Rows1.TabIndex = 27;
            this.Rows1.Text = "Rows";
            this.Rows1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bricks2
            // 
            this.Bricks2.AutoSize = true;
            this.Bricks2.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bricks2.ForeColor = System.Drawing.Color.White;
            this.Bricks2.Location = new System.Drawing.Point(154, 472);
            this.Bricks2.Name = "Bricks2";
            this.Bricks2.Size = new System.Drawing.Size(76, 35);
            this.Bricks2.TabIndex = 28;
            this.Bricks2.Text = "Bricks";
            this.Bricks2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rows2
            // 
            this.Rows2.AutoSize = true;
            this.Rows2.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rows2.ForeColor = System.Drawing.Color.White;
            this.Rows2.Location = new System.Drawing.Point(1017, 472);
            this.Rows2.Name = "Rows2";
            this.Rows2.Size = new System.Drawing.Size(67, 35);
            this.Rows2.TabIndex = 29;
            this.Rows2.Text = "Rows";
            this.Rows2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenLabel2
            // 
            this.greenLabel2.AutoSize = true;
            this.greenLabel2.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLabel2.ForeColor = System.Drawing.Color.White;
            this.greenLabel2.Location = new System.Drawing.Point(913, 240);
            this.greenLabel2.Name = "greenLabel2";
            this.greenLabel2.Size = new System.Drawing.Size(82, 38);
            this.greenLabel2.TabIndex = 30;
            this.greenLabel2.Text = "Green";
            this.greenLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueLabel2
            // 
            this.blueLabel2.AutoSize = true;
            this.blueLabel2.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel2.ForeColor = System.Drawing.Color.White;
            this.blueLabel2.Location = new System.Drawing.Point(1112, 240);
            this.blueLabel2.Name = "blueLabel2";
            this.blueLabel2.Size = new System.Drawing.Size(63, 38);
            this.blueLabel2.TabIndex = 31;
            this.blueLabel2.Text = "Blue";
            this.blueLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yellowLabel2
            // 
            this.yellowLabel2.AutoSize = true;
            this.yellowLabel2.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLabel2.ForeColor = System.Drawing.Color.White;
            this.yellowLabel2.Location = new System.Drawing.Point(911, 421);
            this.yellowLabel2.Name = "yellowLabel2";
            this.yellowLabel2.Size = new System.Drawing.Size(86, 38);
            this.yellowLabel2.TabIndex = 32;
            this.yellowLabel2.Text = "Yellow";
            this.yellowLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redLabel2
            // 
            this.redLabel2.AutoSize = true;
            this.redLabel2.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel2.ForeColor = System.Drawing.Color.White;
            this.redLabel2.Location = new System.Drawing.Point(1114, 421);
            this.redLabel2.Name = "redLabel2";
            this.redLabel2.Size = new System.Drawing.Size(59, 38);
            this.redLabel2.TabIndex = 33;
            this.redLabel2.Text = "Red";
            this.redLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenHit
            // 
            this.greenHit.AutoSize = true;
            this.greenHit.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenHit.ForeColor = System.Drawing.Color.White;
            this.greenHit.Location = new System.Drawing.Point(62, 334);
            this.greenHit.Name = "greenHit";
            this.greenHit.Size = new System.Drawing.Size(69, 35);
            this.greenHit.TabIndex = 34;
            this.greenHit.Text = "1 Hit";
            this.greenHit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueHit
            // 
            this.blueHit.AutoSize = true;
            this.blueHit.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueHit.ForeColor = System.Drawing.Color.White;
            this.blueHit.Location = new System.Drawing.Point(249, 334);
            this.blueHit.Name = "blueHit";
            this.blueHit.Size = new System.Drawing.Size(77, 35);
            this.blueHit.TabIndex = 35;
            this.blueHit.Text = "2 Hits";
            this.blueHit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yellowHit
            // 
            this.yellowHit.AutoSize = true;
            this.yellowHit.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowHit.ForeColor = System.Drawing.Color.White;
            this.yellowHit.Location = new System.Drawing.Point(58, 514);
            this.yellowHit.Name = "yellowHit";
            this.yellowHit.Size = new System.Drawing.Size(77, 35);
            this.yellowHit.TabIndex = 36;
            this.yellowHit.Text = "3 Hits";
            this.yellowHit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redHit
            // 
            this.redHit.AutoSize = true;
            this.redHit.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redHit.ForeColor = System.Drawing.Color.White;
            this.redHit.Location = new System.Drawing.Point(249, 514);
            this.redHit.Name = "redHit";
            this.redHit.Size = new System.Drawing.Size(77, 35);
            this.redHit.TabIndex = 37;
            this.redHit.Text = "4 Hits";
            this.redHit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instLabel
            // 
            this.instLabel.AutoSize = true;
            this.instLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instLabel.ForeColor = System.Drawing.Color.Orange;
            this.instLabel.Location = new System.Drawing.Point(263, 13);
            this.instLabel.Name = "instLabel";
            this.instLabel.Size = new System.Drawing.Size(701, 43);
            this.instLabel.TabIndex = 38;
            this.instLabel.Text = "Please set the number of Bricks and rows for each color\r\n";
            this.instLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 604);
            this.Controls.Add(this.instLabel);
            this.Controls.Add(this.redHit);
            this.Controls.Add(this.yellowHit);
            this.Controls.Add(this.blueHit);
            this.Controls.Add(this.greenHit);
            this.Controls.Add(this.redLabel2);
            this.Controls.Add(this.yellowLabel2);
            this.Controls.Add(this.blueLabel2);
            this.Controls.Add(this.greenLabel2);
            this.Controls.Add(this.Rows2);
            this.Controls.Add(this.Bricks2);
            this.Controls.Add(this.Rows1);
            this.Controls.Add(this.Bricks1);
            this.Controls.Add(this.redLines);
            this.Controls.Add(this.yellowLines);
            this.Controls.Add(this.blueLines);
            this.Controls.Add(this.greenLines);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.RowsLabel);
            this.Controls.Add(this.redBrick);
            this.Controls.Add(this.RedLabel);
            this.Controls.Add(this.yellowBrick);
            this.Controls.Add(this.YellowLabel);
            this.Controls.Add(this.blueBrick);
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.GreenLabel);
            this.Controls.Add(this.greenBrick);
            this.Controls.Add(this.BrickLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SettingsScreen";
            this.Text = "SettingsScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBrick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBrick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBrick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBrick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BrickLabel;
        private System.Windows.Forms.NumericUpDown redBrick;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.NumericUpDown yellowBrick;
        private System.Windows.Forms.Label YellowLabel;
        private System.Windows.Forms.NumericUpDown blueBrick;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.NumericUpDown greenBrick;
        private System.Windows.Forms.Label RowsLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown greenLines;
        private System.Windows.Forms.NumericUpDown blueLines;
        private System.Windows.Forms.NumericUpDown yellowLines;
        private System.Windows.Forms.NumericUpDown redLines;
        private System.Windows.Forms.Label Bricks1;
        private System.Windows.Forms.Label Rows1;
        private System.Windows.Forms.Label Bricks2;
        private System.Windows.Forms.Label Rows2;
        private System.Windows.Forms.Label greenLabel2;
        private System.Windows.Forms.Label blueLabel2;
        private System.Windows.Forms.Label yellowLabel2;
        private System.Windows.Forms.Label redLabel2;
        private System.Windows.Forms.Label greenHit;
        private System.Windows.Forms.Label blueHit;
        private System.Windows.Forms.Label yellowHit;
        private System.Windows.Forms.Label redHit;
        private System.Windows.Forms.Label instLabel;
    }
}