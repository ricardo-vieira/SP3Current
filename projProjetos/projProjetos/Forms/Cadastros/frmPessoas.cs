using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projProjetos.Forms.Cadastros
{
    public partial class frmPessoas : Form
    {
        public frmPessoas()
        {
            InitializeComponent();
        }

        StatusInformacao statusInformacao = StatusInformacao.SELECAO;
        RegraNegocio.Pessoas pessoasRegraNegocio = new RegraNegocio.Pessoas();

        private void MudarStatusInformacao(StatusInformacao statusInformacao)
        {
            this.statusInformacao = statusInformacao;

            switch (statusInformacao)
            {
                case StatusInformacao.INCLUSAO:

                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnInativar.Enabled = false;
                    btnPesquisar.Enabled = false;
                    btnEditar.Enabled = false;

                    txtNome.ReadOnly = false;
                    txtObservacoes.ReadOnly = false;

                    txtDataEdicao.Visible = false;
                    lblDataCriacao.Visible = false;
                    break;

                case StatusInformacao.ALTERACAO:

                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnInativar.Enabled = false;
                    btnPesquisar.Enabled = false;
                    btnEditar.Enabled = false;

                    txtNome.ReadOnly = false;
                    txtObservacoes.ReadOnly = false;

                    txtDataEdicao.Visible = false;
                    lblDataCriacao.Visible = false;
                    break;
                case StatusInformacao.SELECAO:

                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnInativar.Enabled = true;
                    btnPesquisar.Enabled = true;
                    btnEditar.Enabled = true;

                    txtNome.ReadOnly = true;
                    txtObservacoes.ReadOnly = true;

                    txtDataEdicao.Visible = true;
                    lblDataCriacao.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void CarregarInformacoes()
        {
            try
            {
                pessoasRegraNegocio.Listar(Convert.ToInt64(dtgPrincipal.SelectedRows[0].Cells["ID"].Value));

                txtCodigo.Text = pessoasRegraNegocio.entidade.ID.ToString();
                txtNome.Text = pessoasRegraNegocio.entidade.NOME;
                txtObservacoes.Text = pessoasRegraNegocio.entidade.OBSERVACAO;
                txtDataEdicao.Text = pessoasRegraNegocio.entidade.DATACRIACAO.ToString();

                if (pessoasRegraNegocio.entidade.STATUS >= (byte) 1)
                {
                    btnInativar.Text = "Inativar";
                    btnInativar.Image = projProjetos.Properties.Resources.inativar;
                }
                else
                {
                    btnInativar.Text = "Ativar";
                    btnInativar.Image = projProjetos.Properties.Resources.ativar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CarregarInformacoesGerais()
        {
            try
            {
                dtgPrincipal.DataSource = pessoasRegraNegocio.Listar();

                if (dtgPrincipal.Rows.Count > 0)
                {
                    dtgPrincipal.Rows[dtgPrincipal.Rows.Count - 1].Selected = true;
                    CarregarInformacoes();


                    foreach (DataGridViewRow linha in dtgPrincipal.Rows)
                        if (linha.Cells["STATUS"].Value.ToString().Equals("ATIVO"))
                            linha.Cells["dtgPrincipalBtnInativar"].Value = projProjetos.Properties.Resources.excluir;
                        else
                            linha.Cells["dtgPrincipalBtnInativar"].Value = projProjetos.Properties.Resources.miniAtivar;

                    dtgPrincipal.Columns["dtgPrincipalBtnInativar"].DisplayIndex = 5;
                    dtgPrincipal.Columns["dtgPrincipalBtnEditar"].DisplayIndex = 4;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarInformacoes()
        {
            if (txtNome.Text.Trim().Length < 5)
            {
                MessageBox.Show("O campo \"Nome\" não possui a quantidade de caracteres validas necessárias.");
                txtNome.Focus();
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtObservacoes.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //mensagem antes de sair sem salvar as informações
            if ((statusInformacao.Equals(StatusInformacao.INCLUSAO) || statusInformacao.Equals(StatusInformacao.ALTERACAO))                                                              // se a informação estiver sendo inserida ou alterada
                && !(MessageBox.Show("Deseja sair do formulário sem salvar as informações?", "Informação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)) // e o resultado da caixa não diferente "SIM"
            {
                return;               //então finaliza o metodo
            }

            this.Close();             //fecha o formulário
            return;
        }

        private void dtgPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgPrincipal.SelectedRows.Count > 0)
                {
                    switch (dtgPrincipal.Columns[e.ColumnIndex].Name)
                    {
                        case "dtgPrincipalBtnEditar":
                            btnEditar_Click(btnEditar, new EventArgs());
                            break;

                        case "dtgPrincipalBtnInativar":
                            btnInativar_Click(btnInativar, new EventArgs());
                            break;
                        default:
                            CarregarInformacoes();
                            MudarStatusInformacao(StatusInformacao.SELECAO);
                            break; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgPrincipal.SelectedRows.Count > 0)
            {
                CarregarInformacoes();
                MudarStatusInformacao(StatusInformacao.ALTERACAO);
            }
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            CarregarInformacoes();
            MudarStatusInformacao(StatusInformacao.SELECAO);

            if (!(MessageBox.Show(String.Format("Deseja realmente {0} o cadastro \n" +
                                               "ID: {1} \n" +
                                               "Nome: {2} ?", (pessoasRegraNegocio.entidade.STATUS >= (byte)1) ? ("INATIVAR") : ("ATIVAR"),
                                               pessoasRegraNegocio.entidade.ID, pessoasRegraNegocio.entidade.NOME), "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                return;
            }

            pessoasRegraNegocio.MudarStatus();
            CarregarInformacoesGerais();
            
        }

        private void frmPessoas_Load(object sender, EventArgs e)
        {
            MudarStatusInformacao(StatusInformacao.SELECAO);
            CarregarInformacoesGerais();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {

                LimparCampos();
                pessoasRegraNegocio.Incluir();
                MudarStatusInformacao(StatusInformacao.INCLUSAO);
                txtCodigo.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarInformacoes())
                {
                    MudarStatusInformacao(StatusInformacao.SELECAO);

                    pessoasRegraNegocio.entidade.NOME = txtNome.Text;
                    pessoasRegraNegocio.entidade.OBSERVACAO = txtObservacoes.Text;

                    pessoasRegraNegocio.Salvar();

                    CarregarInformacoesGerais();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(String.Format("Deseja realmente cancelar a {0} das informações?", (statusInformacao.Equals(StatusInformacao.INCLUSAO) ? ("INCLUSÃO") : ("ALTERAÇÃO")) ), "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MudarStatusInformacao(StatusInformacao.SELECAO);
                    CarregarInformacoes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
