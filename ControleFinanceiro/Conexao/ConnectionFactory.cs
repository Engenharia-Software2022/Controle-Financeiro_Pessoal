using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Conexao
{
    public class ConnectionFactory
    {
        //metodo para conectar o banco de dados
        public static SqlConnection getConnection()
        {
            //acessando a string de conexão
            string conexao = ConfigurationManager.ConnectionStrings["ControleFinanceiro"].ConnectionString;

            return new SqlConnection(conexao);
        }
    }
}
