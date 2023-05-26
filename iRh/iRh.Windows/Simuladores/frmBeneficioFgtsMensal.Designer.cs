namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioFgtsMensal
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCalcularValeTransporte = new System.Windows.Forms.Button();
            this.panelFgts = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFgts.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(139, 62);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(179, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // btnCalcularValeTransporte
            // 
            this.btnCalcularValeTransporte.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularValeTransporte.Location = new System.Drawing.Point(139, 88);
            this.btnCalcularValeTransporte.Name = "btnCalcularValeTransporte";
            this.btnCalcularValeTransporte.Size = new System.Drawing.Size(179, 63);
            this.btnCalcularValeTransporte.TabIndex = 2;
            this.btnCalcularValeTransporte.Text = "Exibir resultado do FGTS mensal";
            this.btnCalcularValeTransporte.UseVisualStyleBackColor = true;
            this.btnCalcularValeTransporte.Click += new System.EventHandler(this.btnCalcularValeTransporte_Click);
            // 
            // panelFgts
            // 
            this.panelFgts.Controls.Add(this.lblResultado);
            this.panelFgts.Location = new System.Drawing.Point(139, 157);
            this.panelFgts.Name = "panelFgts";
            this.panelFgts.Size = new System.Drawing.Size(179, 92);
            this.panelFgts.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(59, 36);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite abaixo o valor do seu Salário";
            // 
            // frmBeneficioFgtsMensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.rh_digital1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFgts);
            this.Controls.Add(this.btnCalcularValeTransporte);
            this.Controls.Add(this.txtSalario);
            this.Name = "frmBeneficioFgtsMensal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benefício Deposito FGTS";
            this.panelFgts.ResumeLayout(false);
            this.panelFgts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnCalcularValeTransporte;
        private System.Windows.Forms.Panel panelFgts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
    }
}