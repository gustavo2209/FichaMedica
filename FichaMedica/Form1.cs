using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaMedica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbMasculino.Checked = true;
            chkSi.Checked = true;
            chkPartos.Enabled = false;
            txtPaciente.Focus();
        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMasculino.Checked)
            {
                chkProstata.Enabled = true;
                chkPartos.Enabled = false;
                chkPartos.Checked = false;
            }
            if (rdbFemenino.Checked)
            {
                chkProstata.Enabled = false;
                chkPartos.Enabled = true;
                chkProstata.Checked = false;
            }
        }

        private void chkSi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNo.Checked)
            {
                txtseguro.Visible = false;
            }
            if(chkSi.Checked){
                txtseguro.Visible = true;
                txtseguro.Focus();
            }
        }
    }
}
