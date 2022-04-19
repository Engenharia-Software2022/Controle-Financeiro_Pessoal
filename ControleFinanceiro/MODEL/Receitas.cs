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
        public string nometitular { get; set; }
        public string descricaoentrada { get; set; }
        public string valorentrada { get; set; }
        public string selecionarentrada { get; set; }
        public DateTime dataentrada { get; set; }
        public DateTime data_inicio { get; set; }
        public DateTime data_fim { get; set; }

       

    }
}
