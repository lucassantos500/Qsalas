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
    public partial class frmCategoria : Form
    {

        private bool eNovo = false;
        private bool eEditar = false;

        public frmCategoria()
        {
            InitializeComponent();
            this.ttmensagem.SetToolTip(this.txtnome, "Insira o nome da Categoria");
            this.ttmensagem.SetToolTip(this.txtidcategoria, "Insira o código da Categoria");

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
            this.txtnome.Text = String.Empty;
            this.txtidcategoria.Text = String.Empty;
            this.txtdescricao.Text = String.Empty;
        }

        //Habilitar textbox
        private void Habilitar(bool valor)
        {
            this.txtnome.ReadOnly = !valor;
            this.txtdescricao.ReadOnly = !valor;
            this.txtidcategoria.ReadOnly = !valor;

        }

        //Habilitar botões
        private void Botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btnnovo.Enabled = false;
                this.btnsalvar.Enabled = true;
                this.btneditar.Enabled = false;
                this.btncancelar.Enabled = true;

            }
            else
            {
                this.Habilitar(false);
                this.btnnovo.Enabled = true;
                this.btnsalvar.Enabled = false;
                this.btneditar.Enabled = true;
                this.btncancelar.Enabled = false;
            }

        }

        //Ocultar Colunas Grid
        private void ocultarColunas()
        {
            this.datalista.Columns[0].Visible = false;
            this.datalista.Columns[1].Visible = false;
        }

        //42

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
