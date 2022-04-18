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
    public class ReceitasDAO
    {
        SqlConnection conexao;

        public ReceitasDAO()
        {
            this.conexao = ConnectionFactory.getConnection();
        }


        #region método inserir receitas no banco

        public void InserirReceitas(Receitas obj)
        {
            try
            {
                string sql = @"insert into receitas (nome, descricaoentrada, valorentrada,data, receita_despesa) values (@nome,@descricaoentrada,@valorentrada,@data, @receita_despesa)";


                //2 passo - organizar o sql
                SqlCommand cmd = new SqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@descricaoentrada", obj.descricaoentrada);
                cmd.Parameters.AddWithValue("@valorentrada", obj.valorentrada);
                cmd.Parameters.AddWithValue("@data", obj.data);
                cmd.Parameters.AddWithValue("@receita_despesa", obj.receita_despesa);

                conexao.Open();

                cmd.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Receita inserida com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion



        #region método alterar receitas no banco

        public void AlterarReceitas(Receitas obj)
        {
            try
            {
                string sql = @"update receitas set nome = @nome, descricaoentrada = @descricaoentrada, valorentrada = @valorentrada,data = @data, receita_despesa = @receita_despesa where id_receita = @id_receita";


                //2 passo - organizar o sql
                SqlCommand cmd = new SqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@descricaoentrada", obj.descricaoentrada);
                cmd.Parameters.AddWithValue("@valorentrada", obj.valorentrada);
                cmd.Parameters.AddWithValue("@data", obj.data);
                cmd.Parameters.AddWithValue("@receita_despesa", obj.receita_despesa);

                cmd.Parameters.AddWithValue("@id_receita", obj.id_receita);


                conexao.Open();

                cmd.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Receita atualizada com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion



        #region método excluir receita do banco

        public void Excluir(Receitas obj)
        {
            try
            {
                string sql = @"delete from receitas where id_receita = @id_receita";

                //2 passo - organizar o sql
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id_receita", obj.id_receita);

                conexao.Open();

                cmd.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Receita excluída com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }

        #endregion




        #region metodo listar receitas

        //Metodo lIstar receitas
        public DataTable ListarTodasReceitas()
        {

            //1 passo - comando sql
            string sql = @"select * from receitas";

            //2 passo - organizar o sql
            SqlCommand cmd = new SqlCommand(sql, conexao);

            //3 passo - abcmdrir a conexao e executar o comando                
            conexao.Open();
            cmd.ExecuteNonQuery();

            //4 passo - criar o MySQLDataAdapter
            DataTable tabelaReceitas = new DataTable();

            //5 passo - criar o DataTable
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tabelaReceitas);

            //fechar conexão
            conexao.Close();

            //Retornar o DataTable com os dados
            return tabelaReceitas;

        }


        #endregion



        #region metodo efetua login

        public void EfetuaLogin(string email, string senha)
        {
            try
            {
                //string sql
                string sql = "select * from receitas where email = @email and senha = @senha";

                //2 passo - organizar o sql
                SqlCommand cmd = new SqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                conexao.Open();

                SqlDataReader dados = cmd.ExecuteReader();

                if (dados.Read())
                {
                    string nivel_acesso = dados.ToString();

                    if (nivel_acesso.Equals("admin"))
                    {


                        conexao.Close();

                        //restringindo acessos
                    }
                    else if (nivel_acesso.Equals("usuario"))
                    {
                        //frmMenu frm = new frmMenu();
                        //frm._cadastroDeProdutos.Enabled = false;
                        // frm._cadastroDeFornecedores.Enabled = false;

                        //frm.Show();



                        conexao.Close();
                    }


                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Inválidos");
                    conexao.Close();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao acessar" + erro);
                conexao.Close();
            }


            #endregion
        }


        #region Consultar receitas por periodo

        




        #endregion



        #region Método efetuar logoff


        public void EfetuarLogoff()
        {

            //frmLogin frm = new frmLogin();
            //MessageBox.Show("Tem certeza que quer trocar de usuario? " + MessageBoxButtons.OKCancel);
            //frm.Show();

        }


        #endregion



        


    }

}

