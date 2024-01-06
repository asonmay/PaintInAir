
namespace MS_PaintInAir
{
    partial class PaintInAir
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CanvasWindow = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BLabel = new System.Windows.Forms.Label();
            this.GLabel = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.BTrackBar = new System.Windows.Forms.TrackBar();
            this.GTrackBar = new System.Windows.Forms.TrackBar();
            this.RTrackBar = new System.Windows.Forms.TrackBar();
            this.WhiteButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.PinkButton = new System.Windows.Forms.Button();
            this.PurpleButton = new System.Windows.Forms.Button();
            this.OrangeButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.LightBlueButton = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.BrushSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CanvasWindow)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrushSizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // CanvasWindow
            // 
            this.CanvasWindow.Location = new System.Drawing.Point(13, 13);
            this.CanvasWindow.Name = "CanvasWindow";
            this.CanvasWindow.Size = new System.Drawing.Size(617, 332);
            this.CanvasWindow.TabIndex = 0;
            this.CanvasWindow.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.BLabel);
            this.panel1.Controls.Add(this.GLabel);
            this.panel1.Controls.Add(this.RLabel);
            this.panel1.Controls.Add(this.BTrackBar);
            this.panel1.Controls.Add(this.GTrackBar);
            this.panel1.Controls.Add(this.RTrackBar);
            this.panel1.Controls.Add(this.WhiteButton);
            this.panel1.Controls.Add(this.BlueButton);
            this.panel1.Controls.Add(this.PinkButton);
            this.panel1.Controls.Add(this.PurpleButton);
            this.panel1.Controls.Add(this.OrangeButton);
            this.panel1.Controls.Add(this.YellowButton);
            this.panel1.Controls.Add(this.GreenButton);
            this.panel1.Controls.Add(this.LightBlueButton);
            this.panel1.Controls.Add(this.RedButton);
            this.panel1.Controls.Add(this.BrushSizeTrackBar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 102);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Erase ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(539, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 96);
            this.SaveButton.TabIndex = 18;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BLabel.Location = new System.Drawing.Point(424, 32);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(30, 17);
            this.BLabel.TabIndex = 17;
            this.BLabel.Text = "B: 0";
            // 
            // GLabel
            // 
            this.GLabel.AutoSize = true;
            this.GLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GLabel.Location = new System.Drawing.Point(305, 32);
            this.GLabel.Name = "GLabel";
            this.GLabel.Size = new System.Drawing.Size(31, 17);
            this.GLabel.TabIndex = 16;
            this.GLabel.Text = "G: 0";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RLabel.Location = new System.Drawing.Point(186, 32);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(44, 17);
            this.RLabel.TabIndex = 15;
            this.RLabel.Text = "R: 255";
            // 
            // BTrackBar
            // 
            this.BTrackBar.Location = new System.Drawing.Point(424, 51);
            this.BTrackBar.Maximum = 255;
            this.BTrackBar.Name = "BTrackBar";
            this.BTrackBar.Size = new System.Drawing.Size(113, 45);
            this.BTrackBar.TabIndex = 14;
            this.BTrackBar.Scroll += new System.EventHandler(this.BTrackBar_Scroll);
            // 
            // GTrackBar
            // 
            this.GTrackBar.Location = new System.Drawing.Point(305, 51);
            this.GTrackBar.Maximum = 255;
            this.GTrackBar.Name = "GTrackBar";
            this.GTrackBar.Size = new System.Drawing.Size(113, 45);
            this.GTrackBar.TabIndex = 13;
            this.GTrackBar.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // RTrackBar
            // 
            this.RTrackBar.Location = new System.Drawing.Point(186, 51);
            this.RTrackBar.Maximum = 255;
            this.RTrackBar.Name = "RTrackBar";
            this.RTrackBar.Size = new System.Drawing.Size(113, 45);
            this.RTrackBar.TabIndex = 12;
            this.RTrackBar.Value = 255;
            this.RTrackBar.Scroll += new System.EventHandler(this.RTrackBar_Scroll);
            // 
            // WhiteButton
            // 
            this.WhiteButton.BackColor = System.Drawing.Color.White;
            this.WhiteButton.ForeColor = System.Drawing.Color.Red;
            this.WhiteButton.Location = new System.Drawing.Point(508, 4);
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.Size = new System.Drawing.Size(25, 25);
            this.WhiteButton.TabIndex = 11;
            this.WhiteButton.Text = " ";
            this.WhiteButton.UseVisualStyleBackColor = false;
            this.WhiteButton.Click += new System.EventHandler(this.WhiteButton_Click);
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.Blue;
            this.BlueButton.ForeColor = System.Drawing.Color.Red;
            this.BlueButton.Location = new System.Drawing.Point(391, 4);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(25, 25);
            this.BlueButton.TabIndex = 9;
            this.BlueButton.Text = " ";
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // PinkButton
            // 
            this.PinkButton.BackColor = System.Drawing.Color.Violet;
            this.PinkButton.ForeColor = System.Drawing.Color.Red;
            this.PinkButton.Location = new System.Drawing.Point(430, 4);
            this.PinkButton.Name = "PinkButton";
            this.PinkButton.Size = new System.Drawing.Size(25, 25);
            this.PinkButton.TabIndex = 8;
            this.PinkButton.Text = " ";
            this.PinkButton.UseVisualStyleBackColor = false;
            this.PinkButton.Click += new System.EventHandler(this.PinkButton_Click);
            // 
            // PurpleButton
            // 
            this.PurpleButton.BackColor = System.Drawing.Color.Purple;
            this.PurpleButton.ForeColor = System.Drawing.Color.Red;
            this.PurpleButton.Location = new System.Drawing.Point(469, 4);
            this.PurpleButton.Name = "PurpleButton";
            this.PurpleButton.Size = new System.Drawing.Size(25, 25);
            this.PurpleButton.TabIndex = 7;
            this.PurpleButton.Text = " ";
            this.PurpleButton.UseVisualStyleBackColor = false;
            this.PurpleButton.Click += new System.EventHandler(this.PurpleButton_Click);
            // 
            // OrangeButton
            // 
            this.OrangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OrangeButton.ForeColor = System.Drawing.Color.Red;
            this.OrangeButton.Location = new System.Drawing.Point(236, 4);
            this.OrangeButton.Name = "OrangeButton";
            this.OrangeButton.Size = new System.Drawing.Size(25, 25);
            this.OrangeButton.TabIndex = 6;
            this.OrangeButton.Text = " ";
            this.OrangeButton.UseVisualStyleBackColor = false;
            this.OrangeButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.Yellow;
            this.YellowButton.ForeColor = System.Drawing.Color.Red;
            this.YellowButton.Location = new System.Drawing.Point(275, 4);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(25, 25);
            this.YellowButton.TabIndex = 5;
            this.YellowButton.Text = " ";
            this.YellowButton.UseVisualStyleBackColor = false;
            this.YellowButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.Lime;
            this.GreenButton.ForeColor = System.Drawing.Color.Red;
            this.GreenButton.Location = new System.Drawing.Point(314, 4);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(25, 25);
            this.GreenButton.TabIndex = 4;
            this.GreenButton.Text = " ";
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // LightBlueButton
            // 
            this.LightBlueButton.BackColor = System.Drawing.Color.Aqua;
            this.LightBlueButton.ForeColor = System.Drawing.Color.Red;
            this.LightBlueButton.Location = new System.Drawing.Point(352, 4);
            this.LightBlueButton.Name = "LightBlueButton";
            this.LightBlueButton.Size = new System.Drawing.Size(25, 25);
            this.LightBlueButton.TabIndex = 3;
            this.LightBlueButton.Text = " ";
            this.LightBlueButton.UseVisualStyleBackColor = false;
            this.LightBlueButton.Click += new System.EventHandler(this.LightBlueButton_Click);
            // 
            // RedButton
            // 
            this.RedButton.BackColor = System.Drawing.Color.Red;
            this.RedButton.ForeColor = System.Drawing.Color.Red;
            this.RedButton.Location = new System.Drawing.Point(197, 4);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(25, 25);
            this.RedButton.TabIndex = 2;
            this.RedButton.Text = " ";
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrushSizeTrackBar
            // 
            this.BrushSizeTrackBar.Location = new System.Drawing.Point(3, 51);
            this.BrushSizeTrackBar.Maximum = 30;
            this.BrushSizeTrackBar.Name = "BrushSizeTrackBar";
            this.BrushSizeTrackBar.Size = new System.Drawing.Size(185, 45);
            this.BrushSizeTrackBar.TabIndex = 1;
            this.BrushSizeTrackBar.TabStop = false;
            this.BrushSizeTrackBar.Value = 10;
            this.BrushSizeTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brush Size: 10";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Rectangle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Line";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // PaintInAir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(645, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CanvasWindow);
            this.KeyPreview = true;
            this.Name = "PaintInAir";
            this.Text = "Paint in Air";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CanvasWindow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrushSizeTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CanvasWindow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar BrushSizeTrackBar;
        private System.Windows.Forms.Button WhiteButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button PinkButton;
        private System.Windows.Forms.Button PurpleButton;
        private System.Windows.Forms.Button OrangeButton;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button LightBlueButton;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.TrackBar BTrackBar;
        private System.Windows.Forms.TrackBar GTrackBar;
        private System.Windows.Forms.TrackBar RTrackBar;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label GLabel;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

