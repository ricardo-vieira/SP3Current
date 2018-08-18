namespace projProjetos.Forms.Gerencia
{
    partial class frmCriterios
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
            this.grbPrincipal = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtgPrincipal = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnInativar = new System.Windows.Forms.ToolStripButton();
            this.btnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tspPrincipal = new System.Windows.Forms.ToolStrip();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.grbPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
            this.tspPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPrincipal
            // 
            this.grbPrincipal.Controls.Add(this.label1);
            this.grbPrincipal.Controls.Add(this.lblCodigo);
            this.grbPrincipal.Controls.Add(this.txtDescricao);
            this.grbPrincipal.Controls.Add(this.txtCodigo);
            this.grbPrincipal.Location = new System.Drawing.Point(13, 76);
            this.grbPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.grbPrincipal.Name = "grbPrincipal";
            this.grbPrincipal.Padding = new System.Windows.Forms.Padding(4);
            this.grbPrincipal.Size = new System.Drawing.Size(639, 157);
            this.grbPrincipal.TabIndex = 0;
            this.grbPrincipal.TabStop = false;
            this.grbPrincipal.Text = "Informações Cadastrais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(7, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(55, 16);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(86, 50);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(553, 100);
            this.txtDescricao.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(86, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(137, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // dtgPrincipal
            // 
            this.dtgPrincipal.AllowUserToAddRows = false;
            this.dtgPrincipal.AllowUserToDeleteRows = false;
            this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DESCRICAO,
            this.btnEditar,
            this.btnExcluir});
            this.dtgPrincipal.Location = new System.Drawing.Point(13, 240);
            this.dtgPrincipal.Name = "dtgPrincipal";
            this.dtgPrincipal.ReadOnly = true;
            this.dtgPrincipal.RowHeadersVisible = false;
            this.dtgPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPrincipal.Size = new System.Drawing.Size(639, 213);
            this.dtgPrincipal.TabIndex = 3;
            this.dtgPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellContentClick);
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
            // btnCancelar
            // 
            this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 69);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnInativar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInativar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(50, 69);
            this.btnInativar.Text = "Inativar";
            this.btnInativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInativar.Click += new System.EventHandler(this.btnInativar_Click);
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
            // 
            // btnSair
            // 
            this.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSair.Image = global::projProjetos.Properties.Resources.sair;
            this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(54, 69);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tspPrincipal
            // 
            this.tspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnSalvar,
            this.btnCancelar,
            this.btnAlterar,
            this.btnInativar,
            this.btnPesquisar,
            this.btnSair});
            this.tspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tspPrincipal.Name = "tspPrincipal";
            this.tspPrincipal.Size = new System.Drawing.Size(664, 72);
            this.tspPrincipal.TabIndex = 2;
            this.tspPrincipal.Text = "toolStrip1";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Código";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "DESCRICAO";
            this.DESCRICAO.HeaderText = "Descrição";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            this.DESCRICAO.Width = 480;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "";
            this.btnEditar.Image = global::projProjetos.Properties.Resources.editar;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditar.Width = 25;
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "";
            this.btnExcluir.Image = global::projProjetos.Properties.Resources.excluir;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.ReadOnly = true;
            this.btnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnExcluir.Width = 25;
            // 
            // frmCriterios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 465);
            this.Controls.Add(this.dtgPrincipal);
            this.Controls.Add(this.tspPrincipal);
            this.Controls.Add(this.grbPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCriterios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerência :: Critérios";
            this.Load += new System.EventHandler(this.frmCriterios_Load);
            this.grbPrincipal.ResumeLayout(false);
            this.grbPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
            this.tspPrincipal.ResumeLayout(false);
            this.tspPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPrincipal;
        private System.Windows.Forms.DataGridView dtgPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnInativar;
        private System.Windows.Forms.ToolStripButton btnPesquisar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStrip tspPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
    }
}