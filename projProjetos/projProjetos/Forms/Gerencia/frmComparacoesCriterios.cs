using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projProjetos.Forms.Gerencia
{
    public partial class frmComparacoesCriterios : Form
    {
        RegraNegocio.Criterios criteriosRegraNegocios = new RegraNegocio.Criterios();

        public frmComparacoesCriterios()
        {
            InitializeComponent();
        }

        private void frmComparacoesCriterios_Load(object sender, EventArgs e)
        {
            AdicionarColunasCriterios();
            dtgComparacoesCriterios.DataSource = criteriosRegraNegocios.ListarCriteriosComparacoes();
            DesabilitarDiagonal();
        }

        private void AdicionarColunasCriterios()
        {
            DataGridViewComboBoxColumn colunaCombobox;
            dtgComparacoesCriterios.Columns.Clear();
            dtgComparacoesCriterios.DataSource = null;
            DataTable dadosTabela = criteriosRegraNegocios.ListarCriteriosComparacoes();

            dtgComparacoesCriterios.Columns.Add(X); //adiciona a coluna X

            for (int indexColuna = 0; indexColuna < dadosTabela.Columns.Count; indexColuna++)
            {
                if (dadosTabela.Columns[indexColuna].ColumnName != "X")
                {
                    colunaCombobox = new DataGridViewComboBoxColumn
                    {
                        Name = dadosTabela.Columns[indexColuna].ColumnName,
                        DataPropertyName = dadosTabela.Columns[indexColuna].ColumnName,
                    };

                    colunaCombobox.Items.AddRange("1", "3", "5", "7", "9", "1/3", "1/5", "1/7", "1/9");

                    dtgComparacoesCriterios.Columns.Add(colunaCombobox);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AdicionarColunasCriterios();
            dtgComparacoesCriterios.DataSource = criteriosRegraNegocios.ListarCriteriosComparacoes();
            DesabilitarDiagonal();
            dtgComparacoesCriterios.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void DesabilitarDiagonal()
        {
            for (int linha = 0; linha < dtgComparacoesCriterios.Rows.Count; linha++)
            {
                dtgComparacoesCriterios.Rows[linha].Cells[linha + 1].ReadOnly = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = true;
                dtgComparacoesCriterios.Enabled = false;

                criteriosRegraNegocios.SalvarCriteriosComparacoes((dtgComparacoesCriterios.DataSource as DataTable));
                MessageBox.Show("Comparações de criterios salvas com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdicionarColunasCriterios();
                dtgComparacoesCriterios.DataSource = criteriosRegraNegocios.ListarCriteriosComparacoes();
                DesabilitarDiagonal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
