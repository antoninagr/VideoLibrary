using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace VideoLibrary
{
    public partial class MainForm : Form
    {
        List<string> usernames = new List<string>();
        List<string> passwords = new List<string>();
        List<string> id = new List<string>();
        List<string> user_permission = new List<string>();
        readonly string filePath = "users.csv";
        public  static string inputUsername;
        public  static string inputPassword;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string inputUsername = tbUsername.Text.Trim();
            string inputPassword = tbPassword.Text.Trim();

            if (inputUsername == "")
            {
                MessageBox.Show("Input username!");
                return;
            }

            if (inputPassword == "")
            {
                MessageBox.Show("Input password!");
                return;
            }

            if (usernames.Contains(inputUsername))
            {
                MessageBox.Show("Username exists!");
                return;
            }

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(inputUsername + "," + inputPassword+id);
                

                sw.Close();
            }

            
            usernames.Add(inputUsername);
            passwords.Add(inputPassword);
            MessageBox.Show("Sign in successful.");
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           inputUsername = tbUsername.Text;
           inputPassword = tbPassword.Text;

            bool isFound = false;
            for (int i = 0; i < usernames.Count; i++)
            {
                if (usernames[i] == inputUsername
                    && passwords[i] == inputPassword)
                {
                    isFound = true;
                    MessageBox.Show("Login successful.");
                    VideoLibraryForm videolibraryForm = new VideoLibraryForm();
                    videolibraryForm.Show();

                }
            }

            if (!isFound)
                MessageBox.Show("Invalid username/password!");
            
        }

        
    }
}

       
        
    

