using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;

namespace CamadaApresentação
{
    public partial class frmVistaCat_Prod : Form
    {
        public frmVistaCat_Prod()
        {
            InitializeComponent();
        }

        //Ocultar Colunas Grid
        private void ocultarColunas()
        {
            this.datalista.Columns[0].Visible = false;//Oculta a coluna referente a deletar no Grid
            this.datalista.Columns[1].Visible = false;//Oculta a coluna referente ao Código no Grid
        }

        //Mostrar no DataGrid
        private void Mostrar()
        {
            this.datalista.DataSource = Ncategoria.Mostrar();//Mostra as categorias existentes
            this.ocultarColunas();//Oculta colunas do DataGrid desnecessárias(Deletar,Código)
            lbltotal.Text = "Total de registros: " + Convert.ToString(datalista.Rows.Count);//Atualiza a quantidade de registro no Label "lblTotal"
        }

        //Buscar pelo nome
        private void buscarNome()
        {
            this.datalista.DataSource = Ncategoria.BuscarNome(this.txtbuscar.Text);//Busca nome passando o que está sendo digitado na caixa de texto "txtbuscar"
            this.ocultarColunas();//Oculta colunas do DataGrid desnecessárias(Deletar,Código)
            lbltotal.Text = "Total de registros: " + Convert.ToString(datalista.Rows.Count);//Atualiza a quantidade de registro no Label "lblTotal"
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscarNome();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscarNome();
        }

        private void frmVistaCat_Prod_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void frmVistaCat_Prod_DoubleClick(object sender, EventArgs e)
        {
            

        }

        private void datalista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Double Click funcionou");
            frmProduto form = frmProduto.getInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.datalista.CurrentRow.Cells["idcategoria"].Value);
            par2 = Convert.ToString(this.datalista.CurrentRow.Cells["nome"].Value);
            form.setCategoria(par1, par2);
            this.Hide();
        }
    }
}
