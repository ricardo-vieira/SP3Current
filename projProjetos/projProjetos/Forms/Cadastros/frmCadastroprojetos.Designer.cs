using System.Collections;

namespace projProjetos.Forms
{
    partial class frmCadastroProjetos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProjetos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dtgPrincipal = new System.Windows.Forms.DataGridView();
            this.dtgPrincipaltxtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPrincipaltxtNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPrincipalTxtDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPrincipalTxtObservacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPrincipalTxtGerenteProjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPrincipalTxtInvestimentoPrevisto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPrincipalTxtRazaoReceitaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZAORECEITAVALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPrincipalTxtRazaoReceitaPercentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPrincipalTxtTempoPrevistoConclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPrincipalTxtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPrincipalBtnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtgPrincipalBtnInativar = new System.Windows.Forms.DataGridViewImageColumn();
            this.grbPrincipal = new System.Windows.Forms.GroupBox();
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
            this.cboGerenteProjeto = new System.Windows.Forms.ComboBox();
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
            this.txtFluxoValor = new System.Windows.Forms.TextBox();
            this.dtpFluxoCaixaPeriodo = new System.Windows.Forms.DateTimePicker();
            this.btnFluxoSalvar = new System.Windows.Forms.Button();
            this.txtFluxoObservacoes = new System.Windows.Forms.TextBox();
            this.lblObservacoesFluxoCaixa = new System.Windows.Forms.Label();
            this.cboFluxoTipo = new System.Windows.Forms.ComboBox();
            this.lblTipoFluxoCaixa = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.grbFluxoCaixaProjetoAcoes = new System.Windows.Forms.GroupBox();
            this.btnFluxoExcluir = new System.Windows.Forms.Button();
            this.btnFluxoEditar = new System.Windows.Forms.Button();
            this.btnFluxoIncluir = new System.Windows.Forms.Button();
            this.dtgFluxoCaixaProjeto = new System.Windows.Forms.DataGridView();
            this.dtgFluxoCaixaProjetoTxtIdProjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgFluxoCaixaProjetoDataCriacaoFluxo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgFluxoCaixaProjetoTxtDataPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgFluxoCaixaProjetoTxtTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgFluxoCaixaProjetoTxtObservacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgFluxoCaixaProjetoTxtValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgFluxoCaixaProjetoBtnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtgFluxoCaixaProjetoBtnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbParticipantes = new System.Windows.Forms.TabPage();
            this.grbParticipantes = new System.Windows.Forms.GroupBox();
            this.dtgParticipantes = new System.Windows.Forms.DataGridView();
            this.dtgParticipantesTxtProjetosPessoasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgParticipantesTxtNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgParticipantesTxtProjetosPessoasObservacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgParticipantesProjetosPessoasStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgParticipantesTxtProjetosPessoasIdProjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgParticipantesTxtOcupacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgParticipantesTxtDataIngresso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgParticipantesTxtObsrvacoesParticipantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgParticipantesBtnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtgParticipantesBtnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboParticipantesPessoas = new System.Windows.Forms.ComboBox();
            this.dtpParticipantesIngresso = new System.Windows.Forms.DateTimePicker();
            this.lblDataIngresso = new System.Windows.Forms.Label();
            this.txtParticipantesObservacoes = new System.Windows.Forms.TextBox();
            this.lblObservacoesParticipantes = new System.Windows.Forms.Label();
            this.txtParticipantesOcupacao = new System.Windows.Forms.TextBox();
            this.lblOcupacao = new System.Windows.Forms.Label();
            this.btnParticipanteSalvar = new System.Windows.Forms.Button();
            this.lblParticipante = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnParticipanteExcluir = new System.Windows.Forms.Button();
            this.btnParticipanteEditar = new System.Windows.Forms.Button();
            this.btnParticipanteIncluir = new System.Windows.Forms.Button();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tspPrincipal.SuspendLayout();
            this.tbReunioesProjeto.SuspendLayout();
            this.tbInformacoes.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
            this.grbPrincipal.SuspendLayout();
            this.tbFluxoDeCaixa.SuspendLayout();
            this.grbFluxoCaixaProjeto.SuspendLayout();
            this.grbIncluirReceitaVariavel.SuspendLayout();
            this.grbFluxoCaixaProjetoAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFluxoCaixaProjeto)).BeginInit();
            this.tbParticipantes.SuspendLayout();
            this.grbParticipantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantes)).BeginInit();
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
            this.btnAlterar.Text = "Alterar";
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
            this.btnPesquisar.Enabled = false;
            this.btnPesquisar.Image = global::projProjetos.Properties.Resources.pesquisa;
            this.btnPesquisar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(61, 69);
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.Visible = false;
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
            this.tbReunioesProjeto.Size = new System.Drawing.Size(939, 547);
            this.tbReunioesProjeto.TabIndex = 2;
            // 
            // tbInformacoes
            // 
            this.tbInformacoes.Controls.Add(this.tbCadastro);
            this.tbInformacoes.Location = new System.Drawing.Point(4, 25);
            this.tbInformacoes.Name = "tbInformacoes";
            this.tbInformacoes.Padding = new System.Windows.Forms.Padding(3);
            this.tbInformacoes.Size = new System.Drawing.Size(931, 518);
            this.tbInformacoes.TabIndex = 0;
            this.tbInformacoes.Text = "Informações cadastrais";
            this.tbInformacoes.UseVisualStyleBackColor = true;
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.dtgPrincipal);
            this.tbCadastro.Controls.Add(this.grbPrincipal);
            this.tbCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCadastro.Location = new System.Drawing.Point(3, 3);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Size = new System.Drawing.Size(925, 512);
            this.tbCadastro.TabIndex = 0;
            this.tbCadastro.TabStop = false;
            // 
            // dtgPrincipal
            // 
            this.dtgPrincipal.AllowUserToAddRows = false;
            this.dtgPrincipal.AllowUserToDeleteRows = false;
            this.dtgPrincipal.AllowUserToResizeColumns = false;
            this.dtgPrincipal.AllowUserToResizeRows = false;
            this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgPrincipaltxtID,
            this.dtgPrincipaltxtNome,
            this.dtgPrincipalTxtDescricao,
            this.DESCRICAO,
            this.dtgPrincipalTxtObservacao,
            this.dtgPrincipalTxtGerenteProjeto,
            this.dtgPrincipalTxtInvestimentoPrevisto,
            this.dtgPrincipalTxtRazaoReceitaValor,
            this.RAZAORECEITAVALOR,
            this.dtgPrincipalTxtRazaoReceitaPercentual,
            this.dtgPrincipalTxtTempoPrevistoConclusao,
            this.dtgPrincipalTxtStatus,
            this.dtgPrincipalBtnEditar,
            this.dtgPrincipalBtnInativar});
            this.dtgPrincipal.Location = new System.Drawing.Point(6, 343);
            this.dtgPrincipal.MultiSelect = false;
            this.dtgPrincipal.Name = "dtgPrincipal";
            this.dtgPrincipal.ReadOnly = true;
            this.dtgPrincipal.RowHeadersVisible = false;
            this.dtgPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPrincipal.Size = new System.Drawing.Size(913, 162);
            this.dtgPrincipal.TabIndex = 5;
            this.dtgPrincipal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellClick);
            // 
            // dtgPrincipaltxtID
            // 
            this.dtgPrincipaltxtID.DataPropertyName = "ID";
            this.dtgPrincipaltxtID.HeaderText = "ID";
            this.dtgPrincipaltxtID.Name = "dtgPrincipaltxtID";
            this.dtgPrincipaltxtID.ReadOnly = true;
            this.dtgPrincipaltxtID.Visible = false;
            // 
            // dtgPrincipaltxtNome
            // 
            this.dtgPrincipaltxtNome.DataPropertyName = "NOME";
            this.dtgPrincipaltxtNome.HeaderText = "NOME";
            this.dtgPrincipaltxtNome.Name = "dtgPrincipaltxtNome";
            this.dtgPrincipaltxtNome.ReadOnly = true;
            this.dtgPrincipaltxtNome.Width = 180;
            // 
            // dtgPrincipalTxtDescricao
            // 
            this.dtgPrincipalTxtDescricao.DataPropertyName = "OBSERVACAO";
            this.dtgPrincipalTxtDescricao.HeaderText = "Descrição";
            this.dtgPrincipalTxtDescricao.Name = "dtgPrincipalTxtDescricao";
            this.dtgPrincipalTxtDescricao.ReadOnly = true;
            this.dtgPrincipalTxtDescricao.Width = 175;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "DESCRICAO";
            this.DESCRICAO.HeaderText = "DESC";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            this.DESCRICAO.Visible = false;
            // 
            // dtgPrincipalTxtObservacao
            // 
            this.dtgPrincipalTxtObservacao.DataPropertyName = "OBSERVACAO";
            this.dtgPrincipalTxtObservacao.HeaderText = "Observação";
            this.dtgPrincipalTxtObservacao.Name = "dtgPrincipalTxtObservacao";
            this.dtgPrincipalTxtObservacao.ReadOnly = true;
            this.dtgPrincipalTxtObservacao.Visible = false;
            // 
            // dtgPrincipalTxtGerenteProjeto
            // 
            this.dtgPrincipalTxtGerenteProjeto.DataPropertyName = "GERENTEPROJETO";
            this.dtgPrincipalTxtGerenteProjeto.HeaderText = "Gerente do projeto";
            this.dtgPrincipalTxtGerenteProjeto.Name = "dtgPrincipalTxtGerenteProjeto";
            this.dtgPrincipalTxtGerenteProjeto.ReadOnly = true;
            this.dtgPrincipalTxtGerenteProjeto.Width = 150;
            // 
            // dtgPrincipalTxtInvestimentoPrevisto
            // 
            this.dtgPrincipalTxtInvestimentoPrevisto.DataPropertyName = "INVESTIMENTOPREVISTO";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "C2";
            dataGridViewCellStyle16.NullValue = null;
            this.dtgPrincipalTxtInvestimentoPrevisto.DefaultCellStyle = dataGridViewCellStyle16;
            this.dtgPrincipalTxtInvestimentoPrevisto.HeaderText = "Inv. previsto";
            this.dtgPrincipalTxtInvestimentoPrevisto.Name = "dtgPrincipalTxtInvestimentoPrevisto";
            this.dtgPrincipalTxtInvestimentoPrevisto.ReadOnly = true;
            this.dtgPrincipalTxtInvestimentoPrevisto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPrincipalTxtInvestimentoPrevisto.Width = 130;
            // 
            // dtgPrincipalTxtRazaoReceitaValor
            // 
            this.dtgPrincipalTxtRazaoReceitaValor.DataPropertyName = "RECEITACONSTANTE";
            this.dtgPrincipalTxtRazaoReceitaValor.HeaderText = "RECEITACONSTANTE";
            this.dtgPrincipalTxtRazaoReceitaValor.Name = "dtgPrincipalTxtRazaoReceitaValor";
            this.dtgPrincipalTxtRazaoReceitaValor.ReadOnly = true;
            this.dtgPrincipalTxtRazaoReceitaValor.Visible = false;
            // 
            // RAZAORECEITAVALOR
            // 
            this.RAZAORECEITAVALOR.DataPropertyName = "RAZAORECEITAVALOR";
            this.RAZAORECEITAVALOR.HeaderText = "RAZAORECEITAVALOR";
            this.RAZAORECEITAVALOR.Name = "RAZAORECEITAVALOR";
            this.RAZAORECEITAVALOR.ReadOnly = true;
            this.RAZAORECEITAVALOR.Visible = false;
            // 
            // dtgPrincipalTxtRazaoReceitaPercentual
            // 
            this.dtgPrincipalTxtRazaoReceitaPercentual.DataPropertyName = "RAZAORECEITAPERCENTUAL";
            this.dtgPrincipalTxtRazaoReceitaPercentual.HeaderText = "RAZAORECEITAPERCENTUAL";
            this.dtgPrincipalTxtRazaoReceitaPercentual.Name = "dtgPrincipalTxtRazaoReceitaPercentual";
            this.dtgPrincipalTxtRazaoReceitaPercentual.ReadOnly = true;
            this.dtgPrincipalTxtRazaoReceitaPercentual.Visible = false;
            // 
            // dtgPrincipalTxtTempoPrevistoConclusao
            // 
            this.dtgPrincipalTxtTempoPrevistoConclusao.DataPropertyName = "TEMPOPREVISTOCONCLUSAO";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            this.dtgPrincipalTxtTempoPrevistoConclusao.DefaultCellStyle = dataGridViewCellStyle17;
            this.dtgPrincipalTxtTempoPrevistoConclusao.HeaderText = "Conclusão (MESES)";
            this.dtgPrincipalTxtTempoPrevistoConclusao.Name = "dtgPrincipalTxtTempoPrevistoConclusao";
            this.dtgPrincipalTxtTempoPrevistoConclusao.ReadOnly = true;
            this.dtgPrincipalTxtTempoPrevistoConclusao.Width = 120;
            // 
            // dtgPrincipalTxtStatus
            // 
            this.dtgPrincipalTxtStatus.DataPropertyName = "STATUS";
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgPrincipalTxtStatus.DefaultCellStyle = dataGridViewCellStyle18;
            this.dtgPrincipalTxtStatus.HeaderText = "STATUS";
            this.dtgPrincipalTxtStatus.Name = "dtgPrincipalTxtStatus";
            this.dtgPrincipalTxtStatus.ReadOnly = true;
            // 
            // dtgPrincipalBtnEditar
            // 
            this.dtgPrincipalBtnEditar.DataPropertyName = "dtgPrincipalBtnEditar";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle19.NullValue = null;
            this.dtgPrincipalBtnEditar.DefaultCellStyle = dataGridViewCellStyle19;
            this.dtgPrincipalBtnEditar.HeaderText = "";
            this.dtgPrincipalBtnEditar.Image = global::projProjetos.Properties.Resources.editar;
            this.dtgPrincipalBtnEditar.Name = "dtgPrincipalBtnEditar";
            this.dtgPrincipalBtnEditar.ReadOnly = true;
            this.dtgPrincipalBtnEditar.Width = 30;
            // 
            // dtgPrincipalBtnInativar
            // 
            this.dtgPrincipalBtnInativar.DataPropertyName = "dtgPrincipalBtnInativar";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle20.NullValue = null;
            this.dtgPrincipalBtnInativar.DefaultCellStyle = dataGridViewCellStyle20;
            this.dtgPrincipalBtnInativar.HeaderText = "";
            this.dtgPrincipalBtnInativar.Image = global::projProjetos.Properties.Resources.excluir;
            this.dtgPrincipalBtnInativar.Name = "dtgPrincipalBtnInativar";
            this.dtgPrincipalBtnInativar.ReadOnly = true;
            this.dtgPrincipalBtnInativar.Width = 30;
            // 
            // grbPrincipal
            // 
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
            this.grbPrincipal.Controls.Add(this.cboGerenteProjeto);
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
            this.grbPrincipal.Size = new System.Drawing.Size(913, 316);
            this.grbPrincipal.TabIndex = 4;
            this.grbPrincipal.TabStop = false;
            this.grbPrincipal.Text = "Informações";
            // 
            // rbEsforcoAdicionalAcima40PorCento
            // 
            this.rbEsforcoAdicionalAcima40PorCento.AutoSize = true;
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
            this.cboApoioSteakholders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboApoioSteakholders.Enabled = false;
            this.cboApoioSteakholders.FormattingEnabled = true;
            this.cboApoioSteakholders.Items.AddRange(new object[] {
            "Anciosos",
            "Dispostos",
            "Relutantes",
            "Fortemente relutantes"});
            this.cboApoioSteakholders.Location = new System.Drawing.Point(187, 167);
            this.cboApoioSteakholders.Name = "cboApoioSteakholders";
            this.cboApoioSteakholders.Size = new System.Drawing.Size(200, 24);
            this.cboApoioSteakholders.TabIndex = 16;
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
            this.cboApoioAltaGestao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboApoioAltaGestao.Enabled = false;
            this.cboApoioAltaGestao.FormattingEnabled = true;
            this.cboApoioAltaGestao.Items.AddRange(new object[] {
            "Apoio formal e total",
            "Desejam o Sucesso",
            "Neutro",
            "Relutantes"});
            this.cboApoioAltaGestao.Location = new System.Drawing.Point(568, 155);
            this.cboApoioAltaGestao.Name = "cboApoioAltaGestao";
            this.cboApoioAltaGestao.Size = new System.Drawing.Size(191, 24);
            this.cboApoioAltaGestao.TabIndex = 14;
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
            this.cboCapacidadeEntregaEquipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCapacidadeEntregaEquipe.Enabled = false;
            this.cboCapacidadeEntregaEquipe.FormattingEnabled = true;
            this.cboCapacidadeEntregaEquipe.Items.AddRange(new object[] {
            "Muito bom",
            "Bom",
            "Médio",
            "Pobre"});
            this.cboCapacidadeEntregaEquipe.Location = new System.Drawing.Point(568, 117);
            this.cboCapacidadeEntregaEquipe.Name = "cboCapacidadeEntregaEquipe";
            this.cboCapacidadeEntregaEquipe.Size = new System.Drawing.Size(191, 24);
            this.cboCapacidadeEntregaEquipe.TabIndex = 12;
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
            // cboGerenteProjeto
            // 
            this.cboGerenteProjeto.DisplayMember = "NOME";
            this.cboGerenteProjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGerenteProjeto.Enabled = false;
            this.cboGerenteProjeto.FormattingEnabled = true;
            this.cboGerenteProjeto.Location = new System.Drawing.Point(187, 81);
            this.cboGerenteProjeto.Name = "cboGerenteProjeto";
            this.cboGerenteProjeto.Size = new System.Drawing.Size(572, 24);
            this.cboGerenteProjeto.TabIndex = 8;
            this.cboGerenteProjeto.ValueMember = "ID";
            // 
            // txtInvestimentoPrevisto
            // 
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
            this.txtPrazoConclusao.Location = new System.Drawing.Point(187, 111);
            this.txtPrazoConclusao.Name = "txtPrazoConclusao";
            this.txtPrazoConclusao.ReadOnly = true;
            this.txtPrazoConclusao.Size = new System.Drawing.Size(104, 22);
            this.txtPrazoConclusao.TabIndex = 1;
            // 
            // txtCodigo
            // 
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
            this.tbFluxoDeCaixa.Size = new System.Drawing.Size(931, 518);
            this.tbFluxoDeCaixa.TabIndex = 1;
            this.tbFluxoDeCaixa.Text = "Receitas/Despesas previstas";
            this.tbFluxoDeCaixa.UseVisualStyleBackColor = true;
            // 
            // grbFluxoCaixaProjeto
            // 
            this.grbFluxoCaixaProjeto.Controls.Add(this.grbIncluirReceitaVariavel);
            this.grbFluxoCaixaProjeto.Controls.Add(this.grbFluxoCaixaProjetoAcoes);
            this.grbFluxoCaixaProjeto.Controls.Add(this.dtgFluxoCaixaProjeto);
            this.grbFluxoCaixaProjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbFluxoCaixaProjeto.Location = new System.Drawing.Point(3, 3);
            this.grbFluxoCaixaProjeto.Name = "grbFluxoCaixaProjeto";
            this.grbFluxoCaixaProjeto.Size = new System.Drawing.Size(925, 512);
            this.grbFluxoCaixaProjeto.TabIndex = 0;
            this.grbFluxoCaixaProjeto.TabStop = false;
            this.grbFluxoCaixaProjeto.Text = "Receitas/Despesas do projeto";
            // 
            // grbIncluirReceitaVariavel
            // 
            this.grbIncluirReceitaVariavel.Controls.Add(this.txtFluxoValor);
            this.grbIncluirReceitaVariavel.Controls.Add(this.dtpFluxoCaixaPeriodo);
            this.grbIncluirReceitaVariavel.Controls.Add(this.btnFluxoSalvar);
            this.grbIncluirReceitaVariavel.Controls.Add(this.txtFluxoObservacoes);
            this.grbIncluirReceitaVariavel.Controls.Add(this.lblObservacoesFluxoCaixa);
            this.grbIncluirReceitaVariavel.Controls.Add(this.cboFluxoTipo);
            this.grbIncluirReceitaVariavel.Controls.Add(this.lblTipoFluxoCaixa);
            this.grbIncluirReceitaVariavel.Controls.Add(this.lblValor);
            this.grbIncluirReceitaVariavel.Controls.Add(this.lblPeriodo);
            this.grbIncluirReceitaVariavel.Location = new System.Drawing.Point(105, 21);
            this.grbIncluirReceitaVariavel.Name = "grbIncluirReceitaVariavel";
            this.grbIncluirReceitaVariavel.Size = new System.Drawing.Size(814, 107);
            this.grbIncluirReceitaVariavel.TabIndex = 7;
            this.grbIncluirReceitaVariavel.TabStop = false;
            // 
            // txtFluxoValor
            // 
            this.txtFluxoValor.Location = new System.Drawing.Point(100, 74);
            this.txtFluxoValor.Name = "txtFluxoValor";
            this.txtFluxoValor.ReadOnly = true;
            this.txtFluxoValor.Size = new System.Drawing.Size(140, 22);
            this.txtFluxoValor.TabIndex = 8;
            // 
            // dtpFluxoCaixaPeriodo
            // 
            this.dtpFluxoCaixaPeriodo.CustomFormat = "dd/MM/yyyy";
            this.dtpFluxoCaixaPeriodo.Enabled = false;
            this.dtpFluxoCaixaPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFluxoCaixaPeriodo.Location = new System.Drawing.Point(100, 12);
            this.dtpFluxoCaixaPeriodo.Name = "dtpFluxoCaixaPeriodo";
            this.dtpFluxoCaixaPeriodo.Size = new System.Drawing.Size(140, 22);
            this.dtpFluxoCaixaPeriodo.TabIndex = 7;
            // 
            // btnFluxoSalvar
            // 
            this.btnFluxoSalvar.Enabled = false;
            this.btnFluxoSalvar.Location = new System.Drawing.Point(716, 72);
            this.btnFluxoSalvar.Name = "btnFluxoSalvar";
            this.btnFluxoSalvar.Size = new System.Drawing.Size(77, 23);
            this.btnFluxoSalvar.TabIndex = 1;
            this.btnFluxoSalvar.Text = "Salvar";
            this.btnFluxoSalvar.UseVisualStyleBackColor = true;
            this.btnFluxoSalvar.Click += new System.EventHandler(this.btnFluxoSalvar_Click);
            // 
            // txtFluxoObservacoes
            // 
            this.txtFluxoObservacoes.Location = new System.Drawing.Point(365, 14);
            this.txtFluxoObservacoes.Multiline = true;
            this.txtFluxoObservacoes.Name = "txtFluxoObservacoes";
            this.txtFluxoObservacoes.ReadOnly = true;
            this.txtFluxoObservacoes.Size = new System.Drawing.Size(428, 52);
            this.txtFluxoObservacoes.TabIndex = 5;
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
            // cboFluxoTipo
            // 
            this.cboFluxoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFluxoTipo.Enabled = false;
            this.cboFluxoTipo.FormattingEnabled = true;
            this.cboFluxoTipo.Items.AddRange(new object[] {
            "RECEITA",
            "DESPESA"});
            this.cboFluxoTipo.Location = new System.Drawing.Point(100, 42);
            this.cboFluxoTipo.Name = "cboFluxoTipo";
            this.cboFluxoTipo.Size = new System.Drawing.Size(141, 24);
            this.cboFluxoTipo.TabIndex = 3;
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
            this.grbFluxoCaixaProjetoAcoes.Controls.Add(this.btnFluxoExcluir);
            this.grbFluxoCaixaProjetoAcoes.Controls.Add(this.btnFluxoEditar);
            this.grbFluxoCaixaProjetoAcoes.Controls.Add(this.btnFluxoIncluir);
            this.grbFluxoCaixaProjetoAcoes.Location = new System.Drawing.Point(10, 21);
            this.grbFluxoCaixaProjetoAcoes.Name = "grbFluxoCaixaProjetoAcoes";
            this.grbFluxoCaixaProjetoAcoes.Size = new System.Drawing.Size(89, 107);
            this.grbFluxoCaixaProjetoAcoes.TabIndex = 6;
            this.grbFluxoCaixaProjetoAcoes.TabStop = false;
            this.grbFluxoCaixaProjetoAcoes.Text = "Ações";
            // 
            // btnFluxoExcluir
            // 
            this.btnFluxoExcluir.Enabled = false;
            this.btnFluxoExcluir.Location = new System.Drawing.Point(6, 79);
            this.btnFluxoExcluir.Name = "btnFluxoExcluir";
            this.btnFluxoExcluir.Size = new System.Drawing.Size(77, 23);
            this.btnFluxoExcluir.TabIndex = 0;
            this.btnFluxoExcluir.Text = "Excluir";
            this.btnFluxoExcluir.UseVisualStyleBackColor = true;
            this.btnFluxoExcluir.Click += new System.EventHandler(this.btnFluxoExcluir_Click);
            // 
            // btnFluxoEditar
            // 
            this.btnFluxoEditar.Enabled = false;
            this.btnFluxoEditar.Location = new System.Drawing.Point(6, 50);
            this.btnFluxoEditar.Name = "btnFluxoEditar";
            this.btnFluxoEditar.Size = new System.Drawing.Size(77, 23);
            this.btnFluxoEditar.TabIndex = 0;
            this.btnFluxoEditar.Text = "Editar";
            this.btnFluxoEditar.UseVisualStyleBackColor = true;
            this.btnFluxoEditar.Click += new System.EventHandler(this.btnFluxoEditar_Click);
            // 
            // btnFluxoIncluir
            // 
            this.btnFluxoIncluir.Enabled = false;
            this.btnFluxoIncluir.Location = new System.Drawing.Point(6, 21);
            this.btnFluxoIncluir.Name = "btnFluxoIncluir";
            this.btnFluxoIncluir.Size = new System.Drawing.Size(77, 23);
            this.btnFluxoIncluir.TabIndex = 0;
            this.btnFluxoIncluir.Text = "Incluir Receita";
            this.btnFluxoIncluir.UseVisualStyleBackColor = true;
            this.btnFluxoIncluir.Click += new System.EventHandler(this.btnFluxoIncluir_Click);
            // 
            // dtgFluxoCaixaProjeto
            // 
            this.dtgFluxoCaixaProjeto.AllowUserToAddRows = false;
            this.dtgFluxoCaixaProjeto.AllowUserToDeleteRows = false;
            this.dtgFluxoCaixaProjeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFluxoCaixaProjeto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgFluxoCaixaProjetoTxtIdProjeto,
            this.dtgFluxoCaixaProjetoDataCriacaoFluxo,
            this.dtgFluxoCaixaProjetoTxtDataPeriodo,
            this.dtgFluxoCaixaProjetoTxtTipo,
            this.dtgFluxoCaixaProjetoTxtObservacoes,
            this.dtgFluxoCaixaProjetoTxtValor,
            this.dtgFluxoCaixaProjetoBtnEditar,
            this.dtgFluxoCaixaProjetoBtnExcluir});
            this.dtgFluxoCaixaProjeto.Location = new System.Drawing.Point(10, 134);
            this.dtgFluxoCaixaProjeto.MultiSelect = false;
            this.dtgFluxoCaixaProjeto.Name = "dtgFluxoCaixaProjeto";
            this.dtgFluxoCaixaProjeto.ReadOnly = true;
            this.dtgFluxoCaixaProjeto.RowHeadersVisible = false;
            this.dtgFluxoCaixaProjeto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFluxoCaixaProjeto.Size = new System.Drawing.Size(909, 371);
            this.dtgFluxoCaixaProjeto.TabIndex = 5;
            this.dtgFluxoCaixaProjeto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFluxoCaixaProjeto_CellClick);
            this.dtgFluxoCaixaProjeto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFluxoCaixaProjeto_CellContentClick);
            // 
            // dtgFluxoCaixaProjetoTxtIdProjeto
            // 
            this.dtgFluxoCaixaProjetoTxtIdProjeto.DataPropertyName = "IDPROJETO";
            this.dtgFluxoCaixaProjetoTxtIdProjeto.HeaderText = "IDPROJETO";
            this.dtgFluxoCaixaProjetoTxtIdProjeto.Name = "dtgFluxoCaixaProjetoTxtIdProjeto";
            this.dtgFluxoCaixaProjetoTxtIdProjeto.ReadOnly = true;
            this.dtgFluxoCaixaProjetoTxtIdProjeto.Visible = false;
            // 
            // dtgFluxoCaixaProjetoDataCriacaoFluxo
            // 
            this.dtgFluxoCaixaProjetoDataCriacaoFluxo.DataPropertyName = "DATACRIACAO";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.Format = "d";
            dataGridViewCellStyle21.NullValue = null;
            this.dtgFluxoCaixaProjetoDataCriacaoFluxo.DefaultCellStyle = dataGridViewCellStyle21;
            this.dtgFluxoCaixaProjetoDataCriacaoFluxo.HeaderText = "DATACRIACAO";
            this.dtgFluxoCaixaProjetoDataCriacaoFluxo.Name = "dtgFluxoCaixaProjetoDataCriacaoFluxo";
            this.dtgFluxoCaixaProjetoDataCriacaoFluxo.ReadOnly = true;
            this.dtgFluxoCaixaProjetoDataCriacaoFluxo.Visible = false;
            this.dtgFluxoCaixaProjetoDataCriacaoFluxo.Width = 40;
            // 
            // dtgFluxoCaixaProjetoTxtDataPeriodo
            // 
            this.dtgFluxoCaixaProjetoTxtDataPeriodo.DataPropertyName = "DATAPERIODO";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Format = "d";
            dataGridViewCellStyle22.NullValue = null;
            this.dtgFluxoCaixaProjetoTxtDataPeriodo.DefaultCellStyle = dataGridViewCellStyle22;
            this.dtgFluxoCaixaProjetoTxtDataPeriodo.HeaderText = "Data / Periodo";
            this.dtgFluxoCaixaProjetoTxtDataPeriodo.Name = "dtgFluxoCaixaProjetoTxtDataPeriodo";
            this.dtgFluxoCaixaProjetoTxtDataPeriodo.ReadOnly = true;
            this.dtgFluxoCaixaProjetoTxtDataPeriodo.Width = 150;
            // 
            // dtgFluxoCaixaProjetoTxtTipo
            // 
            this.dtgFluxoCaixaProjetoTxtTipo.DataPropertyName = "TIPO";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgFluxoCaixaProjetoTxtTipo.DefaultCellStyle = dataGridViewCellStyle23;
            this.dtgFluxoCaixaProjetoTxtTipo.HeaderText = "Tipo";
            this.dtgFluxoCaixaProjetoTxtTipo.Name = "dtgFluxoCaixaProjetoTxtTipo";
            this.dtgFluxoCaixaProjetoTxtTipo.ReadOnly = true;
            this.dtgFluxoCaixaProjetoTxtTipo.Width = 150;
            // 
            // dtgFluxoCaixaProjetoTxtObservacoes
            // 
            this.dtgFluxoCaixaProjetoTxtObservacoes.DataPropertyName = "OBSERVACOES";
            this.dtgFluxoCaixaProjetoTxtObservacoes.HeaderText = "Observações";
            this.dtgFluxoCaixaProjetoTxtObservacoes.Name = "dtgFluxoCaixaProjetoTxtObservacoes";
            this.dtgFluxoCaixaProjetoTxtObservacoes.ReadOnly = true;
            this.dtgFluxoCaixaProjetoTxtObservacoes.Width = 350;
            // 
            // dtgFluxoCaixaProjetoTxtValor
            // 
            this.dtgFluxoCaixaProjetoTxtValor.DataPropertyName = "VALOR";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle24.Format = "C2";
            dataGridViewCellStyle24.NullValue = "0";
            this.dtgFluxoCaixaProjetoTxtValor.DefaultCellStyle = dataGridViewCellStyle24;
            this.dtgFluxoCaixaProjetoTxtValor.HeaderText = "Valor (R$)";
            this.dtgFluxoCaixaProjetoTxtValor.Name = "dtgFluxoCaixaProjetoTxtValor";
            this.dtgFluxoCaixaProjetoTxtValor.ReadOnly = true;
            this.dtgFluxoCaixaProjetoTxtValor.Width = 150;
            // 
            // dtgFluxoCaixaProjetoBtnEditar
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle25.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle25.NullValue")));
            this.dtgFluxoCaixaProjetoBtnEditar.DefaultCellStyle = dataGridViewCellStyle25;
            this.dtgFluxoCaixaProjetoBtnEditar.HeaderText = "";
            this.dtgFluxoCaixaProjetoBtnEditar.Image = global::projProjetos.Properties.Resources.editar;
            this.dtgFluxoCaixaProjetoBtnEditar.Name = "dtgFluxoCaixaProjetoBtnEditar";
            this.dtgFluxoCaixaProjetoBtnEditar.ReadOnly = true;
            this.dtgFluxoCaixaProjetoBtnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFluxoCaixaProjetoBtnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dtgFluxoCaixaProjetoBtnEditar.Width = 40;
            // 
            // dtgFluxoCaixaProjetoBtnExcluir
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle26.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle26.NullValue")));
            this.dtgFluxoCaixaProjetoBtnExcluir.DefaultCellStyle = dataGridViewCellStyle26;
            this.dtgFluxoCaixaProjetoBtnExcluir.HeaderText = "";
            this.dtgFluxoCaixaProjetoBtnExcluir.Image = global::projProjetos.Properties.Resources.excluir;
            this.dtgFluxoCaixaProjetoBtnExcluir.Name = "dtgFluxoCaixaProjetoBtnExcluir";
            this.dtgFluxoCaixaProjetoBtnExcluir.ReadOnly = true;
            this.dtgFluxoCaixaProjetoBtnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFluxoCaixaProjetoBtnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dtgFluxoCaixaProjetoBtnExcluir.Width = 40;
            // 
            // tbParticipantes
            // 
            this.tbParticipantes.Controls.Add(this.grbParticipantes);
            this.tbParticipantes.Location = new System.Drawing.Point(4, 25);
            this.tbParticipantes.Name = "tbParticipantes";
            this.tbParticipantes.Padding = new System.Windows.Forms.Padding(3);
            this.tbParticipantes.Size = new System.Drawing.Size(931, 518);
            this.tbParticipantes.TabIndex = 2;
            this.tbParticipantes.Text = "Participantes do projeto";
            this.tbParticipantes.UseVisualStyleBackColor = true;
            // 
            // grbParticipantes
            // 
            this.grbParticipantes.Controls.Add(this.dtgParticipantes);
            this.grbParticipantes.Controls.Add(this.groupBox2);
            this.grbParticipantes.Controls.Add(this.groupBox1);
            this.grbParticipantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbParticipantes.Location = new System.Drawing.Point(3, 3);
            this.grbParticipantes.Name = "grbParticipantes";
            this.grbParticipantes.Size = new System.Drawing.Size(925, 512);
            this.grbParticipantes.TabIndex = 0;
            this.grbParticipantes.TabStop = false;
            this.grbParticipantes.Text = "Participantes";
            // 
            // dtgParticipantes
            // 
            this.dtgParticipantes.AllowUserToAddRows = false;
            this.dtgParticipantes.AllowUserToDeleteRows = false;
            this.dtgParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgParticipantesTxtProjetosPessoasID,
            this.dtgParticipantesTxtNome,
            this.dtgParticipantesTxtProjetosPessoasObservacao,
            this.dtgParticipantesProjetosPessoasStatus,
            this.dtgParticipantesTxtProjetosPessoasIdProjeto,
            this.dtgParticipantesTxtOcupacao,
            this.dtgParticipantesTxtDataIngresso,
            this.dtgParticipantesTxtObsrvacoesParticipantes,
            this.dtgParticipantesBtnEditar,
            this.dtgParticipantesBtnExcluir});
            this.dtgParticipantes.Location = new System.Drawing.Point(6, 135);
            this.dtgParticipantes.MultiSelect = false;
            this.dtgParticipantes.Name = "dtgParticipantes";
            this.dtgParticipantes.ReadOnly = true;
            this.dtgParticipantes.RowHeadersVisible = false;
            this.dtgParticipantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgParticipantes.Size = new System.Drawing.Size(913, 370);
            this.dtgParticipantes.TabIndex = 12;
            this.dtgParticipantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgParticipantes_CellClick);
            // 
            // dtgParticipantesTxtProjetosPessoasID
            // 
            this.dtgParticipantesTxtProjetosPessoasID.DataPropertyName = "ID";
            this.dtgParticipantesTxtProjetosPessoasID.HeaderText = "PROJETOSPESSOASID";
            this.dtgParticipantesTxtProjetosPessoasID.Name = "dtgParticipantesTxtProjetosPessoasID";
            this.dtgParticipantesTxtProjetosPessoasID.ReadOnly = true;
            this.dtgParticipantesTxtProjetosPessoasID.Visible = false;
            // 
            // dtgParticipantesTxtNome
            // 
            this.dtgParticipantesTxtNome.DataPropertyName = "NOME";
            this.dtgParticipantesTxtNome.HeaderText = "Nome";
            this.dtgParticipantesTxtNome.Name = "dtgParticipantesTxtNome";
            this.dtgParticipantesTxtNome.ReadOnly = true;
            this.dtgParticipantesTxtNome.Width = 310;
            // 
            // dtgParticipantesTxtProjetosPessoasObservacao
            // 
            this.dtgParticipantesTxtProjetosPessoasObservacao.DataPropertyName = "OBSERVACAO";
            this.dtgParticipantesTxtProjetosPessoasObservacao.HeaderText = "PROJETOSPESSOASOBSERVACAO";
            this.dtgParticipantesTxtProjetosPessoasObservacao.Name = "dtgParticipantesTxtProjetosPessoasObservacao";
            this.dtgParticipantesTxtProjetosPessoasObservacao.ReadOnly = true;
            this.dtgParticipantesTxtProjetosPessoasObservacao.Visible = false;
            // 
            // dtgParticipantesProjetosPessoasStatus
            // 
            this.dtgParticipantesProjetosPessoasStatus.DataPropertyName = "STATUS";
            this.dtgParticipantesProjetosPessoasStatus.HeaderText = "PROJETOSPESSOASSTATUS";
            this.dtgParticipantesProjetosPessoasStatus.Name = "dtgParticipantesProjetosPessoasStatus";
            this.dtgParticipantesProjetosPessoasStatus.ReadOnly = true;
            this.dtgParticipantesProjetosPessoasStatus.Visible = false;
            // 
            // dtgParticipantesTxtProjetosPessoasIdProjeto
            // 
            this.dtgParticipantesTxtProjetosPessoasIdProjeto.DataPropertyName = "IDPROJETO";
            this.dtgParticipantesTxtProjetosPessoasIdProjeto.HeaderText = "PROJETOSPESSOASIDPROJETO";
            this.dtgParticipantesTxtProjetosPessoasIdProjeto.Name = "dtgParticipantesTxtProjetosPessoasIdProjeto";
            this.dtgParticipantesTxtProjetosPessoasIdProjeto.ReadOnly = true;
            this.dtgParticipantesTxtProjetosPessoasIdProjeto.Visible = false;
            // 
            // dtgParticipantesTxtOcupacao
            // 
            this.dtgParticipantesTxtOcupacao.DataPropertyName = "OCUPACAO";
            this.dtgParticipantesTxtOcupacao.HeaderText = "Ocupação";
            this.dtgParticipantesTxtOcupacao.Name = "dtgParticipantesTxtOcupacao";
            this.dtgParticipantesTxtOcupacao.ReadOnly = true;
            this.dtgParticipantesTxtOcupacao.Width = 200;
            // 
            // dtgParticipantesTxtDataIngresso
            // 
            this.dtgParticipantesTxtDataIngresso.DataPropertyName = "DATAINGRESSO";
            this.dtgParticipantesTxtDataIngresso.HeaderText = "Data Ingresso";
            this.dtgParticipantesTxtDataIngresso.Name = "dtgParticipantesTxtDataIngresso";
            this.dtgParticipantesTxtDataIngresso.ReadOnly = true;
            this.dtgParticipantesTxtDataIngresso.Width = 150;
            // 
            // dtgParticipantesTxtObsrvacoesParticipantes
            // 
            this.dtgParticipantesTxtObsrvacoesParticipantes.DataPropertyName = "OBSERVACOESPARTICIPANTE";
            this.dtgParticipantesTxtObsrvacoesParticipantes.HeaderText = "Observações";
            this.dtgParticipantesTxtObsrvacoesParticipantes.Name = "dtgParticipantesTxtObsrvacoesParticipantes";
            this.dtgParticipantesTxtObsrvacoesParticipantes.ReadOnly = true;
            this.dtgParticipantesTxtObsrvacoesParticipantes.Width = 170;
            // 
            // dtgParticipantesBtnEditar
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle27.NullValue = null;
            this.dtgParticipantesBtnEditar.DefaultCellStyle = dataGridViewCellStyle27;
            this.dtgParticipantesBtnEditar.HeaderText = "";
            this.dtgParticipantesBtnEditar.Image = global::projProjetos.Properties.Resources.editar;
            this.dtgParticipantesBtnEditar.Name = "dtgParticipantesBtnEditar";
            this.dtgParticipantesBtnEditar.ReadOnly = true;
            this.dtgParticipantesBtnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgParticipantesBtnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dtgParticipantesBtnEditar.Width = 40;
            // 
            // dtgParticipantesBtnExcluir
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle28.NullValue = null;
            this.dtgParticipantesBtnExcluir.DefaultCellStyle = dataGridViewCellStyle28;
            this.dtgParticipantesBtnExcluir.HeaderText = "";
            this.dtgParticipantesBtnExcluir.Image = global::projProjetos.Properties.Resources.excluir;
            this.dtgParticipantesBtnExcluir.Name = "dtgParticipantesBtnExcluir";
            this.dtgParticipantesBtnExcluir.ReadOnly = true;
            this.dtgParticipantesBtnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgParticipantesBtnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dtgParticipantesBtnExcluir.Width = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboParticipantesPessoas);
            this.groupBox2.Controls.Add(this.dtpParticipantesIngresso);
            this.groupBox2.Controls.Add(this.lblDataIngresso);
            this.groupBox2.Controls.Add(this.txtParticipantesObservacoes);
            this.groupBox2.Controls.Add(this.lblObservacoesParticipantes);
            this.groupBox2.Controls.Add(this.txtParticipantesOcupacao);
            this.groupBox2.Controls.Add(this.lblOcupacao);
            this.groupBox2.Controls.Add(this.btnParticipanteSalvar);
            this.groupBox2.Controls.Add(this.lblParticipante);
            this.groupBox2.Location = new System.Drawing.Point(101, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 108);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // cboParticipantesPessoas
            // 
            this.cboParticipantesPessoas.DisplayMember = "NOME";
            this.cboParticipantesPessoas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParticipantesPessoas.Enabled = false;
            this.cboParticipantesPessoas.FormattingEnabled = true;
            this.cboParticipantesPessoas.Location = new System.Drawing.Point(105, 14);
            this.cboParticipantesPessoas.Name = "cboParticipantesPessoas";
            this.cboParticipantesPessoas.Size = new System.Drawing.Size(451, 24);
            this.cboParticipantesPessoas.TabIndex = 9;
            this.cboParticipantesPessoas.ValueMember = "ID";
            // 
            // dtpParticipantesIngresso
            // 
            this.dtpParticipantesIngresso.CustomFormat = "dd/mm/yyyy";
            this.dtpParticipantesIngresso.Enabled = false;
            this.dtpParticipantesIngresso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpParticipantesIngresso.Location = new System.Drawing.Point(425, 47);
            this.dtpParticipantesIngresso.Name = "dtpParticipantesIngresso";
            this.dtpParticipantesIngresso.Size = new System.Drawing.Size(131, 22);
            this.dtpParticipantesIngresso.TabIndex = 8;
            // 
            // lblDataIngresso
            // 
            this.lblDataIngresso.AutoSize = true;
            this.lblDataIngresso.Enabled = false;
            this.lblDataIngresso.Location = new System.Drawing.Point(292, 50);
            this.lblDataIngresso.Name = "lblDataIngresso";
            this.lblDataIngresso.Size = new System.Drawing.Size(127, 16);
            this.lblDataIngresso.TabIndex = 7;
            this.lblDataIngresso.Text = "Ingresso ao projeto:";
            // 
            // txtParticipantesObservacoes
            // 
            this.txtParticipantesObservacoes.Location = new System.Drawing.Point(105, 75);
            this.txtParticipantesObservacoes.Name = "txtParticipantesObservacoes";
            this.txtParticipantesObservacoes.Size = new System.Drawing.Size(451, 22);
            this.txtParticipantesObservacoes.TabIndex = 6;
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
            // txtParticipantesOcupacao
            // 
            this.txtParticipantesOcupacao.Location = new System.Drawing.Point(105, 47);
            this.txtParticipantesOcupacao.Name = "txtParticipantesOcupacao";
            this.txtParticipantesOcupacao.Size = new System.Drawing.Size(181, 22);
            this.txtParticipantesOcupacao.TabIndex = 4;
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
            // btnParticipanteSalvar
            // 
            this.btnParticipanteSalvar.Enabled = false;
            this.btnParticipanteSalvar.Location = new System.Drawing.Point(735, 79);
            this.btnParticipanteSalvar.Name = "btnParticipanteSalvar";
            this.btnParticipanteSalvar.Size = new System.Drawing.Size(77, 23);
            this.btnParticipanteSalvar.TabIndex = 1;
            this.btnParticipanteSalvar.Text = "Salvar";
            this.btnParticipanteSalvar.UseVisualStyleBackColor = true;
            this.btnParticipanteSalvar.Click += new System.EventHandler(this.btnParticipanteSalvar_Click);
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
            this.groupBox1.Controls.Add(this.btnParticipanteExcluir);
            this.groupBox1.Controls.Add(this.btnParticipanteEditar);
            this.groupBox1.Controls.Add(this.btnParticipanteIncluir);
            this.groupBox1.Location = new System.Drawing.Point(6, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 108);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // btnParticipanteExcluir
            // 
            this.btnParticipanteExcluir.Enabled = false;
            this.btnParticipanteExcluir.Location = new System.Drawing.Point(6, 79);
            this.btnParticipanteExcluir.Name = "btnParticipanteExcluir";
            this.btnParticipanteExcluir.Size = new System.Drawing.Size(77, 23);
            this.btnParticipanteExcluir.TabIndex = 0;
            this.btnParticipanteExcluir.Text = "Excluir";
            this.btnParticipanteExcluir.UseVisualStyleBackColor = true;
            this.btnParticipanteExcluir.Click += new System.EventHandler(this.btnParticipanteExcluir_Click);
            // 
            // btnParticipanteEditar
            // 
            this.btnParticipanteEditar.Enabled = false;
            this.btnParticipanteEditar.Location = new System.Drawing.Point(6, 50);
            this.btnParticipanteEditar.Name = "btnParticipanteEditar";
            this.btnParticipanteEditar.Size = new System.Drawing.Size(77, 23);
            this.btnParticipanteEditar.TabIndex = 0;
            this.btnParticipanteEditar.Text = "Editar";
            this.btnParticipanteEditar.UseVisualStyleBackColor = true;
            this.btnParticipanteEditar.Click += new System.EventHandler(this.btnParticipanteEditar_Click);
            // 
            // btnParticipanteIncluir
            // 
            this.btnParticipanteIncluir.Enabled = false;
            this.btnParticipanteIncluir.Location = new System.Drawing.Point(6, 21);
            this.btnParticipanteIncluir.Name = "btnParticipanteIncluir";
            this.btnParticipanteIncluir.Size = new System.Drawing.Size(77, 23);
            this.btnParticipanteIncluir.TabIndex = 0;
            this.btnParticipanteIncluir.Text = "Incluir Receita";
            this.btnParticipanteIncluir.UseVisualStyleBackColor = true;
            this.btnParticipanteIncluir.Click += new System.EventHandler(this.btnParticipanteIncluir_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grbReunioesProgramadas);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(931, 518);
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
            this.grbReunioesProgramadas.Size = new System.Drawing.Size(925, 512);
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
            this.dtgReunioes.Location = new System.Drawing.Point(10, 248);
            this.dtgReunioes.Name = "dtgReunioes";
            this.dtgReunioes.ReadOnly = true;
            this.dtgReunioes.Size = new System.Drawing.Size(909, 257);
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
            this.tbpReunioesProgramadas.Size = new System.Drawing.Size(913, 221);
            this.tbpReunioesProgramadas.TabIndex = 0;
            // 
            // tbReuniaoInformacoes
            // 
            this.tbReuniaoInformacoes.Controls.Add(this.grbReuniaoInformacoes);
            this.tbReuniaoInformacoes.Location = new System.Drawing.Point(4, 4);
            this.tbReuniaoInformacoes.Name = "tbReuniaoInformacoes";
            this.tbReuniaoInformacoes.Padding = new System.Windows.Forms.Padding(3);
            this.tbReuniaoInformacoes.Size = new System.Drawing.Size(905, 192);
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
            this.grbReuniaoInformacoes.Size = new System.Drawing.Size(899, 186);
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
            this.txtObservacoes.Size = new System.Drawing.Size(292, 105);
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
            this.cklReuniaoSituacao.Location = new System.Drawing.Point(137, 104);
            this.cklReuniaoSituacao.Name = "cklReuniaoSituacao";
            this.cklReuniaoSituacao.Size = new System.Drawing.Size(113, 72);
            this.cklReuniaoSituacao.TabIndex = 0;
            // 
            // lblReuniaoSituacao
            // 
            this.lblReuniaoSituacao.AutoSize = true;
            this.lblReuniaoSituacao.Location = new System.Drawing.Point(6, 105);
            this.lblReuniaoSituacao.Name = "lblReuniaoSituacao";
            this.lblReuniaoSituacao.Size = new System.Drawing.Size(64, 16);
            this.lblReuniaoSituacao.TabIndex = 5;
            this.lblReuniaoSituacao.Text = "Situação:";
            // 
            // txtReuniaoDataRealizacao
            // 
            this.txtReuniaoDataRealizacao.BackColor = System.Drawing.SystemColors.Window;
            this.txtReuniaoDataRealizacao.Enabled = false;
            this.txtReuniaoDataRealizacao.Location = new System.Drawing.Point(137, 71);
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
            this.lblReuniaoDataRealizacao.Location = new System.Drawing.Point(6, 74);
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
            this.tbReuniaoResultado.Size = new System.Drawing.Size(905, 192);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle29.NullValue = null;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle30.NullValue = null;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle30;
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
            // frmCadastroProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 617);
            this.Controls.Add(this.tbReunioesProjeto);
            this.Controls.Add(this.tspPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroProjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SP3 :: Cadastro de Projetos";
            this.Load += new System.EventHandler(this.frmProjetos_Load);
            this.tspPrincipal.ResumeLayout(false);
            this.tspPrincipal.PerformLayout();
            this.tbReunioesProjeto.ResumeLayout(false);
            this.tbInformacoes.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
            this.grbPrincipal.ResumeLayout(false);
            this.grbPrincipal.PerformLayout();
            this.tbFluxoDeCaixa.ResumeLayout(false);
            this.grbFluxoCaixaProjeto.ResumeLayout(false);
            this.grbIncluirReceitaVariavel.ResumeLayout(false);
            this.grbIncluirReceitaVariavel.PerformLayout();
            this.grbFluxoCaixaProjetoAcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFluxoCaixaProjeto)).EndInit();
            this.tbParticipantes.ResumeLayout(false);
            this.grbParticipantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantes)).EndInit();
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
        private System.Windows.Forms.Button btnFluxoExcluir;
        private System.Windows.Forms.Button btnFluxoEditar;
        private System.Windows.Forms.Button btnFluxoIncluir;
        private System.Windows.Forms.DataGridView dtgFluxoCaixaProjeto;
        private System.Windows.Forms.Button btnFluxoSalvar;
        private System.Windows.Forms.TextBox txtFluxoObservacoes;
        private System.Windows.Forms.Label lblObservacoesFluxoCaixa;
        private System.Windows.Forms.ComboBox cboFluxoTipo;
        private System.Windows.Forms.Label lblTipoFluxoCaixa;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox grbParticipantes;
        private System.Windows.Forms.DataGridView dtgParticipantes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpParticipantesIngresso;
        private System.Windows.Forms.Label lblDataIngresso;
        private System.Windows.Forms.TextBox txtParticipantesObservacoes;
        private System.Windows.Forms.Label lblObservacoesParticipantes;
        private System.Windows.Forms.TextBox txtParticipantesOcupacao;
        private System.Windows.Forms.Label lblOcupacao;
        private System.Windows.Forms.Button btnParticipanteSalvar;
        private System.Windows.Forms.Label lblParticipante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnParticipanteExcluir;
        private System.Windows.Forms.Button btnParticipanteEditar;
        private System.Windows.Forms.Button btnParticipanteIncluir;
        private System.Windows.Forms.GroupBox tbCadastro;
        private System.Windows.Forms.DataGridView dtgPrincipal;
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
        private System.Windows.Forms.DateTimePicker dtpFluxoCaixaPeriodo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cboGerenteProjeto;
        private System.Windows.Forms.TextBox txtFluxoValor;
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
        private System.Windows.Forms.ComboBox cboParticipantesPessoas;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgFluxoCaixaProjetoTxtIdProjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgFluxoCaixaProjetoDataCriacaoFluxo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgFluxoCaixaProjetoTxtDataPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgFluxoCaixaProjetoTxtTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgFluxoCaixaProjetoTxtObservacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgFluxoCaixaProjetoTxtValor;
        private System.Windows.Forms.DataGridViewImageColumn dtgFluxoCaixaProjetoBtnEditar;
        private System.Windows.Forms.DataGridViewImageColumn dtgFluxoCaixaProjetoBtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgParticipantesTxtProjetosPessoasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgParticipantesTxtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgParticipantesTxtProjetosPessoasObservacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgParticipantesProjetosPessoasStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgParticipantesTxtProjetosPessoasIdProjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgParticipantesTxtOcupacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgParticipantesTxtDataIngresso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgParticipantesTxtObsrvacoesParticipantes;
        private System.Windows.Forms.DataGridViewImageColumn dtgParticipantesBtnEditar;
        private System.Windows.Forms.DataGridViewImageColumn dtgParticipantesBtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPrincipaltxtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPrincipaltxtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPrincipalTxtDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPrincipalTxtObservacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPrincipalTxtGerenteProjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPrincipalTxtInvestimentoPrevisto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPrincipalTxtRazaoReceitaValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZAORECEITAVALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPrincipalTxtRazaoReceitaPercentual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPrincipalTxtTempoPrevistoConclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPrincipalTxtStatus;
        private System.Windows.Forms.DataGridViewImageColumn dtgPrincipalBtnEditar;
        private System.Windows.Forms.DataGridViewImageColumn dtgPrincipalBtnInativar;
    }
}