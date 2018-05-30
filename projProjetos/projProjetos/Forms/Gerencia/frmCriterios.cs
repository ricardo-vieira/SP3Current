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
    public partial class frmCriterios : Form
    {
        static RegraNegocio.Criterios criteriosRegraNegocio = new RegraNegocio.Criterios();
        StatusInformacao statusInformacao;

        public frmCriterios()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                criteriosRegraNegocio.Incluir();
                LimparCampos();
                HabilitarCampos(true);
                MudarStatusInformacao(StatusInformacao.INCLUSAO);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                criteriosRegraNegocio.entidade.DESCRICAO = txtDescricao.Text;
                criteriosRegraNegocio.Salvar();
                MessageBox.Show("Cadastro salvo com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgPrincipal.DataSource = criteriosRegraNegocio.Listar();
                MudarStatusInformacao(StatusInformacao.VISUALIZACAO);
                ListarInformacoes();
                LimparCampos();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgPrincipal.CurrentRow.Index >= 0)
                    if (criteriosRegraNegocio.Listar(Convert.ToInt64(dtgPrincipal.CurrentRow.Cells["ID"].Value)) != null)
                    {
                        criteriosRegraNegocio.Alterar(Convert.ToInt64(dtgPrincipal.CurrentRow.Cells["ID"].Value));
                        CarregarInformacoesPrincipais();
                    }
                    else
                    {
                        MessageBox.Show("Este registro não se encontra mais disponível.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ListarInformacoes();
                        LimparCampos();
                    }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CarregarInformacoesPrincipais()
        {
            try
            {
                txtCodigo.Text = criteriosRegraNegocio.entidade.ID.ToString();
                txtDescricao.Text = criteriosRegraNegocio.entidade.DESCRICAO.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ListarInformacoes()
        {
            dtgPrincipal.DataSource = criteriosRegraNegocio.Listar();

            //listra o datagridView
            foreach (DataGridViewRow row in dtgPrincipal.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.SkyBlue;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Text = 0.ToString();
            txtDescricao.Clear();
        }

        private void dtgPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    switch (dtgPrincipal.Columns[e.ColumnIndex].Name)
                    {
                        case "btnEditar":
                            btnAlterar_Click(btnAlterar, new EventArgs());
                            MudarStatusInformacao(StatusInformacao.ALTERACAO);
                            break;

                        case "btnExcluir":
                            btnInativar_Click(btnInativar, new EventArgs());
                            MudarStatusInformacao(StatusInformacao.VISUALIZACAO);
                            break;
                        default:

                            if (criteriosRegraNegocio.Listar(Convert.ToInt64(dtgPrincipal.Rows[e.RowIndex].Cells["ID"].Value)) != null)
                            {
                                criteriosRegraNegocio.Alterar(Convert.ToInt64(dtgPrincipal.Rows[e.RowIndex].Cells["ID"].Value));
                                CarregarInformacoesPrincipais();
                            }
                            else
                            {
                                MessageBox.Show("Esse registro não se encontra mais disponível", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                LimparCampos();
                                ListarInformacoes();
                            }
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgPrincipal.CurrentRow.Index >= 0)
                    if (criteriosRegraNegocio.Listar(Convert.ToInt64(dtgPrincipal.CurrentRow.Cells["ID"].Value)) != null)
                    {
                        if (MessageBox.Show(String.Format("Deseja realmente modificar o Status do registro {0} {1}", dtgPrincipal.CurrentRow.Cells["ID"].Value, dtgPrincipal.CurrentRow.Cells["DESCRICAO"].Value), "Deseja realmente realizar esta operação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            criteriosRegraNegocio.MudarStatus(Convert.ToInt64(dtgPrincipal.CurrentRow.Cells["ID"].Value));
                            MessageBox.Show("Status Modificado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListarInformacoes();
                            LimparCampos();
                        }
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Este registro não se encontra mais disponível.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ListarInformacoes();
                LimparCampos();
            }
        }

        private void HabilitarCampos(bool status)
        {
            //txtCodigo.ReadOnly = !status;
            txtDescricao.ReadOnly = !status;
        }

        private void MudarStatusInformacao(StatusInformacao statusInformacao)
        {
            this.statusInformacao = statusInformacao;

            switch (this.statusInformacao)
            {
                case StatusInformacao.INCLUSAO:
                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnInativar.Enabled = false;
                    btnPesquisar.Enabled = false;
                    break;
                case StatusInformacao.ALTERACAO:
                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = false;
                    btnInativar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnPesquisar.Enabled = false;
                    break;
                case StatusInformacao.VISUALIZACAO:
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnCancelar.Visible = false;
                    btnPesquisar.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarCampos(false);
            MudarStatusInformacao(StatusInformacao.VISUALIZACAO);
            ListarInformacoes();
            LimparCampos();
        }

        private void frmCriterios_Load(object sender, EventArgs e)
        {
            ListarInformacoes();
        }
    }

    public enum StatusInformacao
    {
        INCLUSAO = 1,
        ALTERACAO = 2,
        VISUALIZACAO = 0
    }
}
