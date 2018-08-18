namespace projProjetos.Forms.Cadastros.Pesquisa
{
    partial class frmPesquisaProjeto
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
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.blnFiltrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtgPrincipal = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeGerenteProjetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receitaConstanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoReceitaValorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoReceitaPercentualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoPrevistoConclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.investimentoPrevistoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGerenteProjetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoApoioSteakHoldersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoCapacidadeEntregaEquipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoApoioAltaGestaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boolEsforcoAdicionalAte10PorCentoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boolEsforcoAdicionalEntre11e20PorCentoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boolEsforcoAdicionalEntre21e40PorCentoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boolEsforcoAdicionalmaior40PorCentoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.entityObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(731, 513);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(85, 23);
            this.btnSelecionar.TabIndex = 17;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // blnFiltrar
            // 
            this.blnFiltrar.Location = new System.Drawing.Point(741, 24);
            this.blnFiltrar.Name = "blnFiltrar";
            this.blnFiltrar.Size = new System.Drawing.Size(75, 26);
            this.blnFiltrar.TabIndex = 16;
            this.blnFiltrar.Text = "Filtrar";
            this.blnFiltrar.UseVisualStyleBackColor = true;
            this.blnFiltrar.Click += new System.EventHandler(this.BlnFiltrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "",
            "ATIVO",
            "INATIVO"});
            this.cboStatus.Location = new System.Drawing.Point(587, 26);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(147, 24);
            this.cboStatus.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(142, 26);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(437, 22);
            this.txtNome.TabIndex = 11;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(20, 26);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(113, 22);
            this.txtCodigo.TabIndex = 10;
            // 
            // dtgPrincipal
            // 
            this.dtgPrincipal.AllowUserToAddRows = false;
            this.dtgPrincipal.AllowUserToDeleteRows = false;
            this.dtgPrincipal.AllowUserToResizeRows = false;
            this.dtgPrincipal.AutoGenerateColumns = false;
            this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.nomeGerenteProjetoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.receitaConstanteDataGridViewTextBoxColumn,
            this.razaoReceitaValorDataGridViewTextBoxColumn,
            this.razaoReceitaPercentualDataGridViewTextBoxColumn,
            this.tempoPrevistoConclusaoDataGridViewTextBoxColumn,
            this.investimentoPrevistoDataGridViewTextBoxColumn,
            this.dataCricaoDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.idGerenteProjetoDataGridViewTextBoxColumn,
            this.descricaoApoioSteakHoldersDataGridViewTextBoxColumn,
            this.descricaoCapacidadeEntregaEquipeDataGridViewTextBoxColumn,
            this.descricaoApoioAltaGestaoDataGridViewTextBoxColumn,
            this.boolEsforcoAdicionalAte10PorCentoDataGridViewCheckBoxColumn,
            this.boolEsforcoAdicionalEntre11e20PorCentoDataGridViewCheckBoxColumn,
            this.boolEsforcoAdicionalEntre21e40PorCentoDataGridViewCheckBoxColumn,
            this.boolEsforcoAdicionalmaior40PorCentoDataGridViewCheckBoxColumn,
            this.entityObjectDataGridViewTextBoxColumn});
            this.dtgPrincipal.DataSource = this._bindingSource;
            this.dtgPrincipal.Location = new System.Drawing.Point(16, 56);
            this.dtgPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.dtgPrincipal.MultiSelect = false;
            this.dtgPrincipal.Name = "dtgPrincipal";
            this.dtgPrincipal.ReadOnly = true;
            this.dtgPrincipal.RowHeadersVisible = false;
            this.dtgPrincipal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPrincipal.Size = new System.Drawing.Size(800, 450);
            this.dtgPrincipal.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 70;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 230;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 190;
            // 
            // nomeGerenteProjetoDataGridViewTextBoxColumn
            // 
            this.nomeGerenteProjetoDataGridViewTextBoxColumn.DataPropertyName = "NomeGerenteProjeto";
            this.nomeGerenteProjetoDataGridViewTextBoxColumn.HeaderText = "Gerente";
            this.nomeGerenteProjetoDataGridViewTextBoxColumn.Name = "nomeGerenteProjetoDataGridViewTextBoxColumn";
            this.nomeGerenteProjetoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeGerenteProjetoDataGridViewTextBoxColumn.Width = 200;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
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
            // investimentoPrevistoDataGridViewTextBoxColumn
            // 
            this.investimentoPrevistoDataGridViewTextBoxColumn.DataPropertyName = "InvestimentoPrevisto";
            this.investimentoPrevistoDataGridViewTextBoxColumn.HeaderText = "InvestimentoPrevisto";
            this.investimentoPrevistoDataGridViewTextBoxColumn.Name = "investimentoPrevistoDataGridViewTextBoxColumn";
            this.investimentoPrevistoDataGridViewTextBoxColumn.ReadOnly = true;
            this.investimentoPrevistoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataCricaoDataGridViewTextBoxColumn
            // 
            this.dataCricaoDataGridViewTextBoxColumn.DataPropertyName = "DataCricao";
            this.dataCricaoDataGridViewTextBoxColumn.HeaderText = "DataCricao";
            this.dataCricaoDataGridViewTextBoxColumn.Name = "dataCricaoDataGridViewTextBoxColumn";
            this.dataCricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCricaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idGerenteProjetoDataGridViewTextBoxColumn
            // 
            this.idGerenteProjetoDataGridViewTextBoxColumn.DataPropertyName = "IdGerenteProjeto";
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
            // entityObjectDataGridViewTextBoxColumn
            // 
            this.entityObjectDataGridViewTextBoxColumn.DataPropertyName = "EntityObject";
            this.entityObjectDataGridViewTextBoxColumn.HeaderText = "EntityObject";
            this.entityObjectDataGridViewTextBoxColumn.Name = "entityObjectDataGridViewTextBoxColumn";
            this.entityObjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.entityObjectDataGridViewTextBoxColumn.Visible = false;
            // 
            // _bindingSource
            // 
            this._bindingSource.AllowNew = false;
            this._bindingSource.DataSource = typeof(RegraNegocio.View.Projetos.ViewProjeto);
            // 
            // frmPesquisaProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 543);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.blnFiltrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dtgPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisaProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SP3 :: Pesquisa de Projetos";
            this.Load += new System.EventHandler(this.frmPesquisaProjeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button blnFiltrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dtgPrincipal;
        private System.Windows.Forms.BindingSource _bindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeGerenteProjetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receitaConstanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoReceitaValorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoReceitaPercentualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoPrevistoConclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn investimentoPrevistoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGerenteProjetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoApoioSteakHoldersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoCapacidadeEntregaEquipeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoApoioAltaGestaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolEsforcoAdicionalAte10PorCentoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolEsforcoAdicionalEntre11e20PorCentoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolEsforcoAdicionalEntre21e40PorCentoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolEsforcoAdicionalmaior40PorCentoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityObjectDataGridViewTextBoxColumn;
    }
}