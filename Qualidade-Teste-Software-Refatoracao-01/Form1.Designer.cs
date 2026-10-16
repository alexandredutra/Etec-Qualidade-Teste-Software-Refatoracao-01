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
            this.numParcelas = new System.Windows.Forms.NumericUpDown();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblResumo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DADOS DO PEDIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente Nome";
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienteNome.Location = new System.Drawing.Point(28, 110);
            this.txtClienteNome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(351, 29);
            this.txtClienteNome.TabIndex = 2;
            // 
            // txtClienteCpf
            // 
            this.txtClienteCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienteCpf.Location = new System.Drawing.Point(410, 110);
            this.txtClienteCpf.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtClienteCpf.Name = "txtClienteCpf";
            this.txtClienteCpf.Size = new System.Drawing.Size(351, 29);
            this.txtClienteCpf.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cliente CPF";
            // 
            // txtValorBruto
            // 
            this.txtValorBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorBruto.Location = new System.Drawing.Point(28, 205);
            this.txtValorBruto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtValorBruto.Name = "txtValorBruto";
            this.txtValorBruto.Size = new System.Drawing.Size(351, 29);
            this.txtValorBruto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
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
            this.cmbTipoCliente.Location = new System.Drawing.Point(816, 110);
            this.cmbTipoCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(248, 30);
            this.cmbTipoCliente.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(811, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cliente Tipo";
            // 
            // rbDinheiro
            // 
            this.rbDinheiro.AutoSize = true;
            this.rbDinheiro.Location = new System.Drawing.Point(25, 55);
            this.rbDinheiro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbDinheiro.Name = "rbDinheiro";
            this.rbDinheiro.Size = new System.Drawing.Size(98, 26);
            this.rbDinheiro.TabIndex = 11;
            this.rbDinheiro.TabStop = true;
            this.rbDinheiro.Text = "Dinheiro";
            this.rbDinheiro.UseVisualStyleBackColor = true;
            // 
            // rbPix
            // 
            this.rbPix.AutoSize = true;
            this.rbPix.Location = new System.Drawing.Point(168, 55);
            this.rbPix.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbPix.Name = "rbPix";
            this.rbPix.Size = new System.Drawing.Size(54, 26);
            this.rbPix.TabIndex = 12;
            this.rbPix.TabStop = true;
            this.rbPix.Text = "Pix";
            this.rbPix.UseVisualStyleBackColor = true;
            // 
            // rbCartaoCredito
            // 
            this.rbCartaoCredito.AutoSize = true;
            this.rbCartaoCredito.Location = new System.Drawing.Point(288, 55);
            this.rbCartaoCredito.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbCartaoCredito.Name = "rbCartaoCredito";
            this.rbCartaoCredito.Size = new System.Drawing.Size(151, 26);
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
            this.groupBox1.Location = new System.Drawing.Point(28, 258);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(663, 124);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma Pagamento";
            // 
            // numParcelas
            // 
            this.numParcelas.Location = new System.Drawing.Point(497, 55);
            this.numParcelas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numParcelas.Name = "numParcelas";
            this.numParcelas.Size = new System.Drawing.Size(130, 29);
            this.numParcelas.TabIndex = 14;
            this.numParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(775, 295);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(289, 63);
            this.btnFinalizar.TabIndex = 15;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblResumo
            // 
            this.lblResumo.AutoSize = true;
            this.lblResumo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumo.Location = new System.Drawing.Point(35, 408);
            this.lblResumo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(78, 17);
            this.lblResumo.TabIndex = 16;
            this.lblResumo.Text = "lblResumo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 58);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 458);
            this.Controls.Add(this.button1);
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
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.Button button1;
    }
}

