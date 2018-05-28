namespace projProjetos.Forms.Relatorio
{
    partial class frmImpressao
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
            this.crbPrincipal = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crbPrincipal
            // 
            this.crbPrincipal.ActiveViewIndex = -1;
            this.crbPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crbPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.crbPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crbPrincipal.Location = new System.Drawing.Point(0, 0);
            this.crbPrincipal.Name = "crbPrincipal";
            this.crbPrincipal.ShowCloseButton = false;
            this.crbPrincipal.ShowParameterPanelButton = false;
            this.crbPrincipal.Size = new System.Drawing.Size(669, 533);
            this.crbPrincipal.TabIndex = 0;
            this.crbPrincipal.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 533);
            this.Controls.Add(this.crbPrincipal);
            this.MinimizeBox = false;
            this.Name = "frmImpressao";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImpressao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crbPrincipal;
    }
}