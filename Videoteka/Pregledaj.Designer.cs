
namespace Videoteka
{
    partial class Pregledaj
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
            this.Filmovi = new System.Windows.Forms.ListBox();
            this.Količina = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Filmovi
            // 
            this.Filmovi.FormattingEnabled = true;
            this.Filmovi.ItemHeight = 16;
            this.Filmovi.Location = new System.Drawing.Point(133, 154);
            this.Filmovi.Name = "Filmovi";
            this.Filmovi.Size = new System.Drawing.Size(273, 180);
            this.Filmovi.TabIndex = 0;
            // 
            // Količina
            // 
            this.Količina.FormattingEnabled = true;
            this.Količina.ItemHeight = 16;
            this.Količina.Location = new System.Drawing.Point(452, 154);
            this.Količina.Name = "Količina";
            this.Količina.Size = new System.Drawing.Size(174, 180);
            this.Količina.TabIndex = 1;
            // 
            // Pregledaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(130)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(778, 505);
            this.Controls.Add(this.Količina);
            this.Controls.Add(this.Filmovi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pregledaj";
            this.Text = "Pregledaj";
            this.Load += new System.EventHandler(this.Pregledaj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Filmovi;
        private System.Windows.Forms.ListBox Količina;
    }
}