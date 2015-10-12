using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBox
{
    public partial class mainForm : Form
    {
        string sqliteDB = "logs.db";

        public mainForm()
        {
            InitializeComponent();
        }

        private void addMessageButton_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection("Data Source=" + sqliteDB)) 
            {
                conn.Open();
                using (SQLiteTransaction sqlt = conn.BeginTransaction()) 
                {
                    using (SQLiteCommand command = conn.CreateCommand()) 
                    {
                        command.CommandText
                            = "insert into logs (message, posttime) values ('"+textBox.Text+"', DATETIME('now', 'localtime'));";
                        command.ExecuteNonQuery();
                    }
                    sqlt.Commit();
                }
                conn.Close();
            }

            textBox.ResetText();
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(sqliteDB)) 
            {
                using (var conn = new SQLiteConnection("Data Source=" + sqliteDB)) 
                {
                    conn.Open();
                    using (SQLiteCommand command = conn.CreateCommand())
                    {
                        command.CommandText =
                            "CREATE TABLE logs (id INTEGER PRIMARY KEY AUTOINCREMENT, message TEXT, posttime DATETIME NOT NULL);";
                        command.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox.TextLength > 0) 
            {
                addMessageButton.Enabled = true;
            }
            else
            {
                addMessageButton.Enabled = false;
            }
        }
    }
}
