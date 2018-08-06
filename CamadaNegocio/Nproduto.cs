using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class Nproduto
    {
        //Metodo inserir
        public static string Inserir(string codigo, string nome, string descricao, byte[] imagem, int idcateogira, int idapresentacao)
        {
            DProduto  OBJ = new CamadaDados.DProduto();
            OBJ.Codigo = codigo;
            OBJ.Nome = nome;
            OBJ.Descricao = descricao;
            OBJ.Imagem = imagem;
            OBJ.Idcategoria = idcateogira;
            OBJ.Idapresentacao = idapresentacao;
            return OBJ.Inserir(OBJ);
        }

        //Metodo editar
        public static string Editar(int idproduto, string codigo, string nome, string descricao, byte[] imagem, int idcateogira, int idapresentacao)
        {
            DProduto OBJ = new CamadaDados.DProduto();
            OBJ.Idproduto = idproduto;
            OBJ.Codigo = codigo;
            OBJ.Nome = nome;
            OBJ.Descricao = descricao;
            OBJ.Imagem = imagem;
            OBJ.Idcategoria = idcateogira;
            OBJ.Idapresentacao = idapresentacao;
            return OBJ.Editar(OBJ);
        }

        //Metodo excluir
        public static string Deletar(int idproduto)
        {
            DProduto OBJ = new CamadaDados.DProduto();
            OBJ.Idproduto = idproduto;
            return OBJ.Deletar(OBJ);
        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DProduto().Mostrar();
        }

        //Metodo Buscar Texto
        public static DataTable BuscarNome(String textobuscar)
        {
            DProduto OBJ = new CamadaDados.DProduto();
            OBJ.Textobuscar = textobuscar;
            return OBJ.BuscarNome(OBJ);
        }
    }
}
