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
    public partial class frmApresentacao : Form
    {
        private bool eNovo = false;//Variável referente ao click do botão "btnnovo"
        private bool eEditar = false;//variável referente ao click do botão "btneditar"

        public frmApresentacao()
        {
            InitializeComponent();
            this.ttmensagem.SetToolTip(this.txtnome, "Insira o nome da Apresentação");
            this.ttmensagem.SetToolTip(this.txtidapresentacao, "Insira o código da Apresentação");
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
            this.txtidapresentacao.Text = String.Empty;
            this.txtdescricao.Text = String.Empty;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //O que acontece quando form é carregada
        private void frmApresentacao_Load(object sender, EventArgs e)
        {
            this.Top = 0;//Inicia no ponto 0 do eixo y (Mais alto possível)
            this.Left = 0;//Inicia no ponto 0 do eixo x (Mais a esquerda possível)
            this.Mostrar();//Ativa o dataGrid
            this.Habilitar(false);//Desativa as caixas de texto
            this.Botoes();//Ativa botões
        }

        //Clicar no botão buscar
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscarNome();
        }

        //digitar apresentação a pesquisar
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscarNome();
        }

        //Clicar no botão novo
        private void btnnovo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;//Clicou no botão Novo(criar novo registro)
            this.eEditar = false;//Como clicou no botão Novo(criar novo registro), não está editando
            this.Botoes();//Ativar botões
            this.Limpar();//Limpar caixas de texto
            this.Habilitar(true);//Habilitar caixas de texto
            this.txtnome.Focus();//Colocar o foco no nome
            this.txtidapresentacao.Enabled = false;//Desativa a caixa de texto do Código (É auto_increment)
        }

        //Clicar no botão salvar
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resposta = "";
                if (this.txtnome.Text == string.Empty)//Caso tenha deixado o campo "Nome" vazio
                {
                    mensagemError("Preencha todos os campos");
                    errorIcone.SetError(txtnome, "Insira o nome");
                    this.txtnome.Focus();//Coloca o foco no campo nome
                }
                else//Caso não tenha deixado o campo em branco
                {
                    if (this.eNovo)//Caso o eNovo(Clicou em botão novo) seja verdadeiro
                    {
                        //Inserir um novo registro
                        resposta = Napresentacao.Inserir(this.txtnome.Text.Trim().ToUpper(), this.txtdescricao.Text.Trim().ToUpper());
                    }
                    else//Caso o eNovo(Clicou em botão novo) seja falso
                    {
                        //Editar um registro existente
                        resposta = Napresentacao.Editar(Convert.ToInt32(this.txtidapresentacao.Text), this.txtnome.Text.Trim().ToUpper(), this.txtdescricao.Text.Trim().ToUpper());
                    }
                    if (resposta.Equals("Ok"))//Caso tenha conseguido inserir ou editar com sucesso
                    {
                        if (this.eNovo)//Caso o eNovo(Clicou em botão novo) seja verdadeiro
                        {
                            this.mensagemOK("Registro salvo com sucesso");//Mostrar mensagem de sucesso ao criar novo registro
                        }
                        else//Caso o eNovo(Clicou em botão novo) seja falso
                        {
                            this.mensagemOK("Registro modificado com sucesso");//Mostrar mensagem de sucesso ao editar um registro já existente
                        }
                    }
                    else//Caso não tenha conseguido inserir ou editar com sucesso
                    {
                        this.mensagemError(resposta);//Mostrar mensagem de erro de DApresentação destinado a novo formulário ou edição de um formulário já existente
                    }
                    this.eNovo = false;//Desativar o eNovo depois de salvar
                    this.eEditar = false;//Desativar o eEditar depois de salvar
                    this.Limpar();//Limpar caixas de texto
                    this.Mostrar();//Atualizar o grid
                    this.Botoes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //clicar duas vezes em um item da lista
        private void datalista_DoubleClick(object sender, EventArgs e)
        {
            this.txtidapresentacao.Text = Convert.ToString(this.datalista.CurrentRow.Cells["idapresentacao"].Value);//Pegar o Código do registro e preencher a caixa de texto Código com ele
            this.txtnome.Text = Convert.ToString(this.datalista.CurrentRow.Cells["nome"].Value);//Pegar o Código do registro e preencher a caixa de texto Nome com ele
            this.txtdescricao.Text = Convert.ToString(this.datalista.CurrentRow.Cells["descricao"].Value);//Pegar o Código do registro e preencher a caixa de texto Descrição com ele
            //--------------------//
            this.eEditar = true; //
            this.Botoes();      //
            //-----------------//
            this.tabControl1.SelectedIndex = 1;//Mudar para a aba Configuração
        }

        //Clicar no botão editar
        private void btneditar_Click(object sender, EventArgs e)
        {
            if (this.txtidapresentacao.Text.Equals(""))//caso o campo Nome esteja vazio
            {
                this.mensagemError("Selecione um registro para inserir");//Mensagem de erro
            }
            else//caso o campo nome esteja preenchido
            {
                this.eEditar = true;//Liberar edição
                this.Botoes();//Liberar botões
                this.Habilitar(true);//Habilitar caixas de texto

            }
        }

        //Clicar no botão cancelar
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;//Desabilitar criação de novo registro
            this.eEditar = false;//desabilitar edição
            this.Botoes();//desabilitar botões
            this.Habilitar(false);//desabilitar caixas de texto
            this.Limpar();//limpar caixas de texto
        }

        //botão de Check Deletar "chkdeletar"
        private void chkdeletar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkdeletar.Checked)//se o Check estiver ativado
            {
                this.datalista.Columns[0].Visible = true;//mostrar coluna deletar
                this.datalista.Columns[1].Visible = true;//mostrar coluna Código

            }
            else//Se o Check estiver desativado
            {
                this.datalista.Columns[0].Visible = false;//esconder coluna deletar
                this.datalista.Columns[1].Visible = false;//esconder coluna código
            }
        }

        //Check box deletar dentro do DataGrid após o chkdeletar estar ativado
        private void datalista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell chkDeletar = (DataGridViewCheckBoxCell)datalista.Rows[e.RowIndex].Cells["Deletar"];//pega a linha que esta marcada como check
                chkDeletar.Value = !Convert.ToBoolean(chkDeletar.Value);//pega a linha que esta marcada como check
            }
        }

        //Botão deletar
        private void btndeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcao;
                opcao = MessageBox.Show("Realmente deseja apagar o(s) registro(s)?", "SysSistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcao == DialogResult.OK)//Se a resposta do MessaBox for Ok
                {
                    string Cod;
                    string resposta = "";
                    foreach (DataGridViewRow linha in datalista.Rows)//Procura em cada linha do DataGrid
                    {
                        if (Convert.ToBoolean(linha.Cells[0].Value))//Se estiver marcada como check
                        {
                            Cod = Convert.ToString(linha.Cells[1].Value);//Pegar código do registro dessa linha
                            resposta = Napresentacao.Deletar(Convert.ToInt32(Cod));//Deletar registro
                        }
                    }
                    if (resposta.Equals("Ok"))//Caso tudo tenha dado Ok
                    {
                        this.mensagemOK("Registro(s) excluido(s) com sucesso");//Mostrar mensagem de OK
                    }
                    else//Caso algo tenha dado Errado
                    {
                        this.mensagemError(resposta);//Mostrar mensagem de erro
                    }
                    this.Mostrar();//Atualizar DataGrid

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
