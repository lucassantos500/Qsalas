using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DProduto
    {
        private int _Idproduto;
        private string _Codigo;
        private string _Nome;
        private string _Descricao;
        private byte[] _Imagem;
        private int _Idcategoria;
        private int _Idapresentacao;
        private string _Textobuscar;

        public int Idproduto { get => _Idproduto; set => _Idproduto = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Descricao { get => _Descricao; set => _Descricao = value; }
        public byte[] Imagem { get => _Imagem; set => _Imagem = value; }
        public int Idcategoria { get => _Idcategoria; set => _Idcategoria = value; }
        public int Idapresentacao { get => _Idapresentacao; set => _Idapresentacao = value; }
        public string Textobuscar { get => _Textobuscar; set => _Textobuscar = value; }

        //Contrutor vazio
        public DProduto()
        {

        }
        
        //Contrutor
        public DProduto(int idproduto, string codigo, string nome, string descricao, byte[] imagem, int idcategoria, int idapresentacao, string textobuscar)
        {
            this.Idproduto = idproduto;
            this.Codigo = codigo;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Imagem = imagem;
            this.Idcategoria = idcategoria;
            this.Idapresentacao = idapresentacao;
            this.Textobuscar = textobuscar;

        }

        //Metodos
        //Metodo inserir
        public string Inserir(DProduto Produto)
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
                SqlCmd.CommandText = "spinserir_produto";//nome do procedure
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //variável Idproduto
                SqlParameter ParIDproduto = new SqlParameter();
                ParIDproduto.ParameterName = "@idproduto";//nome da variável no procedure
                ParIDproduto.SqlDbType = SqlDbType.Int;
                ParIDproduto.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDproduto);
                //variável Codigo
                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";//nome da variável no procedure
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 50;
                ParCodigo.Value = Produto.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);
                //variável Nome
                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";//nome da variável no procedure
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Produto.Nome;
                SqlCmd.Parameters.Add(ParNome);
                //variável Descricao
                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";//nome da variável no procedure
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 500;
                ParDescricao.Value = Produto.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);
                //variável Imagem
                SqlParameter ParImagem = new SqlParameter();
                ParImagem.ParameterName = "@imagem";//nome da variável no procedure
                ParImagem.SqlDbType = SqlDbType.Image;
                ParImagem.Value = Produto.Imagem;
                SqlCmd.Parameters.Add(ParImagem);
                //variável IdCategoria
                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";//nome da variável no procedure
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Produto.Idcategoria;
                SqlCmd.Parameters.Add(ParIdcategoria);
                //variável IdApresentacao
                SqlParameter ParIdapresentacao = new SqlParameter();
                ParIdapresentacao.ParameterName = "@idapresentacao";//nome da variável no procedure
                ParIdapresentacao.SqlDbType = SqlDbType.Int;
                ParIdapresentacao.Value = Produto.Idapresentacao;
                SqlCmd.Parameters.Add(ParIdapresentacao);


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
        public string Editar(DProduto Produto)
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
                SqlCmd.CommandText = "speditar_produto";//nome do procedure
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //variável IdApresentacao
                SqlParameter ParIDproduto = new SqlParameter();
                ParIDproduto.ParameterName = "@idproduto";//nome da variável no procedure
                ParIDproduto.SqlDbType = SqlDbType.Int;
                ParIDproduto.Value = Produto.Idproduto;
                SqlCmd.Parameters.Add(ParIDproduto);
                //variável Código
                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";//nome da variável no procedure
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 50;
                ParCodigo.Value = Produto.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);
                //variável Nome
                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";//nome da variável no procedure
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Produto.Nome;
                SqlCmd.Parameters.Add(ParNome);
                //variável Descricao
                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";//nome da variável no procedure
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 500;
                ParDescricao.Value = Produto.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);
                //variável Imagem
                SqlParameter ParImagem = new SqlParameter();
                ParImagem.ParameterName = "@imagem";//nome da variável no procedure
                ParImagem.SqlDbType = SqlDbType.Image;
                ParImagem.Value = Produto.Imagem;
                SqlCmd.Parameters.Add(ParImagem);
                //variável IdCategoria
                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";//nome da variável no procedure
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Produto.Idcategoria;
                SqlCmd.Parameters.Add(ParIdcategoria);
                //variável IdApresentacao
                SqlParameter ParIdapresentacao = new SqlParameter();
                ParIdapresentacao.ParameterName = "@idapresentacao";//nome da variável no procedure
                ParIdapresentacao.SqlDbType = SqlDbType.Int;
                ParIdapresentacao.Value = Produto.Idapresentacao;
                SqlCmd.Parameters.Add(ParIdapresentacao);

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
        public string Deletar(DProduto Produto)
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
                SqlCmd.CommandText = "spdeletar_produto";//nome do procedure
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //variável IdApresentacao
                SqlParameter ParIDproduto = new SqlParameter();
                ParIDproduto.ParameterName = "@idproduto";//nome da variável no procedure
                ParIDproduto.SqlDbType = SqlDbType.Int;
                ParIDproduto.Value = Produto.Idproduto;
                SqlCmd.Parameters.Add(ParIDproduto);

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
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = conexao.conexaoDB;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_produto";
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
        public DataTable BuscarNome(DProduto Produto)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = conexao.conexaoDB;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_produto_nome";//nome da procedure
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //variável texto buscar
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";//nome da variável no procedure
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Produto.Textobuscar;
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
