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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn_LancarReceitas_Click(object sender, EventArgs e)
        {
            frmReceitas frm = new frmReceitas();
            frm.Show();
            this.Hide();

        }

        private void btnLancarDespesas_Click(object sender, EventArgs e)
        {
            frmDespesas frm = new frmDespesas();
            frm.Show();
            this.Hide();
        }

        private void btnConsultarPeriodos_Click(object sender, EventArgs e)
        {
           
        }
    }
}
