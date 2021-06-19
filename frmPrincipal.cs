using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropriedadesCheckBox
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        private void RbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblNomePessoaFisica.ForeColor = Color.Blue;
            lblCpfPessoaFisica.ForeColor = Color.Blue;
            lblNomePessoaJuridica.ForeColor = Color.Black;
            lblCnpjPessoaJuridica.ForeColor = Color.Black;
            txtCpfPessoaFisica.Enabled = true;
            txtNomePessoaFisica.Enabled = true;
            txtNomePessoaJuridica.Enabled = false;
            txtCnpjPessoaJuridica.Enabled = false;
        }

        private void RbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblNomePessoaJuridica.ForeColor = Color.Blue;
            lblCnpjPessoaJuridica.ForeColor = Color.Blue;
            lblNomePessoaFisica.ForeColor = Color.Black;
            lblCpfPessoaFisica.ForeColor = Color.Black;
            txtCpfPessoaFisica.Enabled = false;
            txtNomePessoaFisica.Enabled = false;
            txtNomePessoaJuridica.Enabled = true;
            txtCnpjPessoaJuridica.Enabled = true;
        }
    }
            
}
