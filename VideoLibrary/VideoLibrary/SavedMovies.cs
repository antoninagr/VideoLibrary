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
    public partial class SavedMovies : Form
    {
        public string MySavedMovies { get; set; }
        public string mymovie { get; set; }
        public string mysavedmovies { get; set; }
        public SavedMovies()
        {
            InitializeComponent();
        }
        public SavedMovies(string movies)
        {
            InitializeComponent();
            lbSavedMovies.Text = MySavedMovies;
        }

        private void lbSavedMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShowDialog() == DialogResult.OK)
            {
                lbSavedMovies.Items.Add(mymovie);

            }
        }

        

        
    }
}
