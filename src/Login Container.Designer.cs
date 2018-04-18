namespace BlackJackGame
{
    partial class LoginContainer
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
            this.createAccButton = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.passConf = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.userNameLog = new System.Windows.Forms.TextBox();
            this.passLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.guestPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createAccButton
            // 
            this.createAccButton.BackColor = System.Drawing.SystemColors.Menu;
            this.createAccButton.Location = new System.Drawing.Point(83, 123);
            this.createAccButton.Name = "createAccButton";
            this.createAccButton.Size = new System.Drawing.Size(57, 23);
            this.createAccButton.TabIndex = 0;
            this.createAccButton.Text = "Sign Up";
            this.createAccButton.UseVisualStyleBackColor = false;
            this.createAccButton.Click += new System.EventHandler(this.createAccButton_Click);
            // 
            // userName
            // 
            this.userName.ForeColor = System.Drawing.Color.Gray;
            this.userName.Location = new System.Drawing.Point(16, 30);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(124, 20);
            this.userName.TabIndex = 1;
            this.userName.Text = "choose a username";
            this.userName.Enter += new System.EventHandler(this.userName_Enter);
            this.userName.Leave += new System.EventHandler(this.userName_Leave);
            // 
            // pass
            // 
            this.pass.ForeColor = System.Drawing.Color.Gray;
            this.pass.Location = new System.Drawing.Point(16, 61);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(124, 20);
            this.pass.TabIndex = 2;
            this.pass.Text = "password";
            this.pass.Enter += new System.EventHandler(this.pass_Enter);
            this.pass.Leave += new System.EventHandler(this.pass_Leave);
            // 
            // passConf
            // 
            this.passConf.ForeColor = System.Drawing.Color.Gray;
            this.passConf.Location = new System.Drawing.Point(16, 92);
            this.passConf.Name = "passConf";
            this.passConf.Size = new System.Drawing.Size(124, 20);
            this.passConf.TabIndex = 3;
            this.passConf.Text = "verify password";
            this.passConf.Enter += new System.EventHandler(this.passConf_Enter);
            this.passConf.Leave += new System.EventHandler(this.passConf_Leave);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(82, 92);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(57, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userNameLog
            // 
            this.userNameLog.ForeColor = System.Drawing.Color.Gray;
            this.userNameLog.Location = new System.Drawing.Point(15, 30);
            this.userNameLog.Name = "userNameLog";
            this.userNameLog.Size = new System.Drawing.Size(124, 20);
            this.userNameLog.TabIndex = 5;
            this.userNameLog.Text = "username";
            this.userNameLog.Enter += new System.EventHandler(this.userNameLog_Enter);
            this.userNameLog.Leave += new System.EventHandler(this.userNameLog_Leave);
            // 
            // passLog
            // 
            this.passLog.ForeColor = System.Drawing.Color.Gray;
            this.passLog.Location = new System.Drawing.Point(15, 61);
            this.passLog.Name = "passLog";
            this.passLog.Size = new System.Drawing.Size(124, 20);
            this.passLog.TabIndex = 6;
            this.passLog.Text = "password";
            this.passLog.Enter += new System.EventHandler(this.passLog_Enter);
            this.passLog.Leave += new System.EventHandler(this.passLog_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.passConf);
            this.groupBox1.Controls.Add(this.createAccButton);
            this.groupBox1.Location = new System.Drawing.Point(48, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 163);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create A New Account";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userNameLog);
            this.groupBox2.Controls.Add(this.passLog);
            this.groupBox2.Controls.Add(this.loginButton);
            this.groupBox2.Location = new System.Drawing.Point(238, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 131);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sign in";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(355, 186);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(57, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // guestPlay
            // 
            this.guestPlay.Location = new System.Drawing.Point(238, 186);
            this.guestPlay.Name = "guestPlay";
            this.guestPlay.Size = new System.Drawing.Size(111, 23);
            this.guestPlay.TabIndex = 10;
            this.guestPlay.Text = "Continue As Guest";
            this.guestPlay.UseVisualStyleBackColor = true;
            this.guestPlay.Click += new System.EventHandler(this.guestPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hard Sports", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "Issa Blackjack Game";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-11, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Admin Bypass";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(464, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guestPlay);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shitty BlackJack";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAccButton;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox passConf;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox userNameLog;
        private System.Windows.Forms.TextBox passLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button guestPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

