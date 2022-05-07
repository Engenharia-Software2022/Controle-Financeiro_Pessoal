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

namespace ControleFinanceiro.VIEW
{
    public partial class frmDespesas : Form
    {
        public frmDespesas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void frmDespesas_Load(object sender, EventArgs e)
        {
            DespesasDAO dao = new DespesasDAO();
            dgvDespesas.DataSource = dao.ListarTodasDespesas();
        }

        private void dgvDespesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Carregando os dados do datagridview para os textbox clicando no item do datagridview
            txbCodigoDespesa.Text = dgvDespesas.CurrentRow.Cells[0].Value.ToString();
            cbTitularDespesa.Text = dgvDespesas.CurrentRow.Cells[1].Value.ToString();
            txbDescricaoDespesa.Text = dgvDespesas.CurrentRow.Cells[2].Value.ToString();
            txbValorDespesa.Text = dgvDespesas.CurrentRow.Cells[3].Value.ToString();
            cbSelecionarDespesa.Text = dgvDespesas.CurrentRow.Cells[4].Value.ToString();
            dtpDataDespesa.Text = dgvDespesas.CurrentRow.Cells[5].Value.ToString();
        }

        #region Método limpar campos

        private void LimparCampos() 
        {
            txbCodigoDespesa.Text = "";
            cbTitularDespesa.Text = "";
            txbDescricaoDespesa.Text = "";
            txbValorDespesa.Text = "";
            cbSelecionarDespesa.Text = "";
            dtpDataDespesa.Text = "";
        }



        #endregion

        private void btnAlterarDespesa_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirDespesa_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cbTitularDespesa.Text == "" || txbDescricaoDespesa.Text == "" || cbSelecionarDespesa.Text == "" || txbValorDespesa.Text == "" || dtpDataDespesa.Text == "")
            {
                MessageBox.Show("Campos vazios não são permitidos! Preencha todos os campos.");
                // LimparCampos();
            }
            else
            {
                Despesas obj = new Despesas();

                obj.nome = cbTitularDespesa.Text;
                obj.descricaosaida = txbDescricaoDespesa.Text;
                obj.valorsaida = txbValorDespesa.Text;
                obj.selecionarsaida = cbSelecionarDespesa.Text;
                obj.datasaida = Convert.ToDateTime(dtpDataDespesa.Text);

                DespesasDAO dao = new DespesasDAO();
                dao.InserirDespesas(obj);

                //LimparCampos();

                dgvDespesas.DataSource = dao.ListarTodasDespesas();

                LimparCampos();
            }
        }
    }
}
