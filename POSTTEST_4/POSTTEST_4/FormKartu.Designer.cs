namespace WindowsFormsApp4
{
    partial class FormKartu
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblKomunitas = new System.Windows.Forms.Label();
            this.lblKontak = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHobby = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label1.Location = new System.Drawing.Point(149, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "KARTU KOMUNITAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-19, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 87);
            this.panel1.TabIndex = 3;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(12, 92);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(141, 162);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 4;
            this.pbFoto.TabStop = false;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(174, 102);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(51, 20);
            this.lblNama.TabIndex = 5;
            this.lblNama.Text = "Nama";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(174, 140);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(91, 20);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID Anggota";
            // 
            // lblKomunitas
            // 
            this.lblKomunitas.AutoSize = true;
            this.lblKomunitas.Location = new System.Drawing.Point(174, 176);
            this.lblKomunitas.Name = "lblKomunitas";
            this.lblKomunitas.Size = new System.Drawing.Size(84, 20);
            this.lblKomunitas.TabIndex = 7;
            this.lblKomunitas.Text = "Komunitas";
            // 
            // lblKontak
            // 
            this.lblKontak.AutoSize = true;
            this.lblKontak.Location = new System.Drawing.Point(174, 215);
            this.lblKontak.Name = "lblKontak";
            this.lblKontak.Size = new System.Drawing.Size(59, 20);
            this.lblKontak.TabIndex = 8;
            this.lblKontak.Text = "Kontak";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp4.Properties.Resources.Elegant_HAVEN_logo_design;
            this.pictureBox2.Location = new System.Drawing.Point(-237, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1077, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Location = new System.Drawing.Point(409, 102);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(55, 20);
            this.lblHobby.TabIndex = 10;
            this.lblHobby.Text = "Hobby";
            // 
            // FormKartu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(605, 360);
            this.Controls.Add(this.lblHobby);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblKontak);
            this.Controls.Add(this.lblKomunitas);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.panel1);
            this.Name = "FormKartu";
            this.Text = "FormKartu";
            this.Load += new System.EventHandler(this.FormKartu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblKomunitas;
        private System.Windows.Forms.Label lblKontak;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblHobby;
    }
}