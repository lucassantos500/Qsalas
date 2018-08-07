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
        private static frmProduto _instancia;
        
        public static frmProduto getInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new frmProduto();
            }
            return _instancia;
        }

        public void setCategoria (string idcategoria, string nome)
        {
            this.txtidcategoria.Text = idcategoria;
            this.txtcategoria.Text = nome;
        }

        public frmProduto()
        {
            InitializeComponent();
            this.ttmensagem.SetToolTip(this.txtnome, "Insira o nome do Produto");
            this.ttmensagem.SetToolTip(this.pximagem, "selecione uma imágem do produto");
            this.ttmensagem.SetToolTip(this.cbidapresentacao, "selecione uma apresentação do produto");
            this.ttmensagem.SetToolTip(this.txtcategoria, "selecione uma categoria do produto");

            this.txtidcategoria.Visible = false;
            this.txtcategoria.ReadOnly = true;

            this.preencherComboBox();
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
            this.txtcodigo.ReadOnly = !valor;
            this.txtnome.ReadOnly = !valor;
            this.txtdescricao.ReadOnly = !valor;
            this.btnbuscarcategoria.Enabled = valor;
            this.cbidapresentacao.Enabled = valor;
            this.btncarregar.Enabled = valor;
            this.btnlimpar.Enabled = valor;
            this.txtidproduto.ReadOnly = !valor;

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
            this.datalista.Columns[6].Visible = false;//Oculta a coluna referente a idcategoria no Grid
            this.datalista.Columns[8].Visible = false;//Oculta a coluna referente a idapresentacao no Grid

        }

        //Mostrar no DataGrid
        private void Mostrar()
        {
            this.datalista.DataSource = Nproduto.Mostrar();//Mostra as apresentações existentes
            this.ocultarColunas();//Oculta colunas do DataGrid desnecessárias(Deletar,Código)
            lbltotal.Text = "Total de registros: " + Convert.ToString(datalista.Rows.Count);//Atualiza a quantidade de registro no Label "lblTotal"
        }

        //Buscar pelo nome
        private void buscarNome()
        {
            this.datalista.DataSource = Nproduto.BuscarNome(this.txtbuscar.Text);//Busca nome passando o que está sendo digitado na caixa de texto "txtbuscar"
            this.ocultarColunas();//Oculta colunas do DataGrid desnecessárias(Deletar,Código)
            lbltotal.Text = "Total de registros: " + Convert.ToString(datalista.Rows.Count);//Atualiza a quantidade de registro no Label "lblTotal"
        }

        //Preencher combobox
        private void preencherComboBox()
        {
            cbidapresentacao.DataSource = Napresentacao.Mostrar();//Preencher o combox com a apresentação
            cbidapresentacao.ValueMember = "idapresentacao";//organizado pelo idapresentação
            cbidapresentacao.DisplayMember = "nome";//mostrando o nome no combobox
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

        //Clicar no botão upar img
        private void btncarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)//Se a imagem for ok
            {
                this.pximagem.SizeMode = PictureBoxSizeMode.StretchImage;//Ajustar seu tamanho no picture box
                this.pximagem.Image = Image.FromFile(dialog.FileName);
            }

        }

        //Quando o frm é carregado
        private void frmProduto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botoes();
        }

        //Clicar no botão limpar img
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            this.pximagem.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pximagem.Image = global::CamadaApresentação.Properties.Resources.no_image_icon_15;
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
            this.txtidproduto.Enabled = false;//Desativa a caixa de texto do Código (É auto_increment)
        }

        //Clicar no botão salvar
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resposta = "";
                if (this.txtnome.Text == string.Empty || this.txtidcategoria.Text == string.Empty || this.txtcodigo.Text == string.Empty)//Caso tenha deixado o campo "Nome" vazio
                {
                    mensagemError("Preencha todos os campos");
                    errorIcone.SetError(txtnome, "Insira um valor");
                    errorIcone.SetError(txtcodigo, "Insira um valor");
                    errorIcone.SetError(txtcategoria, "Insira um valor");
                    this.txtnome.Focus();//Coloca o foco no campo nome
                }
                else//Caso não tenha deixado o campo em branco
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();//Buffer de stream para armazenar a imagem do picture box
                    this.pximagem.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Png);//armazenando a imagem no stream no formato png

                    byte[] imagem = ms.GetBuffer();

                    if (this.eNovo)//Caso o eNovo(Clicou em botão novo) seja verdadeiro
                    {
                        //Inserir um novo registro
                        resposta = Nproduto.Inserir(this.txtcodigo.Text, this.txtnome.Text.Trim().ToUpper(), this.txtdescricao.Text.Trim().ToUpper(), imagem, Convert.ToInt32(this.txtidcategoria.Text), Convert.ToInt32(this.cbidapresentacao.SelectedValue) );
                    }
                    else//Caso o eNovo(Clicou em botão novo) seja falso
                    {
                        //Editar um registro existente
                        resposta = Nproduto.Editar(Convert.ToInt32(this.txtidproduto.Text), this.txtcodigo.Text, this.txtnome.Text.Trim().ToUpper(), this.txtdescricao.Text.Trim().ToUpper(), imagem, Convert.ToInt32(this.txtidcategoria.Text), Convert.ToInt32(this.cbidapresentacao.SelectedValue));
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

        //Clicar no botão editar
        private void btneditar_Click(object sender, EventArgs e)
        {
            if (this.txtidproduto.Text.Equals(""))//caso o campo Nome esteja vazio
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

        //Check box deletar dentro do DataGrid após o chkdeletar estar ativado
        private void datalista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell chkDeletar = (DataGridViewCheckBoxCell)datalista.Rows[e.RowIndex].Cells["Deletar"];//pega a linha que esta marcada como check
                chkDeletar.Value = !Convert.ToBoolean(chkDeletar.Value);//pega a linha que esta marcada como check
            }
        }

        private void datalista_DoubleClick(object sender, EventArgs e)
        {
            this.txtidproduto.Text = Convert.ToString(this.datalista.CurrentRow.Cells["idproduto"].Value);//Pegar o Código do registro e preencher a caixa de texto Código com ele
            this.txtcodigo.Text = Convert.ToString(this.datalista.CurrentRow.Cells["codigo"].Value);
            this.txtnome.Text = Convert.ToString(this.datalista.CurrentRow.Cells["nome"].Value);//Pegar o Código do registro e preencher a caixa de texto Nome com ele
            this.txtdescricao.Text = Convert.ToString(this.datalista.CurrentRow.Cells["descricao"].Value);//Pegar o Código do registro e preencher a caixa de texto Descrição com ele

            byte[] imagemBuffer = (byte[]) this.datalista.CurrentRow.Cells["imagem"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagemBuffer);

            this.pximagem.Image = Image.FromStream(ms);
            this.pximagem.SizeMode = PictureBoxSizeMode.StretchImage;

            this.txtidcategoria.Text = Convert.ToString(this.datalista.CurrentRow.Cells["idcategoria"].Value);
            this.txtcategoria.Text = Convert.ToString(this.datalista.CurrentRow.Cells["categoria"].Value);
            this.cbidapresentacao.SelectedValue = Convert.ToString(this.datalista.CurrentRow.Cells["idapresentacao"].Value);

            //--------------------//
            this.eEditar = true; //
            this.Botoes();      //
            //-----------------//
            this.tabControl1.SelectedIndex = 1;//Mudar para a aba Configuração
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
                            resposta = Nproduto.Deletar(Convert.ToInt32(Cod));//Deletar registro
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

        private void btnbuscarcategoria_Click(object sender, EventArgs e)
        {
            frmVistaCat_Prod form = new frmVistaCat_Prod();
            form.ShowDialog();

        }
    }
}
