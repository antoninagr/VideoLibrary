using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoLibrary
{
    public partial class AddForm : Form
    {
        public string MyNewMovie { get; set; }
        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(string element)
        {
            InitializeComponent();
            tbAdd.Text = element;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.MyNewMovie = tbAdd.Text;

            this.DialogResult = DialogResult.OK;
            if (tbAdd.Text.Length==0)
            {
                MessageBox.Show("Fill the field!");
                return;
            }
           
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.MyNewMovie = tbAdd.Text;

            this.DialogResult = DialogResult.OK;
            if (tbAdd.Text.Length == 0)
            {
                MessageBox.Show("Fill the field!");
                return;
            }
        }
    }
}
