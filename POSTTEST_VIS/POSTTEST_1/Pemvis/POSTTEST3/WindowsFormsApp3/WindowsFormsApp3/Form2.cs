using System;
using System.Windows.Forms;

namespace KartuProfil
{
    public partial class Form2 : Form
    {
        public Form2(string nama, string umur, string telepon, string alamat,
                     string tanggal, string gender, string hobby, string image)
        {
            InitializeComponent();

            lblNama.Text = nama;
            lblUmur.Text = umur;
            lblTelepon.Text = telepon;
            lblAlamat.Text = alamat;
            lblTanggal.Text = tanggal;
            lblGender.Text = gender;
            lblHobby.Text = hobby;

            if (image != "")
            {
                pictureBox1.ImageLocation = image;
            }
        }
    }
}