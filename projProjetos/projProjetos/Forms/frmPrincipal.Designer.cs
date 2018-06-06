namespace projProjetos.Forms
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCadastros = new System.Windows.Forms.ToolStripDropDownButton();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLancamentos = new System.Windows.Forms.ToolStripDropDownButton();
            this.reuniõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGerencia = new System.Windows.Forms.ToolStripDropDownButton();
            this.critériosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparaçõesDeCritériosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparaçõesCRITERIOPROJETOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSegurança = new System.Windows.Forms.ToolStripDropDownButton();
            this.usuáriosDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfisDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this._bindingSourcePessoas = new System.Windows.Forms.BindingSource(this.components);
            this._bindingSourceProjetos = new System.Windows.Forms.BindingSource(this.components);
            this._bindingSourceReunioes = new System.Windows.Forms.BindingSource(this.components);
            this.tbcParincipal = new System.Windows.Forms.TabControl();
            this.tbPrincipal = new System.Windows.Forms.TabPage();
            this.grbProjetos = new System.Windows.Forms.GroupBox();
            this.grbPessoas = new System.Windows.Forms.GroupBox();
            this.grbReunioes = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourcePessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceProjetos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceReunioes)).BeginInit();
            this.tbcParincipal.SuspendLayout();
            this.tbPrincipal.SuspendLayout();
            this.grbProjetos.SuspendLayout();
            this.grbPessoas.SuspendLayout();
            this.grbReunioes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.btnSair});
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
            this.projetosToolStripMenuItem});
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
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            // 
            // projetosToolStripMenuItem
            // 
            this.projetosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("projetosToolStripMenuItem.Image")));
            this.projetosToolStripMenuItem.Name = "projetosToolStripMenuItem";
            this.projetosToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.projetosToolStripMenuItem.Text = "Projetos";
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
            this.critériosToolStripMenuItem,
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
            // critériosToolStripMenuItem
            // 
            this.critériosToolStripMenuItem.Name = "critériosToolStripMenuItem";
            this.critériosToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.critériosToolStripMenuItem.Text = "Critérios";
            // 
            // comparaçõesDeCritériosToolStripMenuItem
            // 
            this.comparaçõesDeCritériosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("comparaçõesDeCritériosToolStripMenuItem.Image")));
            this.comparaçõesDeCritériosToolStripMenuItem.Name = "comparaçõesDeCritériosToolStripMenuItem";
            this.comparaçõesDeCritériosToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.comparaçõesDeCritériosToolStripMenuItem.Text = "Comparações entre Critérios";
            // 
            // comparaçõesCRITERIOPROJETOSToolStripMenuItem
            // 
            this.comparaçõesCRITERIOPROJETOSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("comparaçõesCRITERIOPROJETOSToolStripMenuItem.Image")));
            this.comparaçõesCRITERIOPROJETOSToolStripMenuItem.Name = "comparaçõesCRITERIOPROJETOSToolStripMenuItem";
            this.comparaçõesCRITERIOPROJETOSToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.comparaçõesCRITERIOPROJETOSToolStripMenuItem.Text = "Comparações CRITERIO-PROJETOS";
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
            this.tbcParincipal.Controls.Add(this.tbPrincipal);
            this.tbcParincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcParincipal.Location = new System.Drawing.Point(0, 54);
            this.tbcParincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tbcParincipal.Name = "tbcParincipal";
            this.tbcParincipal.SelectedIndex = 0;
            this.tbcParincipal.Size = new System.Drawing.Size(1008, 671);
            this.tbcParincipal.TabIndex = 3;
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Controls.Add(this.grbProjetos);
            this.tbPrincipal.Controls.Add(this.grbPessoas);
            this.tbPrincipal.Controls.Add(this.grbReunioes);
            this.tbPrincipal.Location = new System.Drawing.Point(4, 4);
            this.tbPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.Padding = new System.Windows.Forms.Padding(4);
            this.tbPrincipal.Size = new System.Drawing.Size(1000, 642);
            this.tbPrincipal.TabIndex = 0;
            this.tbPrincipal.Text = "Informacoes";
            this.tbPrincipal.UseVisualStyleBackColor = true;
            // 
            // grbProjetos
            // 
            this.grbProjetos.Controls.Add(this.textBox3);
            this.grbProjetos.Controls.Add(this.dataGridView3);
            this.grbProjetos.Location = new System.Drawing.Point(436, 350);
            this.grbProjetos.Margin = new System.Windows.Forms.Padding(4);
            this.grbProjetos.Name = "grbProjetos";
            this.grbProjetos.Padding = new System.Windows.Forms.Padding(4);
            this.grbProjetos.Size = new System.Drawing.Size(556, 284);
            this.grbProjetos.TabIndex = 2;
            this.grbProjetos.TabStop = false;
            this.grbProjetos.Text = "Projetos";
            // 
            // grbPessoas
            // 
            this.grbPessoas.Controls.Add(this.textBox2);
            this.grbPessoas.Controls.Add(this.dataGridView2);
            this.grbPessoas.Location = new System.Drawing.Point(8, 350);
            this.grbPessoas.Margin = new System.Windows.Forms.Padding(4);
            this.grbPessoas.Name = "grbPessoas";
            this.grbPessoas.Padding = new System.Windows.Forms.Padding(4);
            this.grbPessoas.Size = new System.Drawing.Size(419, 284);
            this.grbPessoas.TabIndex = 1;
            this.grbPessoas.TabStop = false;
            this.grbPessoas.Text = "Pessoas";
            // 
            // grbReunioes
            // 
            this.grbReunioes.Controls.Add(this.dataGridView1);
            this.grbReunioes.Location = new System.Drawing.Point(8, 8);
            this.grbReunioes.Margin = new System.Windows.Forms.Padding(4);
            this.grbReunioes.Name = "grbReunioes";
            this.grbReunioes.Padding = new System.Windows.Forms.Padding(4);
            this.grbReunioes.Size = new System.Drawing.Size(983, 334);
            this.grbReunioes.TabIndex = 0;
            this.grbReunioes.TabStop = false;
            this.grbReunioes.Text = "Reunioes Agendadas";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 725);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1008, 4);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(969, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(412, 197);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(7, 80);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(541, 197);
            this.dataGridView3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(412, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(541, 22);
            this.textBox3.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tbcParincipal);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projetos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourcePessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceProjetos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourceReunioes)).EndInit();
            this.tbcParincipal.ResumeLayout(false);
            this.tbPrincipal.ResumeLayout(false);
            this.grbProjetos.ResumeLayout(false);
            this.grbProjetos.PerformLayout();
            this.grbPessoas.ResumeLayout(false);
            this.grbPessoas.PerformLayout();
            this.grbReunioes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem critériosToolStripMenuItem;
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
        private System.Windows.Forms.BindingSource _bindingSourcePessoas;
        private System.Windows.Forms.BindingSource _bindingSourceProjetos;
        private System.Windows.Forms.BindingSource _bindingSourceReunioes;
        private System.Windows.Forms.TabControl tbcParincipal;
        private System.Windows.Forms.TabPage tbPrincipal;
        private System.Windows.Forms.GroupBox grbProjetos;
        private System.Windows.Forms.GroupBox grbPessoas;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox grbReunioes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}