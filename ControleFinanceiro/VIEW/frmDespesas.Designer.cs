namespace ControleFinanceiro.VIEW
{
    partial class frmDespesas
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
            this.btnExcluirDespesa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCodigoDespesa = new System.Windows.Forms.TextBox();
            this.btnAlterarDespesa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTitularDespesa = new System.Windows.Forms.ComboBox();
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.btnCadastrarDespesa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDescricaoDespesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataDespesa = new System.Windows.Forms.DateTimePicker();
            this.cbSelecionarDespesa = new System.Windows.Forms.ComboBox();
            this.txbValorDrespesa = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirDespesa
            // 
            this.btnExcluirDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirDespesa.Location = new System.Drawing.Point(399, 385);
            this.btnExcluirDespesa.Name = "btnExcluirDespesa";
            this.btnExcluirDespesa.Size = new System.Drawing.Size(132, 37);
            this.btnExcluirDespesa.TabIndex = 35;
            this.btnExcluirDespesa.Text = "Excluir";
            this.btnExcluirDespesa.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Codigo:";
            // 
            // txbCodigoDespesa
            // 
            this.txbCodigoDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoDespesa.Location = new System.Drawing.Point(161, 93);
            this.txbCodigoDespesa.Name = "txbCodigoDespesa";
            this.txbCodigoDespesa.ReadOnly = true;
            this.txbCodigoDespesa.Size = new System.Drawing.Size(52, 26);
            this.txbCodigoDespesa.TabIndex = 33;
            // 
            // btnAlterarDespesa
            // 
            this.btnAlterarDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarDespesa.Location = new System.Drawing.Point(239, 385);
            this.btnAlterarDespesa.Name = "btnAlterarDespesa";
            this.btnAlterarDespesa.Size = new System.Drawing.Size(132, 37);
            this.btnAlterarDespesa.TabIndex = 32;
            this.btnAlterarDespesa.Text = "Alterar";
            this.btnAlterarDespesa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(678, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 37);
            this.label6.TabIndex = 31;
            this.label6.Text = "10:34:36";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Selecione o nome:";
            // 
            // cbTitularDespesa
            // 
            this.cbTitularDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTitularDespesa.FormattingEnabled = true;
            this.cbTitularDespesa.Items.AddRange(new object[] {
            "Marcos Antonio Garcia",
            "Ana Lúcia Batista Garcia",
            "Samuel Gomes da Silva"});
            this.cbTitularDespesa.Location = new System.Drawing.Point(539, 90);
            this.cbTitularDespesa.Name = "cbTitularDespesa";
            this.cbTitularDespesa.Size = new System.Drawing.Size(203, 28);
            this.cbTitularDespesa.TabIndex = 29;
            // 
            // dgvDespesas
            // 
            this.dgvDespesas.AllowUserToAddRows = false;
            this.dgvDespesas.AllowUserToDeleteRows = false;
            this.dgvDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesas.Location = new System.Drawing.Point(43, 205);
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.ReadOnly = true;
            this.dgvDespesas.Size = new System.Drawing.Size(776, 150);
            this.dgvDespesas.TabIndex = 27;
            // 
            // btnCadastrarDespesa
            // 
            this.btnCadastrarDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarDespesa.Location = new System.Drawing.Point(92, 385);
            this.btnCadastrarDespesa.Name = "btnCadastrarDespesa";
            this.btnCadastrarDespesa.Size = new System.Drawing.Size(132, 37);
            this.btnCadastrarDespesa.TabIndex = 26;
            this.btnCadastrarDespesa.Text = "Cadastrar";
            this.btnCadastrarDespesa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Selecione a entrada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Descrição:";
            // 
            // txbDescricaoDespesa
            // 
            this.txbDescricaoDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescricaoDespesa.Location = new System.Drawing.Point(161, 164);
            this.txbDescricaoDespesa.Name = "txbDescricaoDespesa";
            this.txbDescricaoDespesa.Size = new System.Drawing.Size(198, 26);
            this.txbDescricaoDespesa.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Valor (R$):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Data:";
            // 
            // dtpDataDespesa
            // 
            this.dtpDataDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDespesa.Location = new System.Drawing.Point(161, 126);
            this.dtpDataDespesa.Name = "dtpDataDespesa";
            this.dtpDataDespesa.Size = new System.Drawing.Size(198, 26);
            this.dtpDataDespesa.TabIndex = 20;
            // 
            // cbSelecionarDespesa
            // 
            this.cbSelecionarDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelecionarDespesa.FormattingEnabled = true;
            this.cbSelecionarDespesa.Items.AddRange(new object[] {
            "RECEITAS"});
            this.cbSelecionarDespesa.Location = new System.Drawing.Point(539, 126);
            this.cbSelecionarDespesa.Name = "cbSelecionarDespesa";
            this.cbSelecionarDespesa.Size = new System.Drawing.Size(203, 28);
            this.cbSelecionarDespesa.TabIndex = 19;
            // 
            // txbValorDrespesa
            // 
            this.txbValorDrespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorDrespesa.Location = new System.Drawing.Point(539, 164);
            this.txbValorDrespesa.Name = "txbValorDrespesa";
            this.txbValorDrespesa.Size = new System.Drawing.Size(203, 26);
            this.txbValorDrespesa.TabIndex = 18;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(163, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 37);
            this.btnSair.TabIndex = 37;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(120, 37);
            this.btnVoltar.TabIndex = 36;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluirDespesa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbCodigoDespesa);
            this.Controls.Add(this.btnAlterarDespesa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTitularDespesa);
            this.Controls.Add(this.dgvDespesas);
            this.Controls.Add(this.btnCadastrarDespesa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbDescricaoDespesa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataDespesa);
            this.Controls.Add(this.cbSelecionarDespesa);
            this.Controls.Add(this.txbValorDrespesa);
            this.Name = "frmDespesas";
            this.Text = "frmDespesas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirDespesa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCodigoDespesa;
        private System.Windows.Forms.Button btnAlterarDespesa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbTitularDespesa;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.Button btnCadastrarDespesa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDescricaoDespesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataDespesa;
        private System.Windows.Forms.ComboBox cbSelecionarDespesa;
        private System.Windows.Forms.TextBox txbValorDrespesa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVoltar;
    }
}