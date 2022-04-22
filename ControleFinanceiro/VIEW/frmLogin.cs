using ControleFinanceiro.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro.VIEW
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text == "" || txbSenha.Text == "")
            {
                MessageBox.Show("Informe todos os campos.");
            }
            else
            {


                string email, senha;

                email = txbEmail.Text;
                senha = txbSenha.Text;

                ReceitasDAO dao = new ReceitasDAO();
                dao.EfetuaLogin(email, senha);

                frmMenu frm = new frmMenu();
                frm.Show();

                //não funciona no método da classe cliente
                //precisa ser na chamada do método
                this.Hide();
            }

        }
    }
}
