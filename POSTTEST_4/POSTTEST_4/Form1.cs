using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool Validasi()
        {
            if (txtNama.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("Inputan tidak boleh kosong!");
                return false;
            }

            if (!rbLaki.Checked && !rbPerempuan.Checked)
            {
                MessageBox.Show("Pilih jenis kelamin!");
                return false;
            }

            if (!mtbTelepon.MaskFull)
            {
                MessageBox.Show("Nomor telepon belum lengkap!");
                return false;
            }

            if (!cb1.Checked && !cb2.Checked && !cb3.Checked && !cb4.Checked &&
                !cb5.Checked && !cb6.Checked && !cb7.Checked && !cb8.Checked)
            {
                MessageBox.Show("Pilih minimal 1 hobby!");
                return false;
            }

            return true;
        }
        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void simpanDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(txtNama.Text);
                sw.WriteLine(txtID.Text);
                sw.WriteLine(cmbKomunitas.Text);
                sw.WriteLine(mtbTelepon.Text);
                sw.Close();

                MessageBox.Show("Data berhasil disimpan!");
            }
        }
        private void bukaDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                txtNama.Text = sr.ReadLine();
                txtID.Text = sr.ReadLine();
                cmbKomunitas.Text = sr.ReadLine();
                mtbTelepon.Text = sr.ReadLine();
                sr.Close();
            }
        }
        private void btnSimpanCetak_Click(object sender, EventArgs e)
        {
            if (!Validasi()) return;

            string hobby = "";

            if (cb1.Checked) hobby += "Coding, ";
            if (cb2.Checked) hobby += "Gaming, ";
            if (cb3.Checked) hobby += "Music, ";
            if (cb4.Checked) hobby += "Drawing, ";
            if (cb5.Checked) hobby += "Streaming, ";
            if (cb6.Checked) hobby += "Sport, ";
            if (cb7.Checked) hobby += "Fishing, ";
            if (cb8.Checked) hobby += "Singing, ";

            FormKartu fk = new FormKartu();

            fk.TampilData(
                txtNama.Text,
                txtID.Text,
                cmbKomunitas.Text,
                mtbTelepon.Text,
                pbFoto.Image,
                hobby
            );

            // kirim gambar
            fk.pbFoto.Image = pbFoto.Image;

            fk.Show();

            MessageBox.Show("Data berhasil ditampilkan!");
        }

        private void simpanDataToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(txtNama.Text);
                sw.WriteLine(txtID.Text);
                sw.Close();

                MessageBox.Show("Data disimpan!");
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Yakin ingin keluar?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSimpanCetak_Click_1(object sender, EventArgs e)
        {

        }

        private void pbFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
