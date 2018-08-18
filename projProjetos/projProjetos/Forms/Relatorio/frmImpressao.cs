using EFDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projProjetos.Forms.Relatorio
{
    public partial class frmImpressao : Form
    {
        long idReuniao;

        public frmImpressao(long idReuniao)
        {
            this.idReuniao = idReuniao;

            InitializeComponent();
        }

        private void frmImpressao_Load(object sender, EventArgs e)
        {
            try
            {
                Reuniao relatorio = new Reuniao();

                dsRelatorio ds = new dsRelatorio();

                dsRelatorioTableAdapters.tbPautaProjetosTableAdapter tbAdapter = new dsRelatorioTableAdapters.tbPautaProjetosTableAdapter();

                tbAdapter.Fill(ds.tbPautaProjetos, idReuniao);

                relatorio.SetDataSource(ds.Tables["tbPautaProjetos"]);
                crbPrincipal.ReportSource = relatorio;
                crbPrincipal.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
