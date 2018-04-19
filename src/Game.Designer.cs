namespace BlackJackGame
{
    partial class Game
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
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.standButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.splashImage = new System.Windows.Forms.PictureBox();
            this.trainerOn = new System.Windows.Forms.RadioButton();
            this.trainerOff = new System.Windows.Forms.RadioButton();
            this.idealMoveLabel = new System.Windows.Forms.Label();
            this.trainerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splashImage)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(282, 341);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(377, 341);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.Color.Transparent;
            this.hitButton.Enabled = false;
            this.hitButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.hitButton.Image = global::BlackJackGame.Properties.Resources.hitButtonImage;
            this.hitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hitButton.Location = new System.Drawing.Point(325, 190);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 27);
            this.hitButton.TabIndex = 3;
            this.hitButton.Text = "  Hit";
            this.hitButton.UseVisualStyleBackColor = false;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "12";
            // 
            // standButton
            // 
            this.standButton.Enabled = false;
            this.standButton.Image = global::BlackJackGame.Properties.Resources.standButtonImage;
            this.standButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.standButton.Location = new System.Drawing.Point(325, 223);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(75, 27);
            this.standButton.TabIndex = 5;
            this.standButton.Text = "     Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(357, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Player";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.Image = global::BlackJackGame.Properties.Resources.splitButton;
            this.button2.Location = new System.Drawing.Point(325, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 10;
            this.button2.Text = "       Split";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // splashImage
            // 
            this.splashImage.BackColor = System.Drawing.Color.Transparent;
            this.splashImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splashImage.Image = global::BlackJackGame.Properties.Resources.splashImage;
            this.splashImage.Location = new System.Drawing.Point(2, -18);
            this.splashImage.Name = "splashImage";
            this.splashImage.Size = new System.Drawing.Size(505, 560);
            this.splashImage.TabIndex = 9;
            this.splashImage.TabStop = false;
            // 
            // trainerOn
            // 
            this.trainerOn.AutoSize = true;
            this.trainerOn.BackColor = System.Drawing.Color.Transparent;
            this.trainerOn.Location = new System.Drawing.Point(324, 306);
            this.trainerOn.Name = "trainerOn";
            this.trainerOn.Size = new System.Drawing.Size(14, 13);
            this.trainerOn.TabIndex = 11;
            this.trainerOn.TabStop = true;
            this.trainerOn.UseVisualStyleBackColor = false;
            // 
            // trainerOff
            // 
            this.trainerOff.AutoSize = true;
            this.trainerOff.BackColor = System.Drawing.Color.Transparent;
            this.trainerOff.Location = new System.Drawing.Point(374, 306);
            this.trainerOff.Name = "trainerOff";
            this.trainerOff.Size = new System.Drawing.Size(14, 13);
            this.trainerOff.TabIndex = 12;
            this.trainerOff.TabStop = true;
            this.trainerOff.UseVisualStyleBackColor = false;
            // 
            // idealMoveLabel
            // 
            this.idealMoveLabel.AutoSize = true;
            this.idealMoveLabel.BackColor = System.Drawing.Color.Transparent;
            this.idealMoveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idealMoveLabel.Location = new System.Drawing.Point(266, 409);
            this.idealMoveLabel.Name = "idealMoveLabel";
            this.idealMoveLabel.Size = new System.Drawing.Size(91, 17);
            this.idealMoveLabel.TabIndex = 13;
            this.idealMoveLabel.Text = "Ideal Move:";
            // 
            // trainerLabel
            // 
            this.trainerLabel.AutoSize = true;
            this.trainerLabel.BackColor = System.Drawing.Color.Transparent;
            this.trainerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainerLabel.Location = new System.Drawing.Point(357, 409);
            this.trainerLabel.Name = "trainerLabel";
            this.trainerLabel.Size = new System.Drawing.Size(91, 17);
            this.trainerLabel.TabIndex = 14;
            this.trainerLabel.Text = "Ideal Move:";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = global::BlackJackGame.Properties.Resources.GUI2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(460, 490);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trainerOff);
            this.Controls.Add(this.trainerOn);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.splashImage);
            this.Controls.Add(this.trainerLabel);
            this.Controls.Add(this.idealMoveLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.splashImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox splashImage;
        private System.Windows.Forms.RadioButton trainerOn;
        private System.Windows.Forms.RadioButton trainerOff;
        private System.Windows.Forms.Label idealMoveLabel;
        private System.Windows.Forms.Label trainerLabel;
    }
}