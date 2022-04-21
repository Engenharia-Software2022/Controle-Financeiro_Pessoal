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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespesas));
            this.btnExcluirDespesa = new System.Windows.Forms.Button();
            this.btnAlterarDespesa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadastrarDespesa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCodigoDespesa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTitularDespesa = new System.Windows.Forms.ComboBox();
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDescricaoDespesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataDespesa = new System.Windows.Forms.DateTimePicker();
            this.cbSelecionarDespesa = new System.Windows.Forms.ComboBox();
            this.txbValorDespesa = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirDespesa
            // 
            this.btnExcluirDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirDespesa.Location = new System.Drawing.Point(668, 363);
            this.btnExcluirDespesa.Name = "btnExcluirDespesa";
            this.btnExcluirDespesa.Size = new System.Drawing.Size(132, 37);
            this.btnExcluirDespesa.TabIndex = 35;
            this.btnExcluirDespesa.Text = "Excluir";
            this.btnExcluirDespesa.UseVisualStyleBackColor = true;
            this.btnExcluirDespesa.Click += new System.EventHandler(this.btnExcluirDespesa_Click);
            // 
            // btnAlterarDespesa
            // 
            this.btnAlterarDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarDespesa.Location = new System.Drawing.Point(668, 406);
            this.btnAlterarDespesa.Name = "btnAlterarDespesa";
            this.btnAlterarDespesa.Size = new System.Drawing.Size(132, 37);
            this.btnAlterarDespesa.TabIndex = 32;
            this.btnAlterarDespesa.Text = "Alterar";
            this.btnAlterarDespesa.UseVisualStyleBackColor = true;
            this.btnAlterarDespesa.Click += new System.EventHandler(this.btnAlterarDespesa_Click);
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
            // btnCadastrarDespesa
            // 
            this.btnCadastrarDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarDespesa.Location = new System.Drawing.Point(530, 363);
            this.btnCadastrarDespesa.Name = "btnCadastrarDespesa";
            this.btnCadastrarDespesa.Size = new System.Drawing.Size(132, 37);
            this.btnCadastrarDespesa.TabIndex = 26;
            this.btnCadastrarDespesa.Text = "Cadastrar";
            this.btnCadastrarDespesa.UseVisualStyleBackColor = true;
           
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbCodigoDespesa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbTitularDespesa);
            this.groupBox1.Controls.Add(this.dgvDespesas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbDescricaoDespesa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDataDespesa);
            this.groupBox1.Controls.Add(this.cbSelecionarDespesa);
            this.groupBox1.Controls.Add(this.txbValorDespesa);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 290);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lançamento Despesas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Codigo:";
            // 
            // txbCodigoDespesa
            // 
            this.txbCodigoDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoDespesa.Location = new System.Drawing.Point(130, 20);
            this.txbCodigoDespesa.Name = "txbCodigoDespesa";
            this.txbCodigoDespesa.ReadOnly = true;
            this.txbCodigoDespesa.Size = new System.Drawing.Size(52, 22);
            this.txbCodigoDespesa.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Selecione o nome:";
            // 
            // cbTitularDespesa
            // 
            this.cbTitularDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTitularDespesa.FormattingEnabled = true;
            this.cbTitularDespesa.Items.AddRange(new object[] {
            "Marcos",
            "Ana Lúcia",
            "Samuel"});
            this.cbTitularDespesa.Location = new System.Drawing.Point(508, 17);
            this.cbTitularDespesa.Name = "cbTitularDespesa";
            this.cbTitularDespesa.Size = new System.Drawing.Size(203, 24);
            this.cbTitularDespesa.TabIndex = 44;
            // 
            // dgvDespesas
            // 
            this.dgvDespesas.AllowUserToAddRows = false;
            this.dgvDespesas.AllowUserToDeleteRows = false;
            this.dgvDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesas.Location = new System.Drawing.Point(12, 113);
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.ReadOnly = true;
            this.dgvDespesas.Size = new System.Drawing.Size(776, 150);
            this.dgvDespesas.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Selecione a entrada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Descrição:";
            // 
            // txbDescricaoDespesa
            // 
            this.txbDescricaoDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescricaoDespesa.Location = new System.Drawing.Point(130, 76);
            this.txbDescricaoDespesa.Name = "txbDescricaoDespesa";
            this.txbDescricaoDespesa.Size = new System.Drawing.Size(198, 22);
            this.txbDescricaoDespesa.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Valor (R$):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Data:";
            // 
            // dtpDataDespesa
            // 
            this.dtpDataDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDespesa.Location = new System.Drawing.Point(130, 48);
            this.dtpDataDespesa.Name = "dtpDataDespesa";
            this.dtpDataDespesa.Size = new System.Drawing.Size(198, 22);
            this.dtpDataDespesa.TabIndex = 37;
            // 
            // cbSelecionarDespesa
            // 
            this.cbSelecionarDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelecionarDespesa.FormattingEnabled = true;
            this.cbSelecionarDespesa.Items.AddRange(new object[] {
            "despesas"});
            this.cbSelecionarDespesa.Location = new System.Drawing.Point(508, 48);
            this.cbSelecionarDespesa.Name = "cbSelecionarDespesa";
            this.cbSelecionarDespesa.Size = new System.Drawing.Size(203, 24);
            this.cbSelecionarDespesa.TabIndex = 36;
            // 
            // txbValorDespesa
            // 
            this.txbValorDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorDespesa.Location = new System.Drawing.Point(508, 79);
            this.txbValorDespesa.Name = "txbValorDespesa";
            this.txbValorDespesa.Size = new System.Drawing.Size(203, 22);
            this.txbValorDespesa.TabIndex = 35;
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(183, 363);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(70, 60);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditar.TabIndex = 41;
            this.btnEditar.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(320, 368);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(60, 50);
            this.btnExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExcluir.TabIndex = 40;
            this.btnExcluir.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(67, 368);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(60, 50);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvar.TabIndex = 39;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluirDespesa);
            this.Controls.Add(this.btnAlterarDespesa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCadastrarDespesa);
            this.Name = "frmDespesas";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmDespesas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirDespesa;
        private System.Windows.Forms.Button btnAlterarDespesa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadastrarDespesa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCodigoDespesa;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbTitularDespesa;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDescricaoDespesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataDespesa;
        private System.Windows.Forms.ComboBox cbSelecionarDespesa;
        private System.Windows.Forms.TextBox txbValorDespesa;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.PictureBox btnExcluir;
        private System.Windows.Forms.PictureBox btnSalvar;
    }
}