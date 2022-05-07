using ControleFinanceiro.Conexao;
using ControleFinanceiro.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro.DAO
{
    public class DespesasDAO
    {
        SqlConnection conexao;

        public DespesasDAO()
        {
            this.conexao = ConnectionFactory.getConnection();
        }


        #region método inserir despesas no banco

        public void InserirDespesas(Despesas obj)
        {
            try
            {
                string sql = @"insert into despesas (nome, descricaosaida, valorsaida, selecionarsaida, datasaida) values (@nome,@descricaosaida,@valorsaida, @selecionarsaida, @datasaida)";


                //2 passo - organizar o sql
                SqlCommand cmd = new SqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@descricaosaida", obj.descricaosaida);
                cmd.Parameters.AddWithValue("@valorsaida", obj.valorsaida);
                cmd.Parameters.AddWithValue("@selecionarsaida", obj.selecionarsaida);
                cmd.Parameters.AddWithValue("@datasaida", obj.datasaida);
                

                conexao.Open();

                cmd.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Despesa inserida com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion



        #region método alterar despesas no banco

        public void AlterarDespesas(Despesas obj)
        {
            try
            {
                string sql = @"update despesas set nometitular = @nometitular, descricaosaida = @descricaosaida, valorsaida = @valorsaida, selecionarsaida = @selecionarsaida, datasaida = @datasaida where id_receita = @id";


                //2 passo - organizar o sql
                SqlCommand cmd = new SqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@descricaosaida", obj.descricaosaida);
                cmd.Parameters.AddWithValue("@valorsaida", obj.valorsaida);
                cmd.Parameters.AddWithValue("@selecionarsaida", obj.selecionarsaida);
                cmd.Parameters.AddWithValue("@datasaida", obj.datasaida);
                //cmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);

                conexao.Open();

                cmd.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Despesa atualizada com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion



        #region método excluir despesa do banco

        public void excluirDespesa(Despesas obj)
        {
            try
            {
                string sql = @"delete from despesas where id_receitas = @id";

                //2 passo - organizar o sql
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", obj.id_despesa);

                conexao.Open();

                cmd.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Despesa excluída com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }

        #endregion



        #region metodo listar despesas

        //Metodo lIstar receitas
        public DataTable ListarTodasDespesas()
        {

            //1 passo - comando sql
            string sql = @"select * from despesas";

            //2 passo - organizar o sql
            SqlCommand cmd = new SqlCommand(sql, conexao);

            //3 passo - abcmdrir a conexao e executar o comando                
            conexao.Open();
            cmd.ExecuteNonQuery();

            //4 passo - criar o MySQLDataAdapter
            DataTable tabelaDespesas = new DataTable();

            //5 passo - criar o DataTable
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tabelaDespesas);

            //fechar conexão
            conexao.Close();

            //Retornar o DataTable com os dados
            return tabelaDespesas;

        }


        #endregion



        #region Consultar despesas por nome

        public DataTable ConsultarDespesasPorNome(string nome)
        {

            //1 passo - comando sql
            string sql = @"select * from despesas where nometitular = @nometitular";

            //2 passo - organizar o sql
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nometitular", nome);

            //3 passo - abcmdrir a conexao e executar o comando                
            conexao.Open();
            cmd.ExecuteNonQuery();

            //4 passo - criar o MySQLDataAdapter
            DataTable tabelaDespesas = new DataTable();

            //5 passo - criar o DataTable
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tabelaDespesas);

            //fechar conexão
            conexao.Close();

            //Retornar o DataTable com os dados
            return tabelaDespesas;

        }




        #endregion


        


    }
}
