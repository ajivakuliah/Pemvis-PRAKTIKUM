using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace KartuProfil
{
    public partial class Form1 : Form
    {
        string imagePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = open.FileName;
                imagePath = open.FileName;
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {

            if (txtNamaa.Text == "" ||
                txtUmurr.Text == "" ||
                txtTeleponn.Text == "" ||
                txtAlamatt.Text == "")
            {
                MessageBox.Show("Inputan tidak boleh kosong");
                return;
            }

            if (!rbLakik.Checked && !rbCewe.Checked)
            {
                MessageBox.Show("Pilih jenis kelamin");
                return;
            }

            if (!Regex.IsMatch(txtNamaa.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Nama hanya boleh huruf");
                return;
            }

            if (!int.TryParse(txtUmurr.Text, out _))
            {
                MessageBox.Show("Umur hanya boleh angka");
                return;
            }

            if (!long.TryParse(txtTeleponn.Text, out _))
            {
                MessageBox.Show("Nomor telepon hanya boleh angka");
                return;
            }

            var hobbies = groupBoxHobbyy.Controls
                .OfType<CheckBox>()
                .Where(c => c.Checked)
                .Select(c => c.Text)
                .ToList();

            if (hobbies.Count == 0)
            {
                MessageBox.Show("Pilih minimal 1 hobby");
                return;
            }

            string gender = rbLakik.Checked ? "Laki-Laki" : "Perempuan";

            Form2 hasil = new Form2(
                txtNamaa.Text,
                txtUmurr.Text,
                txtTeleponn.Text,
                txtAlamatt.Text,
                dateTimePicker2.Value.ToShortDateString(),
                gender,
                string.Join(", ", hobbies),
                imagePath
            );

            hasil.Show();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}