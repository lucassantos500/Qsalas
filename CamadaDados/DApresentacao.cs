using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DApresentacao
    {
        private int _Idapresentacao;
        private string _Nome;
        private string _Descricao;
        private string _TextoBuscar;

        //Get & Set

        public int Idapresentacao { get => _Idapresentacao; set => _Idapresentacao = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Descricao { get => _Descricao; set => _Descricao = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }


        public DApresentacao() { }

        //Construtor com parametros

        public DApresentacao(int idapresentacao, string nome, string descricao, string textobuscar)
        {
            this.Idapresentacao = idapresentacao;
            this.Nome = nome;
            this.Descricao = descricao;
            this.TextoBuscar = textobuscar;
        }

        //Metodo inserir
        public string Inserir(DApresentacao Apresentacao)
        {
            string resposta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Conexão feita
                SqlCon.ConnectionString = conexao.conexaoDB;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_apresentacao";//nome do procedure
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //variável IdApresentacao
                SqlParameter ParIDapresentacao = new SqlParameter();
                ParIDapresentacao.ParameterName = "@idapresentacao";//nome da variável no procedure
                ParIDapresentacao.SqlDbType = SqlDbType.Int;
                ParIDapresentacao.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDapresentacao);
                //variável Nome
                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";//nome da variável no procedure
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Apresentacao.Nome;
                SqlCmd.Parameters.Add(ParNome);
                //variável Descricao
                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";//nome da variável no procedure
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 100;
                ParDescricao.Value = Apresentacao.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);

                //Executar o comando de inserção

                resposta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro Não Inserido";



            }
            catch (Exception ex)
            {
                //Problema com o try
                resposta = ex.Message;
            }
            finally
            {
                //Executar sempre
                if (SqlCon.State == ConnectionState.Open)
                {
                    //Caso a conexão esteja aberta
                    SqlCon.Close();
                }
            }
            return resposta;
        }

        //Metodo editar
        public string Editar(DApresentacao Apresentacao)
        {
            string resposta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Conexão feita
                SqlCon.ConnectionString = conexao.conexaoDB;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_apresentacao";//nome do procedure
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //variável IdApresentacao
                SqlParameter ParIDapresentacao = new SqlParameter();
                ParIDapresentacao.ParameterName = "@idapresentacao";//nome da variável no procedure
                ParIDapresentacao.SqlDbType = SqlDbType.Int;
                ParIDapresentacao.Value = Apresentacao.Idapresentacao;
                SqlCmd.Parameters.Add(ParIDapresentacao);
                //variável Nome
                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";//nome da variável no procedure
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Apresentacao.Nome;
                SqlCmd.Parameters.Add(ParNome);
                //variável Descricao
                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";//nome da variável no procedure
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 100;
                ParDescricao.Value = Apresentacao.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);

                //Executar o comando de edição

                resposta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Edição Não Inserida";
            }
            catch (Exception ex)
            {
                //Problema com o try
                resposta = ex.Message;
            }
            finally
            {
                //Executar sempre
                if (SqlCon.State == ConnectionState.Open)
                {
                    //Caso a conexão esteja aberta
                    SqlCon.Close();
                }
            }
            return resposta;
        }

        //Metodo Deletar
        public string Deletar(DApresentacao Apresentacao)
        {
            string resposta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Conexão feita
                SqlCon.ConnectionString = conexao.conexaoDB;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_apresentacao";//nome do procedure
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //variável IdApresentacao
                SqlParameter ParIDapresentacao = new SqlParameter();
                ParIDapresentacao.ParameterName = "@idapresentacao";//nome da variável no procedure
                ParIDapresentacao.SqlDbType = SqlDbType.Int;
                ParIDapresentacao.Value = Apresentacao.Idapresentacao;
                SqlCmd.Parameters.Add(ParIDapresentacao);
              
                //Executar o comando de edição

                resposta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Apresentacao Não Deletada";
            }
            catch (Exception ex)
            {
                //Problema com o try
                resposta = ex.Message;
            }
            finally
            {
                //Executar sempre
                if (SqlCon.State == ConnectionState.Open)
                {
                    //Caso a conexão esteja aberta
                    SqlCon.Close();
                }
            }
            return resposta;
        }

        //Metodo mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("apresentacao");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = conexao.conexaoDB;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_apresentacao";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                //Executar sempre
                if (SqlCon.State == ConnectionState.Open)
                {
                    //Caso a conexão esteja aberta
                    SqlCon.Close();
                }
            }
            return DtResultado;
        }

        //Buscar nome
        public DataTable BuscarNome(DApresentacao Apresentacao)
        {
            DataTable DtResultado = new DataTable("apresentacao");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = conexao.conexaoDB;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_apresentacao_nome";//nome da procedure
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //variável texto buscar
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";//nome da variável no procedure
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Apresentacao.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                //Executar sempre
                if (SqlCon.State == ConnectionState.Open)
                {
                    //Caso a conexão esteja aberta
                    SqlCon.Close();
                }
            }
            return DtResultado;
        }


    }
}
