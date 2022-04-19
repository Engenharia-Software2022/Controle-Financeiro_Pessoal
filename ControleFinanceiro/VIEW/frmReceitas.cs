using ControleFinanceiro.DAO;
using ControleFinanceiro.MODEL;
using ControleFinanceiro.VIEW;
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
    public partial class frmReceitas : Form
    {
        public frmReceitas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region Botão Cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cbNomeTitular.Text == "" || txbDescricaoEntrada.Text == "" || cbSelecionar_Receita.Text == "" || txbValorEntrada.Text == "" || dtpDataEntrada.Text == "")
            {
                MessageBox.Show("Campos vazios não são permitidos! Preencha todos os campos.");
                LimparCampos();
                
            }
            else
            {

                Receitas obj = new Receitas();

                obj.nometitular = cbNomeTitular.Text;
                obj.descricaoentrada = txbDescricaoEntrada.Text;
                obj.valorentrada = txbValorEntrada.Text;

                obj.dataentrada = Convert.ToDateTime(dtpDataEntrada.Text);
                obj.selecionarentrada = cbSelecionar_Receita.Text;

                ReceitasDAO dao = new ReceitasDAO();
                dao.InserirReceitas(obj);

                LimparCampos();

                dgvEntradas.DataSource = dao.ListarTodasReceitas();
            }

        }

        #endregion


        
        #region Método limpar campos

        private void LimparCampos() 
        {
            cbNomeTitular.Text = "";
            txbDescricaoEntrada.Text = "";
            txbValorEntrada.Text = "";
            dtpDataEntrada.Text = "";
            cbSelecionar_Receita.Text = "";
        }

        #endregion


        #region Botão alterar
        private void btnAlterarReceita_Click(object sender, EventArgs e)
        {
            if (cbNomeTitular.Text == "" || txbDescricaoEntrada.Text == "" || cbSelecionar_Receita.Text == "" || txbValorEntrada.Text == "" || dtpDataEntrada.Text == "")
            {
                MessageBox.Show("Campos vazios não são permitidos! Preencha todos os campos.");
                LimparCampos();

            }
            else
            {
                Receitas obj = new Receitas();

                //receber os dados dos campos
                obj.nometitular = cbNomeTitular.Text;
                obj.descricaoentrada = txbDescricaoEntrada.Text;
                obj.valorentrada = txbValorEntrada.Text;
                obj.dataentrada = Convert.ToDateTime(dtpDataEntrada.Text);
                obj.selecionarentrada = cbSelecionar_Receita.Text;

                obj.id_receita = int.Parse(txbCodigo.Text);

                // criar o objeto da classe clienteDAO

                ReceitasDAO dao = new ReceitasDAO();
                dao.AlterarReceitas(obj);

                //atualiza o datagridview
                dgvEntradas.DataSource = dao.ListarTodasReceitas();
            } 

        }

        #endregion


        #region botão excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cbNomeTitular.Text == "" || txbDescricaoEntrada.Text == "" || cbSelecionar_Receita.Text == "" || txbValorEntrada.Text == "" || dtpDataEntrada.Text == "")
            {
                MessageBox.Show("Campos vazios não são permitidos! Preencha todos os campos.");
                LimparCampos();

            }
            else
            {
                Receitas obj = new Receitas();

                obj.id_receita = int.Parse(txbCodigo.Text);

                ReceitasDAO dao = new ReceitasDAO();
                dao.Excluir(obj);
                dgvEntradas.DataSource = dao.ListarTodasReceitas();
            }
        }

        #endregion


        #region botão relatório
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmPesquisar frm = new frmPesquisar();
            frm.ShowDialog();
            this.Hide();
        }

        #endregion


        private void frmReceitas_Load(object sender, EventArgs e)
        {
            ReceitasDAO dao = new ReceitasDAO();
            dgvEntradas.DataSource = dao.ListarTodasReceitas();
        }

        private void dgvFinancas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Carregando os dados do datagridview para os textbox clicando no item do datagridview

            txbCodigo.Text = dgvEntradas.CurrentRow.Cells[0].Value.ToString();
            cbNomeTitular.Text = dgvEntradas.CurrentRow.Cells[1].Value.ToString();
            txbDescricaoEntrada.Text = dgvEntradas.CurrentRow.Cells[2].Value.ToString();
            txbValorEntrada.Text = dgvEntradas.CurrentRow.Cells[3].Value.ToString();
            dtpDataEntrada.Text = dgvEntradas.CurrentRow.Cells[4].Value.ToString();
            cbSelecionar_Receita.Text = dgvEntradas.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
