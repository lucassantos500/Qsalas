using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;
using System.Data.SqlClient;

namespace CamadaNegocio
{
    public class Napresentacao
    {
        //Metodo inserir
        public static string Inserir(string nome, string descricao)
        {
            DApresentacao OBJ = new CamadaDados.DApresentacao();
            OBJ.Nome = nome;
            OBJ.Descricao = descricao;
            return OBJ.Inserir(OBJ);
        }

        //Metodo editar
        public static string Editar(int Idapresentacao, string nome, string descricao)
        {
            DApresentacao OBJ = new CamadaDados.DApresentacao();
            OBJ.Idapresentacao = Idapresentacao;
            OBJ.Nome = nome;
            OBJ.Descricao = descricao;
            return OBJ.Editar(OBJ);
        }

        //Metodo excluir
        public static string Deletar(int Idapresentacao)
        {
            DApresentacao OBJ = new CamadaDados.DApresentacao();
            OBJ.Idapresentacao = Idapresentacao;
            return OBJ.Deletar(OBJ);
        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DApresentacao().Mostrar();
        }

        //Metodo Buscar Texto
        public static DataTable BuscarNome(String textobuscar)
        {
            DApresentacao OBJ = new CamadaDados.DApresentacao();
            OBJ.TextoBuscar = textobuscar;
            return OBJ.BuscarNome(OBJ);
        }
    }
}
