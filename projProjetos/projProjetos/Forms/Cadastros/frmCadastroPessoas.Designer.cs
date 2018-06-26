namespace projProjetos.Forms.Cadastros
{
    partial class frmCadastroPessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroPessoas));
            this.tspPrincipal = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnInativar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblDataCriacao = new System.Windows.Forms.Label();
            this.txtDataEdicao = new System.Windows.Forms.MaskedTextBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.lblObServações = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this._bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tspPrincipal.SuspendLayout();
            this.grbInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tspPrincipal
            // 
            this.tspPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnSalvar,
            this.btnEditar,
            this.btnInativar,
            this.btnCancelar,
            this.btnPesquisar,
            this.btnSair});
            this.tspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tspPrincipal.Name = "tspPrincipal";
            this.tspPrincipal.Size = new System.Drawing.Size(939, 74);
            this.tspPrincipal.TabIndex = 0;
            this.tspPrincipal.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(54, 71);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(54, 71);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::projProjetos.Properties.Resources.btnAlterar;
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(54, 71);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInativar
            // 
            this.btnInativar.Enabled = false;
            this.btnInativar.Image = global::projProjetos.Properties.Resources.inativar;
            this.btnInativar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInativar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(54, 71);
            this.btnInativar.Text = "Inativar";
            this.btnInativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInativar.Click += new System.EventHandler(this.btnInativar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::projProjetos.Properties.Resources.btnCancelar;
            this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(62, 71);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::projProjetos.Properties.Resources.pesquisa;
            this.btnPesquisar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(68, 71);
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSair.Image = global::projProjetos.Properties.Resources.sair;
            this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 71);
            this.btnSair.Text = "Fechar";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.lblDataCriacao);
            this.grbInformacoes.Controls.Add(this.txtDataEdicao);
            this.grbInformacoes.Controls.Add(this.txtObservacoes);
            this.grbInformacoes.Controls.Add(this.lblObServações);
            this.grbInformacoes.Controls.Add(this.txtNome);
            this.grbInformacoes.Controls.Add(this.lblNome);
            this.grbInformacoes.Controls.Add(this.txtCodigo);
            this.grbInformacoes.Controls.Add(this.Codigo);
            this.grbInformacoes.Location = new System.Drawing.Point(16, 78);
            this.grbInformacoes.Margin = new System.Windows.Forms.Padding(4);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Padding = new System.Windows.Forms.Padding(4);
            this.grbInformacoes.Size = new System.Drawing.Size(910, 202);
            this.grbInformacoes.TabIndex = 0;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // lblDataCriacao
            // 
            this.lblDataCriacao.AutoSize = true;
            this.lblDataCriacao.Location = new System.Drawing.Point(682, 16);
            this.lblDataCriacao.Name = "lblDataCriacao";
            this.lblDataCriacao.Size = new System.Drawing.Size(104, 16);
            this.lblDataCriacao.TabIndex = 5;
            this.lblDataCriacao.Text = "Data de edição:";
            // 
            // txtDataEdicao
            // 
            this.txtDataEdicao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "DataCriacao", true));
            this.txtDataEdicao.Location = new System.Drawing.Point(792, 13);
            this.txtDataEdicao.Mask = "00/00/0000 90:00";
            this.txtDataEdicao.Name = "txtDataEdicao";
            this.txtDataEdicao.ReadOnly = true;
            this.txtDataEdicao.Size = new System.Drawing.Size(108, 22);
            this.txtDataEdicao.TabIndex = 3;
            this.txtDataEdicao.ValidatingType = typeof(System.DateTime);
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this._bindingSource, "OBSERVACAO", true));
            this.txtObservacoes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "OBSERVACAO", true));
            this.txtObservacoes.Location = new System.Drawing.Point(106, 72);
            this.txtObservacoes.MaxLength = 1024;
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.ReadOnly = true;
            this.txtObservacoes.Size = new System.Drawing.Size(794, 123);
            this.txtObservacoes.TabIndex = 2;
            // 
            // lblObServações
            // 
            this.lblObServações.AutoSize = true;
            this.lblObServações.Location = new System.Drawing.Point(7, 75);
            this.lblObServações.Name = "lblObServações";
            this.lblObServações.Size = new System.Drawing.Size(93, 16);
            this.lblObServações.TabIndex = 2;
            this.lblObServações.Text = "Observações:";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this._bindingSource, "NOME", true));
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "NOME", true));
            this.txtNome.Location = new System.Drawing.Point(106, 44);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(794, 22);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this._bindingSource, "ID", true));
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "ID", true));
            this.txtCodigo.Location = new System.Drawing.Point(106, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(126, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(7, 19);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(55, 16);
            this.Codigo.TabIndex = 0;
            this.Codigo.Text = "Código:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // _bindingSource
            // 
            this._bindingSource.DataSource = typeof(RegraNegocio.View.Pessoas.ViewPessoa);
            // 
            // frmCadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 287);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.tspPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SP3 :: Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.frmPessoas_Load);
            this.tspPrincipal.ResumeLayout(false);
            this.tspPrincipal.PerformLayout();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspPrincipal;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnInativar;
        private System.Windows.Forms.ToolStripButton btnPesquisar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label lblDataCriacao;
        private System.Windows.Forms.MaskedTextBox txtDataEdicao;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label lblObServações;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.BindingSource _bindingSource;
    }
}