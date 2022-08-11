using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblKalkulator_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // Do something  
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNilai1.Text);
            int num2 = int.Parse(txtNilai2.Text);
            int jumlah = num1 + num2;
            txtHasilNilai.Text = jumlah.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNilai1.Text = "";
            txtNilai2.Text = "";
            txtHasilNilai.Text = "";
            
        }

        private void txtHasilNilai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNilai1.Text);
            int num2 = int.Parse(txtNilai2.Text);
            int jumlah = num1 - num2;
            txtHasilNilai.Text = jumlah.ToString();
        }

        private void lblKali_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNilai1.Text);
            int num2 = int.Parse(txtNilai2.Text);
            int jumlah = num1 * num2;
            txtHasilNilai.Text = jumlah.ToString();
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNilai1.Text);
            int num2 = int.Parse(txtNilai2.Text);
            int jumlah = num1 / num2;
            txtHasilNilai.Text = jumlah.ToString();
        }
    }
}
