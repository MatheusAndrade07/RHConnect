namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioValeTransporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValeTransportePergunta = new System.Windows.Forms.Label();
            this.checkedBoxSimValeTransporte = new System.Windows.Forms.CheckBox();
            this.checkedBoxNaoValeTransporte = new System.Windows.Forms.CheckBox();
            this.lblSalarioValeTransporte = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtQuantidadeVales = new System.Windows.Forms.TextBox();
            this.txtValorPassagem = new System.Windows.Forms.TextBox();
            this.lblQuantidadeValeTransporte = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcularValeTransporte = new System.Windows.Forms.Button();
            this.lblValorDaPassagem = new System.Windows.Forms.Label();
            this.panelValeTransporte = new System.Windows.Forms.Panel();
            this.lblValeTransporteApena = new System.Windows.Forms.Label();
            this.checkBoxNaoVL = new System.Windows.Forms.CheckBox();
            this.checkBoxSimVL = new System.Windows.Forms.CheckBox();
            this.panelValeTransporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValeTransportePergunta
            // 
            this.lblValeTransportePergunta.AutoSize = true;
            this.lblValeTransportePergunta.Location = new System.Drawing.Point(38, 38);
            this.lblValeTransportePergunta.Name = "lblValeTransportePergunta";
            this.lblValeTransportePergunta.Size = new System.Drawing.Size(145, 13);
            this.lblValeTransportePergunta.TabIndex = 0;
            this.lblValeTransportePergunta.Text = "Você usa o Vale Transporte?";
            // 
            // checkedBoxSimValeTransporte
            // 
            this.checkedBoxSimValeTransporte.AutoSize = true;
            this.checkedBoxSimValeTransporte.Location = new System.Drawing.Point(41, 71);
            this.checkedBoxSimValeTransporte.Name = "checkedBoxSimValeTransporte";
            this.checkedBoxSimValeTransporte.Size = new System.Drawing.Size(43, 17);
            this.checkedBoxSimValeTransporte.TabIndex = 2;
            this.checkedBoxSimValeTransporte.Text = "Sim";
            this.checkedBoxSimValeTransporte.UseVisualStyleBackColor = true;
            this.checkedBoxSimValeTransporte.CheckedChanged += new System.EventHandler(this.checkedBoxSimValeTransporte_CheckedChanged_1);
            // 
            // checkedBoxNaoValeTransporte
            // 
            this.checkedBoxNaoValeTransporte.AutoSize = true;
            this.checkedBoxNaoValeTransporte.Location = new System.Drawing.Point(99, 71);
            this.checkedBoxNaoValeTransporte.Name = "checkedBoxNaoValeTransporte";
            this.checkedBoxNaoValeTransporte.Size = new System.Drawing.Size(46, 17);
            this.checkedBoxNaoValeTransporte.TabIndex = 3;
            this.checkedBoxNaoValeTransporte.Text = "Não";
            this.checkedBoxNaoValeTransporte.UseVisualStyleBackColor = true;
            this.checkedBoxNaoValeTransporte.CheckedChanged += new System.EventHandler(this.checkedBoxNaoValeTransporte_CheckedChanged_1);
            // 
            // lblSalarioValeTransporte
            // 
            this.lblSalarioValeTransporte.AutoSize = true;
            this.lblSalarioValeTransporte.Location = new System.Drawing.Point(10, 2);
            this.lblSalarioValeTransporte.Name = "lblSalarioValeTransporte";
            this.lblSalarioValeTransporte.Size = new System.Drawing.Size(133, 13);
            this.lblSalarioValeTransporte.TabIndex = 7;
            this.lblSalarioValeTransporte.Text = "Digite abaixo o seu salário:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(13, 28);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(130, 20);
            this.txtSalario.TabIndex = 8;
            // 
            // txtQuantidadeVales
            // 
            this.txtQuantidadeVales.Location = new System.Drawing.Point(13, 101);
            this.txtQuantidadeVales.Name = "txtQuantidadeVales";
            this.txtQuantidadeVales.Size = new System.Drawing.Size(130, 20);
            this.txtQuantidadeVales.TabIndex = 9;
            // 
            // txtValorPassagem
            // 
            this.txtValorPassagem.Location = new System.Drawing.Point(13, 166);
            this.txtValorPassagem.Name = "txtValorPassagem";
            this.txtValorPassagem.Size = new System.Drawing.Size(130, 20);
            this.txtValorPassagem.TabIndex = 10;
            // 
            // lblQuantidadeValeTransporte
            // 
            this.lblQuantidadeValeTransporte.AutoSize = true;
            this.lblQuantidadeValeTransporte.Location = new System.Drawing.Point(10, 69);
            this.lblQuantidadeValeTransporte.Name = "lblQuantidadeValeTransporte";
            this.lblQuantidadeValeTransporte.Size = new System.Drawing.Size(213, 13);
            this.lblQuantidadeValeTransporte.TabIndex = 11;
            this.lblQuantidadeValeTransporte.Text = "Quantos Vale Transporte você usa por dia?";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(47, 271);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Visible = false;
            // 
            // btnCalcularValeTransporte
            // 
            this.btnCalcularValeTransporte.Location = new System.Drawing.Point(13, 205);
            this.btnCalcularValeTransporte.Name = "btnCalcularValeTransporte";
            this.btnCalcularValeTransporte.Size = new System.Drawing.Size(130, 46);
            this.btnCalcularValeTransporte.TabIndex = 13;
            this.btnCalcularValeTransporte.Text = "Calcular vale transporte!";
            this.btnCalcularValeTransporte.UseVisualStyleBackColor = true;
            this.btnCalcularValeTransporte.Click += new System.EventHandler(this.btnCalcularValeTransporte_Click_1);
            // 
            // lblValorDaPassagem
            // 
            this.lblValorDaPassagem.AutoSize = true;
            this.lblValorDaPassagem.Location = new System.Drawing.Point(10, 137);
            this.lblValorDaPassagem.Name = "lblValorDaPassagem";
            this.lblValorDaPassagem.Size = new System.Drawing.Size(234, 13);
            this.lblValorDaPassagem.TabIndex = 14;
            this.lblValorDaPassagem.Text = "Coloque no campo abaixo o valor da passagem:";
            // 
            // panelValeTransporte
            // 
            this.panelValeTransporte.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelValeTransporte.Controls.Add(this.lblValorDaPassagem);
            this.panelValeTransporte.Controls.Add(this.btnCalcularValeTransporte);
            this.panelValeTransporte.Controls.Add(this.lblResultado);
            this.panelValeTransporte.Controls.Add(this.lblQuantidadeValeTransporte);
            this.panelValeTransporte.Controls.Add(this.txtValorPassagem);
            this.panelValeTransporte.Controls.Add(this.txtQuantidadeVales);
            this.panelValeTransporte.Controls.Add(this.txtSalario);
            this.panelValeTransporte.Controls.Add(this.lblSalarioValeTransporte);
            this.panelValeTransporte.Location = new System.Drawing.Point(41, 113);
            this.panelValeTransporte.Name = "panelValeTransporte";
            this.panelValeTransporte.Size = new System.Drawing.Size(275, 325);
            this.panelValeTransporte.TabIndex = 15;
            this.panelValeTransporte.Visible = false;
            // 
            // lblValeTransporteApena
            // 
            this.lblValeTransporteApena.AutoSize = true;
            this.lblValeTransporteApena.Location = new System.Drawing.Point(417, 38);
            this.lblValeTransporteApena.Name = "lblValeTransporteApena";
            this.lblValeTransporteApena.Size = new System.Drawing.Size(266, 13);
            this.lblValeTransporteApena.TabIndex = 16;
            this.lblValeTransporteApena.Text = "Você quer saber se vale a pena usa o vale transporte?";
            // 
            // checkBoxNaoVL
            // 
            this.checkBoxNaoVL.AutoSize = true;
            this.checkBoxNaoVL.Location = new System.Drawing.Point(469, 71);
            this.checkBoxNaoVL.Name = "checkBoxNaoVL";
            this.checkBoxNaoVL.Size = new System.Drawing.Size(46, 17);
            this.checkBoxNaoVL.TabIndex = 17;
            this.checkBoxNaoVL.Text = "Não";
            this.checkBoxNaoVL.UseVisualStyleBackColor = true;
            // 
            // checkBoxSimVL
            // 
            this.checkBoxSimVL.AutoSize = true;
            this.checkBoxSimVL.Location = new System.Drawing.Point(420, 71);
            this.checkBoxSimVL.Name = "checkBoxSimVL";
            this.checkBoxSimVL.Size = new System.Drawing.Size(43, 17);
            this.checkBoxSimVL.TabIndex = 18;
            this.checkBoxSimVL.Text = "Sim";
            this.checkBoxSimVL.UseVisualStyleBackColor = true;
            this.checkBoxSimVL.CheckedChanged += new System.EventHandler(this.checkBoxSimVL_CheckedChanged);
            // 
            // frmBeneficioValeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.checkBoxSimVL);
            this.Controls.Add(this.checkBoxNaoVL);
            this.Controls.Add(this.lblValeTransporteApena);
            this.Controls.Add(this.panelValeTransporte);
            this.Controls.Add(this.checkedBoxNaoValeTransporte);
            this.Controls.Add(this.checkedBoxSimValeTransporte);
            this.Controls.Add(this.lblValeTransportePergunta);
            this.Name = "frmBeneficioValeTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benefício Vale Transporte";
            this.panelValeTransporte.ResumeLayout(false);
            this.panelValeTransporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValeTransportePergunta;
        private System.Windows.Forms.CheckBox checkedBoxSimValeTransporte;
        private System.Windows.Forms.CheckBox checkedBoxNaoValeTransporte;
        private System.Windows.Forms.Label lblSalarioValeTransporte;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtQuantidadeVales;
        private System.Windows.Forms.TextBox txtValorPassagem;
        private System.Windows.Forms.Label lblQuantidadeValeTransporte;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcularValeTransporte;
        private System.Windows.Forms.Label lblValorDaPassagem;
        private System.Windows.Forms.Panel panelValeTransporte;
        private System.Windows.Forms.Label lblValeTransporteApena;
        private System.Windows.Forms.CheckBox checkBoxNaoVL;
        private System.Windows.Forms.CheckBox checkBoxSimVL;
    }
}