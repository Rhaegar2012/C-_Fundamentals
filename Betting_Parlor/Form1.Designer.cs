namespace Betting_Parlor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.betterLabel = new System.Windows.Forms.Label();
            this.betsButton = new System.Windows.Forms.Button();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.betCounter = new System.Windows.Forms.NumericUpDown();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dogCounter = new System.Windows.Forms.NumericUpDown();
            this.raceButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.dog1PictureBox = new System.Windows.Forms.PictureBox();
            this.dog2PictureBox = new System.Windows.Forms.PictureBox();
            this.dog3PictureBox = new System.Windows.Forms.PictureBox();
            this.dog4PictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.betAgainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.Image = ((System.Drawing.Image)(resources.GetObject("raceTrack.Image")));
            this.raceTrack.Location = new System.Drawing.Point(12, 12);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(776, 224);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrack.TabIndex = 0;
            this.raceTrack.TabStop = false;
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(48, 290);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(126, 21);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(48, 317);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(131, 21);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(48, 344);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(118, 21);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            // 
            // betterLabel
            // 
            this.betterLabel.AutoSize = true;
            this.betterLabel.Location = new System.Drawing.Point(45, 408);
            this.betterLabel.Name = "betterLabel";
            this.betterLabel.Size = new System.Drawing.Size(43, 17);
            this.betterLabel.TabIndex = 4;
            this.betterLabel.Text = "name";
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(109, 402);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(82, 28);
            this.betsButton.TabIndex = 5;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.AutoSize = true;
            this.joeBetLabel.Location = new System.Drawing.Point(269, 290);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(83, 17);
            this.joeBetLabel.TabIndex = 6;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // betCounter
            // 
            this.betCounter.Location = new System.Drawing.Point(224, 406);
            this.betCounter.Name = "betCounter";
            this.betCounter.Size = new System.Drawing.Size(120, 22);
            this.betCounter.TabIndex = 7;
            // 
            // alBetLabel
            // 
            this.alBetLabel.AutoSize = true;
            this.alBetLabel.Location = new System.Drawing.Point(269, 346);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(75, 17);
            this.alBetLabel.TabIndex = 8;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.AutoSize = true;
            this.bobBetLabel.Location = new System.Drawing.Point(269, 317);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(88, 17);
            this.bobBetLabel.TabIndex = 9;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "bucks on dog number";
            // 
            // dogCounter
            // 
            this.dogCounter.Location = new System.Drawing.Point(518, 406);
            this.dogCounter.Name = "dogCounter";
            this.dogCounter.Size = new System.Drawing.Size(120, 22);
            this.dogCounter.TabIndex = 12;
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(445, 280);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(193, 90);
            this.raceButton.TabIndex = 13;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Betting Parlor";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Location = new System.Drawing.Point(45, 270);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(119, 17);
            this.minimumBetLabel.TabIndex = 15;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // dog1PictureBox
            // 
            this.dog1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dog1PictureBox.Image")));
            this.dog1PictureBox.Location = new System.Drawing.Point(26, 27);
            this.dog1PictureBox.Name = "dog1PictureBox";
            this.dog1PictureBox.Size = new System.Drawing.Size(86, 19);
            this.dog1PictureBox.TabIndex = 16;
            this.dog1PictureBox.TabStop = false;
            // 
            // dog2PictureBox
            // 
            this.dog2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dog2PictureBox.Image")));
            this.dog2PictureBox.Location = new System.Drawing.Point(27, 78);
            this.dog2PictureBox.Name = "dog2PictureBox";
            this.dog2PictureBox.Size = new System.Drawing.Size(85, 20);
            this.dog2PictureBox.TabIndex = 17;
            this.dog2PictureBox.TabStop = false;
            // 
            // dog3PictureBox
            // 
            this.dog3PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dog3PictureBox.Image")));
            this.dog3PictureBox.Location = new System.Drawing.Point(27, 138);
            this.dog3PictureBox.Name = "dog3PictureBox";
            this.dog3PictureBox.Size = new System.Drawing.Size(85, 23);
            this.dog3PictureBox.TabIndex = 18;
            this.dog3PictureBox.TabStop = false;
            // 
            // dog4PictureBox
            // 
            this.dog4PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dog4PictureBox.Image")));
            this.dog4PictureBox.Location = new System.Drawing.Point(27, 198);
            this.dog4PictureBox.Name = "dog4PictureBox";
            this.dog4PictureBox.Size = new System.Drawing.Size(85, 24);
            this.dog4PictureBox.TabIndex = 19;
            this.dog4PictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // betAgainButton
            // 
            this.betAgainButton.Location = new System.Drawing.Point(656, 280);
            this.betAgainButton.Name = "betAgainButton";
            this.betAgainButton.Size = new System.Drawing.Size(132, 90);
            this.betAgainButton.TabIndex = 20;
            this.betAgainButton.Text = "Bet Again!";
            this.betAgainButton.UseVisualStyleBackColor = true;
            this.betAgainButton.Click += new System.EventHandler(this.betAgainButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.betAgainButton);
            this.Controls.Add(this.dog4PictureBox);
            this.Controls.Add(this.dog3PictureBox);
            this.Controls.Add(this.dog2PictureBox);
            this.Controls.Add(this.dog1PictureBox);
            this.Controls.Add(this.minimumBetLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.raceButton);
            this.Controls.Add(this.dogCounter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bobBetLabel);
            this.Controls.Add(this.alBetLabel);
            this.Controls.Add(this.betCounter);
            this.Controls.Add(this.joeBetLabel);
            this.Controls.Add(this.betsButton);
            this.Controls.Add(this.betterLabel);
            this.Controls.Add(this.alRadioButton);
            this.Controls.Add(this.bobRadioButton);
            this.Controls.Add(this.joeRadioButton);
            this.Controls.Add(this.raceTrack);
            this.Name = "Form1";
            this.Text = "Betting Parlor";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.Label betterLabel;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.NumericUpDown betCounter;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown dogCounter;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.PictureBox dog1PictureBox;
        private System.Windows.Forms.PictureBox dog2PictureBox;
        private System.Windows.Forms.PictureBox dog3PictureBox;
        private System.Windows.Forms.PictureBox dog4PictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button betAgainButton;
    }
}

