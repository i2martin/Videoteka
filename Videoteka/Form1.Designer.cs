namespace Videoteka
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.korisnik = new System.Windows.Forms.TextBox();
            this.lozinka = new System.Windows.Forms.TextBox();
            this.PotvrdiPrijavu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PotvrdiPrijavu);
            this.groupBox1.Controls.Add(this.lozinka);
            this.groupBox1.Controls.Add(this.korisnik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(282, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prijava";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lozinka";
            // 
            // korisnik
            // 
            this.korisnik.Location = new System.Drawing.Point(189, 66);
            this.korisnik.Name = "korisnik";
            this.korisnik.Size = new System.Drawing.Size(100, 22);
            this.korisnik.TabIndex = 2;
            // 
            // lozinka
            // 
            this.lozinka.Location = new System.Drawing.Point(189, 117);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(100, 22);
            this.lozinka.TabIndex = 3;
            // 
            // PotvrdiPrijavu
            // 
            this.PotvrdiPrijavu.Location = new System.Drawing.Point(136, 180);
            this.PotvrdiPrijavu.Name = "PotvrdiPrijavu";
            this.PotvrdiPrijavu.Size = new System.Drawing.Size(94, 39);
            this.PotvrdiPrijavu.TabIndex = 4;
            this.PotvrdiPrijavu.Text = "Potvrdi";
            this.PotvrdiPrijavu.UseVisualStyleBackColor = true;
            this.PotvrdiPrijavu.Click += new System.EventHandler(this.PotvrdiPrijavu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PotvrdiPrijavu;
        private System.Windows.Forms.TextBox lozinka;
        private System.Windows.Forms.TextBox korisnik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

