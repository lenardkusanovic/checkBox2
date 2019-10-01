using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kusanovicLenardCheckBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChkDorucak_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkRucak_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkVecera_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnPosalji_Click(object sender, EventArgs e)
        {
            txtPrikaz.Clear();

            if (chkDorucak.Checked)
            {
                txtPrikaz.AppendText("\r\n odabrali ste dorucak. ");
            }
            if (chkRucak.Checked)
            {
                txtPrikaz.AppendText("\r\n odabrali ste rucak. ");
            }
            if (chkVecera.Checked)
            {
                txtPrikaz.AppendText("\r\n odabrali ste vecera. ");
            }
            if (chkSakrijiNarudzbu.Checked) 
            {
                txtPrikaz.Clear();
            }

        }

        private void ChkSakrijiNarudzbu_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSakrijiNarudzbu.Checked)
            {
                if (chkDorucak.Checked)
                {
                    txtPrikaz.AppendText("\r\n odabrali ste dorucak. ");
                }
                if (chkRucak.Checked)
                {
                    txtPrikaz.AppendText("\r\n odabrali ste rucak. ");
                }
                if (chkVecera.Checked)
                {
                    txtPrikaz.AppendText("\r\n odabrali ste vecera. ");
                }
            }
            else
            {
                txtPrikaz.Clear();
            }
        }
    }
}
