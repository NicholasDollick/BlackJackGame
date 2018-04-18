using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Liphsoft.Crypto.Argon2;
using System.Security.Cryptography;

namespace BlackJackGame
{
    public partial class LoginContainer : Form
    {
        Database databaseObject = new Database();
        PasswordHasher hasher = new PasswordHasher();
        static string displayName = "guest";

        public LoginContainer()
        {
            InitializeComponent();
        }

        private void createAccButton_Click(object sender, EventArgs e)
        {
            string myhash = "";
            string query = "INSERT INTO users (username, password) VALUES (?, ?)";


            if (userName.Text.Equals("") || userName.Text.Equals("choose a username"))
                MessageBox.Show("Please Enter A Username");
            else if(pass.Text.Equals(""))
                MessageBox.Show("Please Enter A Password");
            else if(passConf.Text.Equals(""))
                MessageBox.Show("Please Confirm Your Password");
            else if (pass.Text.Equals(passConf.Text))
            {
                myhash = hasher.Hash(pass.Text);
                SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
                myCommand.Parameters.AddWithValue("@username", userName.Text);
                myCommand.Parameters.AddWithValue("@password", myhash);
                databaseObject.OpenConnection();
                myCommand.ExecuteNonQuery();
                databaseObject.CloseConnection();
                MessageBox.Show("Account Created! You may now log in!");
                clearCreate();
            }
            else
                MessageBox.Show("Your Passwords Don't Match");
                 
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            string expectedPass = "";
            string query = "SELECT password FROM users WHERE username = ?";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            myCommand.Parameters.AddWithValue("@username", userNameLog.Text);
            databaseObject.OpenConnection();
            SQLiteDataReader reader = myCommand.ExecuteReader();
            while(reader.Read())
            {
                expectedPass = reader["password"].ToString();
            }
            databaseObject.CloseConnection();

            if (expectedPass.Equals("") || userName.Text.Equals("username")) //the query will only get values on valid usernames. If the fetched pass is still the default value, the username must not exist.
                MessageBox.Show("Username does not exist");
            else if (hasher.Verify(expectedPass, passLog.Text))
            {
                displayName = userNameLog.Text;
                this.Hide();

                Game game = new Game();
                game.ShowDialog();
            }
            else
                MessageBox.Show("Invalid Pass");

        }

        //mild bug here
        private void clearCreate()
        {
            userName.ForeColor = Color.Gray;
            pass.ForeColor = Color.Gray;
            passConf.ForeColor = Color.Gray;
            pass.UseSystemPasswordChar = false;
            passConf.UseSystemPasswordChar = false;
            userName.Text = "choose a username";
            pass.Text = "password";
            passConf.Text = "verify password";
        }

        //begin a series of functions to provide neat UI elements
        private void userName_Enter(object sender, EventArgs e)
        {
            if(userName.Text == "choose a username")
            {
                userName.Text = "";

                userName.ForeColor = Color.Black;
            }
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
                userName.Text = "choose a username";

                userName.ForeColor = Color.Gray;
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "password")
            {
                pass.Text = "";
                pass.UseSystemPasswordChar = true;
                pass.ForeColor = Color.Black;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "password";
                pass.UseSystemPasswordChar = false;
                pass.ForeColor = Color.Gray;
            }
        }
        

        private void passConf_Enter(object sender, EventArgs e)
        {
            if (passConf.Text == "verify password")
            {
                passConf.Text = "";
                passConf.UseSystemPasswordChar = true;
                passConf.ForeColor = Color.Black;
            }
        }

        private void passConf_Leave(object sender, EventArgs e)
        {
            if (passConf.Text == "")
            {
                passConf.Text = "verify password";
                passConf.UseSystemPasswordChar = false;
                passConf.ForeColor = Color.Gray;
            }
        }

        private void userNameLog_Enter(object sender, EventArgs e)
        {
            if (userNameLog.Text == "username")
            {
                userNameLog.Text = "";

                userNameLog.ForeColor = Color.Black;
            }
        }

        private void userNameLog_Leave(object sender, EventArgs e)
        {
            if (userNameLog.Text == "")
            {
                userNameLog.Text = "username";

                userNameLog.ForeColor = Color.Gray;
            }
        }

        private void passLog_Enter(object sender, EventArgs e)
        {
            if (passLog.Text == "password")
            {
                passLog.Text = "";
                passLog.UseSystemPasswordChar = true;
                passLog.ForeColor = Color.Black;
            }
        }

        private void passLog_Leave(object sender, EventArgs e)
        {
            if (passLog.Text == "")
            {
                passLog.Text = "password";
                passLog.UseSystemPasswordChar = false;
                passLog.ForeColor = Color.Gray;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Game game = new Game();
            game.ShowDialog();
        }

        private void guestPlay_Click(object sender, EventArgs e)
        {
            this.Hide();

            Game game = new Game();
            game.ShowDialog();
        }

        public static string GetPlayerName()
        {
            return displayName;
        }
    }

    
}
