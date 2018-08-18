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
    public partial class frmComparacoesCriteriosProjetos : Form
    {
        RegraNegocio.Criterios criteriosRegraNegocio = new RegraNegocio.Criterios();

        public frmComparacoesCriteriosProjetos()
        {
            InitializeComponent();
            cboCriterio.DataSource = criteriosRegraNegocio.Listar();
        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboCriterio.SelectedItem != null)
                {
                    PopularDataGrid();
                    DesabilitarDiagonal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopularDataGrid()
        {
            try
            {
                if (cboCriterio.SelectedItem != null)
                {
                    System.Data.DataTable dadosTabela = criteriosRegraNegocio.ListarCriteriosProjetosComparacoes(cboCriterio.SelectedItem);

                    dtgPrincipal.DataSource = null;
                    dtgPrincipal.Columns.Clear();

                    dtgPrincipal.Columns.Add(X);


                    DataGridViewComboBoxColumn colunaDatagrid;

                    foreach (System.Data.DataColumn coluna in dadosTabela.Columns)
                    {
                        if (coluna.ColumnName != "X")
                        {
                            colunaDatagrid = new DataGridViewComboBoxColumn
                            {
                                DataPropertyName = coluna.ColumnName,
                                Name = coluna.ColumnName,
                                HeaderText = coluna.ColumnName
                            };

                            colunaDatagrid.Items.AddRange("1", "3", "5", "7", "9", "1/3", "1/5", "1/7", "1/9");

                            dtgPrincipal.Columns.Add(colunaDatagrid);

                        }
                    }
                    dtgPrincipal.DataSource = dadosTabela;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = true;
            cboCriterio.Enabled = true;
            cboCriterio.DataSource = criteriosRegraNegocio.Listar();
            dtgPrincipal.ReadOnly = false;
            DesabilitarDiagonal();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cboCriterio.SelectedItem != null)
            {
                dtgPrincipal.ReadOnly = true;
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = true;

                criteriosRegraNegocio.SalvarCriterioProjetosComparacoes(cboCriterio.SelectedItem, (dtgPrincipal.DataSource as System.Data.DataTable));
                cboCriterio.DataSource = criteriosRegraNegocio.Listar();
                DesabilitarDiagonal();
            }
        }

        private void frmComparacoesCriteriosProjetos_Load(object sender, EventArgs e)
        {

        }

        private void DesabilitarDiagonal()
        {
            if (dtgPrincipal.Rows.Count > 0 && dtgPrincipal.Rows.Count == dtgPrincipal.Columns.Count + 1)
            {
                for (int i = 0; i < dtgPrincipal.Rows.Count; i++)
                    dtgPrincipal.Rows[i].Cells[i + 1].ReadOnly = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
