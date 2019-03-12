namespace VideoLibrary
{
    partial class SavedMovies
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
            this.lbSavedMovies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbSavedMovies
            // 
            this.lbSavedMovies.FormattingEnabled = true;
            this.lbSavedMovies.Location = new System.Drawing.Point(38, 27);
            this.lbSavedMovies.Name = "lbSavedMovies";
            this.lbSavedMovies.Size = new System.Drawing.Size(145, 173);
            this.lbSavedMovies.TabIndex = 0;
            this.lbSavedMovies.SelectedIndexChanged += new System.EventHandler(this.lbSavedMovies_SelectedIndexChanged);
            // 
            // SavedMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbSavedMovies);
            this.Name = "SavedMovies";
            this.Text = "SavedMovies";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSavedMovies;
    }
}