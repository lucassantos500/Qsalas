﻿namespace CamadaApresentação
{
    partial class frmApresentacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ttmensagem = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkdeletar = new System.Windows.Forms.CheckBox();
            this.datalista = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtidapresentacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // ttmensagem
            // 
            this.ttmensagem.IsBalloon = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkdeletar);
            this.tabPage1.Controls.Add(this.datalista);
            this.tabPage1.Controls.Add(this.lbltotal);
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.btndeletar);
            this.tabPage1.Controls.Add(this.btnimprimir);
            this.tabPage1.Controls.Add(this.txtbuscar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkdeletar
            // 
            this.chkdeletar.AutoSize = true;
            this.chkdeletar.Location = new System.Drawing.Point(47, 50);
            this.chkdeletar.Name = "chkdeletar";
            this.chkdeletar.Size = new System.Drawing.Size(60, 17);
            this.chkdeletar.TabIndex = 7;
            this.chkdeletar.Text = "Deletar";
            this.chkdeletar.UseVisualStyleBackColor = true;
            this.chkdeletar.CheckedChanged += new System.EventHandler(this.chkdeletar_CheckedChanged);
            // 
            // datalista
            // 
            this.datalista.AllowUserToAddRows = false;
            this.datalista.AllowUserToDeleteRows = false;
            this.datalista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datalista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            this.datalista.Location = new System.Drawing.Point(9, 88);
            this.datalista.MultiSelect = false;
            this.datalista.Name = "datalista";
            this.datalista.ReadOnly = true;
            this.datalista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalista.Size = new System.Drawing.Size(750, 254);
            this.datalista.TabIndex = 6;
            this.datalista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalista_CellContentClick);
            this.datalista.DoubleClick += new System.EventHandler(this.datalista_DoubleClick);
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(471, 15);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 13);
            this.lbltotal.TabIndex = 5;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnbuscar.Location = new System.Drawing.Point(207, 10);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 4;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(288, 10);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(75, 23);
            this.btndeletar.TabIndex = 3;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(684, 10);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 23);
            this.btnimprimir.TabIndex = 2;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(47, 12);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(144, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(543, 228);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(166, 228);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(75, 23);
            this.btnnovo.TabIndex = 8;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(415, 228);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 7;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(288, 228);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 6;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(81, 139);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdescricao.Size = new System.Drawing.Size(623, 66);
            this.txtdescricao.TabIndex = 5;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(81, 87);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(160, 20);
            this.txtnome.TabIndex = 4;
            // 
            // txtidapresentacao
            // 
            this.txtidapresentacao.Location = new System.Drawing.Point(81, 36);
            this.txtidapresentacao.Name = "txtidapresentacao";
            this.txtidapresentacao.Size = new System.Drawing.Size(160, 20);
            this.txtidapresentacao.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btnnovo);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btnsalvar);
            this.groupBox1.Controls.Add(this.txtdescricao);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.txtidapresentacao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apresentacao";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configurações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 374);
            this.tabControl1.TabIndex = 3;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apresentacao";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmApresentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmApresentacao";
            this.Text = "Apresentacao";
            this.Load += new System.EventHandler(this.frmApresentacao_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttmensagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkdeletar;
        private System.Windows.Forms.DataGridView datalista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deletar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtidapresentacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.Label label1;
    }
}