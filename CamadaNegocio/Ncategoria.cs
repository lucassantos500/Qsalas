using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class Ncategoria
    {
        //Metodo inserir
        public static string Inserir(string nome, string descricao)
        {
            DCategoria OBJ = new CamadaDados.DCategoria();
            OBJ.Nome = nome;
            OBJ.Descricao = descricao;
            return OBJ.Inserir(OBJ);
        }

        //Metodo editar
        public static string Editar(int Idcategoria, string nome, string descricao)
        {
            DCategoria OBJ = new CamadaDados.DCategoria();
            OBJ.Idcategoria = Idcategoria;
            OBJ.Nome = nome;
            OBJ.Descricao = descricao;
            return OBJ.Editar(OBJ);
        }

        //Metodo excluir
        public static string Deletar(int Idcategoria)
        {
            DCategoria OBJ = new CamadaDados.DCategoria();
            OBJ.Idcategoria = Idcategoria;
            return OBJ.Deletar(OBJ);
        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DCategoria().Mostrar();
        }

        //Metodo Buscar Texto
        public static DataTable BuscarNome(String textobuscar)
        {
            DCategoria OBJ = new CamadaDados.DCategoria();
            OBJ.TextoBuscar = textobuscar;
            return OBJ.BuscarNome(OBJ);
        }
    }
}
