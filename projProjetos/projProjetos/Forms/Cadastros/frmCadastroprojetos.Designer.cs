using System.Collections;

namespace projProjetos.Forms.Cadastros
{
    partial class FrmCadastroProjetos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroProjetos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tspPrincipal = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnInativar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tbReunioesProjeto = new System.Windows.Forms.TabControl();
            this.tbInformacoes = new System.Windows.Forms.TabPage();
            this.tbCadastro = new System.Windows.Forms.GroupBox();
            this.grbPrincipal = new System.Windows.Forms.GroupBox();
            this.txtNomeGerenteProjeto = new System.Windows.Forms.TextBox();
            this._bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPesquisaGerenteProjeto = new System.Windows.Forms.Button();
            this.txtCodigoGerente = new System.Windows.Forms.TextBox();
            this.rbEsforcoAdicionalAcima40PorCento = new System.Windows.Forms.RadioButton();
            this.rbEsforcoAdicional21A40PorCento = new System.Windows.Forms.RadioButton();
            this.rbEsforcoAdicional11A20PorCento = new System.Windows.Forms.RadioButton();
            this.rbEsforcoAdicionalAte10porCento = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cboApoioSteakholders = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboApoioAltaGestao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCapacidadeEntregaEquipe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInvestimentoPrevisto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtPrazoConclusao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDataAlteracao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbFluxoDeCaixa = new System.Windows.Forms.TabPage();
            this.grbFluxoCaixaProjeto = new System.Windows.Forms.GroupBox();
            this.grbIncluirReceitaVariavel = new System.Windows.Forms.GroupBox();
            this.btnReceitaVariavelCancelar = new System.Windows.Forms.Button();
            this.txtReceitaVariavelValor = new System.Windows.Forms.TextBox();
            this._bindingSourceReceitaVariavel = new System.Windows.Forms.BindingSource(this.components);
            this.dtpReceitaVariavelPeriodo = new System.Windows.Forms.DateTimePicker();
            this.btnReceitaVariavelSalvar = new System.Windows.Forms.Button();
            this.txtReceitaVariavelObservacoes = new System.Windows.Forms.TextBox();
            this.lblObservacoesFluxoCaixa = new System.Windows.Forms.Label();
            this.cboReceitaVariavelFluxo = new System.Windows.Forms.ComboBox();
            this.lblTipoFluxoCaixa = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.grbFluxoCaixaProjetoAcoes = new System.Windows.Forms.GroupBox();
            this.btnReceitaVariavelExcluir = new System.Windows.Forms.Button();
            this.btnReceitaVariavelEditar = new System.Windows.Forms.Button();
            this.btnReceitaVariavelIncluir = new System.Windows.Forms.Button();
            this.dtgReceitaVariavel = new System.Windows.Forms.DataGridView();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPeriodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProjetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgReceitaVariavelBtnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtgReceitaVariavelBtnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbParticipantes = new System.Windows.Forms.TabPage();
            this.grbParticipantes = new System.Windows.Forms.GroupBox();
            this.dtgProjetoPessoa = new System.Windows.Forms.DataGridView();
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataIngressoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityObjectDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProjetoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProjetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProjetoPessoaBtnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtgProjetoPessoaBtnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this._bindingSourceProjetoPessoa = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProjetoPessoaCancelar = new System.Windows.Forms.Button();
            this.txtProjetoPessoaNome = new System.Windows.Forms.TextBox();
            this.btnProjetoPessoaPesquisaPessoa = new System.Windows.Forms.Button();
            this.txtProjetoPessoaCodPessoa = new System.Windows.Forms.TextBox();
            this.dtpProjetoPessoaDataIngresso = new System.Windows.Forms.DateTimePicker();
            this.lblDataIngresso = new System.Windows.Forms.Label();
            this.txtProjetoPessoaObservacoes = new System.Windows.Forms.TextBox();
            this.lblObservacoesParticipantes = new System.Windows.Forms.Label();
            this.txtProjetoPessoaOcupacao = new System.Windows.Forms.TextBox();
            this.lblOcupacao = new System.Windows.Forms.Label();
            this.btnprojetoPessoaSalvar = new System.Windows.Forms.Button();
            this.lblParticipante = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnprojetoPessoaExcluir = new System.Windows.Forms.Button();
            this.btnProjetoPessoaEditar = new System.Windows.Forms.Button();
            this.btnProjetoPessoaIncluir = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grbReunioesProgramadas = new System.Windows.Forms.GroupBox();
            this.dtgReunioes = new System.Windows.Forms.DataGridView();
            this.tbpReunioesProgramadas = new System.Windows.Forms.TabControl();
            this.tbReuniaoInformacoes = new System.Windows.Forms.TabPage();
            this.grbReuniaoInformacoes = new System.Windows.Forms.GroupBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.lblReuniaoObservacoes = new System.Windows.Forms.Label();
            this.cklReuniaoSituacao = new System.Windows.Forms.CheckedListBox();
            this.lblReuniaoSituacao = new System.Windows.Forms.Label();
            this.txtReuniaoDataRealizacao = new System.Windows.Forms.MaskedTextBox();
            this.txtReuniaoDescricao = new System.Windows.Forms.TextBox();
            this.lblReuniaoDataRealizacao = new System.Windows.Forms.Label();
            this.lblReuniaoDescricao = new System.Windows.Forms.Label();
            this.txtReuniaoCodigo = new System.Windows.Forms.TextBox();
            this.lblReuniaoCodigo = new System.Windows.Forms.Label();
            this.tbReuniaoResultado = new System.Windows.Forms.TabPage();
            this.dtgReuniaoResultado = new System.Windows.Forms.DataGridView();
            this.rbMultiplasReceitas = new System.Windows.Forms.RadioButton();
            this.rbReceitaUnica = new System.Windows.Forms.RadioButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tspPrincipal.SuspendLayout();
            this.tbReunioesProjeto.SuspendLayout();
            this.tbInformacoes.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.grbPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSource)).BeginInit();
            this.tbFluxoDeCaixa.SuspendLayout();
            this.grbFluxoCaixaProjeto.SuspendLayout();
            this.grbIncluirReceitaVariavel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceReceitaVariavel)).BeginInit();
            this.grbFluxoCaixaProjetoAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReceitaVariavel)).BeginInit();
            this.tbParticipantes.SuspendLayout();
            this.grbParticipantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProjetoPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceProjetoPessoa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbReunioesProgramadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReunioes)).BeginInit();
            this.tbpReunioesProgramadas.SuspendLayout();
            this.tbReuniaoInformacoes.SuspendLayout();
            this.grbReuniaoInformacoes.SuspendLayout();
            this.tbReuniaoResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReuniaoResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // tspPrincipal
            // 
            this.tspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnSalvar,
            this.btnAlterar,
            this.btnInativar,
            this.btnCancelar,
            this.btnPesquisar,
            this.btnSair});
            this.tspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tspPrincipal.Name = "tspPrincipal";
            this.tspPrincipal.Size = new System.Drawing.Size(939, 72);
            this.tspPrincipal.TabIndex = 0;
            this.tspPrincipal.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::projProjetos.Properties.Resources.novo;
            this.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(54, 69);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = global::projProjetos.Properties.Resources.salvar;
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(54, 69);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Image = global::projProjetos.Properties.Resources.btnAlterar;
            this.btnAlterar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(54, 69);
            this.btnAlterar.Text = "Editar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInativar
            // 
            this.btnInativar.Enabled = false;
            this.btnInativar.Image = global::projProjetos.Properties.Resources.ativar;
            this.btnInativar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInativar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(54, 69);
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
            this.btnCancelar.Size = new System.Drawing.Size(57, 69);
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
            this.btnPesquisar.Size = new System.Drawing.Size(61, 69);
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
            this.btnSair.Size = new System.Drawing.Size(36, 69);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tbReunioesProjeto
            // 
            this.tbReunioesProjeto.Controls.Add(this.tbInformacoes);
            this.tbReunioesProjeto.Controls.Add(this.tbFluxoDeCaixa);
            this.tbReunioesProjeto.Controls.Add(this.tbParticipantes);
            this.tbReunioesProjeto.Controls.Add(this.tabPage1);
            this.tbReunioesProjeto.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbReunioesProjeto.Location = new System.Drawing.Point(0, 72);
            this.tbReunioesProjeto.Name = "tbReunioesProjeto";
            this.tbReunioesProjeto.SelectedIndex = 0;
            this.tbReunioesProjeto.Size = new System.Drawing.Size(939, 366);
            this.tbReunioesProjeto.TabIndex = 2;
            // 
            // tbInformacoes
            // 
            this.tbInformacoes.Controls.Add(this.tbCadastro);
            this.tbInformacoes.Location = new System.Drawing.Point(4, 25);
            this.tbInformacoes.Name = "tbInformacoes";
            this.tbInformacoes.Padding = new System.Windows.Forms.Padding(3);
            this.tbInformacoes.Size = new System.Drawing.Size(931, 337);
            this.tbInformacoes.TabIndex = 0;
            this.tbInformacoes.Text = "Informações cadastrais";
            this.tbInformacoes.UseVisualStyleBackColor = true;
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.grbPrincipal);
            this.tbCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCadastro.Location = new System.Drawing.Point(3, 3);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Size = new System.Drawing.Size(925, 331);
            this.tbCadastro.TabIndex = 0;
            this.tbCadastro.TabStop = false;
            // 
            // grbPrincipal
            // 
            this.grbPrincipal.Controls.Add(this.txtNomeGerenteProjeto);
            this.grbPrincipal.Controls.Add(this.btnPesquisaGerenteProjeto);
            this.grbPrincipal.Controls.Add(this.txtCodigoGerente);
            this.grbPrincipal.Controls.Add(this.rbEsforcoAdicionalAcima40PorCento);
            this.grbPrincipal.Controls.Add(this.rbEsforcoAdicional21A40PorCento);
            this.grbPrincipal.Controls.Add(this.rbEsforcoAdicional11A20PorCento);
            this.grbPrincipal.Controls.Add(this.rbEsforcoAdicionalAte10porCento);
            this.grbPrincipal.Controls.Add(this.label9);
            this.grbPrincipal.Controls.Add(this.cboApoioSteakholders);
            this.grbPrincipal.Controls.Add(this.label8);
            this.grbPrincipal.Controls.Add(this.cboApoioAltaGestao);
            this.grbPrincipal.Controls.Add(this.label7);
            this.grbPrincipal.Controls.Add(this.cboCapacidadeEntregaEquipe);
            this.grbPrincipal.Controls.Add(this.label6);
            this.grbPrincipal.Controls.Add(this.label3);
            this.grbPrincipal.Controls.Add(this.label5);
            this.grbPrincipal.Controls.Add(this.txtInvestimentoPrevisto);
            this.grbPrincipal.Controls.Add(this.label1);
            this.grbPrincipal.Controls.Add(this.txtDataAlteracao);
            this.grbPrincipal.Controls.Add(this.txtDescricao);
            this.grbPrincipal.Controls.Add(this.label2);
            this.grbPrincipal.Controls.Add(this.txtNome);
            this.grbPrincipal.Controls.Add(this.label4);
            this.grbPrincipal.Controls.Add(this.lblNome);
            this.grbPrincipal.Controls.Add(this.txtPrazoConclusao);
            this.grbPrincipal.Controls.Add(this.txtCodigo);
            this.grbPrincipal.Controls.Add(this.lblDataAlteracao);
            this.grbPrincipal.Controls.Add(this.lblCodigo);
            this.grbPrincipal.Location = new System.Drawing.Point(6, 21);
            this.grbPrincipal.Name = "grbPrincipal";
            this.grbPrincipal.Size = new System.Drawing.Size(769, 304);
            this.grbPrincipal.TabIndex = 4;
            this.grbPrincipal.TabStop = false;
            this.grbPrincipal.Text = "Informações";
            // 
            // txtNomeGerenteProjeto
            // 
            this.txtNomeGerenteProjeto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeGerenteProjeto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "NomeGerenteProjeto", true));
            this.txtNomeGerenteProjeto.Enabled = false;
            this.txtNomeGerenteProjeto.Location = new System.Drawing.Point(294, 83);
            this.txtNomeGerenteProjeto.Name = "txtNomeGerenteProjeto";
            this.txtNomeGerenteProjeto.ReadOnly = true;
            this.txtNomeGerenteProjeto.Size = new System.Drawing.Size(465, 22);
            this.txtNomeGerenteProjeto.TabIndex = 24;
            // 
            // _bindingSource
            // 
            this._bindingSource.DataSource = typeof(RegraNegocio.View.Projetos.ViewProjeto);
            this._bindingSource.CurrentChanged += new System.EventHandler(this._bindingSource_CurrentChanged);
            // 
            // btnPesquisaGerenteProjeto
            // 
            this.btnPesquisaGerenteProjeto.Enabled = false;
            this.btnPesquisaGerenteProjeto.Location = new System.Drawing.Point(187, 83);
            this.btnPesquisaGerenteProjeto.Name = "btnPesquisaGerenteProjeto";
            this.btnPesquisaGerenteProjeto.Size = new System.Drawing.Size(35, 23);
            this.btnPesquisaGerenteProjeto.TabIndex = 23;
            this.btnPesquisaGerenteProjeto.Text = "...";
            this.btnPesquisaGerenteProjeto.UseVisualStyleBackColor = true;
            this.btnPesquisaGerenteProjeto.Click += new System.EventHandler(this.btnPesquisaGerenteProjeto_Click);
            // 
            // txtCodigoGerente
            // 
            this.txtCodigoGerente.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoGerente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "IdGerenteProjeto", true));
            this.txtCodigoGerente.Enabled = false;
            this.txtCodigoGerente.Location = new System.Drawing.Point(228, 83);
            this.txtCodigoGerente.Name = "txtCodigoGerente";
            this.txtCodigoGerente.ReadOnly = true;
            this.txtCodigoGerente.Size = new System.Drawing.Size(63, 22);
            this.txtCodigoGerente.TabIndex = 22;
            // 
            // rbEsforcoAdicionalAcima40PorCento
            // 
            this.rbEsforcoAdicionalAcima40PorCento.AutoSize = true;
            this.rbEsforcoAdicionalAcima40PorCento.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this._bindingSource, "BoolEsforcoAdicionalmaior40PorCento", true));
            this.rbEsforcoAdicionalAcima40PorCento.Enabled = false;
            this.rbEsforcoAdicionalAcima40PorCento.Location = new System.Drawing.Point(532, 200);
            this.rbEsforcoAdicionalAcima40PorCento.Name = "rbEsforcoAdicionalAcima40PorCento";
            this.rbEsforcoAdicionalAcima40PorCento.Size = new System.Drawing.Size(112, 20);
            this.rbEsforcoAdicionalAcima40PorCento.TabIndex = 21;
            this.rbEsforcoAdicionalAcima40PorCento.Text = "Acima de 40%";
            this.rbEsforcoAdicionalAcima40PorCento.UseVisualStyleBackColor = true;
            // 
            // rbEsforcoAdicional21A40PorCento
            // 
            this.rbEsforcoAdicional21A40PorCento.AutoSize = true;
            this.rbEsforcoAdicional21A40PorCento.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this._bindingSource, "BoolEsforcoAdicionalEntre21e40PorCento", true));
            this.rbEsforcoAdicional21A40PorCento.Enabled = false;
            this.rbEsforcoAdicional21A40PorCento.Location = new System.Drawing.Point(400, 200);
            this.rbEsforcoAdicional21A40PorCento.Name = "rbEsforcoAdicional21A40PorCento";
            this.rbEsforcoAdicional21A40PorCento.Size = new System.Drawing.Size(126, 20);
            this.rbEsforcoAdicional21A40PorCento.TabIndex = 20;
            this.rbEsforcoAdicional21A40PorCento.Text = "Entre 21% e 40%";
            this.rbEsforcoAdicional21A40PorCento.UseVisualStyleBackColor = true;
            // 
            // rbEsforcoAdicional11A20PorCento
            // 
            this.rbEsforcoAdicional11A20PorCento.AutoSize = true;
            this.rbEsforcoAdicional11A20PorCento.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this._bindingSource, "BoolEsforcoAdicionalEntre11e20PorCento", true));
            this.rbEsforcoAdicional11A20PorCento.Enabled = false;
            this.rbEsforcoAdicional11A20PorCento.Location = new System.Drawing.Point(268, 200);
            this.rbEsforcoAdicional11A20PorCento.Name = "rbEsforcoAdicional11A20PorCento";
            this.rbEsforcoAdicional11A20PorCento.Size = new System.Drawing.Size(126, 20);
            this.rbEsforcoAdicional11A20PorCento.TabIndex = 19;
            this.rbEsforcoAdicional11A20PorCento.Text = "Entre 11% a 20%";
            this.rbEsforcoAdicional11A20PorCento.UseVisualStyleBackColor = true;
            // 
            // rbEsforcoAdicionalAte10porCento
            // 
            this.rbEsforcoAdicionalAte10porCento.AutoSize = true;
            this.rbEsforcoAdicionalAte10porCento.Checked = true;
            this.rbEsforcoAdicionalAte10porCento.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this._bindingSource, "BoolEsforcoAdicionalAte10PorCento", true));
            this.rbEsforcoAdicionalAte10porCento.Enabled = false;
            this.rbEsforcoAdicionalAte10porCento.Location = new System.Drawing.Point(187, 200);
            this.rbEsforcoAdicionalAte10porCento.Name = "rbEsforcoAdicionalAte10porCento";
            this.rbEsforcoAdicionalAte10porCento.Size = new System.Drawing.Size(75, 20);
            this.rbEsforcoAdicionalAte10porCento.TabIndex = 18;
            this.rbEsforcoAdicionalAte10porCento.TabStop = true;
            this.rbEsforcoAdicionalAte10porCento.Text = "Até 10%";
            this.rbEsforcoAdicionalAte10porCento.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Esforço Adicional:";
            // 
            // cboApoioSteakholders
            // 
            this.cboApoioSteakholders.DataSource = this._bindingSource;
            this.cboApoioSteakholders.DisplayMember = "DescricaoApoioSteakHolders";
            this.cboApoioSteakholders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboApoioSteakholders.Enabled = false;
            this.cboApoioSteakholders.FormattingEnabled = true;
            this.cboApoioSteakholders.Location = new System.Drawing.Point(187, 167);
            this.cboApoioSteakholders.Name = "cboApoioSteakholders";
            this.cboApoioSteakholders.Size = new System.Drawing.Size(200, 24);
            this.cboApoioSteakholders.TabIndex = 16;
            this.cboApoioSteakholders.ValueMember = "DescricaoApoioSteakHolders";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Apoio dos Steakeholders:";
            // 
            // cboApoioAltaGestao
            // 
            this.cboApoioAltaGestao.DataSource = this._bindingSource;
            this.cboApoioAltaGestao.DisplayMember = "DescricaoApoioAltaGestao";
            this.cboApoioAltaGestao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboApoioAltaGestao.Enabled = false;
            this.cboApoioAltaGestao.FormattingEnabled = true;
            this.cboApoioAltaGestao.Location = new System.Drawing.Point(568, 155);
            this.cboApoioAltaGestao.Name = "cboApoioAltaGestao";
            this.cboApoioAltaGestao.Size = new System.Drawing.Size(191, 24);
            this.cboApoioAltaGestao.TabIndex = 14;
            this.cboApoioAltaGestao.ValueMember = "DescricaoApoioAltaGestao";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Apoio \r\nda Alta Gestão:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCapacidadeEntregaEquipe
            // 
            this.cboCapacidadeEntregaEquipe.DataSource = this._bindingSource;
            this.cboCapacidadeEntregaEquipe.DisplayMember = "DescricaoCapacidadeEntregaEquipe";
            this.cboCapacidadeEntregaEquipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCapacidadeEntregaEquipe.Enabled = false;
            this.cboCapacidadeEntregaEquipe.FormattingEnabled = true;
            this.cboCapacidadeEntregaEquipe.Location = new System.Drawing.Point(568, 117);
            this.cboCapacidadeEntregaEquipe.Name = "cboCapacidadeEntregaEquipe";
            this.cboCapacidadeEntregaEquipe.Size = new System.Drawing.Size(191, 24);
            this.cboCapacidadeEntregaEquipe.TabIndex = 12;
            this.cboCapacidadeEntregaEquipe.ValueMember = "DescricaoCapacidadeEntregaEquipe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Capacidade de\r\n Entrega da Equipe:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Un. Meses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Previsão de duração:";
            // 
            // txtInvestimentoPrevisto
            // 
            this.txtInvestimentoPrevisto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "InvestimentoPrevisto", true));
            this.txtInvestimentoPrevisto.Location = new System.Drawing.Point(187, 139);
            this.txtInvestimentoPrevisto.Name = "txtInvestimentoPrevisto";
            this.txtInvestimentoPrevisto.ReadOnly = true;
            this.txtInvestimentoPrevisto.Size = new System.Drawing.Size(200, 22);
            this.txtInvestimentoPrevisto.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gerente do Projeto..(Enter):";
            // 
            // txtDataAlteracao
            // 
            this.txtDataAlteracao.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataAlteracao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "DataCricao", true));
            this.txtDataAlteracao.Location = new System.Drawing.Point(611, 25);
            this.txtDataAlteracao.Mask = "00/00/0000";
            this.txtDataAlteracao.Name = "txtDataAlteracao";
            this.txtDataAlteracao.ReadOnly = true;
            this.txtDataAlteracao.Size = new System.Drawing.Size(148, 22);
            this.txtDataAlteracao.TabIndex = 3;
            this.txtDataAlteracao.ValidatingType = typeof(System.DateTime);
            this.txtDataAlteracao.Visible = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "Descricao", true));
            this.txtDescricao.Location = new System.Drawing.Point(187, 240);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(572, 58);
            this.txtDescricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Decrição:";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "Nome", true));
            this.txtNome.Location = new System.Drawing.Point(187, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(572, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Investimento previsto:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtPrazoConclusao
            // 
            this.txtPrazoConclusao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "TempoPrevistoConclusao", true));
            this.txtPrazoConclusao.Location = new System.Drawing.Point(187, 111);
            this.txtPrazoConclusao.Name = "txtPrazoConclusao";
            this.txtPrazoConclusao.ReadOnly = true;
            this.txtPrazoConclusao.Size = new System.Drawing.Size(104, 22);
            this.txtPrazoConclusao.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "Id", true));
            this.txtCodigo.Location = new System.Drawing.Point(187, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(200, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblDataAlteracao
            // 
            this.lblDataAlteracao.AutoSize = true;
            this.lblDataAlteracao.Location = new System.Drawing.Point(505, 28);
            this.lblDataAlteracao.Name = "lblDataAlteracao";
            this.lblDataAlteracao.Size = new System.Drawing.Size(100, 16);
            this.lblDataAlteracao.TabIndex = 0;
            this.lblDataAlteracao.Text = "Data alteração:";
            this.lblDataAlteracao.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 28);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(55, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // tbFluxoDeCaixa
            // 
            this.tbFluxoDeCaixa.Controls.Add(this.grbFluxoCaixaProjeto);
            this.tbFluxoDeCaixa.Location = new System.Drawing.Point(4, 25);
            this.tbFluxoDeCaixa.Name = "tbFluxoDeCaixa";
            this.tbFluxoDeCaixa.Padding = new System.Windows.Forms.Padding(3);
            this.tbFluxoDeCaixa.Size = new System.Drawing.Size(931, 337);
            this.tbFluxoDeCaixa.TabIndex = 1;
            this.tbFluxoDeCaixa.Text = "Receitas/Despesas previstas";
            this.tbFluxoDeCaixa.UseVisualStyleBackColor = true;
            // 
            // grbFluxoCaixaProjeto
            // 
            this.grbFluxoCaixaProjeto.Controls.Add(this.grbIncluirReceitaVariavel);
            this.grbFluxoCaixaProjeto.Controls.Add(this.grbFluxoCaixaProjetoAcoes);
            this.grbFluxoCaixaProjeto.Controls.Add(this.dtgReceitaVariavel);
            this.grbFluxoCaixaProjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbFluxoCaixaProjeto.Location = new System.Drawing.Point(3, 3);
            this.grbFluxoCaixaProjeto.Name = "grbFluxoCaixaProjeto";
            this.grbFluxoCaixaProjeto.Size = new System.Drawing.Size(925, 331);
            this.grbFluxoCaixaProjeto.TabIndex = 0;
            this.grbFluxoCaixaProjeto.TabStop = false;
            this.grbFluxoCaixaProjeto.Text = "Receitas/Despesas do projeto";
            // 
            // grbIncluirReceitaVariavel
            // 
            this.grbIncluirReceitaVariavel.Controls.Add(this.btnReceitaVariavelCancelar);
            this.grbIncluirReceitaVariavel.Controls.Add(this.txtReceitaVariavelValor);
            this.grbIncluirReceitaVariavel.Controls.Add(this.dtpReceitaVariavelPeriodo);
            this.grbIncluirReceitaVariavel.Controls.Add(this.btnReceitaVariavelSalvar);
            this.grbIncluirReceitaVariavel.Controls.Add(this.txtReceitaVariavelObservacoes);
            this.grbIncluirReceitaVariavel.Controls.Add(this.lblObservacoesFluxoCaixa);
            this.grbIncluirReceitaVariavel.Controls.Add(this.cboReceitaVariavelFluxo);
            this.grbIncluirReceitaVariavel.Controls.Add(this.lblTipoFluxoCaixa);
            this.grbIncluirReceitaVariavel.Controls.Add(this.lblValor);
            this.grbIncluirReceitaVariavel.Controls.Add(this.lblPeriodo);
            this.grbIncluirReceitaVariavel.Location = new System.Drawing.Point(105, 21);
            this.grbIncluirReceitaVariavel.Name = "grbIncluirReceitaVariavel";
            this.grbIncluirReceitaVariavel.Size = new System.Drawing.Size(814, 107);
            this.grbIncluirReceitaVariavel.TabIndex = 7;
            this.grbIncluirReceitaVariavel.TabStop = false;
            // 
            // btnReceitaVariavelCancelar
            // 
            this.btnReceitaVariavelCancelar.Location = new System.Drawing.Point(635, 72);
            this.btnReceitaVariavelCancelar.Name = "btnReceitaVariavelCancelar";
            this.btnReceitaVariavelCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnReceitaVariavelCancelar.TabIndex = 9;
            this.btnReceitaVariavelCancelar.Text = "Cancelar";
            this.btnReceitaVariavelCancelar.UseVisualStyleBackColor = true;
            this.btnReceitaVariavelCancelar.Click += new System.EventHandler(this.btnReceitaVariavelCancelar_Click);
            // 
            // txtReceitaVariavelValor
            // 
            this.txtReceitaVariavelValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSourceReceitaVariavel, "Valor", true));
            this.txtReceitaVariavelValor.Location = new System.Drawing.Point(100, 74);
            this.txtReceitaVariavelValor.Name = "txtReceitaVariavelValor";
            this.txtReceitaVariavelValor.ReadOnly = true;
            this.txtReceitaVariavelValor.Size = new System.Drawing.Size(140, 22);
            this.txtReceitaVariavelValor.TabIndex = 8;
            // 
            // _bindingSourceReceitaVariavel
            // 
            this._bindingSourceReceitaVariavel.DataSource = typeof(RegraNegocio.View.Projetos.ViewProjetosReceitaVariavel);
            this._bindingSourceReceitaVariavel.CurrentChanged += new System.EventHandler(this._bindingSourceReceitaVariavel_CurrentChanged);
            // 
            // dtpReceitaVariavelPeriodo
            // 
            this.dtpReceitaVariavelPeriodo.CustomFormat = "dd/MM/yyyy";
            this.dtpReceitaVariavelPeriodo.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._bindingSourceReceitaVariavel, "DataPeriodo", true));
            this.dtpReceitaVariavelPeriodo.Enabled = false;
            this.dtpReceitaVariavelPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceitaVariavelPeriodo.Location = new System.Drawing.Point(100, 12);
            this.dtpReceitaVariavelPeriodo.Name = "dtpReceitaVariavelPeriodo";
            this.dtpReceitaVariavelPeriodo.Size = new System.Drawing.Size(140, 22);
            this.dtpReceitaVariavelPeriodo.TabIndex = 7;
            // 
            // btnReceitaVariavelSalvar
            // 
            this.btnReceitaVariavelSalvar.Enabled = false;
            this.btnReceitaVariavelSalvar.Location = new System.Drawing.Point(716, 72);
            this.btnReceitaVariavelSalvar.Name = "btnReceitaVariavelSalvar";
            this.btnReceitaVariavelSalvar.Size = new System.Drawing.Size(77, 23);
            this.btnReceitaVariavelSalvar.TabIndex = 1;
            this.btnReceitaVariavelSalvar.Text = "Salvar";
            this.btnReceitaVariavelSalvar.UseVisualStyleBackColor = true;
            this.btnReceitaVariavelSalvar.Click += new System.EventHandler(this.btnReceitaVariavelSalvar_Click);
            // 
            // txtReceitaVariavelObservacoes
            // 
            this.txtReceitaVariavelObservacoes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSourceReceitaVariavel, "Observacoes", true));
            this.txtReceitaVariavelObservacoes.Location = new System.Drawing.Point(365, 14);
            this.txtReceitaVariavelObservacoes.Multiline = true;
            this.txtReceitaVariavelObservacoes.Name = "txtReceitaVariavelObservacoes";
            this.txtReceitaVariavelObservacoes.ReadOnly = true;
            this.txtReceitaVariavelObservacoes.Size = new System.Drawing.Size(428, 52);
            this.txtReceitaVariavelObservacoes.TabIndex = 5;
            // 
            // lblObservacoesFluxoCaixa
            // 
            this.lblObservacoesFluxoCaixa.AutoSize = true;
            this.lblObservacoesFluxoCaixa.Location = new System.Drawing.Point(266, 17);
            this.lblObservacoesFluxoCaixa.Name = "lblObservacoesFluxoCaixa";
            this.lblObservacoesFluxoCaixa.Size = new System.Drawing.Size(93, 16);
            this.lblObservacoesFluxoCaixa.TabIndex = 4;
            this.lblObservacoesFluxoCaixa.Text = "Observações:";
            // 
            // cboReceitaVariavelFluxo
            // 
            this.cboReceitaVariavelFluxo.DataSource = this._bindingSourceReceitaVariavel;
            this.cboReceitaVariavelFluxo.DisplayMember = "Tipo";
            this.cboReceitaVariavelFluxo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReceitaVariavelFluxo.Enabled = false;
            this.cboReceitaVariavelFluxo.FormattingEnabled = true;
            this.cboReceitaVariavelFluxo.Location = new System.Drawing.Point(100, 42);
            this.cboReceitaVariavelFluxo.Name = "cboReceitaVariavelFluxo";
            this.cboReceitaVariavelFluxo.Size = new System.Drawing.Size(141, 24);
            this.cboReceitaVariavelFluxo.TabIndex = 3;
            this.cboReceitaVariavelFluxo.ValueMember = "Tipo";
            // 
            // lblTipoFluxoCaixa
            // 
            this.lblTipoFluxoCaixa.AutoSize = true;
            this.lblTipoFluxoCaixa.Location = new System.Drawing.Point(6, 45);
            this.lblTipoFluxoCaixa.Name = "lblTipoFluxoCaixa";
            this.lblTipoFluxoCaixa.Size = new System.Drawing.Size(88, 16);
            this.lblTipoFluxoCaixa.TabIndex = 2;
            this.lblTipoFluxoCaixa.Text = "Tipo do fluxo:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(6, 75);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 16);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor:";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(6, 17);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(59, 16);
            this.lblPeriodo.TabIndex = 0;
            this.lblPeriodo.Text = "Periodo:";
            // 
            // grbFluxoCaixaProjetoAcoes
            // 
            this.grbFluxoCaixaProjetoAcoes.Controls.Add(this.btnReceitaVariavelExcluir);
            this.grbFluxoCaixaProjetoAcoes.Controls.Add(this.btnReceitaVariavelEditar);
            this.grbFluxoCaixaProjetoAcoes.Controls.Add(this.btnReceitaVariavelIncluir);
            this.grbFluxoCaixaProjetoAcoes.Location = new System.Drawing.Point(10, 21);
            this.grbFluxoCaixaProjetoAcoes.Name = "grbFluxoCaixaProjetoAcoes";
            this.grbFluxoCaixaProjetoAcoes.Size = new System.Drawing.Size(89, 107);
            this.grbFluxoCaixaProjetoAcoes.TabIndex = 6;
            this.grbFluxoCaixaProjetoAcoes.TabStop = false;
            this.grbFluxoCaixaProjetoAcoes.Text = "Ações";
            // 
            // btnReceitaVariavelExcluir
            // 
            this.btnReceitaVariavelExcluir.Enabled = false;
            this.btnReceitaVariavelExcluir.Location = new System.Drawing.Point(6, 79);
            this.btnReceitaVariavelExcluir.Name = "btnReceitaVariavelExcluir";
            this.btnReceitaVariavelExcluir.Size = new System.Drawing.Size(77, 23);
            this.btnReceitaVariavelExcluir.TabIndex = 0;
            this.btnReceitaVariavelExcluir.Text = "Excluir";
            this.btnReceitaVariavelExcluir.UseVisualStyleBackColor = true;
            this.btnReceitaVariavelExcluir.Click += new System.EventHandler(this.btnReceitaVariavelExcluir_Click);
            // 
            // btnReceitaVariavelEditar
            // 
            this.btnReceitaVariavelEditar.Enabled = false;
            this.btnReceitaVariavelEditar.Location = new System.Drawing.Point(6, 50);
            this.btnReceitaVariavelEditar.Name = "btnReceitaVariavelEditar";
            this.btnReceitaVariavelEditar.Size = new System.Drawing.Size(77, 23);
            this.btnReceitaVariavelEditar.TabIndex = 0;
            this.btnReceitaVariavelEditar.Text = "Editar";
            this.btnReceitaVariavelEditar.UseVisualStyleBackColor = true;
            this.btnReceitaVariavelEditar.Click += new System.EventHandler(this.btnReceitaVariavelEditar_Click);
            // 
            // btnReceitaVariavelIncluir
            // 
            this.btnReceitaVariavelIncluir.Enabled = false;
            this.btnReceitaVariavelIncluir.Location = new System.Drawing.Point(6, 21);
            this.btnReceitaVariavelIncluir.Name = "btnReceitaVariavelIncluir";
            this.btnReceitaVariavelIncluir.Size = new System.Drawing.Size(77, 23);
            this.btnReceitaVariavelIncluir.TabIndex = 0;
            this.btnReceitaVariavelIncluir.Text = "Incluir Receita";
            this.btnReceitaVariavelIncluir.UseVisualStyleBackColor = true;
            this.btnReceitaVariavelIncluir.Click += new System.EventHandler(this.btnReceitaVariavelIncluir_Click);
            // 
            // dtgReceitaVariavel
            // 
            this.dtgReceitaVariavel.AllowUserToAddRows = false;
            this.dtgReceitaVariavel.AllowUserToDeleteRows = false;
            this.dtgReceitaVariavel.AutoGenerateColumns = false;
            this.dtgReceitaVariavel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReceitaVariavel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoDataGridViewTextBoxColumn,
            this.dataPeriodoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.dataCriacaoDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn,
            this.entityObjectDataGridViewTextBoxColumn,
            this.idProjetoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dtgReceitaVariavelBtnEditar,
            this.dtgReceitaVariavelBtnExcluir});
            this.dtgReceitaVariavel.DataSource = this._bindingSourceReceitaVariavel;
            this.dtgReceitaVariavel.Location = new System.Drawing.Point(10, 134);
            this.dtgReceitaVariavel.MultiSelect = false;
            this.dtgReceitaVariavel.Name = "dtgReceitaVariavel";
            this.dtgReceitaVariavel.ReadOnly = true;
            this.dtgReceitaVariavel.RowHeadersVisible = false;
            this.dtgReceitaVariavel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgReceitaVariavel.Size = new System.Drawing.Size(909, 191);
            this.dtgReceitaVariavel.TabIndex = 5;
            this.dtgReceitaVariavel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgReceitaVariavel_CellContentClick);
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 120;
            // 
            // dataPeriodoDataGridViewTextBoxColumn
            // 
            this.dataPeriodoDataGridViewTextBoxColumn.DataPropertyName = "DataPeriodo";
            this.dataPeriodoDataGridViewTextBoxColumn.HeaderText = "Período";
            this.dataPeriodoDataGridViewTextBoxColumn.Name = "dataPeriodoDataGridViewTextBoxColumn";
            this.dataPeriodoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataPeriodoDataGridViewTextBoxColumn.Width = 150;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0,00";
            this.valorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataCriacaoDataGridViewTextBoxColumn
            // 
            this.dataCriacaoDataGridViewTextBoxColumn.DataPropertyName = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.HeaderText = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.Name = "dataCriacaoDataGridViewTextBoxColumn";
            this.dataCriacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCriacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacoesDataGridViewTextBoxColumn.Width = 400;
            // 
            // entityObjectDataGridViewTextBoxColumn
            // 
            this.entityObjectDataGridViewTextBoxColumn.DataPropertyName = "EntityObject";
            this.entityObjectDataGridViewTextBoxColumn.HeaderText = "EntityObject";
            this.entityObjectDataGridViewTextBoxColumn.Name = "entityObjectDataGridViewTextBoxColumn";
            this.entityObjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.entityObjectDataGridViewTextBoxColumn.Visible = false;
            // 
            // idProjetoDataGridViewTextBoxColumn
            // 
            this.idProjetoDataGridViewTextBoxColumn.DataPropertyName = "IdProjeto";
            this.idProjetoDataGridViewTextBoxColumn.HeaderText = "IdProjeto";
            this.idProjetoDataGridViewTextBoxColumn.Name = "idProjetoDataGridViewTextBoxColumn";
            this.idProjetoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProjetoDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtgReceitaVariavelBtnEditar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.NullValue = null;
            this.dtgReceitaVariavelBtnEditar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgReceitaVariavelBtnEditar.HeaderText = "";
            this.dtgReceitaVariavelBtnEditar.Image = global::projProjetos.Properties.Resources.editar;
            this.dtgReceitaVariavelBtnEditar.Name = "dtgReceitaVariavelBtnEditar";
            this.dtgReceitaVariavelBtnEditar.ReadOnly = true;
            this.dtgReceitaVariavelBtnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReceitaVariavelBtnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dtgReceitaVariavelBtnEditar.Width = 40;
            // 
            // dtgReceitaVariavelBtnExcluir
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.NullValue = null;
            this.dtgReceitaVariavelBtnExcluir.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgReceitaVariavelBtnExcluir.HeaderText = "";
            this.dtgReceitaVariavelBtnExcluir.Image = global::projProjetos.Properties.Resources.excluir;
            this.dtgReceitaVariavelBtnExcluir.Name = "dtgReceitaVariavelBtnExcluir";
            this.dtgReceitaVariavelBtnExcluir.ReadOnly = true;
            this.dtgReceitaVariavelBtnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReceitaVariavelBtnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dtgReceitaVariavelBtnExcluir.Width = 40;
            // 
            // tbParticipantes
            // 
            this.tbParticipantes.Controls.Add(this.grbParticipantes);
            this.tbParticipantes.Location = new System.Drawing.Point(4, 25);
            this.tbParticipantes.Name = "tbParticipantes";
            this.tbParticipantes.Padding = new System.Windows.Forms.Padding(3);
            this.tbParticipantes.Size = new System.Drawing.Size(931, 337);
            this.tbParticipantes.TabIndex = 2;
            this.tbParticipantes.Text = "Participantes do projeto";
            this.tbParticipantes.UseVisualStyleBackColor = true;
            // 
            // grbParticipantes
            // 
            this.grbParticipantes.Controls.Add(this.dtgProjetoPessoa);
            this.grbParticipantes.Controls.Add(this.groupBox2);
            this.grbParticipantes.Controls.Add(this.groupBox1);
            this.grbParticipantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbParticipantes.Location = new System.Drawing.Point(3, 3);
            this.grbParticipantes.Name = "grbParticipantes";
            this.grbParticipantes.Size = new System.Drawing.Size(925, 331);
            this.grbParticipantes.TabIndex = 0;
            this.grbParticipantes.TabStop = false;
            this.grbParticipantes.Text = "Participantes";
            // 
            // dtgProjetoPessoa
            // 
            this.dtgProjetoPessoa.AllowUserToAddRows = false;
            this.dtgProjetoPessoa.AllowUserToDeleteRows = false;
            this.dtgProjetoPessoa.AutoGenerateColumns = false;
            this.dtgProjetoPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProjetoPessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoaDataGridViewTextBoxColumn,
            this.nomePessoaDataGridViewTextBoxColumn,
            this.dataIngressoDataGridViewTextBoxColumn,
            this.ocupacaoDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn1,
            this.entityObjectDataGridViewTextBoxColumn1,
            this.idProjetoDataGridViewTextBoxColumn1,
            this.nomeProjetoDataGridViewTextBoxColumn,
            this.dtgProjetoPessoaBtnEditar,
            this.dtgProjetoPessoaBtnExcluir});
            this.dtgProjetoPessoa.DataSource = this._bindingSourceProjetoPessoa;
            this.dtgProjetoPessoa.Location = new System.Drawing.Point(6, 135);
            this.dtgProjetoPessoa.MultiSelect = false;
            this.dtgProjetoPessoa.Name = "dtgProjetoPessoa";
            this.dtgProjetoPessoa.ReadOnly = true;
            this.dtgProjetoPessoa.RowHeadersVisible = false;
            this.dtgProjetoPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProjetoPessoa.Size = new System.Drawing.Size(913, 190);
            this.dtgProjetoPessoa.TabIndex = 12;
            this.dtgProjetoPessoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProjetoPessoa_CellContentClick);
            // 
            // idPessoaDataGridViewTextBoxColumn
            // 
            this.idPessoaDataGridViewTextBoxColumn.DataPropertyName = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idPessoaDataGridViewTextBoxColumn.Name = "idPessoaDataGridViewTextBoxColumn";
            this.idPessoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPessoaDataGridViewTextBoxColumn.Width = 70;
            // 
            // nomePessoaDataGridViewTextBoxColumn
            // 
            this.nomePessoaDataGridViewTextBoxColumn.DataPropertyName = "NomePessoa";
            this.nomePessoaDataGridViewTextBoxColumn.HeaderText = "Participante";
            this.nomePessoaDataGridViewTextBoxColumn.Name = "nomePessoaDataGridViewTextBoxColumn";
            this.nomePessoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomePessoaDataGridViewTextBoxColumn.Width = 230;
            // 
            // dataIngressoDataGridViewTextBoxColumn
            // 
            this.dataIngressoDataGridViewTextBoxColumn.DataPropertyName = "DataIngresso";
            this.dataIngressoDataGridViewTextBoxColumn.HeaderText = "Data do Ingresso";
            this.dataIngressoDataGridViewTextBoxColumn.Name = "dataIngressoDataGridViewTextBoxColumn";
            this.dataIngressoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataIngressoDataGridViewTextBoxColumn.Width = 140;
            // 
            // ocupacaoDataGridViewTextBoxColumn
            // 
            this.ocupacaoDataGridViewTextBoxColumn.DataPropertyName = "Ocupacao";
            this.ocupacaoDataGridViewTextBoxColumn.HeaderText = "Ocupação";
            this.ocupacaoDataGridViewTextBoxColumn.Name = "ocupacaoDataGridViewTextBoxColumn";
            this.ocupacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ocupacaoDataGridViewTextBoxColumn.Width = 140;
            // 
            // observacoesDataGridViewTextBoxColumn1
            // 
            this.observacoesDataGridViewTextBoxColumn1.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn1.HeaderText = "Observações";
            this.observacoesDataGridViewTextBoxColumn1.Name = "observacoesDataGridViewTextBoxColumn1";
            this.observacoesDataGridViewTextBoxColumn1.ReadOnly = true;
            this.observacoesDataGridViewTextBoxColumn1.Width = 230;
            // 
            // entityObjectDataGridViewTextBoxColumn1
            // 
            this.entityObjectDataGridViewTextBoxColumn1.DataPropertyName = "EntityObject";
            this.entityObjectDataGridViewTextBoxColumn1.HeaderText = "EntityObject";
            this.entityObjectDataGridViewTextBoxColumn1.Name = "entityObjectDataGridViewTextBoxColumn1";
            this.entityObjectDataGridViewTextBoxColumn1.ReadOnly = true;
            this.entityObjectDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idProjetoDataGridViewTextBoxColumn1
            // 
            this.idProjetoDataGridViewTextBoxColumn1.DataPropertyName = "IdProjeto";
            this.idProjetoDataGridViewTextBoxColumn1.HeaderText = "IdProjeto";
            this.idProjetoDataGridViewTextBoxColumn1.Name = "idProjetoDataGridViewTextBoxColumn1";
            this.idProjetoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idProjetoDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nomeProjetoDataGridViewTextBoxColumn
            // 
            this.nomeProjetoDataGridViewTextBoxColumn.DataPropertyName = "NomeProjeto";
            this.nomeProjetoDataGridViewTextBoxColumn.HeaderText = "NomeProjeto";
            this.nomeProjetoDataGridViewTextBoxColumn.Name = "nomeProjetoDataGridViewTextBoxColumn";
            this.nomeProjetoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeProjetoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtgProjetoPessoaBtnEditar
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.NullValue = null;
            this.dtgProjetoPessoaBtnEditar.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProjetoPessoaBtnEditar.HeaderText = "";
            this.dtgProjetoPessoaBtnEditar.Image = global::projProjetos.Properties.Resources.editar;
            this.dtgProjetoPessoaBtnEditar.Name = "dtgProjetoPessoaBtnEditar";
            this.dtgProjetoPessoaBtnEditar.ReadOnly = true;
            this.dtgProjetoPessoaBtnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProjetoPessoaBtnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dtgProjetoPessoaBtnEditar.Width = 40;
            // 
            // dtgProjetoPessoaBtnExcluir
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.NullValue = null;
            this.dtgProjetoPessoaBtnExcluir.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgProjetoPessoaBtnExcluir.HeaderText = "";
            this.dtgProjetoPessoaBtnExcluir.Image = global::projProjetos.Properties.Resources.excluir;
            this.dtgProjetoPessoaBtnExcluir.Name = "dtgProjetoPessoaBtnExcluir";
            this.dtgProjetoPessoaBtnExcluir.ReadOnly = true;
            this.dtgProjetoPessoaBtnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProjetoPessoaBtnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dtgProjetoPessoaBtnExcluir.Width = 40;
            // 
            // _bindingSourceProjetoPessoa
            // 
            this._bindingSourceProjetoPessoa.DataSource = typeof(RegraNegocio.View.Projetos.ViewProjetoPessoa);
            this._bindingSourceProjetoPessoa.CurrentChanged += new System.EventHandler(this._bindingSourceProjetoPessoa_CurrentChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProjetoPessoaCancelar);
            this.groupBox2.Controls.Add(this.txtProjetoPessoaNome);
            this.groupBox2.Controls.Add(this.btnProjetoPessoaPesquisaPessoa);
            this.groupBox2.Controls.Add(this.txtProjetoPessoaCodPessoa);
            this.groupBox2.Controls.Add(this.dtpProjetoPessoaDataIngresso);
            this.groupBox2.Controls.Add(this.lblDataIngresso);
            this.groupBox2.Controls.Add(this.txtProjetoPessoaObservacoes);
            this.groupBox2.Controls.Add(this.lblObservacoesParticipantes);
            this.groupBox2.Controls.Add(this.txtProjetoPessoaOcupacao);
            this.groupBox2.Controls.Add(this.lblOcupacao);
            this.groupBox2.Controls.Add(this.btnprojetoPessoaSalvar);
            this.groupBox2.Controls.Add(this.lblParticipante);
            this.groupBox2.Location = new System.Drawing.Point(101, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 108);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnProjetoPessoaCancelar
            // 
            this.btnProjetoPessoaCancelar.Enabled = false;
            this.btnProjetoPessoaCancelar.Location = new System.Drawing.Point(652, 75);
            this.btnProjetoPessoaCancelar.Name = "btnProjetoPessoaCancelar";
            this.btnProjetoPessoaCancelar.Size = new System.Drawing.Size(77, 23);
            this.btnProjetoPessoaCancelar.TabIndex = 28;
            this.btnProjetoPessoaCancelar.Text = "Cancelar";
            this.btnProjetoPessoaCancelar.UseVisualStyleBackColor = true;
            this.btnProjetoPessoaCancelar.Click += new System.EventHandler(this.btnProjetoPessoaCancelar_Click);
            // 
            // txtProjetoPessoaNome
            // 
            this.txtProjetoPessoaNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtProjetoPessoaNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSourceProjetoPessoa, "NomePessoa", true));
            this.txtProjetoPessoaNome.Enabled = false;
            this.txtProjetoPessoaNome.Location = new System.Drawing.Point(212, 18);
            this.txtProjetoPessoaNome.Name = "txtProjetoPessoaNome";
            this.txtProjetoPessoaNome.ReadOnly = true;
            this.txtProjetoPessoaNome.Size = new System.Drawing.Size(600, 22);
            this.txtProjetoPessoaNome.TabIndex = 27;
            // 
            // btnProjetoPessoaPesquisaPessoa
            // 
            this.btnProjetoPessoaPesquisaPessoa.Enabled = false;
            this.btnProjetoPessoaPesquisaPessoa.Location = new System.Drawing.Point(105, 17);
            this.btnProjetoPessoaPesquisaPessoa.Name = "btnProjetoPessoaPesquisaPessoa";
            this.btnProjetoPessoaPesquisaPessoa.Size = new System.Drawing.Size(35, 23);
            this.btnProjetoPessoaPesquisaPessoa.TabIndex = 26;
            this.btnProjetoPessoaPesquisaPessoa.Text = "...";
            this.btnProjetoPessoaPesquisaPessoa.UseVisualStyleBackColor = true;
            this.btnProjetoPessoaPesquisaPessoa.Click += new System.EventHandler(this.btnProjetoPessoaPesquisaPessoa_Click);
            // 
            // txtProjetoPessoaCodPessoa
            // 
            this.txtProjetoPessoaCodPessoa.BackColor = System.Drawing.SystemColors.Window;
            this.txtProjetoPessoaCodPessoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSourceProjetoPessoa, "IdPessoa", true));
            this.txtProjetoPessoaCodPessoa.Enabled = false;
            this.txtProjetoPessoaCodPessoa.Location = new System.Drawing.Point(146, 18);
            this.txtProjetoPessoaCodPessoa.Name = "txtProjetoPessoaCodPessoa";
            this.txtProjetoPessoaCodPessoa.ReadOnly = true;
            this.txtProjetoPessoaCodPessoa.Size = new System.Drawing.Size(63, 22);
            this.txtProjetoPessoaCodPessoa.TabIndex = 25;
            // 
            // dtpProjetoPessoaDataIngresso
            // 
            this.dtpProjetoPessoaDataIngresso.CustomFormat = "dd/mm/yyyy";
            this.dtpProjetoPessoaDataIngresso.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._bindingSourceProjetoPessoa, "DataIngresso", true));
            this.dtpProjetoPessoaDataIngresso.Enabled = false;
            this.dtpProjetoPessoaDataIngresso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProjetoPessoaDataIngresso.Location = new System.Drawing.Point(681, 45);
            this.dtpProjetoPessoaDataIngresso.Name = "dtpProjetoPessoaDataIngresso";
            this.dtpProjetoPessoaDataIngresso.Size = new System.Drawing.Size(131, 22);
            this.dtpProjetoPessoaDataIngresso.TabIndex = 8;
            // 
            // lblDataIngresso
            // 
            this.lblDataIngresso.AutoSize = true;
            this.lblDataIngresso.Enabled = false;
            this.lblDataIngresso.Location = new System.Drawing.Point(548, 50);
            this.lblDataIngresso.Name = "lblDataIngresso";
            this.lblDataIngresso.Size = new System.Drawing.Size(127, 16);
            this.lblDataIngresso.TabIndex = 7;
            this.lblDataIngresso.Text = "Ingresso ao projeto:";
            // 
            // txtProjetoPessoaObservacoes
            // 
            this.txtProjetoPessoaObservacoes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSourceProjetoPessoa, "Observacoes", true));
            this.txtProjetoPessoaObservacoes.Location = new System.Drawing.Point(105, 75);
            this.txtProjetoPessoaObservacoes.Name = "txtProjetoPessoaObservacoes";
            this.txtProjetoPessoaObservacoes.Size = new System.Drawing.Size(541, 22);
            this.txtProjetoPessoaObservacoes.TabIndex = 6;
            // 
            // lblObservacoesParticipantes
            // 
            this.lblObservacoesParticipantes.AutoSize = true;
            this.lblObservacoesParticipantes.Location = new System.Drawing.Point(6, 78);
            this.lblObservacoesParticipantes.Name = "lblObservacoesParticipantes";
            this.lblObservacoesParticipantes.Size = new System.Drawing.Size(93, 16);
            this.lblObservacoesParticipantes.TabIndex = 5;
            this.lblObservacoesParticipantes.Text = "Observações:";
            // 
            // txtProjetoPessoaOcupacao
            // 
            this.txtProjetoPessoaOcupacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSourceProjetoPessoa, "Ocupacao", true));
            this.txtProjetoPessoaOcupacao.Location = new System.Drawing.Point(105, 47);
            this.txtProjetoPessoaOcupacao.Name = "txtProjetoPessoaOcupacao";
            this.txtProjetoPessoaOcupacao.Size = new System.Drawing.Size(437, 22);
            this.txtProjetoPessoaOcupacao.TabIndex = 4;
            // 
            // lblOcupacao
            // 
            this.lblOcupacao.AutoSize = true;
            this.lblOcupacao.Location = new System.Drawing.Point(6, 50);
            this.lblOcupacao.Name = "lblOcupacao";
            this.lblOcupacao.Size = new System.Drawing.Size(74, 16);
            this.lblOcupacao.TabIndex = 3;
            this.lblOcupacao.Text = "Ocupação:";
            // 
            // btnprojetoPessoaSalvar
            // 
            this.btnprojetoPessoaSalvar.Enabled = false;
            this.btnprojetoPessoaSalvar.Location = new System.Drawing.Point(735, 75);
            this.btnprojetoPessoaSalvar.Name = "btnprojetoPessoaSalvar";
            this.btnprojetoPessoaSalvar.Size = new System.Drawing.Size(77, 23);
            this.btnprojetoPessoaSalvar.TabIndex = 1;
            this.btnprojetoPessoaSalvar.Text = "Salvar";
            this.btnprojetoPessoaSalvar.UseVisualStyleBackColor = true;
            this.btnprojetoPessoaSalvar.Click += new System.EventHandler(this.btnprojetoPessoaSalvar_Click);
            // 
            // lblParticipante
            // 
            this.lblParticipante.AutoSize = true;
            this.lblParticipante.Location = new System.Drawing.Point(6, 17);
            this.lblParticipante.Name = "lblParticipante";
            this.lblParticipante.Size = new System.Drawing.Size(82, 16);
            this.lblParticipante.TabIndex = 0;
            this.lblParticipante.Text = "Participante:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnprojetoPessoaExcluir);
            this.groupBox1.Controls.Add(this.btnProjetoPessoaEditar);
            this.groupBox1.Controls.Add(this.btnProjetoPessoaIncluir);
            this.groupBox1.Location = new System.Drawing.Point(6, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 108);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // btnprojetoPessoaExcluir
            // 
            this.btnprojetoPessoaExcluir.Enabled = false;
            this.btnprojetoPessoaExcluir.Location = new System.Drawing.Point(6, 79);
            this.btnprojetoPessoaExcluir.Name = "btnprojetoPessoaExcluir";
            this.btnprojetoPessoaExcluir.Size = new System.Drawing.Size(77, 23);
            this.btnprojetoPessoaExcluir.TabIndex = 0;
            this.btnprojetoPessoaExcluir.Text = "Excluir";
            this.btnprojetoPessoaExcluir.UseVisualStyleBackColor = true;
            this.btnprojetoPessoaExcluir.Click += new System.EventHandler(this.btnprojetoPessoaExcluir_Click);
            // 
            // btnProjetoPessoaEditar
            // 
            this.btnProjetoPessoaEditar.Enabled = false;
            this.btnProjetoPessoaEditar.Location = new System.Drawing.Point(6, 50);
            this.btnProjetoPessoaEditar.Name = "btnProjetoPessoaEditar";
            this.btnProjetoPessoaEditar.Size = new System.Drawing.Size(77, 23);
            this.btnProjetoPessoaEditar.TabIndex = 0;
            this.btnProjetoPessoaEditar.Text = "Editar";
            this.btnProjetoPessoaEditar.UseVisualStyleBackColor = true;
            this.btnProjetoPessoaEditar.Click += new System.EventHandler(this.btnProjetoPessoaEditar_Click);
            // 
            // btnProjetoPessoaIncluir
            // 
            this.btnProjetoPessoaIncluir.Enabled = false;
            this.btnProjetoPessoaIncluir.Location = new System.Drawing.Point(6, 21);
            this.btnProjetoPessoaIncluir.Name = "btnProjetoPessoaIncluir";
            this.btnProjetoPessoaIncluir.Size = new System.Drawing.Size(77, 23);
            this.btnProjetoPessoaIncluir.TabIndex = 0;
            this.btnProjetoPessoaIncluir.Text = "Incluir Receita";
            this.btnProjetoPessoaIncluir.UseVisualStyleBackColor = true;
            this.btnProjetoPessoaIncluir.Click += new System.EventHandler(this.btnProjetoPessoaIncluir_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grbReunioesProgramadas);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(931, 337);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Reuniões programadas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grbReunioesProgramadas
            // 
            this.grbReunioesProgramadas.Controls.Add(this.dtgReunioes);
            this.grbReunioesProgramadas.Controls.Add(this.tbpReunioesProgramadas);
            this.grbReunioesProgramadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbReunioesProgramadas.Enabled = false;
            this.grbReunioesProgramadas.Location = new System.Drawing.Point(3, 3);
            this.grbReunioesProgramadas.Name = "grbReunioesProgramadas";
            this.grbReunioesProgramadas.Size = new System.Drawing.Size(925, 331);
            this.grbReunioesProgramadas.TabIndex = 0;
            this.grbReunioesProgramadas.TabStop = false;
            this.grbReunioesProgramadas.Visible = false;
            // 
            // dtgReunioes
            // 
            this.dtgReunioes.AllowUserToAddRows = false;
            this.dtgReunioes.AllowUserToDeleteRows = false;
            this.dtgReunioes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReunioes.Enabled = false;
            this.dtgReunioes.Location = new System.Drawing.Point(3, 214);
            this.dtgReunioes.Name = "dtgReunioes";
            this.dtgReunioes.ReadOnly = true;
            this.dtgReunioes.Size = new System.Drawing.Size(909, 111);
            this.dtgReunioes.TabIndex = 1;
            // 
            // tbpReunioesProgramadas
            // 
            this.tbpReunioesProgramadas.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tbpReunioesProgramadas.Controls.Add(this.tbReuniaoInformacoes);
            this.tbpReunioesProgramadas.Controls.Add(this.tbReuniaoResultado);
            this.tbpReunioesProgramadas.Location = new System.Drawing.Point(6, 21);
            this.tbpReunioesProgramadas.Multiline = true;
            this.tbpReunioesProgramadas.Name = "tbpReunioesProgramadas";
            this.tbpReunioesProgramadas.SelectedIndex = 0;
            this.tbpReunioesProgramadas.Size = new System.Drawing.Size(913, 187);
            this.tbpReunioesProgramadas.TabIndex = 0;
            // 
            // tbReuniaoInformacoes
            // 
            this.tbReuniaoInformacoes.Controls.Add(this.grbReuniaoInformacoes);
            this.tbReuniaoInformacoes.Location = new System.Drawing.Point(4, 4);
            this.tbReuniaoInformacoes.Name = "tbReuniaoInformacoes";
            this.tbReuniaoInformacoes.Padding = new System.Windows.Forms.Padding(3);
            this.tbReuniaoInformacoes.Size = new System.Drawing.Size(905, 158);
            this.tbReuniaoInformacoes.TabIndex = 0;
            this.tbReuniaoInformacoes.Text = "Informações";
            this.tbReuniaoInformacoes.UseVisualStyleBackColor = true;
            // 
            // grbReuniaoInformacoes
            // 
            this.grbReuniaoInformacoes.Controls.Add(this.txtObservacoes);
            this.grbReuniaoInformacoes.Controls.Add(this.lblReuniaoObservacoes);
            this.grbReuniaoInformacoes.Controls.Add(this.cklReuniaoSituacao);
            this.grbReuniaoInformacoes.Controls.Add(this.lblReuniaoSituacao);
            this.grbReuniaoInformacoes.Controls.Add(this.txtReuniaoDataRealizacao);
            this.grbReuniaoInformacoes.Controls.Add(this.txtReuniaoDescricao);
            this.grbReuniaoInformacoes.Controls.Add(this.lblReuniaoDataRealizacao);
            this.grbReuniaoInformacoes.Controls.Add(this.lblReuniaoDescricao);
            this.grbReuniaoInformacoes.Controls.Add(this.txtReuniaoCodigo);
            this.grbReuniaoInformacoes.Controls.Add(this.lblReuniaoCodigo);
            this.grbReuniaoInformacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbReuniaoInformacoes.Location = new System.Drawing.Point(3, 3);
            this.grbReuniaoInformacoes.Name = "grbReuniaoInformacoes";
            this.grbReuniaoInformacoes.Size = new System.Drawing.Size(899, 152);
            this.grbReuniaoInformacoes.TabIndex = 0;
            this.grbReuniaoInformacoes.TabStop = false;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservacoes.Enabled = false;
            this.txtObservacoes.Location = new System.Drawing.Point(383, 71);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.ReadOnly = true;
            this.txtObservacoes.Size = new System.Drawing.Size(292, 75);
            this.txtObservacoes.TabIndex = 7;
            // 
            // lblReuniaoObservacoes
            // 
            this.lblReuniaoObservacoes.AutoSize = true;
            this.lblReuniaoObservacoes.Location = new System.Drawing.Point(284, 74);
            this.lblReuniaoObservacoes.Name = "lblReuniaoObservacoes";
            this.lblReuniaoObservacoes.Size = new System.Drawing.Size(93, 16);
            this.lblReuniaoObservacoes.TabIndex = 6;
            this.lblReuniaoObservacoes.Text = "Observações:";
            // 
            // cklReuniaoSituacao
            // 
            this.cklReuniaoSituacao.Enabled = false;
            this.cklReuniaoSituacao.FormattingEnabled = true;
            this.cklReuniaoSituacao.Items.AddRange(new object[] {
            "Executada",
            "Suspensa",
            "Adiada",
            "Cancelada"});
            this.cklReuniaoSituacao.Location = new System.Drawing.Point(137, 74);
            this.cklReuniaoSituacao.Name = "cklReuniaoSituacao";
            this.cklReuniaoSituacao.Size = new System.Drawing.Size(113, 72);
            this.cklReuniaoSituacao.TabIndex = 0;
            // 
            // lblReuniaoSituacao
            // 
            this.lblReuniaoSituacao.AutoSize = true;
            this.lblReuniaoSituacao.Location = new System.Drawing.Point(15, 74);
            this.lblReuniaoSituacao.Name = "lblReuniaoSituacao";
            this.lblReuniaoSituacao.Size = new System.Drawing.Size(64, 16);
            this.lblReuniaoSituacao.TabIndex = 5;
            this.lblReuniaoSituacao.Text = "Situação:";
            // 
            // txtReuniaoDataRealizacao
            // 
            this.txtReuniaoDataRealizacao.BackColor = System.Drawing.SystemColors.Window;
            this.txtReuniaoDataRealizacao.Enabled = false;
            this.txtReuniaoDataRealizacao.Location = new System.Drawing.Point(562, 15);
            this.txtReuniaoDataRealizacao.Mask = "00/00/0000 90:00";
            this.txtReuniaoDataRealizacao.Name = "txtReuniaoDataRealizacao";
            this.txtReuniaoDataRealizacao.ReadOnly = true;
            this.txtReuniaoDataRealizacao.Size = new System.Drawing.Size(113, 22);
            this.txtReuniaoDataRealizacao.TabIndex = 4;
            this.txtReuniaoDataRealizacao.ValidatingType = typeof(System.DateTime);
            // 
            // txtReuniaoDescricao
            // 
            this.txtReuniaoDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.txtReuniaoDescricao.Enabled = false;
            this.txtReuniaoDescricao.Location = new System.Drawing.Point(137, 43);
            this.txtReuniaoDescricao.Name = "txtReuniaoDescricao";
            this.txtReuniaoDescricao.ReadOnly = true;
            this.txtReuniaoDescricao.Size = new System.Drawing.Size(538, 22);
            this.txtReuniaoDescricao.TabIndex = 3;
            // 
            // lblReuniaoDataRealizacao
            // 
            this.lblReuniaoDataRealizacao.AutoSize = true;
            this.lblReuniaoDataRealizacao.Location = new System.Drawing.Point(431, 18);
            this.lblReuniaoDataRealizacao.Name = "lblReuniaoDataRealizacao";
            this.lblReuniaoDataRealizacao.Size = new System.Drawing.Size(125, 16);
            this.lblReuniaoDataRealizacao.TabIndex = 2;
            this.lblReuniaoDataRealizacao.Text = "Data da realização:";
            // 
            // lblReuniaoDescricao
            // 
            this.lblReuniaoDescricao.AutoSize = true;
            this.lblReuniaoDescricao.Location = new System.Drawing.Point(6, 46);
            this.lblReuniaoDescricao.Name = "lblReuniaoDescricao";
            this.lblReuniaoDescricao.Size = new System.Drawing.Size(73, 16);
            this.lblReuniaoDescricao.TabIndex = 2;
            this.lblReuniaoDescricao.Text = "Descricão:";
            // 
            // txtReuniaoCodigo
            // 
            this.txtReuniaoCodigo.Enabled = false;
            this.txtReuniaoCodigo.Location = new System.Drawing.Point(137, 12);
            this.txtReuniaoCodigo.Name = "txtReuniaoCodigo";
            this.txtReuniaoCodigo.ReadOnly = true;
            this.txtReuniaoCodigo.Size = new System.Drawing.Size(237, 22);
            this.txtReuniaoCodigo.TabIndex = 1;
            // 
            // lblReuniaoCodigo
            // 
            this.lblReuniaoCodigo.AutoSize = true;
            this.lblReuniaoCodigo.Location = new System.Drawing.Point(6, 18);
            this.lblReuniaoCodigo.Name = "lblReuniaoCodigo";
            this.lblReuniaoCodigo.Size = new System.Drawing.Size(55, 16);
            this.lblReuniaoCodigo.TabIndex = 0;
            this.lblReuniaoCodigo.Text = "Código:";
            // 
            // tbReuniaoResultado
            // 
            this.tbReuniaoResultado.Controls.Add(this.dtgReuniaoResultado);
            this.tbReuniaoResultado.Location = new System.Drawing.Point(4, 4);
            this.tbReuniaoResultado.Name = "tbReuniaoResultado";
            this.tbReuniaoResultado.Padding = new System.Windows.Forms.Padding(3);
            this.tbReuniaoResultado.Size = new System.Drawing.Size(905, 158);
            this.tbReuniaoResultado.TabIndex = 1;
            this.tbReuniaoResultado.Text = "Resultado";
            this.tbReuniaoResultado.UseVisualStyleBackColor = true;
            // 
            // dtgReuniaoResultado
            // 
            this.dtgReuniaoResultado.AllowUserToAddRows = false;
            this.dtgReuniaoResultado.AllowUserToDeleteRows = false;
            this.dtgReuniaoResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReuniaoResultado.Enabled = false;
            this.dtgReuniaoResultado.Location = new System.Drawing.Point(6, 6);
            this.dtgReuniaoResultado.Name = "dtgReuniaoResultado";
            this.dtgReuniaoResultado.ReadOnly = true;
            this.dtgReuniaoResultado.Size = new System.Drawing.Size(893, 180);
            this.dtgReuniaoResultado.TabIndex = 0;
            // 
            // rbMultiplasReceitas
            // 
            this.rbMultiplasReceitas.AutoSize = true;
            this.rbMultiplasReceitas.Location = new System.Drawing.Point(9, 47);
            this.rbMultiplasReceitas.Name = "rbMultiplasReceitas";
            this.rbMultiplasReceitas.Size = new System.Drawing.Size(136, 20);
            this.rbMultiplasReceitas.TabIndex = 5;
            this.rbMultiplasReceitas.Text = "Multiplas Receitas";
            this.rbMultiplasReceitas.UseVisualStyleBackColor = true;
            // 
            // rbReceitaUnica
            // 
            this.rbReceitaUnica.AutoSize = true;
            this.rbReceitaUnica.Checked = true;
            this.rbReceitaUnica.Location = new System.Drawing.Point(9, 21);
            this.rbReceitaUnica.Name = "rbReceitaUnica";
            this.rbReceitaUnica.Size = new System.Drawing.Size(108, 20);
            this.rbReceitaUnica.TabIndex = 4;
            this.rbReceitaUnica.TabStop = true;
            this.rbReceitaUnica.Text = "Receita única";
            this.rbReceitaUnica.UseVisualStyleBackColor = true;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::projProjetos.Properties.Resources.editar;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn3.Visible = false;
            this.dataGridViewImageColumn3.Width = 40;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Image = global::projProjetos.Properties.Resources.excluir;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn4.Visible = false;
            this.dataGridViewImageColumn4.Width = 40;
            // 
            // FrmCadastroProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 443);
            this.ControlBox = false;
            this.Controls.Add(this.tbReunioesProjeto);
            this.Controls.Add(this.tspPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroProjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SP3 :: Cadastro de Projetos";
            this.Load += new System.EventHandler(this.frmCadastroProjetos_Load);
            this.tspPrincipal.ResumeLayout(false);
            this.tspPrincipal.PerformLayout();
            this.tbReunioesProjeto.ResumeLayout(false);
            this.tbInformacoes.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.grbPrincipal.ResumeLayout(false);
            this.grbPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSource)).EndInit();
            this.tbFluxoDeCaixa.ResumeLayout(false);
            this.grbFluxoCaixaProjeto.ResumeLayout(false);
            this.grbIncluirReceitaVariavel.ResumeLayout(false);
            this.grbIncluirReceitaVariavel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceReceitaVariavel)).EndInit();
            this.grbFluxoCaixaProjetoAcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReceitaVariavel)).EndInit();
            this.tbParticipantes.ResumeLayout(false);
            this.grbParticipantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProjetoPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceProjetoPessoa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grbReunioesProgramadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReunioes)).EndInit();
            this.tbpReunioesProgramadas.ResumeLayout(false);
            this.tbReuniaoInformacoes.ResumeLayout(false);
            this.grbReuniaoInformacoes.ResumeLayout(false);
            this.grbReuniaoInformacoes.PerformLayout();
            this.tbReuniaoResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReuniaoResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspPrincipal;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnInativar;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.TabControl tbReunioesProjeto;
        private System.Windows.Forms.TabPage tbInformacoes;
        private System.Windows.Forms.TabPage tbFluxoDeCaixa;
        private System.Windows.Forms.TabPage tbParticipantes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.GroupBox grbFluxoCaixaProjeto;
        private System.Windows.Forms.RadioButton rbMultiplasReceitas;
        private System.Windows.Forms.RadioButton rbReceitaUnica;
        private System.Windows.Forms.GroupBox grbIncluirReceitaVariavel;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.GroupBox grbFluxoCaixaProjetoAcoes;
        private System.Windows.Forms.Button btnReceitaVariavelExcluir;
        private System.Windows.Forms.Button btnReceitaVariavelEditar;
        private System.Windows.Forms.Button btnReceitaVariavelIncluir;
        private System.Windows.Forms.DataGridView dtgReceitaVariavel;
        private System.Windows.Forms.Button btnReceitaVariavelSalvar;
        private System.Windows.Forms.TextBox txtReceitaVariavelObservacoes;
        private System.Windows.Forms.Label lblObservacoesFluxoCaixa;
        private System.Windows.Forms.ComboBox cboReceitaVariavelFluxo;
        private System.Windows.Forms.Label lblTipoFluxoCaixa;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox grbParticipantes;
        private System.Windows.Forms.DataGridView dtgProjetoPessoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpProjetoPessoaDataIngresso;
        private System.Windows.Forms.Label lblDataIngresso;
        private System.Windows.Forms.TextBox txtProjetoPessoaObservacoes;
        private System.Windows.Forms.Label lblObservacoesParticipantes;
        private System.Windows.Forms.TextBox txtProjetoPessoaOcupacao;
        private System.Windows.Forms.Label lblOcupacao;
        private System.Windows.Forms.Button btnprojetoPessoaSalvar;
        private System.Windows.Forms.Label lblParticipante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnprojetoPessoaExcluir;
        private System.Windows.Forms.Button btnProjetoPessoaEditar;
        private System.Windows.Forms.Button btnProjetoPessoaIncluir;
        private System.Windows.Forms.GroupBox tbCadastro;
        private System.Windows.Forms.GroupBox grbPrincipal;
        private System.Windows.Forms.MaskedTextBox txtDataAlteracao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtPrazoConclusao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDataAlteracao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox grbReunioesProgramadas;
        private System.Windows.Forms.TabControl tbpReunioesProgramadas;
        private System.Windows.Forms.TabPage tbReuniaoInformacoes;
        private System.Windows.Forms.TabPage tbReuniaoResultado;
        private System.Windows.Forms.DataGridView dtgReunioes;
        private System.Windows.Forms.GroupBox grbReuniaoInformacoes;
        private System.Windows.Forms.CheckedListBox cklReuniaoSituacao;
        private System.Windows.Forms.Label lblReuniaoSituacao;
        private System.Windows.Forms.MaskedTextBox txtReuniaoDataRealizacao;
        private System.Windows.Forms.TextBox txtReuniaoDescricao;
        private System.Windows.Forms.Label lblReuniaoDataRealizacao;
        private System.Windows.Forms.Label lblReuniaoDescricao;
        private System.Windows.Forms.TextBox txtReuniaoCodigo;
        private System.Windows.Forms.Label lblReuniaoCodigo;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label lblReuniaoObservacoes;
        private System.Windows.Forms.DataGridView dtgReuniaoResultado;
        private System.Windows.Forms.ToolStripButton btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInvestimentoPrevisto;
        private System.Windows.Forms.DateTimePicker dtpReceitaVariavelPeriodo;
        private System.Windows.Forms.TextBox txtReceitaVariavelValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbEsforcoAdicionalAcima40PorCento;
        private System.Windows.Forms.RadioButton rbEsforcoAdicional21A40PorCento;
        private System.Windows.Forms.RadioButton rbEsforcoAdicional11A20PorCento;
        private System.Windows.Forms.RadioButton rbEsforcoAdicionalAte10porCento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboApoioSteakholders;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboApoioAltaGestao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCapacidadeEntregaEquipe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.TextBox txtNomeGerenteProjeto;
        private System.Windows.Forms.Button btnPesquisaGerenteProjeto;
        private System.Windows.Forms.TextBox txtCodigoGerente;
        private System.Windows.Forms.TextBox txtProjetoPessoaNome;
        private System.Windows.Forms.Button btnProjetoPessoaPesquisaPessoa;
        private System.Windows.Forms.TextBox txtProjetoPessoaCodPessoa;
        private System.Windows.Forms.BindingSource _bindingSource;
        private System.Windows.Forms.BindingSource _bindingSourceReceitaVariavel;
        private System.Windows.Forms.BindingSource _bindingSourceProjetoPessoa;
        private System.Windows.Forms.Button btnReceitaVariavelCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPeriodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProjetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn dtgReceitaVariavelBtnEditar;
        private System.Windows.Forms.DataGridViewImageColumn dtgReceitaVariavelBtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIngressoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityObjectDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProjetoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProjetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn dtgProjetoPessoaBtnEditar;
        private System.Windows.Forms.DataGridViewImageColumn dtgProjetoPessoaBtnExcluir;
        private System.Windows.Forms.Button btnProjetoPessoaCancelar;
    }
}