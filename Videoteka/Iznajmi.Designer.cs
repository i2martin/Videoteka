
namespace Videoteka
{
    partial class Iznajmi
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
            this.ListaFilmova = new System.Windows.Forms.ComboBox();
            this.IznajmiButton = new FontAwesome.Sharp.IconButton();
            this.ListaKorisnika = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ListaFilmova
            // 
            this.ListaFilmova.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaFilmova.FormattingEnabled = true;
            this.ListaFilmova.Location = new System.Drawing.Point(220, 88);
            this.ListaFilmova.Name = "ListaFilmova";
            this.ListaFilmova.Size = new System.Drawing.Size(339, 24);
            this.ListaFilmova.TabIndex = 0;
            // 
            // IznajmiButton
            // 
            this.IznajmiButton.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.IznajmiButton.IconColor = System.Drawing.Color.Black;
            this.IznajmiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IznajmiButton.Location = new System.Drawing.Point(220, 243);
            this.IznajmiButton.Name = "IznajmiButton";
            this.IznajmiButton.Size = new System.Drawing.Size(339, 67);
            this.IznajmiButton.TabIndex = 1;
            this.IznajmiButton.Text = "Iznajmi";
            this.IznajmiButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IznajmiButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IznajmiButton.UseVisualStyleBackColor = true;
            this.IznajmiButton.Click += new System.EventHandler(this.IznajmiButton_Click);
            // 
            // ListaKorisnika
            // 
            this.ListaKorisnika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaKorisnika.FormattingEnabled = true;
            this.ListaKorisnika.Location = new System.Drawing.Point(220, 160);
            this.ListaKorisnika.Name = "ListaKorisnika";
            this.ListaKorisnika.Size = new System.Drawing.Size(339, 24);
            this.ListaKorisnika.TabIndex = 2;
            // 
            // Iznajmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(130)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(778, 505);
            this.Controls.Add(this.ListaKorisnika);
            this.Controls.Add(this.IznajmiButton);
            this.Controls.Add(this.ListaFilmova);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Iznajmi";
            this.Text = "Iznajmi";
            this.Load += new System.EventHandler(this.Iznajmi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ListaFilmova;
        private FontAwesome.Sharp.IconButton IznajmiButton;
        private System.Windows.Forms.ComboBox ListaKorisnika;
    }
}