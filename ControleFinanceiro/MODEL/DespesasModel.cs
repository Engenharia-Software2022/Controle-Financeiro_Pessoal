﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.MODEL
{
    public class DespesasModel
    {
        public int id_despesa { get; set; }
        public string nome { get; set; }
        public string descricaosaida { get; set; }
        public string valorsaida { get; set; }
        public DateTime data { get; set; }

        public int id_receita_fk { get; set; }
       

    }
}
