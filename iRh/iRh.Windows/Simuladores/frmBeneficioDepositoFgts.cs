using iRh.Windows.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioDepositoFgts : Form
    {
        public frmBeneficioDepositoFgts()
        {
            InitializeComponent();
        }
        private void btnCalcularValeTransporte_Click(object sender, EventArgs e)
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
                var resultadoFgts = Fgts.CalculaFgts(salario);

                lblResultado.Text = "R$ " + resultadoFgts.ToString("F2");
                lblResultado.Visible = true;
                panelFgts.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe seu sálario base", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
