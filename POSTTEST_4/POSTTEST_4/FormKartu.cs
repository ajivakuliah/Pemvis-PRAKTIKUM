using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormKartu : Form
    {
        public FormKartu()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormKartu_Load(object sender, EventArgs e)
        {

        }
        public void TampilData(string nama, string id, string komunitas, string telp, Image foto, string hobby)
        {
            lblNama.Text = "Nama: " + nama;
            lblID.Text = "ID: " + id;
            lblKomunitas.Text = "Komunitas: " + komunitas;
            lblKontak.Text = "Telp: " + telp;

            lblHobby.Text = "Hobby: " + hobby;

            if (foto != null)
            {
                pbFoto.Image = foto;
                pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

    }
}
