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
using WMPLib;

namespace VideoLibrary
{
    
    public partial class VideoLibraryForm : Form
    {
        public string mysavedmovies { get; set; }
        List<string> Movies = new List<string>();
        readonly string filePath = "movies.csv";
        OpenFileDialog openFileDialogPlayer;
        string username;
        string password;
        public VideoLibraryForm()
        {
            InitializeComponent();
            username = MainForm.inputUsername;
            password = MainForm.inputPassword;
        }
        

        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogPlayer = new OpenFileDialog();
            openFileDialogPlayer.FileName = string.Empty;
            openFileDialogPlayer.InitialDirectory = "C:\\";
            openFileDialogPlayer.Filter = "All files(*.*)|*.*";
            openFileDialogPlayer.FilterIndex = 2;
            openFileDialogPlayer.RestoreDirectory = true;
            if (openFileDialogPlayer.ShowDialog()==DialogResult.OK)
                try
            {
                axWindowsMediaPlayer1.URL = openFileDialogPlayer.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
                catch(Exception ex)
                {
                    MessageBox.Show("Error! Can't be read." + ex.Message, "Message for an error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void VideoLibraryForm_Load(object sender, EventArgs e)
        {
            if (username=="admin"&&password=="admin")
            {
                btnAdd.Visible = true;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                openToolStripMenuItem.Visible = true;
            }
              
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();

            if (form.ShowDialog() == DialogResult.OK )
            {
                lbMovies.Items.Add(form.MyNewMovie);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (lbMovies.SelectedItem==null)
            {
                MessageBox.Show("Select a movie!");
            }
            else
            {
                
                string element = lbMovies.SelectedItem.ToString();
                AddForm frm = new AddForm(element);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    lbMovies.Items.Add(frm.MyNewMovie);
                    
                }
            }
            
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lbMovies.Items.Remove(lbMovies.SelectedItem);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mymovie = lbMovies.SelectedItem.ToString();
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(mymovie);


                sw.Close();
            }
        }




        

        private void myMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SavedMovies form = new SavedMovies(mysavedmovies);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
           
            
            

        }
    
    


       

        

        

       
    }
}
