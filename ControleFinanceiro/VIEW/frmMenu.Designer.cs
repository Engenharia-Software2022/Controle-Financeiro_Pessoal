namespace ControleFinanceiro.VIEW
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btn_LancarReceitas = new System.Windows.Forms.Button();
            this.btnLancarDespesas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_LancarReceitas
            // 
            this.btn_LancarReceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LancarReceitas.Image = ((System.Drawing.Image)(resources.GetObject("btn_LancarReceitas.Image")));
            this.btn_LancarReceitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LancarReceitas.Location = new System.Drawing.Point(56, 119);
            this.btn_LancarReceitas.Name = "btn_LancarReceitas";
            this.btn_LancarReceitas.Size = new System.Drawing.Size(185, 87);
            this.btn_LancarReceitas.TabIndex = 0;
            this.btn_LancarReceitas.Text = "Lançar Receitas";
            this.btn_LancarReceitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LancarReceitas.UseVisualStyleBackColor = true;
            this.btn_LancarReceitas.Click += new System.EventHandler(this.btn_LancarReceitas_Click);
            // 
            // btnLancarDespesas
            // 
            this.btnLancarDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancarDespesas.Image = ((System.Drawing.Image)(resources.GetObject("btnLancarDespesas.Image")));
            this.btnLancarDespesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLancarDespesas.Location = new System.Drawing.Point(302, 119);
            this.btnLancarDespesas.Name = "btnLancarDespesas";
            this.btnLancarDespesas.Size = new System.Drawing.Size(194, 87);
            this.btnLancarDespesas.TabIndex = 1;
            this.btnLancarDespesas.Text = "Lançar Despesas";
            this.btnLancarDespesas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLancarDespesas.UseVisualStyleBackColor = true;
            this.btnLancarDespesas.Click += new System.EventHandler(this.btnLancarDespesas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seja Bem Vindo!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Versão: 1.0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(172, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "O que deseja fazer?";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(556, 288);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLancarDespesas);
            this.Controls.Add(this.btn_LancarReceitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LancarReceitas;
        private System.Windows.Forms.Button btnLancarDespesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}