namespace Qualidade_Teste_Software_Refatoracao_01
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.txtClienteCpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorBruto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbDinheiro = new System.Windows.Forms.RadioButton();
            this.rbPix = new System.Windows.Forms.RadioButton();
            this.rbCartaoCredito = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.numParcelas = new System.Windows.Forms.NumericUpDown();
            this.lblResumo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DADOS DO PEDIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente Nome";
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienteNome.Location = new System.Drawing.Point(18, 80);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(224, 22);
            this.txtClienteNome.TabIndex = 2;
            // 
            // txtClienteCpf
            // 
            this.txtClienteCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienteCpf.Location = new System.Drawing.Point(261, 80);
            this.txtClienteCpf.Name = "txtClienteCpf";
            this.txtClienteCpf.Size = new System.Drawing.Size(224, 22);
            this.txtClienteCpf.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cliente CPF";
            // 
            // txtValorBruto
            // 
            this.txtValorBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorBruto.Location = new System.Drawing.Point(18, 149);
            this.txtValorBruto.Name = "txtValorBruto";
            this.txtValorBruto.Size = new System.Drawing.Size(224, 22);
            this.txtValorBruto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor Bruto";
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Items.AddRange(new object[] {
            "Comum",
            "Estudante",
            "VIP"});
            this.cmbTipoCliente.Location = new System.Drawing.Point(519, 80);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(159, 24);
            this.cmbTipoCliente.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cliente Tipo";
            // 
            // rbDinheiro
            // 
            this.rbDinheiro.AutoSize = true;
            this.rbDinheiro.Location = new System.Drawing.Point(16, 40);
            this.rbDinheiro.Name = "rbDinheiro";
            this.rbDinheiro.Size = new System.Drawing.Size(72, 20);
            this.rbDinheiro.TabIndex = 11;
            this.rbDinheiro.TabStop = true;
            this.rbDinheiro.Text = "Dinheiro";
            this.rbDinheiro.UseVisualStyleBackColor = true;
            // 
            // rbPix
            // 
            this.rbPix.AutoSize = true;
            this.rbPix.Location = new System.Drawing.Point(107, 40);
            this.rbPix.Name = "rbPix";
            this.rbPix.Size = new System.Drawing.Size(44, 20);
            this.rbPix.TabIndex = 12;
            this.rbPix.TabStop = true;
            this.rbPix.Text = "Pix";
            this.rbPix.UseVisualStyleBackColor = true;
            // 
            // rbCartaoCredito
            // 
            this.rbCartaoCredito.AutoSize = true;
            this.rbCartaoCredito.Location = new System.Drawing.Point(183, 40);
            this.rbCartaoCredito.Name = "rbCartaoCredito";
            this.rbCartaoCredito.Size = new System.Drawing.Size(108, 20);
            this.rbCartaoCredito.TabIndex = 13;
            this.rbCartaoCredito.TabStop = true;
            this.rbCartaoCredito.Text = "Cartao Crédito";
            this.rbCartaoCredito.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numParcelas);
            this.groupBox1.Controls.Add(this.rbDinheiro);
            this.groupBox1.Controls.Add(this.rbCartaoCredito);
            this.groupBox1.Controls.Add(this.rbPix);
            this.groupBox1.Location = new System.Drawing.Point(18, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 90);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma Pagamento";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(494, 215);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(184, 46);
            this.btnFinalizar.TabIndex = 15;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // numParcelas
            // 
            this.numParcelas.Location = new System.Drawing.Point(316, 40);
            this.numParcelas.Name = "numParcelas";
            this.numParcelas.Size = new System.Drawing.Size(83, 22);
            this.numParcelas.TabIndex = 14;
            this.numParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblResumo
            // 
            this.lblResumo.AutoSize = true;
            this.lblResumo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumo.Location = new System.Drawing.Point(22, 297);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(78, 17);
            this.lblResumo.TabIndex = 16;
            this.lblResumo.Text = "lblResumo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 336);
            this.Controls.Add(this.lblResumo);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTipoCliente);
            this.Controls.Add(this.txtValorBruto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClienteCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClienteNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Formulários Pedido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClienteNome;
        private System.Windows.Forms.TextBox txtClienteCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorBruto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbDinheiro;
        private System.Windows.Forms.RadioButton rbPix;
        private System.Windows.Forms.RadioButton rbCartaoCredito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.NumericUpDown numParcelas;
        private System.Windows.Forms.Label lblResumo;
    }
}

