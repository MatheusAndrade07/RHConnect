using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iRh.Windows.Core;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioValeTransporte : Form
    {
        public frmBeneficioValeTransporte()
        {
            InitializeComponent();
        }
        private void btnCalcularValeTransporte_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe seu sálario base", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var quantidadeValeTransporte = double.Parse(txtQuantidadeVales.Text); ;
                var valorDaPassagem = double.Parse(txtValorPassagem.Text);
                double descontoValeTransporte = ValeTransporte.CalculaValeTransporte(salario);

                lblResultado.Text = "R$ " + descontoValeTransporte.ToString();
                lblResultado.Visible = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Informe seu sálario base! ", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void checkedBoxNaoValeTransporte_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkedBoxNaoValeTransporte.Checked)
            {
                MessageBox.Show("Você não tem direito ao vale transporte!", "Atençaõ!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void checkedBoxSimValeTransporte_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkedBoxSimValeTransporte.Checked)
            {
                MessageBox.Show("Você tem direito ao vale transporte! " + Environment.NewLine + Environment.NewLine + "Aperte em 'OK' para continuar!");
                checkedBoxNaoValeTransporte.Visible = false;
                panelValeTransporte.Visible = true;
            }
        }

        private void checkBoxSimVL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSimVL.Checked)
            {
                var salario = double.Parse(txtSalario.Text);
            }
        }
    }
}
