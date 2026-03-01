using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2409106017_Ajiva_Alank_Setiandra_POSTTEST1
{
    public partial class Form1 : Form
    {
        double totalIP = 0;
        int jumlahSemester = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TomTambah_Click(object sender, EventArgs e)
        {
            double ipSemester;

            if (double.TryParse(TIPSem.Text, out ipSemester))
            {
                totalIP += ipSemester;
                jumlahSemester++;

                double ipk = totalIP / jumlahSemester;

                TIPK.Text = ipk.ToString("0.00");

                // Predikat
                if (ipk >= 2.00 && ipk <= 2.75)
                {
                    Predikat.Text = "Cukup";
                }
                else if (ipk >= 2.76 && ipk <= 3.00)
                {
                    Predikat.Text = "Memuaskan";
                }
                else if (ipk >= 3.01)
                {
                    Predikat.Text = "Sangat Memuaskan";
                }
                else
                {
                    Predikat.Text = "-";
                }

                TIPSem.Clear();
                TIPSem.Focus();
            }
            else
            {
                MessageBox.Show("Masukkan angka yang valid!");
            }
        }


        private void TomReset_Click(object sender, EventArgs e)
        {
            totalIP = 0;
            jumlahSemester = 0;

            TIPSem.Clear();
            TIPK.Clear();
            Predikat.Text = "";
        }
    }
}