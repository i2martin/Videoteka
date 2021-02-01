namespace Videoteka
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vrijeme = new System.Windows.Forms.Label();
            this.ImeProzora = new System.Windows.Forms.Label();
            this.Prozori = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Zatvori = new FontAwesome.Sharp.IconButton();
            this.Vrati = new FontAwesome.Sharp.IconButton();
            this.Iznajmi = new FontAwesome.Sharp.IconButton();
            this.Pregledaj = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(130)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.Vrijeme);
            this.panel1.Controls.Add(this.ImeProzora);
            this.panel1.Controls.Add(this.Prozori);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 662);
            this.panel1.TabIndex = 1;
            // 
            // Vrijeme
            // 
            this.Vrijeme.AutoSize = true;
            this.Vrijeme.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vrijeme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Vrijeme.Location = new System.Drawing.Point(703, 63);
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.Size = new System.Drawing.Size(0, 38);
            this.Vrijeme.TabIndex = 3;
            // 
            // ImeProzora
            // 
            this.ImeProzora.AutoSize = true;
            this.ImeProzora.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeProzora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ImeProzora.Location = new System.Drawing.Point(318, 63);
            this.ImeProzora.Name = "ImeProzora";
            this.ImeProzora.Size = new System.Drawing.Size(0, 38);
            this.ImeProzora.TabIndex = 1;
            // 
            // Prozori
            // 
            this.Prozori.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Prozori.Location = new System.Drawing.Point(253, 157);
            this.Prozori.Name = "Prozori";
            this.Prozori.Size = new System.Drawing.Size(778, 505);
            this.Prozori.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(36)))), ((int)(((byte)(98)))));
            this.panel2.Controls.Add(this.Zatvori);
            this.panel2.Controls.Add(this.Vrati);
            this.panel2.Controls.Add(this.Iznajmi);
            this.panel2.Controls.Add(this.Pregledaj);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 662);
            this.panel2.TabIndex = 1;
            // 
            // Zatvori
            // 
            this.Zatvori.FlatAppearance.BorderSize = 0;
            this.Zatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zatvori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Zatvori.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.Zatvori.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Zatvori.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Zatvori.Location = new System.Drawing.Point(0, 556);
            this.Zatvori.Name = "Zatvori";
            this.Zatvori.Size = new System.Drawing.Size(253, 94);
            this.Zatvori.TabIndex = 10;
            this.Zatvori.Text = "Izlaz";
            this.Zatvori.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Zatvori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Zatvori.UseVisualStyleBackColor = true;
            this.Zatvori.Click += new System.EventHandler(this.Zatvori_Click_1);
            // 
            // Vrati
            // 
            this.Vrati.FlatAppearance.BorderSize = 0;
            this.Vrati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vrati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Vrati.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.Vrati.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Vrati.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Vrati.Location = new System.Drawing.Point(0, 357);
            this.Vrati.Name = "Vrati";
            this.Vrati.Size = new System.Drawing.Size(253, 94);
            this.Vrati.TabIndex = 9;
            this.Vrati.Text = "Vrati";
            this.Vrati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Vrati.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Vrati.UseVisualStyleBackColor = true;
            this.Vrati.Click += new System.EventHandler(this.Vrati_Click);
            // 
            // Iznajmi
            // 
            this.Iznajmi.FlatAppearance.BorderSize = 0;
            this.Iznajmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Iznajmi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Iznajmi.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.Iznajmi.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Iznajmi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Iznajmi.Location = new System.Drawing.Point(0, 257);
            this.Iznajmi.Name = "Iznajmi";
            this.Iznajmi.Size = new System.Drawing.Size(253, 94);
            this.Iznajmi.TabIndex = 8;
            this.Iznajmi.Text = "Iznajmi";
            this.Iznajmi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Iznajmi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Iznajmi.UseVisualStyleBackColor = true;
            this.Iznajmi.Click += new System.EventHandler(this.Iznajmi_Click);
            // 
            // Pregledaj
            // 
            this.Pregledaj.FlatAppearance.BorderSize = 0;
            this.Pregledaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pregledaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Pregledaj.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.Pregledaj.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Pregledaj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Pregledaj.Location = new System.Drawing.Point(0, 157);
            this.Pregledaj.Name = "Pregledaj";
            this.Pregledaj.Size = new System.Drawing.Size(253, 94);
            this.Pregledaj.TabIndex = 2;
            this.Pregledaj.Text = "Pregledaj";
            this.Pregledaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Pregledaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Pregledaj.UseVisualStyleBackColor = true;
            this.Pregledaj.Click += new System.EventHandler(this.Pregledaj_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 159);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(53, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Videoteka";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 662);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Zatvori;
        private FontAwesome.Sharp.IconButton Vrati;
        private FontAwesome.Sharp.IconButton Iznajmi;
        private FontAwesome.Sharp.IconButton Pregledaj;
        private System.Windows.Forms.Label Vrijeme;
        private System.Windows.Forms.Label ImeProzora;
        private System.Windows.Forms.Panel Prozori;
    }
}