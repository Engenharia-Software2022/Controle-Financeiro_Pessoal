using ControleFinanceiro.DAO;
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
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ReceitasDAO dao = new ReceitasDAO();

            string nome = mtbDataInicial.Text;

            dgvRelatorio.DataSource = dao.ConsultarReceitasPorNome(nome);

            if (dgvRelatorio.Rows.Count <= 0)
            {
                MessageBox.Show("Nenhum Cliente encontrado!");
                dgvRelatorio.DataSource = dao.ListarTodasReceitas();
            }
        }
    }
}
