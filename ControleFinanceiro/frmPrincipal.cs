using ControleFinanceiro.DAO;
using ControleFinanceiro.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cbNomes.Text == "" || txbDescricao.Text == "" || cbSelecionar_rec_des.Text == "" || txbValor.Text == "" || dtpData.Text == "")
            {
                MessageBox.Show("Campos vazios não são permitidos! Preencha todos os campos.");
                LimparCampos();
                
            }
            else
            {

                Receitas obj = new Receitas();

                obj.nome = cbNomes.Text;
                obj.descricaoentrada = txbDescricao.Text;
                obj.valorentrada = txbValor.Text;

                obj.data = Convert.ToDateTime(dtpData.Text);
                obj.receita_despesa = cbSelecionar_rec_des.Text;

                ReceitasDAO dao = new ReceitasDAO();
                dao.InserirReceitas(obj);

                LimparCampos();

                dgvFinancas.DataSource = dao.ListarTodasReceitas();
            }



        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ReceitasDAO dao = new ReceitasDAO();
            dgvFinancas.DataSource = dao.ListarTodasReceitas();
        }

        private void LimparCampos() 
        {
            cbNomes.Text = "";
            txbDescricao.Text = "";
            txbValor.Text = "";
            dtpData.Text = "";
            cbSelecionar_rec_des.Text = "";
        }

    }
}
