using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DCategoria
    {
        private int _Idcategoria;
        private string _Nome;
        private string _Descricao;
        private string _TextoBuscar;

        //Get & Set

        public int Idcategoria { get => _Idcategoria; set => _Idcategoria = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Descricao { get => _Descricao; set => _Descricao = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        //Construtor Vazio

        public DCategoria() { }

        //Construtor com parametros

        public DCategoria(int idcategoria, string nome, string descricao, string textobuscar)
        {
            this.Idcategoria = idcategoria;
            this.Nome = nome;
            this.Descricao = descricao;
            this.TextoBuscar = textobuscar;
        }

        //Metodo inserir
        public string Inserir(DCategoria Categoria)
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
                SqlCmd.CommandText = "spinserir_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //variável IdCategoria
                SqlParameter ParIDcategoria = new SqlParameter();
                ParIDcategoria.ParameterName = "@idcategoria";//nome da variável no procedure
                ParIDcategoria.SqlDbType = SqlDbType.Int;
                ParIDcategoria.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDcategoria);
                //variável Nome
                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";//nome da variável no procedure
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Categoria.Nome;
                SqlCmd.Parameters.Add(ParNome);
                //variável Descricao
                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";//nome da variável no procedure
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 100;
                ParDescricao.Value = Categoria.Descricao;
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
        public string Editar(DCategoria Categoria)
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
                    SqlCmd.CommandText = "speditar_categoria";
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    //variável IdCategoria
                    SqlParameter ParIDcategoria = new SqlParameter();
                    ParIDcategoria.ParameterName = "@idcategoria";//nome da variável no procedure
                    ParIDcategoria.SqlDbType = SqlDbType.Int;
                    ParIDcategoria.Value = Categoria.Idcategoria;
                    SqlCmd.Parameters.Add(ParIDcategoria);
                    //variável Nome
                    SqlParameter ParNome = new SqlParameter();
                    ParNome.ParameterName = "@nome";//nome da variável no procedure
                    ParNome.SqlDbType = SqlDbType.VarChar;
                    ParNome.Size = 50;
                    ParNome.Value = Categoria.Nome;
                    SqlCmd.Parameters.Add(ParNome);
                    //variável Descricao
                    SqlParameter ParDescricao = new SqlParameter();
                    ParDescricao.ParameterName = "@descricao";//nome da variável no procedure
                    ParDescricao.SqlDbType = SqlDbType.VarChar;
                    ParDescricao.Size = 100;
                    ParDescricao.Value = Categoria.Descricao;
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
        public string Deletar(DCategoria Categoria)
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
                SqlCmd.CommandText = "spdeletar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //variável IdCategoria
                SqlParameter ParIDcategoria = new SqlParameter();
                ParIDcategoria.ParameterName = "@idcategoria";//nome da variável no procedure
                ParIDcategoria.SqlDbType = SqlDbType.Int;
                ParIDcategoria.Value = Categoria.Idcategoria;
                SqlCmd.Parameters.Add(ParIDcategoria);
                /*
                //variável Nome
                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";//nome da variável no procedure
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Categoria.Nome;
                SqlCmd.Parameters.Add(ParNome);
                //variável Descricao
                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";//nome da variável no procedure
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 100;
                ParDescricao.Value = Categoria.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);
                */
                //Executar o comando de edição

                resposta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Categoria Não Deletada";
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
            DataTable DtResultado = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = conexao.conexaoDB;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch(Exception ex)
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
        public DataTable BuscarNome(DCategoria Categoria)
        {
            DataTable DtResultado = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = conexao.conexaoDB;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_nome";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //variável texto buscar
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";//nome da variável no procedure
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Categoria.TextoBuscar;
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
