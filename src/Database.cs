using System;
using System.Data.SQLite;
using System.IO;

namespace BlackJackGame
{
    class Database
    {
        public SQLiteConnection myConnection;

        public Database()
        {
            myConnection = new SQLiteConnection("Data Source=database.sqlite");

            //initialize databse with proper row/col values
            if (!File.Exists("./database.sqlite"))
            {
                string sql = "CREATE TABLE \"users\"(\"username\" TEXT NOT NULL  check(typeof(\"username\") = 'text') , \"password\" TEXT NOT NULL check(typeof(\"password\") = 'text') )";
                
                SQLiteConnection.CreateFile("database.sqlite");
                myConnection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
            }
        }

        public void OpenConnection()
        {
            if(myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}
