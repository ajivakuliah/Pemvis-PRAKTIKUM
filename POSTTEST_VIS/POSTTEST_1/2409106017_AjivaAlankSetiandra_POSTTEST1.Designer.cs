namespace _2409106017_Ajiva_Alank_Setiandra_POSTTEST1
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
            this.IPSem = new System.Windows.Forms.Label();
            this.Predikat = new System.Windows.Forms.Label();
            this.IPKum = new System.Windows.Forms.Label();
            this.TIPSem = new System.Windows.Forms.TextBox();
            this.TIPK = new System.Windows.Forms.TextBox();
            this.TomTambah = new System.Windows.Forms.Button();
            this.TomReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPSem
            // 
            this.IPSem.AutoSize = true;
            this.IPSem.Location = new System.Drawing.Point(169, 127);
            this.IPSem.Name = "IPSem";
            this.IPSem.Size = new System.Drawing.Size(97, 20);
            this.IPSem.TabIndex = 0;
            this.IPSem.Text = "IP Semester";
            this.IPSem.Click += new System.EventHandler(this.label1_Click);
            // 
            // Predikat
            // 
            this.Predikat.AutoSize = true;
            this.Predikat.Location = new System.Drawing.Point(288, 250);
            this.Predikat.Name = "Predikat";
            this.Predikat.Size = new System.Drawing.Size(51, 20);
            this.Predikat.TabIndex = 1;
            this.Predikat.Text = "label2";
            this.Predikat.Click += new System.EventHandler(this.label2_Click);
            // 
            // IPKum
            // 
            this.IPKum.AutoSize = true;
            this.IPKum.Location = new System.Drawing.Point(169, 211);
            this.IPKum.Name = "IPKum";
            this.IPKum.Size = new System.Drawing.Size(94, 20);
            this.IPKum.TabIndex = 2;
            this.IPKum.Text = "IP Kumulatif";
            this.IPKum.Click += new System.EventHandler(this.label3_Click);
            // 
            // TIPSem
            // 
            this.TIPSem.Location = new System.Drawing.Point(292, 127);
            this.TIPSem.Name = "TIPSem";
            this.TIPSem.Size = new System.Drawing.Size(219, 26);
            this.TIPSem.TabIndex = 3;
            // 
            // TIPK
            // 
            this.TIPK.Location = new System.Drawing.Point(292, 211);
            this.TIPK.Name = "TIPK";
            this.TIPK.ReadOnly = true;
            this.TIPK.Size = new System.Drawing.Size(219, 26);
            this.TIPK.TabIndex = 4;
            // 
            // TomTambah
            // 
            this.TomTambah.Location = new System.Drawing.Point(292, 159);
            this.TomTambah.Name = "TomTambah";
            this.TomTambah.Size = new System.Drawing.Size(104, 35);
            this.TomTambah.TabIndex = 5;
            this.TomTambah.Text = "Tambah";
            this.TomTambah.UseVisualStyleBackColor = true;
            this.TomTambah.Click += new System.EventHandler(this.TomTambah_Click);
            // 
            // TomReset
            // 
            this.TomReset.Location = new System.Drawing.Point(402, 159);
            this.TomReset.Name = "TomReset";
            this.TomReset.Size = new System.Drawing.Size(109, 35);
            this.TomReset.TabIndex = 6;
            this.TomReset.Text = "Reset";
            this.TomReset.UseVisualStyleBackColor = true;
            this.TomReset.Click += new System.EventHandler(this.TomReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TomReset);
            this.Controls.Add(this.TomTambah);
            this.Controls.Add(this.TIPK);
            this.Controls.Add(this.TIPSem);
            this.Controls.Add(this.IPKum);
            this.Controls.Add(this.Predikat);
            this.Controls.Add(this.IPSem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPSem;
        private System.Windows.Forms.Label Predikat;
        private System.Windows.Forms.Label IPKum;
        private System.Windows.Forms.TextBox TIPSem;
        private System.Windows.Forms.TextBox TIPK;
        private System.Windows.Forms.Button TomTambah;
        private System.Windows.Forms.Button TomReset;
    }
}

