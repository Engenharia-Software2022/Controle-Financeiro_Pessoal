using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.MODEL
{
    public class Despesas
    {
        public int id_despesa { get; set; }
        public string nome { get; set; }
        public string descricaosaida { get; set; }
        public string valorsaida { get; set; }
        public DateTime data { get; set; }
        public DateTime data_inicio { get; set; }
        public DateTime data_fim { get; set; }
  
    }
}
