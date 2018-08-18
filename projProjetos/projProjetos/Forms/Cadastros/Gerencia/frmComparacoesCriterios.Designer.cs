namespace projProjetos.Forms.Gerencia
{
    partial class frmComparacoesCriterios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tspPrincipal = new System.Windows.Forms.ToolStrip();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.dtgComparacoesCriterios = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgComparacoesCriterios)).BeginInit();
            this.SuspendLayout();
            // 
            // tspPrincipal
            // 
            this.tspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAlterar,
            this.btnSalvar,
            this.btnCancelar,
            this.btnSair});
            this.tspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tspPrincipal.Name = "tspPrincipal";
            this.tspPrincipal.Size = new System.Drawing.Size(609, 72);
            this.tspPrincipal.TabIndex = 3;
            this.tspPrincipal.Text = "toolStrip1";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::projProjetos.Properties.Resources.btnAlterar;
            this.btnAlterar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(54, 69);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            // dtgComparacoesCriterios
            // 
            this.dtgComparacoesCriterios.AllowUserToAddRows = false;
            this.dtgComparacoesCriterios.AllowUserToDeleteRows = false;
            this.dtgComparacoesCriterios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgComparacoesCriterios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgComparacoesCriterios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgComparacoesCriterios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgComparacoesCriterios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X});
            this.dtgComparacoesCriterios.Enabled = false;
            this.dtgComparacoesCriterios.Location = new System.Drawing.Point(12, 75);
            this.dtgComparacoesCriterios.Name = "dtgComparacoesCriterios";
            this.dtgComparacoesCriterios.RowHeadersVisible = false;
            this.dtgComparacoesCriterios.Size = new System.Drawing.Size(585, 383);
            this.dtgComparacoesCriterios.TabIndex = 4;
            // 
            // X
            // 
            this.X.DataPropertyName = "X";
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 39;
            // 
            // frmComparacoesCriterios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 470);
            this.Controls.Add(this.dtgComparacoesCriterios);
            this.Controls.Add(this.tspPrincipal);
            this.Name = "frmComparacoesCriterios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerência :: Comparações entre Critérios";
            this.Load += new System.EventHandler(this.frmComparacoesCriterios_Load);
            this.tspPrincipal.ResumeLayout(false);
            this.tspPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgComparacoesCriterios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspPrincipal;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.DataGridView dtgComparacoesCriterios;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
    }
}