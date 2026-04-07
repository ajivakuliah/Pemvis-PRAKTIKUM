namespace WindowsFormsApp4
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbKomunitas = new System.Windows.Forms.ComboBox();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtbTelepon = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSimpanCetak = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb8 = new System.Windows.Forms.CheckBox();
            this.cb7 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatKartuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpanDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "KARTU KOMUNITAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 116);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 322);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbKomunitas);
            this.tabPage1.Controls.Add(this.rbPerempuan);
            this.tabPage1.Controls.Add(this.rbLaki);
            this.tabPage1.Controls.Add(this.dtpTanggal);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.txtNama);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data Utama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbKomunitas
            // 
            this.cmbKomunitas.FormattingEnabled = true;
            this.cmbKomunitas.Items.AddRange(new object[] {
            "Artist",
            "Musician",
            "Gamer",
            "Streamer",
            "Editor"});
            this.cmbKomunitas.Location = new System.Drawing.Point(172, 196);
            this.cmbKomunitas.Name = "cmbKomunitas";
            this.cmbKomunitas.Size = new System.Drawing.Size(198, 28);
            this.cmbKomunitas.TabIndex = 10;
            this.cmbKomunitas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(280, 152);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(116, 24);
            this.rbPerempuan.TabIndex = 9;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Location = new System.Drawing.Point(172, 152);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(91, 24);
            this.rbLaki.TabIndex = 8;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki-laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(172, 106);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(198, 26);
            this.dtpTanggal.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(172, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(388, 26);
            this.txtID.TabIndex = 6;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(172, 15);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(388, 26);
            this.txtNama.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Jenis Komunitas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tanggal Lahir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID Anggota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtAlamat);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.mtbTelepon);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kontak";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(184, 94);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(374, 104);
            this.txtAlamat.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(184, 55);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // mtbTelepon
            // 
            this.mtbTelepon.Location = new System.Drawing.Point(184, 18);
            this.mtbTelepon.Mask = "0000-0000-0000";
            this.mtbTelepon.Name = "mtbTelepon";
            this.mtbTelepon.Size = new System.Drawing.Size(146, 26);
            this.mtbTelepon.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Alamat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "No. Telepon";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSimpanCetak);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.btnBrowse);
            this.tabPage3.Controls.Add(this.pbFoto);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(646, 289);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profil";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnSimpanCetak
            // 
            this.btnSimpanCetak.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpanCetak.Location = new System.Drawing.Point(241, 243);
            this.btnSimpanCetak.Name = "btnSimpanCetak";
            this.btnSimpanCetak.Size = new System.Drawing.Size(236, 40);
            this.btnSimpanCetak.TabIndex = 4;
            this.btnSimpanCetak.Text = "Simpan dan Cetak";
            this.btnSimpanCetak.UseVisualStyleBackColor = true;
            this.btnSimpanCetak.Click += new System.EventHandler(this.btnSimpanCetak_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb8);
            this.groupBox2.Controls.Add(this.cb7);
            this.groupBox2.Controls.Add(this.cb6);
            this.groupBox2.Controls.Add(this.cb5);
            this.groupBox2.Controls.Add(this.cb4);
            this.groupBox2.Controls.Add(this.cb3);
            this.groupBox2.Controls.Add(this.cb2);
            this.groupBox2.Controls.Add(this.cb1);
            this.groupBox2.Location = new System.Drawing.Point(381, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 215);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hobby";
            // 
            // cb8
            // 
            this.cb8.AutoSize = true;
            this.cb8.Location = new System.Drawing.Point(121, 167);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(88, 24);
            this.cb8.TabIndex = 7;
            this.cb8.Text = "Singing";
            this.cb8.UseVisualStyleBackColor = true;
            // 
            // cb7
            // 
            this.cb7.AutoSize = true;
            this.cb7.Location = new System.Drawing.Point(121, 125);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(93, 24);
            this.cb7.TabIndex = 6;
            this.cb7.Text = "Drawing";
            this.cb7.UseVisualStyleBackColor = true;
            // 
            // cb6
            // 
            this.cb6.AutoSize = true;
            this.cb6.Location = new System.Drawing.Point(121, 84);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(86, 24);
            this.cb6.TabIndex = 5;
            this.cb6.Text = "Fishing";
            this.cb6.UseVisualStyleBackColor = true;
            this.cb6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Location = new System.Drawing.Point(121, 43);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(74, 24);
            this.cb5.TabIndex = 4;
            this.cb5.Text = "Sport";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(6, 167);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(108, 24);
            this.cb4.TabIndex = 3;
            this.cb4.Text = "Streaming";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(6, 125);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(76, 24);
            this.cb3.TabIndex = 2;
            this.cb3.Text = "Music";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(6, 84);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(91, 24);
            this.cb2.TabIndex = 1;
            this.cb2.Text = "Gaming";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(6, 43);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(85, 24);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "Coding";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(223, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 215);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peran";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 143);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(95, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Anggota";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 95);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ketua";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Admin";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(49, 206);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(93, 31);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(19, 21);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(154, 168);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.inputDataToolStripMenuItem,
            this.lihatKartuToolStripMenuItem,
            this.simpanDataToolStripMenuItem,
            this.bukaDataToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // inputDataToolStripMenuItem
            // 
            this.inputDataToolStripMenuItem.Name = "inputDataToolStripMenuItem";
            this.inputDataToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.inputDataToolStripMenuItem.Text = "Input Data";
            // 
            // lihatKartuToolStripMenuItem
            // 
            this.lihatKartuToolStripMenuItem.Name = "lihatKartuToolStripMenuItem";
            this.lihatKartuToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.lihatKartuToolStripMenuItem.Text = "Lihat Kartu";
            // 
            // simpanDataToolStripMenuItem
            // 
            this.simpanDataToolStripMenuItem.Name = "simpanDataToolStripMenuItem";
            this.simpanDataToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.simpanDataToolStripMenuItem.Text = "Simpan Data";
            this.simpanDataToolStripMenuItem.Click += new System.EventHandler(this.simpanDataToolStripMenuItem_Click_1);
            // 
            // bukaDataToolStripMenuItem
            // 
            this.bukaDataToolStripMenuItem.Name = "bukaDataToolStripMenuItem";
            this.bukaDataToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.bukaDataToolStripMenuItem.Text = "Buka Data";
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 67);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.Elegant_HAVEN_logo_design;
            this.pictureBox1.Location = new System.Drawing.Point(-57, -49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(673, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatKartuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpanDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukaDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKomunitas;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtbTelepon;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb8;
        private System.Windows.Forms.CheckBox cb7;
        private System.Windows.Forms.CheckBox cb6;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.Button btnSimpanCetak;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

