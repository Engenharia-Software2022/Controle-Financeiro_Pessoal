using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.MODEL
{
    public class Receitas
    {
        public int id_receita { get; set; }
        public string nome { get; set; }
        public string descricaoentrada { get; set; }
        public string valorentrada { get; set; }
        public DateTime data { get; set; }
        public string receita_despesa { get; set; }


    }
}
