namespace projProjetos.Forms
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Agendado"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.HotTrack, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Cancelado"}, -1, System.Drawing.Color.Black, System.Drawing.Color.Red, null);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Realizando"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Gold, null);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Atrasado"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Salmon, null);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Reagendado"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.SlateBlue, null);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Priorizada"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.SpringGreen, null);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Improdutiva"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Thistle, null);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCadastros = new System.Windows.Forms.ToolStripDropDownButton();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criteriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLancamentos = new System.Windows.Forms.ToolStripDropDownButton();
            this.reuniõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGerencia = new System.Windows.Forms.ToolStripDropDownButton();
            this.comparaçõesDeCritériosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparaçõesCRITERIOPROJETOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSegurança = new System.Windows.Forms.ToolStripDropDownButton();
            this.usuáriosDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfisDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.btnRelatorios = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbcParincipal = new System.Windows.Forms.TabControl();
            this.tbpPrincipal = new System.Windows.Forms.TabPage();
            this.tbpAgenda = new System.Windows.Forms.TabPage();
            this.grbProjetos = new System.Windows.Forms.GroupBox();
            this.ckbAgendaFiltroProjetoSelecaoPautado = new System.Windows.Forms.CheckBox();
            this.ckbAgendaFiltroProjetoSelecaoPriorizado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAgendaFiltroProjetosCodigo = new System.Windows.Forms.TextBox();
            this.txtAgendaFiltroProjetosNome = new System.Windows.Forms.TextBox();
            this.dtgAgendaProjetos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeGerenteProjetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgAgendaProjetosCkbSelecaoPautado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtgAgendaProjetosCkbSelecaoPriorizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.investimentoPrevistoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receitaConstanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoReceitaValorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoReceitaPercentualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoPrevistoConclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGerenteProjetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoApoioSteakHoldersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoCapacidadeEntregaEquipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoApoioAltaGestaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boolEsforcoAdicionalAte10PorCentoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boolEsforcoAdicionalEntre11e20PorCentoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boolEsforcoAdicionalEntre21e40PorCentoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boolEsforcoAdicionalmaior40PorCentoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.entityObjectDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bindingSourceAgenda_Projetos = new System.Windows.Forms.BindingSource(this.components);
            this.grbPessoas = new System.Windows.Forms.GroupBox();
            this.ckbAgendaFiltroPessoaSelecionarResponsavel = new System.Windows.Forms.CheckBox();
            this.ckbAgendaFiltroPessoaSelecionarGerente = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtAgendaFiltroPessoasCodigo = new System.Windows.Forms.TextBox();
            this.txtAgendaFiltroPessoasNome = new System.Windows.Forms.TextBox();
            this.dtgAgendaPessoas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgAgendaPessoaCkbSelecaoGerente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtgAgendapessoaCkbSelecaoResponsavel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bindingSourceAgenda_Pessoas = new System.Windows.Forms.BindingSource(this.components);
            this.grbReunioes = new System.Windows.Forms.GroupBox();
            this.lvwAgendaReuniaoSituacao = new System.Windows.Forms.ListView();
            this.dtgAgendaReunioes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bindingSourceAgenda_Reunioes = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ckbFiltroReuniaoData = new System.Windows.Forms.CheckBox();
            this.cboAgendaFiltroReuniaoData = new System.Windows.Forms.ComboBox();
            this.mtcAgendaFiltroReuniao = new System.Windows.Forms.MonthCalendar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._timmerAgenda = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.tbcParincipal.SuspendLayout();
            this.tbpAgenda.SuspendLayout();
            this.grbProjetos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgendaProjetos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceAgenda_Projetos)).BeginInit();
            this.grbPessoas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgendaPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceAgenda_Pessoas)).BeginInit();
            this.grbReunioes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgendaReunioes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceAgenda_Reunioes)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastros,
            this.toolStripSeparator4,
            this.btnLancamentos,
            this.toolStripSeparator1,
            this.btnGerencia,
            this.toolStripSeparator3,
            this.btnSegurança,
            this.toolStripSeparator5,
            this.toolStripSeparator2,
            this.btnSair,
            this.btnRelatorios});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCadastros
            // 
            this.btnCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.projetosToolStripMenuItem,
            this.aHPToolStripMenuItem});
            this.btnCadastros.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastros.Image")));
            this.btnCadastros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCadastros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(72, 51);
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoasToolStripMenuItem.Image")));
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // projetosToolStripMenuItem
            // 
            this.projetosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("projetosToolStripMenuItem.Image")));
            this.projetosToolStripMenuItem.Name = "projetosToolStripMenuItem";
            this.projetosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.projetosToolStripMenuItem.Text = "Projetos";
            this.projetosToolStripMenuItem.Click += new System.EventHandler(this.projetosToolStripMenuItem_Click);
            // 
            // aHPToolStripMenuItem
            // 
            this.aHPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criteriosToolStripMenuItem});
            this.aHPToolStripMenuItem.Name = "aHPToolStripMenuItem";
            this.aHPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aHPToolStripMenuItem.Text = "AHP";
            // 
            // criteriosToolStripMenuItem
            // 
            this.criteriosToolStripMenuItem.Name = "criteriosToolStripMenuItem";
            this.criteriosToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.criteriosToolStripMenuItem.Text = "Criterios";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 54);
            // 
            // btnLancamentos
            // 
            this.btnLancamentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reuniõesToolStripMenuItem});
            this.btnLancamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnLancamentos.Image")));
            this.btnLancamentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLancamentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLancamentos.Name = "btnLancamentos";
            this.btnLancamentos.Size = new System.Drawing.Size(91, 51);
            this.btnLancamentos.Text = "Lançamentos";
            this.btnLancamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // reuniõesToolStripMenuItem
            // 
            this.reuniõesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reuniõesToolStripMenuItem.Image")));
            this.reuniõesToolStripMenuItem.Name = "reuniõesToolStripMenuItem";
            this.reuniõesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.reuniõesToolStripMenuItem.Text = "Reuniões";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // btnGerencia
            // 
            this.btnGerencia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comparaçõesDeCritériosToolStripMenuItem,
            this.comparaçõesCRITERIOPROJETOSToolStripMenuItem});
            this.btnGerencia.Image = ((System.Drawing.Image)(resources.GetObject("btnGerencia.Image")));
            this.btnGerencia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGerencia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGerencia.Name = "btnGerencia";
            this.btnGerencia.Size = new System.Drawing.Size(66, 51);
            this.btnGerencia.Text = "Gerência";
            this.btnGerencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // comparaçõesDeCritériosToolStripMenuItem
            // 
            this.comparaçõesDeCritériosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("comparaçõesDeCritériosToolStripMenuItem.Image")));
            this.comparaçõesDeCritériosToolStripMenuItem.Name = "comparaçõesDeCritériosToolStripMenuItem";
            this.comparaçõesDeCritériosToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.comparaçõesDeCritériosToolStripMenuItem.Text = "Comparações entre Critérios";
            // 
            // comparaçõesCRITERIOPROJETOSToolStripMenuItem
            // 
            this.comparaçõesCRITERIOPROJETOSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("comparaçõesCRITERIOPROJETOSToolStripMenuItem.Image")));
            this.comparaçõesCRITERIOPROJETOSToolStripMenuItem.Name = "comparaçõesCRITERIOPROJETOSToolStripMenuItem";
            this.comparaçõesCRITERIOPROJETOSToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.comparaçõesCRITERIOPROJETOSToolStripMenuItem.Text = "Comparações Criterios Projetos";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // btnSegurança
            // 
            this.btnSegurança.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosDoSistemaToolStripMenuItem,
            this.perfisDeUsuáriosToolStripMenuItem});
            this.btnSegurança.Image = ((System.Drawing.Image)(resources.GetObject("btnSegurança.Image")));
            this.btnSegurança.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSegurança.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSegurança.Name = "btnSegurança";
            this.btnSegurança.Size = new System.Drawing.Size(75, 51);
            this.btnSegurança.Text = "Segurança";
            this.btnSegurança.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // usuáriosDoSistemaToolStripMenuItem
            // 
            this.usuáriosDoSistemaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuáriosDoSistemaToolStripMenuItem.Image")));
            this.usuáriosDoSistemaToolStripMenuItem.Name = "usuáriosDoSistemaToolStripMenuItem";
            this.usuáriosDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.usuáriosDoSistemaToolStripMenuItem.Text = "Usuários do sistema";
            // 
            // perfisDeUsuáriosToolStripMenuItem
            // 
            this.perfisDeUsuáriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("perfisDeUsuáriosToolStripMenuItem.Image")));
            this.perfisDeUsuáriosToolStripMenuItem.Name = "perfisDeUsuáriosToolStripMenuItem";
            this.perfisDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.perfisDeUsuáriosToolStripMenuItem.Text = "Perfis de usuários";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // btnSair
            // 
            this.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 51);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRelatorios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(37, 51);
            this.btnRelatorios.Text = "Relat";
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::projProjetos.Properties.Resources.editar;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::projProjetos.Properties.Resources.editar;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 40;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::projProjetos.Properties.Resources.editar;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 30;
            // 
            // tbcParincipal
            // 
            this.tbcParincipal.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tbcParincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcParincipal.Controls.Add(this.tbpPrincipal);
            this.tbcParincipal.Controls.Add(this.tbpAgenda);
            this.tbcParincipal.Location = new System.Drawing.Point(0, 54);
            this.tbcParincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tbcParincipal.Name = "tbcParincipal";
            this.tbcParincipal.SelectedIndex = 0;
            this.tbcParincipal.Size = new System.Drawing.Size(1009, 649);
            this.tbcParincipal.TabIndex = 3;
            // 
            // tbpPrincipal
            // 
            this.tbpPrincipal.Location = new System.Drawing.Point(4, 4);
            this.tbpPrincipal.Name = "tbpPrincipal";
            this.tbpPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPrincipal.Size = new System.Drawing.Size(1001, 620);
            this.tbpPrincipal.TabIndex = 1;
            this.tbpPrincipal.Text = "Principal";
            this.tbpPrincipal.UseVisualStyleBackColor = true;
            // 
            // tbpAgenda
            // 
            this.tbpAgenda.Controls.Add(this.grbProjetos);
            this.tbpAgenda.Controls.Add(this.grbPessoas);
            this.tbpAgenda.Controls.Add(this.grbReunioes);
            this.tbpAgenda.Location = new System.Drawing.Point(4, 4);
            this.tbpAgenda.Margin = new System.Windows.Forms.Padding(4);
            this.tbpAgenda.Name = "tbpAgenda";
            this.tbpAgenda.Padding = new System.Windows.Forms.Padding(4);
            this.tbpAgenda.Size = new System.Drawing.Size(1001, 620);
            this.tbpAgenda.TabIndex = 0;
            this.tbpAgenda.Text = "Agenda";
            this.tbpAgenda.UseVisualStyleBackColor = true;
            this.tbpAgenda.Resize += new System.EventHandler(this.tbpAgenda_Resize);
            // 
            // grbProjetos
            // 
            this.grbProjetos.Controls.Add(this.ckbAgendaFiltroProjetoSelecaoPautado);
            this.grbProjetos.Controls.Add(this.ckbAgendaFiltroProjetoSelecaoPriorizado);
            this.grbProjetos.Controls.Add(this.label3);
            this.grbProjetos.Controls.Add(this.label4);
            this.grbProjetos.Controls.Add(this.txtAgendaFiltroProjetosCodigo);
            this.grbProjetos.Controls.Add(this.txtAgendaFiltroProjetosNome);
            this.grbProjetos.Controls.Add(this.dtgAgendaProjetos);
            this.grbProjetos.Location = new System.Drawing.Point(436, 350);
            this.grbProjetos.Margin = new System.Windows.Forms.Padding(4);
            this.grbProjetos.Name = "grbProjetos";
            this.grbProjetos.Padding = new System.Windows.Forms.Padding(4);
            this.grbProjetos.Size = new System.Drawing.Size(556, 284);
            this.grbProjetos.TabIndex = 2;
            this.grbProjetos.TabStop = false;
            this.grbProjetos.Text = "Projetos";
            // 
            // ckbAgendaFiltroProjetoSelecaoPautado
            // 
            this.ckbAgendaFiltroProjetoSelecaoPautado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbAgendaFiltroProjetoSelecaoPautado.AutoSize = true;
            this.ckbAgendaFiltroProjetoSelecaoPautado.Location = new System.Drawing.Point(377, 22);
            this.ckbAgendaFiltroProjetoSelecaoPautado.Name = "ckbAgendaFiltroProjetoSelecaoPautado";
            this.ckbAgendaFiltroProjetoSelecaoPautado.Size = new System.Drawing.Size(78, 20);
            this.ckbAgendaFiltroProjetoSelecaoPautado.TabIndex = 18;
            this.ckbAgendaFiltroProjetoSelecaoPautado.Text = "Pautado";
            this.ckbAgendaFiltroProjetoSelecaoPautado.UseVisualStyleBackColor = true;
            this.ckbAgendaFiltroProjetoSelecaoPautado.CheckedChanged += new System.EventHandler(this.ckbAgendaFiltroProjetoPautado_CheckedChanged);
            // 
            // ckbAgendaFiltroProjetoSelecaoPriorizado
            // 
            this.ckbAgendaFiltroProjetoSelecaoPriorizado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbAgendaFiltroProjetoSelecaoPriorizado.AutoSize = true;
            this.ckbAgendaFiltroProjetoSelecaoPriorizado.Location = new System.Drawing.Point(461, 22);
            this.ckbAgendaFiltroProjetoSelecaoPriorizado.Name = "ckbAgendaFiltroProjetoSelecaoPriorizado";
            this.ckbAgendaFiltroProjetoSelecaoPriorizado.Size = new System.Drawing.Size(88, 20);
            this.ckbAgendaFiltroProjetoSelecaoPriorizado.TabIndex = 17;
            this.ckbAgendaFiltroProjetoSelecaoPriorizado.Text = "Priorizado";
            this.ckbAgendaFiltroProjetoSelecaoPriorizado.UseVisualStyleBackColor = true;
            this.ckbAgendaFiltroProjetoSelecaoPriorizado.CheckedChanged += new System.EventHandler(this.ckbAgendaFiltroProjetoSelecaoPriorizado_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Projeto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Codigo";
            // 
            // txtAgendaFiltroProjetosCodigo
            // 
            this.txtAgendaFiltroProjetosCodigo.Location = new System.Drawing.Point(7, 52);
            this.txtAgendaFiltroProjetosCodigo.Name = "txtAgendaFiltroProjetosCodigo";
            this.txtAgendaFiltroProjetosCodigo.Size = new System.Drawing.Size(80, 22);
            this.txtAgendaFiltroProjetosCodigo.TabIndex = 4;
            this.txtAgendaFiltroProjetosCodigo.TextChanged += new System.EventHandler(this.txtAgendaFiltroProjetosCodigo_TextChanged);
            // 
            // txtAgendaFiltroProjetosNome
            // 
            this.txtAgendaFiltroProjetosNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgendaFiltroProjetosNome.Location = new System.Drawing.Point(93, 52);
            this.txtAgendaFiltroProjetosNome.Name = "txtAgendaFiltroProjetosNome";
            this.txtAgendaFiltroProjetosNome.Size = new System.Drawing.Size(455, 22);
            this.txtAgendaFiltroProjetosNome.TabIndex = 4;
            this.txtAgendaFiltroProjetosNome.TextChanged += new System.EventHandler(this.txtAgendaFiltroProjetosNome_TextChanged);
            // 
            // dtgAgendaProjetos
            // 
            this.dtgAgendaProjetos.AllowUserToAddRows = false;
            this.dtgAgendaProjetos.AllowUserToDeleteRows = false;
            this.dtgAgendaProjetos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgAgendaProjetos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgAgendaProjetos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAgendaProjetos.AutoGenerateColumns = false;
            this.dtgAgendaProjetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAgendaProjetos.BackgroundColor = System.Drawing.Color.White;
            this.dtgAgendaProjetos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgAgendaProjetos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgAgendaProjetos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgAgendaProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgendaProjetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nomeDataGridViewTextBoxColumn1,
            this.nomeGerenteProjetoDataGridViewTextBoxColumn,
            this.dtgAgendaProjetosCkbSelecaoPautado,
            this.dtgAgendaProjetosCkbSelecaoPriorizado,
            this.investimentoPrevistoDataGridViewTextBoxColumn,
            this.receitaConstanteDataGridViewTextBoxColumn,
            this.razaoReceitaValorDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.razaoReceitaPercentualDataGridViewTextBoxColumn,
            this.tempoPrevistoConclusaoDataGridViewTextBoxColumn,
            this.dataCricaoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn1,
            this.observacaoDataGridViewTextBoxColumn1,
            this.idGerenteProjetoDataGridViewTextBoxColumn,
            this.descricaoApoioSteakHoldersDataGridViewTextBoxColumn,
            this.descricaoCapacidadeEntregaEquipeDataGridViewTextBoxColumn,
            this.descricaoApoioAltaGestaoDataGridViewTextBoxColumn,
            this.boolEsforcoAdicionalAte10PorCentoDataGridViewCheckBoxColumn,
            this.boolEsforcoAdicionalEntre11e20PorCentoDataGridViewCheckBoxColumn,
            this.boolEsforcoAdicionalEntre21e40PorCentoDataGridViewCheckBoxColumn,
            this.boolEsforcoAdicionalmaior40PorCentoDataGridViewCheckBoxColumn,
            this.entityObjectDataGridViewTextBoxColumn1});
            this.dtgAgendaProjetos.DataSource = this._bindingSourceAgenda_Projetos;
            this.dtgAgendaProjetos.Location = new System.Drawing.Point(7, 80);
            this.dtgAgendaProjetos.MultiSelect = false;
            this.dtgAgendaProjetos.Name = "dtgAgendaProjetos";
            this.dtgAgendaProjetos.RowHeadersVisible = false;
            this.dtgAgendaProjetos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAgendaProjetos.Size = new System.Drawing.Size(541, 182);
            this.dtgAgendaProjetos.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.FillWeight = 75F;
            this.idDataGridViewTextBoxColumn2.HeaderText = "Codigo";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.FillWeight = 150F;
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeGerenteProjetoDataGridViewTextBoxColumn
            // 
            this.nomeGerenteProjetoDataGridViewTextBoxColumn.DataPropertyName = "NomeGerenteProjeto";
            this.nomeGerenteProjetoDataGridViewTextBoxColumn.FillWeight = 150F;
            this.nomeGerenteProjetoDataGridViewTextBoxColumn.HeaderText = "Gerente";
            this.nomeGerenteProjetoDataGridViewTextBoxColumn.Name = "nomeGerenteProjetoDataGridViewTextBoxColumn";
            this.nomeGerenteProjetoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtgAgendaProjetosCkbSelecaoPautado
            // 
            this.dtgAgendaProjetosCkbSelecaoPautado.DataPropertyName = "SelecaoPautado";
            this.dtgAgendaProjetosCkbSelecaoPautado.FillWeight = 60F;
            this.dtgAgendaProjetosCkbSelecaoPautado.HeaderText = "Pautado";
            this.dtgAgendaProjetosCkbSelecaoPautado.Name = "dtgAgendaProjetosCkbSelecaoPautado";
            this.dtgAgendaProjetosCkbSelecaoPautado.Visible = false;
            // 
            // dtgAgendaProjetosCkbSelecaoPriorizado
            // 
            this.dtgAgendaProjetosCkbSelecaoPriorizado.DataPropertyName = "SelecaoPriorizado";
            this.dtgAgendaProjetosCkbSelecaoPriorizado.FillWeight = 70F;
            this.dtgAgendaProjetosCkbSelecaoPriorizado.HeaderText = "Priorizado";
            this.dtgAgendaProjetosCkbSelecaoPriorizado.Name = "dtgAgendaProjetosCkbSelecaoPriorizado";
            this.dtgAgendaProjetosCkbSelecaoPriorizado.Visible = false;
            // 
            // investimentoPrevistoDataGridViewTextBoxColumn
            // 
            this.investimentoPrevistoDataGridViewTextBoxColumn.DataPropertyName = "InvestimentoPrevisto";
            this.investimentoPrevistoDataGridViewTextBoxColumn.HeaderText = "InvestimentoPrevisto";
            this.investimentoPrevistoDataGridViewTextBoxColumn.Name = "investimentoPrevistoDataGridViewTextBoxColumn";
            this.investimentoPrevistoDataGridViewTextBoxColumn.ReadOnly = true;
            this.investimentoPrevistoDataGridViewTextBoxColumn.Visible = false;
            // 
            // receitaConstanteDataGridViewTextBoxColumn
            // 
            this.receitaConstanteDataGridViewTextBoxColumn.DataPropertyName = "ReceitaConstante";
            this.receitaConstanteDataGridViewTextBoxColumn.HeaderText = "ReceitaConstante";
            this.receitaConstanteDataGridViewTextBoxColumn.Name = "receitaConstanteDataGridViewTextBoxColumn";
            this.receitaConstanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.receitaConstanteDataGridViewTextBoxColumn.Visible = false;
            // 
            // razaoReceitaValorDataGridViewTextBoxColumn
            // 
            this.razaoReceitaValorDataGridViewTextBoxColumn.DataPropertyName = "RazaoReceitaValor";
            this.razaoReceitaValorDataGridViewTextBoxColumn.HeaderText = "RazaoReceitaValor";
            this.razaoReceitaValorDataGridViewTextBoxColumn.Name = "razaoReceitaValorDataGridViewTextBoxColumn";
            this.razaoReceitaValorDataGridViewTextBoxColumn.ReadOnly = true;
            this.razaoReceitaValorDataGridViewTextBoxColumn.Visible = false;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.FillWeight = 150F;
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // razaoReceitaPercentualDataGridViewTextBoxColumn
            // 
            this.razaoReceitaPercentualDataGridViewTextBoxColumn.DataPropertyName = "RazaoReceitaPercentual";
            this.razaoReceitaPercentualDataGridViewTextBoxColumn.HeaderText = "RazaoReceitaPercentual";
            this.razaoReceitaPercentualDataGridViewTextBoxColumn.Name = "razaoReceitaPercentualDataGridViewTextBoxColumn";
            this.razaoReceitaPercentualDataGridViewTextBoxColumn.ReadOnly = true;
            this.razaoReceitaPercentualDataGridViewTextBoxColumn.Visible = false;
            // 
            // tempoPrevistoConclusaoDataGridViewTextBoxColumn
            // 
            this.tempoPrevistoConclusaoDataGridViewTextBoxColumn.DataPropertyName = "TempoPrevistoConclusao";
            this.tempoPrevistoConclusaoDataGridViewTextBoxColumn.HeaderText = "TempoPrevistoConclusao";
            this.tempoPrevistoConclusaoDataGridViewTextBoxColumn.Name = "tempoPrevistoConclusaoDataGridViewTextBoxColumn";
            this.tempoPrevistoConclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempoPrevistoConclusaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataCricaoDataGridViewTextBoxColumn
            // 
            this.dataCricaoDataGridViewTextBoxColumn.DataPropertyName = "DataCricao";
            this.dataCricaoDataGridViewTextBoxColumn.HeaderText = "DataCricao";
            this.dataCricaoDataGridViewTextBoxColumn.Name = "dataCricaoDataGridViewTextBoxColumn";
            this.dataCricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCricaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn1.Visible = false;
            // 
            // observacaoDataGridViewTextBoxColumn1
            // 
            this.observacaoDataGridViewTextBoxColumn1.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn1.HeaderText = "Observacao";
            this.observacaoDataGridViewTextBoxColumn1.Name = "observacaoDataGridViewTextBoxColumn1";
            this.observacaoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.observacaoDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idGerenteProjetoDataGridViewTextBoxColumn
            // 
            this.idGerenteProjetoDataGridViewTextBoxColumn.DataPropertyName = "IdGerenteProjeto";
            this.idGerenteProjetoDataGridViewTextBoxColumn.FillWeight = 70F;
            this.idGerenteProjetoDataGridViewTextBoxColumn.HeaderText = "IdGerenteProjeto";
            this.idGerenteProjetoDataGridViewTextBoxColumn.Name = "idGerenteProjetoDataGridViewTextBoxColumn";
            this.idGerenteProjetoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idGerenteProjetoDataGridViewTextBoxColumn.Visible = false;
            // 
            // descricaoApoioSteakHoldersDataGridViewTextBoxColumn
            // 
            this.descricaoApoioSteakHoldersDataGridViewTextBoxColumn.DataPropertyName = "DescricaoApoioSteakHolders";
            this.descricaoApoioSteakHoldersDataGridViewTextBoxColumn.HeaderText = "DescricaoApoioSteakHolders";
            this.descricaoApoioSteakHoldersDataGridViewTextBoxColumn.Name = "descricaoApoioSteakHoldersDataGridViewTextBoxColumn";
            this.descricaoApoioSteakHoldersDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoApoioSteakHoldersDataGridViewTextBoxColumn.Visible = false;
            // 
            // descricaoCapacidadeEntregaEquipeDataGridViewTextBoxColumn
            // 
            this.descricaoCapacidadeEntregaEquipeDataGridViewTextBoxColumn.DataPropertyName = "DescricaoCapacidadeEntregaEquipe";
            this.descricaoCapacidadeEntregaEquipeDataGridViewTextBoxColumn.HeaderText = "DescricaoCapacidadeEntregaEquipe";
            this.descricaoCapacidadeEntregaEquipeDataGridViewTextBoxColumn.Name = "descricaoCapacidadeEntregaEquipeDataGridViewTextBoxColumn";
            this.descricaoCapacidadeEntregaEquipeDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoCapacidadeEntregaEquipeDataGridViewTextBoxColumn.Visible = false;
            // 
            // descricaoApoioAltaGestaoDataGridViewTextBoxColumn
            // 
            this.descricaoApoioAltaGestaoDataGridViewTextBoxColumn.DataPropertyName = "DescricaoApoioAltaGestao";
            this.descricaoApoioAltaGestaoDataGridViewTextBoxColumn.HeaderText = "DescricaoApoioAltaGestao";
            this.descricaoApoioAltaGestaoDataGridViewTextBoxColumn.Name = "descricaoApoioAltaGestaoDataGridViewTextBoxColumn";
            this.descricaoApoioAltaGestaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoApoioAltaGestaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // boolEsforcoAdicionalAte10PorCentoDataGridViewCheckBoxColumn
            // 
            this.boolEsforcoAdicionalAte10PorCentoDataGridViewCheckBoxColumn.DataPropertyName = "BoolEsforcoAdicionalAte10PorCento";
            this.boolEsforcoAdicionalAte10PorCentoDataGridViewCheckBoxColumn.HeaderText = "BoolEsforcoAdicionalAte10PorCento";
            this.boolEsforcoAdicionalAte10PorCentoDataGridViewCheckBoxColumn.Name = "boolEsforcoAdicionalAte10PorCentoDataGridViewCheckBoxColumn";
            this.boolEsforcoAdicionalAte10PorCentoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.boolEsforcoAdicionalAte10PorCentoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // boolEsforcoAdicionalEntre11e20PorCentoDataGridViewCheckBoxColumn
            // 
            this.boolEsforcoAdicionalEntre11e20PorCentoDataGridViewCheckBoxColumn.DataPropertyName = "BoolEsforcoAdicionalEntre11e20PorCento";
            this.boolEsforcoAdicionalEntre11e20PorCentoDataGridViewCheckBoxColumn.HeaderText = "BoolEsforcoAdicionalEntre11e20PorCento";
            this.boolEsforcoAdicionalEntre11e20PorCentoDataGridViewCheckBoxColumn.Name = "boolEsforcoAdicionalEntre11e20PorCentoDataGridViewCheckBoxColumn";
            this.boolEsforcoAdicionalEntre11e20PorCentoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.boolEsforcoAdicionalEntre11e20PorCentoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // boolEsforcoAdicionalEntre21e40PorCentoDataGridViewCheckBoxColumn
            // 
            this.boolEsforcoAdicionalEntre21e40PorCentoDataGridViewCheckBoxColumn.DataPropertyName = "BoolEsforcoAdicionalEntre21e40PorCento";
            this.boolEsforcoAdicionalEntre21e40PorCentoDataGridViewCheckBoxColumn.HeaderText = "BoolEsforcoAdicionalEntre21e40PorCento";
            this.boolEsforcoAdicionalEntre21e40PorCentoDataGridViewCheckBoxColumn.Name = "boolEsforcoAdicionalEntre21e40PorCentoDataGridViewCheckBoxColumn";
            this.boolEsforcoAdicionalEntre21e40PorCentoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.boolEsforcoAdicionalEntre21e40PorCentoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // boolEsforcoAdicionalmaior40PorCentoDataGridViewCheckBoxColumn
            // 
            this.boolEsforcoAdicionalmaior40PorCentoDataGridViewCheckBoxColumn.DataPropertyName = "BoolEsforcoAdicionalmaior40PorCento";
            this.boolEsforcoAdicionalmaior40PorCentoDataGridViewCheckBoxColumn.HeaderText = "BoolEsforcoAdicionalmaior40PorCento";
            this.boolEsforcoAdicionalmaior40PorCentoDataGridViewCheckBoxColumn.Name = "boolEsforcoAdicionalmaior40PorCentoDataGridViewCheckBoxColumn";
            this.boolEsforcoAdicionalmaior40PorCentoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.boolEsforcoAdicionalmaior40PorCentoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // entityObjectDataGridViewTextBoxColumn1
            // 
            this.entityObjectDataGridViewTextBoxColumn1.DataPropertyName = "EntityObject";
            this.entityObjectDataGridViewTextBoxColumn1.HeaderText = "EntityObject";
            this.entityObjectDataGridViewTextBoxColumn1.Name = "entityObjectDataGridViewTextBoxColumn1";
            this.entityObjectDataGridViewTextBoxColumn1.ReadOnly = true;
            this.entityObjectDataGridViewTextBoxColumn1.Visible = false;
            // 
            // _bindingSourceAgenda_Projetos
            // 
            this._bindingSourceAgenda_Projetos.DataSource = typeof(RegraNegocio.View.Projetos.ViewProjeto);
            // 
            // grbPessoas
            // 
            this.grbPessoas.Controls.Add(this.ckbAgendaFiltroPessoaSelecionarResponsavel);
            this.grbPessoas.Controls.Add(this.ckbAgendaFiltroPessoaSelecionarGerente);
            this.grbPessoas.Controls.Add(this.label2);
            this.grbPessoas.Controls.Add(this.Label15);
            this.grbPessoas.Controls.Add(this.txtAgendaFiltroPessoasCodigo);
            this.grbPessoas.Controls.Add(this.txtAgendaFiltroPessoasNome);
            this.grbPessoas.Controls.Add(this.dtgAgendaPessoas);
            this.grbPessoas.Location = new System.Drawing.Point(8, 350);
            this.grbPessoas.Margin = new System.Windows.Forms.Padding(4);
            this.grbPessoas.Name = "grbPessoas";
            this.grbPessoas.Padding = new System.Windows.Forms.Padding(4);
            this.grbPessoas.Size = new System.Drawing.Size(419, 262);
            this.grbPessoas.TabIndex = 1;
            this.grbPessoas.TabStop = false;
            this.grbPessoas.Text = "Pessoas";
            // 
            // ckbAgendaFiltroPessoaSelecionarResponsavel
            // 
            this.ckbAgendaFiltroPessoaSelecionarResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbAgendaFiltroPessoaSelecionarResponsavel.AutoSize = true;
            this.ckbAgendaFiltroPessoaSelecionarResponsavel.Location = new System.Drawing.Point(223, 22);
            this.ckbAgendaFiltroPessoaSelecionarResponsavel.Name = "ckbAgendaFiltroPessoaSelecionarResponsavel";
            this.ckbAgendaFiltroPessoaSelecionarResponsavel.Size = new System.Drawing.Size(108, 20);
            this.ckbAgendaFiltroPessoaSelecionarResponsavel.TabIndex = 16;
            this.ckbAgendaFiltroPessoaSelecionarResponsavel.Text = "Responsavel";
            this.ckbAgendaFiltroPessoaSelecionarResponsavel.UseVisualStyleBackColor = true;
            this.ckbAgendaFiltroPessoaSelecionarResponsavel.CheckedChanged += new System.EventHandler(this.ckbAgendaFiltroPessoaSelecionarResponsavel_CheckedChanged);
            // 
            // ckbAgendaFiltroPessoaSelecionarGerente
            // 
            this.ckbAgendaFiltroPessoaSelecionarGerente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbAgendaFiltroPessoaSelecionarGerente.AutoSize = true;
            this.ckbAgendaFiltroPessoaSelecionarGerente.Location = new System.Drawing.Point(337, 22);
            this.ckbAgendaFiltroPessoaSelecionarGerente.Name = "ckbAgendaFiltroPessoaSelecionarGerente";
            this.ckbAgendaFiltroPessoaSelecionarGerente.Size = new System.Drawing.Size(75, 20);
            this.ckbAgendaFiltroPessoaSelecionarGerente.TabIndex = 15;
            this.ckbAgendaFiltroPessoaSelecionarGerente.Text = "Gerente";
            this.ckbAgendaFiltroPessoaSelecionarGerente.UseVisualStyleBackColor = true;
            this.ckbAgendaFiltroPessoaSelecionarGerente.CheckedChanged += new System.EventHandler(this.ckbAgendaFiltroPessoaSelecionarGerente_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(7, 33);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(58, 16);
            this.Label15.TabIndex = 13;
            this.Label15.Text = "Codigo";
            // 
            // txtAgendaFiltroPessoasCodigo
            // 
            this.txtAgendaFiltroPessoasCodigo.Location = new System.Drawing.Point(7, 52);
            this.txtAgendaFiltroPessoasCodigo.Name = "txtAgendaFiltroPessoasCodigo";
            this.txtAgendaFiltroPessoasCodigo.Size = new System.Drawing.Size(80, 22);
            this.txtAgendaFiltroPessoasCodigo.TabIndex = 3;
            this.txtAgendaFiltroPessoasCodigo.TextChanged += new System.EventHandler(this.txtAgendaFiltroPessoasCodigo_TextChanged);
            // 
            // txtAgendaFiltroPessoasNome
            // 
            this.txtAgendaFiltroPessoasNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgendaFiltroPessoasNome.Location = new System.Drawing.Point(93, 52);
            this.txtAgendaFiltroPessoasNome.Name = "txtAgendaFiltroPessoasNome";
            this.txtAgendaFiltroPessoasNome.Size = new System.Drawing.Size(319, 22);
            this.txtAgendaFiltroPessoasNome.TabIndex = 2;
            this.txtAgendaFiltroPessoasNome.TextChanged += new System.EventHandler(this.txtAgendaFiltroPessoasNome_TextChanged);
            // 
            // dtgAgendaPessoas
            // 
            this.dtgAgendaPessoas.AllowUserToAddRows = false;
            this.dtgAgendaPessoas.AllowUserToDeleteRows = false;
            this.dtgAgendaPessoas.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dtgAgendaPessoas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgAgendaPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAgendaPessoas.AutoGenerateColumns = false;
            this.dtgAgendaPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAgendaPessoas.BackgroundColor = System.Drawing.Color.White;
            this.dtgAgendaPessoas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgAgendaPessoas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgAgendaPessoas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgAgendaPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgendaPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn,
            this.dtgAgendaPessoaCkbSelecaoGerente,
            this.dtgAgendapessoaCkbSelecaoResponsavel,
            this.statusDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.dataCriacaoDataGridViewTextBoxColumn,
            this.entityObjectDataGridViewTextBoxColumn});
            this.dtgAgendaPessoas.DataSource = this._bindingSourceAgenda_Pessoas;
            this.dtgAgendaPessoas.Location = new System.Drawing.Point(7, 80);
            this.dtgAgendaPessoas.MultiSelect = false;
            this.dtgAgendaPessoas.Name = "dtgAgendaPessoas";
            this.dtgAgendaPessoas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgAgendaPessoas.RowHeadersVisible = false;
            this.dtgAgendaPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAgendaPessoas.Size = new System.Drawing.Size(405, 175);
            this.dtgAgendaPessoas.TabIndex = 1;
            this.dtgAgendaPessoas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgendaPessoas_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.FillWeight = 25F;
            this.idDataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtgAgendaPessoaCkbSelecaoGerente
            // 
            this.dtgAgendaPessoaCkbSelecaoGerente.DataPropertyName = "SelecaoGerente";
            this.dtgAgendaPessoaCkbSelecaoGerente.FillWeight = 30F;
            this.dtgAgendaPessoaCkbSelecaoGerente.HeaderText = "Gerente";
            this.dtgAgendaPessoaCkbSelecaoGerente.Name = "dtgAgendaPessoaCkbSelecaoGerente";
            this.dtgAgendaPessoaCkbSelecaoGerente.Visible = false;
            // 
            // dtgAgendapessoaCkbSelecaoResponsavel
            // 
            this.dtgAgendapessoaCkbSelecaoResponsavel.DataPropertyName = "SelecaoResponsavel";
            this.dtgAgendapessoaCkbSelecaoResponsavel.FillWeight = 30F;
            this.dtgAgendapessoaCkbSelecaoResponsavel.HeaderText = "Respons.";
            this.dtgAgendapessoaCkbSelecaoResponsavel.Name = "dtgAgendapessoaCkbSelecaoResponsavel";
            this.dtgAgendapessoaCkbSelecaoResponsavel.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataCriacaoDataGridViewTextBoxColumn
            // 
            this.dataCriacaoDataGridViewTextBoxColumn.DataPropertyName = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.HeaderText = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.Name = "dataCriacaoDataGridViewTextBoxColumn";
            this.dataCriacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCriacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // entityObjectDataGridViewTextBoxColumn
            // 
            this.entityObjectDataGridViewTextBoxColumn.DataPropertyName = "EntityObject";
            this.entityObjectDataGridViewTextBoxColumn.HeaderText = "EntityObject";
            this.entityObjectDataGridViewTextBoxColumn.Name = "entityObjectDataGridViewTextBoxColumn";
            this.entityObjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.entityObjectDataGridViewTextBoxColumn.Visible = false;
            // 
            // _bindingSourceAgenda_Pessoas
            // 
            this._bindingSourceAgenda_Pessoas.DataSource = typeof(RegraNegocio.View.Pessoas.ViewPessoa);
            // 
            // grbReunioes
            // 
            this.grbReunioes.Controls.Add(this.lvwAgendaReuniaoSituacao);
            this.grbReunioes.Controls.Add(this.dtgAgendaReunioes);
            this.grbReunioes.Controls.Add(this.label1);
            this.grbReunioes.Controls.Add(this.ckbFiltroReuniaoData);
            this.grbReunioes.Controls.Add(this.cboAgendaFiltroReuniaoData);
            this.grbReunioes.Controls.Add(this.mtcAgendaFiltroReuniao);
            this.grbReunioes.Location = new System.Drawing.Point(8, 8);
            this.grbReunioes.Margin = new System.Windows.Forms.Padding(4);
            this.grbReunioes.Name = "grbReunioes";
            this.grbReunioes.Padding = new System.Windows.Forms.Padding(4);
            this.grbReunioes.Size = new System.Drawing.Size(983, 334);
            this.grbReunioes.TabIndex = 0;
            this.grbReunioes.TabStop = false;
            this.grbReunioes.Text = "Reunioes Agendadas";
            // 
            // lvwAgendaReuniaoSituacao
            // 
            this.lvwAgendaReuniaoSituacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwAgendaReuniaoSituacao.CheckBoxes = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            this.lvwAgendaReuniaoSituacao.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.lvwAgendaReuniaoSituacao.Location = new System.Drawing.Point(10, 41);
            this.lvwAgendaReuniaoSituacao.Name = "lvwAgendaReuniaoSituacao";
            this.lvwAgendaReuniaoSituacao.Size = new System.Drawing.Size(224, 90);
            this.lvwAgendaReuniaoSituacao.TabIndex = 14;
            this.lvwAgendaReuniaoSituacao.UseCompatibleStateImageBehavior = false;
            this.lvwAgendaReuniaoSituacao.View = System.Windows.Forms.View.List;
            this.lvwAgendaReuniaoSituacao.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvwAgendaReuniaoSituacao_ItemChecked);
            // 
            // dtgAgendaReunioes
            // 
            this.dtgAgendaReunioes.AllowUserToOrderColumns = true;
            this.dtgAgendaReunioes.AllowUserToResizeColumns = false;
            this.dtgAgendaReunioes.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dtgAgendaReunioes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgAgendaReunioes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAgendaReunioes.AutoGenerateColumns = false;
            this.dtgAgendaReunioes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAgendaReunioes.BackgroundColor = System.Drawing.Color.White;
            this.dtgAgendaReunioes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgAgendaReunioes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgAgendaReunioes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgAgendaReunioes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgendaReunioes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.descricaoDataGridViewTextBoxColumn1,
            this.responsavelDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2});
            this.dtgAgendaReunioes.DataSource = this._bindingSourceAgenda_Reunioes;
            this.dtgAgendaReunioes.Location = new System.Drawing.Point(240, 22);
            this.dtgAgendaReunioes.Name = "dtgAgendaReunioes";
            this.dtgAgendaReunioes.RowHeadersVisible = false;
            this.dtgAgendaReunioes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgAgendaReunioes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAgendaReunioes.Size = new System.Drawing.Size(736, 305);
            this.dtgAgendaReunioes.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 60F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn1
            // 
            this.descricaoDataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn1.FillWeight = 180F;
            this.descricaoDataGridViewTextBoxColumn1.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn1.Name = "descricaoDataGridViewTextBoxColumn1";
            this.descricaoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // responsavelDataGridViewTextBoxColumn
            // 
            this.responsavelDataGridViewTextBoxColumn.DataPropertyName = "Responsavel";
            this.responsavelDataGridViewTextBoxColumn.HeaderText = "Responsavel";
            this.responsavelDataGridViewTextBoxColumn.Name = "responsavelDataGridViewTextBoxColumn";
            this.responsavelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Local";
            this.dataGridViewTextBoxColumn6.HeaderText = "Local";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DataHoraEvento";
            this.dataGridViewTextBoxColumn2.FillWeight = 70F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Data/Hora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // _bindingSourceAgenda_Reunioes
            // 
            this._bindingSourceAgenda_Reunioes.DataSource = typeof(RegraNegocio.View.Reunioes.ViewReuniao);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Status da Reuniao";
            // 
            // ckbFiltroReuniaoData
            // 
            this.ckbFiltroReuniaoData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbFiltroReuniaoData.AutoSize = true;
            this.ckbFiltroReuniaoData.Checked = true;
            this.ckbFiltroReuniaoData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbFiltroReuniaoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFiltroReuniaoData.Location = new System.Drawing.Point(7, 139);
            this.ckbFiltroReuniaoData.Name = "ckbFiltroReuniaoData";
            this.ckbFiltroReuniaoData.Size = new System.Drawing.Size(68, 20);
            this.ckbFiltroReuniaoData.TabIndex = 10;
            this.ckbFiltroReuniaoData.Text = "Data: ";
            this.ckbFiltroReuniaoData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbFiltroReuniaoData.UseVisualStyleBackColor = true;
            this.ckbFiltroReuniaoData.CheckedChanged += new System.EventHandler(this.ckbFiltroReuniaoData_CheckedChanged);
            // 
            // cboAgendaFiltroReuniaoData
            // 
            this.cboAgendaFiltroReuniaoData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboAgendaFiltroReuniaoData.BackColor = System.Drawing.Color.White;
            this.cboAgendaFiltroReuniaoData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgendaFiltroReuniaoData.ForeColor = System.Drawing.Color.White;
            this.cboAgendaFiltroReuniaoData.FormattingEnabled = true;
            this.cboAgendaFiltroReuniaoData.Items.AddRange(new object[] {
            "Cadastro",
            "Agendamento"});
            this.cboAgendaFiltroReuniaoData.Location = new System.Drawing.Point(75, 137);
            this.cboAgendaFiltroReuniaoData.Name = "cboAgendaFiltroReuniaoData";
            this.cboAgendaFiltroReuniaoData.Size = new System.Drawing.Size(159, 24);
            this.cboAgendaFiltroReuniaoData.TabIndex = 2;
            this.cboAgendaFiltroReuniaoData.SelectedIndexChanged += new System.EventHandler(this.cboAgendaFiltroReuniaoData_SelectedIndexChanged);
            // 
            // mtcAgendaFiltroReuniao
            // 
            this.mtcAgendaFiltroReuniao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mtcAgendaFiltroReuniao.Location = new System.Drawing.Point(7, 165);
            this.mtcAgendaFiltroReuniao.MaxSelectionCount = 365;
            this.mtcAgendaFiltroReuniao.Name = "mtcAgendaFiltroReuniao";
            this.mtcAgendaFiltroReuniao.TabIndex = 1;
            this.mtcAgendaFiltroReuniao.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mtcAgendaFiltroReuniao_DateChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _timmerAgenda
            // 
            this._timmerAgenda.Enabled = true;
            this._timmerAgenda.Interval = 10000;
            this._timmerAgenda.Tick += new System.EventHandler(this.timmer_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbcParincipal);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projetos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbcParincipal.ResumeLayout(false);
            this.tbpAgenda.ResumeLayout(false);
            this.grbProjetos.ResumeLayout(false);
            this.grbProjetos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgendaProjetos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceAgenda_Projetos)).EndInit();
            this.grbPessoas.ResumeLayout(false);
            this.grbPessoas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgendaPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceAgenda_Pessoas)).EndInit();
            this.grbReunioes.ResumeLayout(false);
            this.grbReunioes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgendaReunioes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceAgenda_Reunioes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnSegurança;
        private System.Windows.Forms.ToolStripDropDownButton btnCadastros;
        private System.Windows.Forms.ToolStripDropDownButton btnLancamentos;
        private System.Windows.Forms.ToolStripDropDownButton btnGerencia;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reuniõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfisDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparaçõesDeCritériosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparaçõesCRITERIOPROJETOSToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.BindingSource _bindingSourceAgenda_Pessoas;
        private System.Windows.Forms.BindingSource _bindingSourceAgenda_Projetos;
        private System.Windows.Forms.BindingSource _bindingSourceAgenda_Reunioes;
        private System.Windows.Forms.TabControl tbcParincipal;
        private System.Windows.Forms.TabPage tbpAgenda;
        private System.Windows.Forms.GroupBox grbProjetos;
        private System.Windows.Forms.GroupBox grbPessoas;
        private System.Windows.Forms.GroupBox grbReunioes;
        private System.Windows.Forms.DataGridView dtgAgendaProjetos;
        private System.Windows.Forms.DataGridView dtgAgendaPessoas;
        private System.Windows.Forms.MonthCalendar mtcAgendaFiltroReuniao;
        private System.Windows.Forms.ComboBox cboAgendaFiltroReuniaoData;
        private System.Windows.Forms.CheckBox ckbFiltroReuniaoData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAgendaFiltroProjetosCodigo;
        private System.Windows.Forms.TextBox txtAgendaFiltroProjetosNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.TextBox txtAgendaFiltroPessoasCodigo;
        private System.Windows.Forms.TextBox txtAgendaFiltroPessoasNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAHORAEVENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYBACKACEITAVELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAXAREMUNERACAOMERCADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAUTADESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sITUACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dtgAgendaReunioes;
        private System.Windows.Forms.ToolStripMenuItem aHPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criteriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnRelatorios;
        private System.Windows.Forms.TabPage tbpPrincipal;
        private System.Windows.Forms.Timer _timmerAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ListView lvwAgendaReuniaoSituacao;
        private System.Windows.Forms.CheckBox ckbAgendaFiltroProjetoSelecaoPautado;
        private System.Windows.Forms.CheckBox ckbAgendaFiltroProjetoSelecaoPriorizado;
        private System.Windows.Forms.CheckBox ckbAgendaFiltroPessoaSelecionarResponsavel;
        private System.Windows.Forms.CheckBox ckbAgendaFiltroPessoaSelecionarGerente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtgAgendaPessoaCkbSelecaoGerente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtgAgendapessoaCkbSelecaoResponsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeGerenteProjetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtgAgendaProjetosCkbSelecaoPautado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtgAgendaProjetosCkbSelecaoPriorizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn investimentoPrevistoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receitaConstanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoReceitaValorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoReceitaPercentualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoPrevistoConclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGerenteProjetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoApoioSteakHoldersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoCapacidadeEntregaEquipeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoApoioAltaGestaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolEsforcoAdicionalAte10PorCentoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolEsforcoAdicionalEntre11e20PorCentoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolEsforcoAdicionalEntre21e40PorCentoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolEsforcoAdicionalmaior40PorCentoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityObjectDataGridViewTextBoxColumn1;
    }
}