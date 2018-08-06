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
    public partial class frmProduto : Form
    {
        private bool eNovo = false;//Variável referente ao click do botão "btnnovo"
        private bool eEditar = false;//variável referente ao click do botão "btneditar"

        public frmProduto()
        {
            InitializeComponent();
            this.ttmensagem.SetToolTip(this.txtnome, "Insira o nome do Produto");
            this.ttmensagem.SetToolTip(this.pximagem, "selecione uma imágem do produto");
            this.ttmensagem.SetToolTip(this.cbidapresentacao, "selecione uma apresentação do produto");
            this.ttmensagem.SetToolTip(this.txtcategoria, "selecione uma categoria do produto");

            this.txtidcategoria.Visible = false;
            this.txtcategoria.ReadOnly = true;
        }

        //Mostrar mensagem de confirmação
        private void mensagemOK(string mensagem)
        {
            MessageBox.Show(mensagem, "SysSistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar mensagem de Erro
        private void mensagemError(string mensagem)
        {
            MessageBox.Show(mensagem, "SysSistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpar Campos
        private void Limpar()
        {
            this.txtcodigo.Text = String.Empty;
            this.txtnome.Text = String.Empty;
            this.txtidproduto.Text = String.Empty;
            this.txtdescricao.Text = String.Empty;
            this.txtidcategoria.Text = String.Empty;
            this.txtcategoria.Text = String.Empty;
            this.pximagem.Image = global::CamadaApresentação.Properties.Resources.no_image_icon_15;
        }

        //Habilitar textbox
        private void Habilitar(bool valor)
        {
            this.txtnome.ReadOnly = !valor;
            this.txtdescricao.ReadOnly = !valor;
            this.txtidapresentacao.ReadOnly = !valor;

        }

        //Habilitar botões
        private void Botoes()
        {
            if (this.eNovo || this.eEditar)//Se o eNovo ou eEditar for true (Alguem quer editar ou criar novo formulário)
            {
                this.Habilitar(true);//Habilitar as caixas de texto para escrita
                this.btnnovo.Enabled = false;//Desabilitar botão Novo "btnnovo", pois já esta sendo feito a edição ou criação de novo registro
                this.btnsalvar.Enabled = true;//Habilitar botão de Salvar "btnsalvar"
                this.btneditar.Enabled = false;//Desabilitar botão Editar "btneditar", pois já esta sendo feito a edição ou criação de novo registro
                this.btncancelar.Enabled = true;//Habilita o botão de Cancelar "btncancelar"

            }
            else//Se o eNovo ou eEditar for false (Nada está sendo editado ou criado)
            {
                this.Habilitar(false);//Desabilitar as caixas de texto para escrita
                this.btnnovo.Enabled = true;//Habilitar o botão Novo "btnnovo"
                this.btnsalvar.Enabled = false;//Desabilitar o botão de Salvar "btnsalvar", pois nada esta sendo feito
                this.btneditar.Enabled = true;//Habilitar o botão de Editar "btneditar"
                this.btncancelar.Enabled = false;//Desabilitar o botão de Cancelar "btncancelar", pois nada esta sendo feito
            }

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
            this.datalista.DataSource = Napresentacao.Mostrar();//Mostra as apresentações existentes
            this.ocultarColunas();//Oculta colunas do DataGrid desnecessárias(Deletar,Código)
            lbltotal.Text = "Total de registros: " + Convert.ToString(datalista.Rows.Count);//Atualiza a quantidade de registro no Label "lblTotal"
        }

        //Buscar pelo nome
        private void buscarNome()
        {
            this.datalista.DataSource = Napresentacao.BuscarNome(this.txtbuscar.Text);//Busca nome passando o que está sendo digitado na caixa de texto "txtbuscar"
            this.ocultarColunas();//Oculta colunas do DataGrid desnecessárias(Deletar,Código)
            lbltotal.Text = "Total de registros: " + Convert.ToString(datalista.Rows.Count);//Atualiza a quantidade de registro no Label "lblTotal"
        }









        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncarregar_Click(object sender, EventArgs e)
        {

        }

        private void frmProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
