using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projProjetos.Forms
{
    public partial class frmReunioes : Form
    {
        public frmReunioes()
        {
            InitializeComponent();
        }

        StatusInformacao statusInformacao = StatusInformacao.SELECAO;
        StatusInformacao statusInformacaoPautaProjeto = StatusInformacao.SELECAO;

        RegraNegocio.Reunioes reuniaoRegraNegocio = new RegraNegocio.Reunioes();
        RegraNegocio.Projetos projetoRegraNegocio = new RegraNegocio.Projetos();
        RegraNegocio.Pessoas pessoasRegraNegocio = new RegraNegocio.Pessoas();

        private void MudarStatusInformacao(StatusInformacao statusInformacao)
        {
            this.statusInformacao = statusInformacao;

            switch (this.statusInformacao)
            {
                case StatusInformacao.INCLUSAO:
                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnCancelar.Visible = true;
                    btnAlterar.Enabled = false;
                    btnEfetivarReuniao.Enabled = false;
                    btnAHPCalcular.Enabled = true;

                    txtDescricao.ReadOnly = false;

                    txtSituacao.Text = "EM OPERAÇÃO";
                    txtSituacao.BackColor = Color.Blue;

                    dtpDataHoraEvento.Enabled = true;

                    txtPayBackAceitavel.ReadOnly = false;
                    txtTIR.ReadOnly = false;
                    txtLocal.ReadOnly = false;
                    txtDescricaoPauta.ReadOnly = false;
                    txtTaxaCustoCapital.ReadOnly = false;

                    cboResponsavel.Enabled = true;

                    lblDataInclusao.Visible = false;
                    txtDataHoraInclusao.Visible = false;

                    MudarStatusInformacaoPautaProjeto(StatusInformacao.SELECAO);
                    btnPautaExcluir.Enabled = false;

                    btnCancelarReuniao.Enabled = false;
                    btnEfetivarReuniao.Enabled = false;

                    break;

                case StatusInformacao.ALTERACAO:
                    btnPautaIncluir.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnCancelar.Visible = true;
                    btnAlterar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEfetivarReuniao.Enabled = false;
                    btnAHPCalcular.Enabled = false;


                    if (reuniaoRegraNegocio.entidade.SITUACAO.Equals("EM OPERAÇÃO"))
                    {
                        txtDescricao.ReadOnly = false;

                        dtpDataHoraEvento.Enabled = true;

                        txtPayBackAceitavel.ReadOnly = false;
                        txtTIR.ReadOnly = false;
                        txtLocal.ReadOnly = false;
                        txtDescricaoPauta.ReadOnly = false;
                        txtTaxaCustoCapital.ReadOnly = false;

                        cboResponsavel.Enabled = true;


                        btnAHPCalcular.Enabled = true;

                        lblDataInclusao.Visible = false;
                        txtDataHoraInclusao.Visible = false;

                        btnCancelarReuniao.Enabled = false;
                        btnEfetivarReuniao.Enabled = false;

                        MudarStatusInformacaoPautaProjeto(StatusInformacao.SELECAO);
                        btnPautaExcluir.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(String.Format("Não é possivel alterar esta reunião, pois a mesma está {0}", reuniaoRegraNegocio.entidade.SITUACAO), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MudarStatusInformacao(StatusInformacao.SELECAO);
                    }

                    break;

                case StatusInformacao.SELECAO:
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Visible = false;
                    btnAlterar.Enabled = true;
                    btnAHPCalcular.Enabled = false;

                    txtDescricao.ReadOnly = true;

                    dtpDataHoraEvento.Enabled = false;
                    txtSituacao.Clear();

                    txtPayBackAceitavel.ReadOnly = true;
                    txtTIR.ReadOnly = true;
                    txtLocal.ReadOnly = true;
                    txtDescricaoPauta.ReadOnly = true;
                    txtTaxaCustoCapital.ReadOnly = true;

                    cboResponsavel.Enabled = false;

                    lblDataInclusao.Visible = true;
                    txtDataHoraInclusao.Visible = true;

                    btnEfetivarReuniao.Enabled = false;
                    btnCancelarReuniao.Enabled = false;

                    MudarStatusInformacaoPautaProjeto(StatusInformacao.SELECAO);
                    break;
            }
        }

        private void MudarStatusInformacaoPautaProjeto(StatusInformacao statusInformacaoPautaProjeto)
        {
            this.statusInformacaoPautaProjeto = statusInformacaoPautaProjeto;

            switch (this.statusInformacaoPautaProjeto)
            {
                case StatusInformacao.INCLUSAO:
                    if (this.statusInformacao.Equals(StatusInformacao.INCLUSAO) || this.statusInformacao.Equals(StatusInformacao.ALTERACAO))
                    {
                        btnPautaIncluir.Enabled = false;
                        cboPautaProjeto.Enabled = true;
                        btnPautaSalvar.Enabled = true;
                        btnAHPCalcular.Enabled = false;

                        txtPautaDataInclusao.Visible = false;
                    }
                    break;
                case StatusInformacao.ALTERACAO:
                    //Não tem implementação
                    break;
                case StatusInformacao.SELECAO:
                    if (this.statusInformacao.Equals(StatusInformacao.INCLUSAO) || this.statusInformacao.Equals(StatusInformacao.ALTERACAO))
                    {
                        btnPautaIncluir.Enabled = true;
                        btnAHPCalcular.Enabled = true;
                    }
                    else
                    {
                        btnPautaIncluir.Enabled = false;
                        btnAHPCalcular.Enabled = false;
                    }

                    cboPautaProjeto.Enabled = false;
                    btnPautaExcluir.Enabled = false;
                    btnPautaSalvar.Enabled = false;
                    txtPautaDataInclusao.Visible = true;


                    break;
            }
        }

        private void CarregarInformacoes()
        {
            try
            {
                tbcReunioes.SelectTab(tbpPrincipal);

                if (dtgPrincipal.SelectedRows.Count > 0)
                {
                    MudarStatusInformacao(StatusInformacao.SELECAO);
                    reuniaoRegraNegocio.Listar(Convert.ToInt64(dtgPrincipal.SelectedRows[0].Cells["dtgPrincipalTxtId"].Value));

                    txtCodigo.Text = reuniaoRegraNegocio.entidade.ID.ToString();
                    txtDescricao.Text = reuniaoRegraNegocio.entidade.DESCRICAO.ToString();
                    txtSituacao.Text = reuniaoRegraNegocio.entidade.SITUACAO;
                    txtLocal.Text = reuniaoRegraNegocio.entidade.LOCAL.ToString();
                    dtpDataHoraEvento.Value = Convert.ToDateTime(reuniaoRegraNegocio.entidade.DATAHORAEVENTO);
                    txtDescricaoPauta.Text = reuniaoRegraNegocio.entidade.PAUTADESCRICAO;

                    txtPayBackAceitavel.Text = String.Format("{0:0.00}",reuniaoRegraNegocio.entidade.PAYBACKACEITAVEL);
                    txtTIR.Text = String.Format("{0:0.00}", reuniaoRegraNegocio.entidade.TAXAREMUNERACAOMERCADO);
                    txtTaxaCustoCapital.Text = String.Format("{0:0.00}", reuniaoRegraNegocio.entidade.TAXACUSTOCAPITAL);

                    txtDataHoraInclusao.Text = reuniaoRegraNegocio.entidade.DATACRIACAO.ToString();

                    cboResponsavel.DataSource = pessoasRegraNegocio.Listar();
                    cboResponsavel.SelectedValue = reuniaoRegraNegocio.entidade.RESPONSAVEL;

                    CarregarInformacoesGeraisPautaProjetos(true);
                    CarregarInformaoesGeraisRankProjetos();

                    switch (reuniaoRegraNegocio.entidade.SITUACAO)
                    {
                        case "EM OPERAÇÃO":
                            btnEfetivarReuniao.Enabled = true;
                            btnCancelarReuniao.Enabled = true;
                            txtSituacao.BackColor = Color.Blue;
                            break;
                        case "EFETIVADO":
                            btnEfetivarReuniao.Enabled = false;
                            btnCancelarReuniao.Enabled = true;
                            txtSituacao.BackColor = Color.Green;
                            break;

                        case "CANCELADO":
                            btnEfetivarReuniao.Enabled = false;
                            btnCancelarReuniao.Enabled = false;
                            txtSituacao.BackColor = Color.Red;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarInformacoesPautaProjeto()
        {
            try
            {
                if (dtgPautaProjetos.SelectedRows.Count > 0)
                {
                    if (Convert.ToInt64(dtgPautaProjetos.SelectedRows[0].Cells["dtgPautaProjetosTxtIdPautaProjeto"].Value) == 0)
                        reuniaoRegraNegocio.ListarPautaProjetoSemId(Convert.ToInt64(dtgPautaProjetos.SelectedRows[0].Cells["dtgPautaProjetosTxtIdProjeto"].Value));

                    else
                        reuniaoRegraNegocio.ListarPautaProjetos(Convert.ToInt64(dtgPautaProjetos.SelectedRows[0].Cells["dtgPautaProjetosTxtIdPautaProjeto"].Value));

                    cboPautaProjeto.DataSource = projetoRegraNegocio.Listar();
                    cboPautaProjeto.SelectedValue = reuniaoRegraNegocio.pautaProjeto.IDPROJETO;

                    projetoRegraNegocio.Listar(reuniaoRegraNegocio.pautaProjeto.IDPROJETO);

                    txtPautaGerente.Text = projetoRegraNegocio.entidade.GERENTEPROJETO.NOME;
                    txtPautaInvestimentoPrevisto.Text = String.Format("R$ {0:0.00}", reuniaoRegraNegocio.pautaProjeto.INVESTIMENTOPREVISTO);
                    txtPautaTempoConclusao.Text = reuniaoRegraNegocio.pautaProjeto.TEMPOPREVISTOCONCLUSAO.ToString();

                    if (!this.statusInformacao.Equals(StatusInformacao.SELECAO) && this.statusInformacaoPautaProjeto.Equals(StatusInformacao.SELECAO))
                        btnPautaExcluir.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarInformacoesGerais()
        {
            try
            {

                dtgPrincipal.DataSource = reuniaoRegraNegocio.Listar();
                dtgPrincipal.Columns["btnEditar"].DisplayIndex = 7;

                if (dtgPrincipal.Rows.Count > 0)
                {
                    dtgPrincipal.Rows[dtgPrincipal.Rows.Count - 1].Selected = true;

                    CarregarInformacoes();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarInformacoesGeraisPautaProjetos(bool selecionarRegistroAutomaticamente)
        {
            try
            {
                MudarStatusInformacaoPautaProjeto(StatusInformacao.SELECAO);
                dtgPautaProjetos.DataSource = reuniaoRegraNegocio.ListarPautaProjeto();

                if (reuniaoRegraNegocio.entidade.AHPCALCULADO != null && reuniaoRegraNegocio.entidade.AHPCALCULADO >= 1)
                {
                    txtAHPCalculado.Text = "SIM";
                    txtAHPCalculado.ForeColor = Color.Green;
                }
                else
                {
                    txtAHPCalculado.Text = "NÃO";
                    txtAHPCalculado.ForeColor = Color.Red;
                }

                if (dtgPautaProjetos.Rows.Count > 0)
                {
                    if (selecionarRegistroAutomaticamente)
                        CarregarInformacoesPautaProjeto();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CarregarInformaoesGeraisRankProjetos()
        {
            try
            {
                dtgRankProjetos.DataSource = reuniaoRegraNegocio.ListarProjetosCalculados();

                if (reuniaoRegraNegocio.entidade.SITUACAO.Equals("EFETIVADO") || (reuniaoRegraNegocio.entidade.SITUACAO.Equals("CANCELADO") && reuniaoRegraNegocio.entidade.AHPCALCULADO != null && reuniaoRegraNegocio.entidade.AHPCALCULADO >= 1))
                {
                    dtgRankProjetos.Visible = true;
                    //dtgRankProjetos.DataSource = null;
                    //dtgRankProjetos.Columns.Clear();
                    //RecarregarColunasdtgPrincipal();
                    ColorirDataGridRankProjetos();
                    btnImprimir.Enabled = true;

                    dtgRankProjetos.Sort(dtgRankProjetos.Columns["dtgRankProjetosNome"], ListSortDirection.Ascending);
                    dtgRankProjetos_Sorted(dtgRankProjetos, new EventArgs());
                }
                else
                {
                    dtgRankProjetos.Visible = false;
                    btnImprimir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Text = 0.ToString();

            txtDescricao.Clear();

            dtpDataHoraEvento.Value = DateTime.Now;

            txtPayBackAceitavel.Text = String.Format("{0:0.00}", 0);
            txtTIR.Text = String.Format("{0:0.00}", 0);
            txtTaxaCustoCapital.Text = String.Format("{0:0.00}", 0);
            txtLocal.Clear();
            txtDescricaoPauta.Clear();

            cboResponsavel.DataSource = pessoasRegraNegocio.Listar();
            cboResponsavel.SelectedItem = null;

            LimparCamposPautaProjetos();
        }

        private void LimparCamposPautaProjetos()
        {
            cboPautaProjeto.DataSource = projetoRegraNegocio.Listar();
            cboPautaProjeto.SelectedItem = null;
            txtPautaDataInclusao.Clear();
            txtPautaGerente.Clear();
            txtPautaInvestimentoPrevisto.Clear();
        }

        private bool ValidarInformacoes()
        {
            if (txtDescricao.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo \"Descrição\" não foi preenchido ou contem apenas caracteres em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                return false;
            }

            if (txtLocal.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo \"Local\" não foi preenchido ou contem apenas caracteres em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocal.Focus();
                return false;
            }

            if (cboResponsavel.SelectedItem == null)
            {
                MessageBox.Show("Deve ser selecionado o resposável pela reunião", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboResponsavel.Focus();
                return false;
            }

            if (this.statusInformacao.Equals(StatusInformacao.EFETIVACAO))
            {

                if (txtDescricaoPauta.Text.Trim().Length < 1)
                {
                    MessageBox.Show("O campo \"Descrição da pauta\" não foi preenchido ou contem apenas espaços em branco.");
                    txtDescricaoPauta.Focus();
                    return false;
                }

                if (Convert.ToDouble(txtPayBackAceitavel.Text) <= 0)
                {
                    MessageBox.Show("O campo \"PayBack aceitável\" está com o valor \"0\"", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPayBackAceitavel.Focus();
                    return false;
                }

                if (Convert.ToDouble(txtTaxaCustoCapital.Text) <= 0)
                {
                    MessageBox.Show("O campo \"Taxa de Custo Capital\" está com o valor \"0\"", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTaxaCustoCapital.Focus();
                    return false;
                }

                if (Convert.ToDouble(txtTIR.Text) <= 0)
                {
                    MessageBox.Show("O campo \"TIR\" está com o valor \"0\".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTIR.Focus();
                    return false;
                }

                if (reuniaoRegraNegocio.entidade.PAUTAPROJETOS.Count < 0)
                {
                    MessageBox.Show("A reunião não pode ser efetivada pois não contem projetos na pauta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbpPautaProjetos.Focus();
                    return false;
                }

                if (reuniaoRegraNegocio.entidade.AHPCALCULADO == null || reuniaoRegraNegocio.entidade.AHPCALCULADO < 1)
                {
                    MessageBox.Show("A reunião não pode ser efetivada pois o critério AHP não foi priorizado para os projetos pautados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbpPautaProjetos.Focus();
                    return false;
                }

            }

            return true;
        }

        private bool ValidarInformacoesPautaProjetos()
        {
            if (cboPautaProjeto.SelectedItem == null)
            {
                MessageBox.Show("Deve ser indicado o projeto a ser incluso na pauta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPautaProjeto.Focus();
                return false;
            }

            return true;
        }

        private void EnviarInformacoesObjeto()
        {
            try
            {
                reuniaoRegraNegocio.entidade.DESCRICAO = txtDescricao.Text;
                reuniaoRegraNegocio.entidade.LOCAL = txtLocal.Text;
                reuniaoRegraNegocio.entidade.DATAHORAEVENTO = dtpDataHoraEvento.Value;
                reuniaoRegraNegocio.entidade.RESPONSAVEL = Convert.ToInt64(cboResponsavel.SelectedValue);
                reuniaoRegraNegocio.entidade.PAYBACKACEITAVEL = Convert.ToDecimal(txtPayBackAceitavel.Text);
                reuniaoRegraNegocio.entidade.TAXAREMUNERACAOMERCADO = Convert.ToDecimal(txtTIR.Text);
                reuniaoRegraNegocio.entidade.TAXACUSTOCAPITAL = Convert.ToDecimal(txtTaxaCustoCapital.Text);
                reuniaoRegraNegocio.entidade.PAUTADESCRICAO = txtDescricaoPauta.Text;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EnviarInformacoesObjetoPautaProjetos()
        {
            try
            {
                reuniaoRegraNegocio.pautaProjeto.IDPROJETO = Convert.ToInt64(cboPautaProjeto.SelectedValue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                MudarStatusInformacao(StatusInformacao.INCLUSAO);
                LimparCampos();
                reuniaoRegraNegocio.Incluir();
                txtCodigo.Text = 0.ToString();
                CarregarInformacoesGeraisPautaProjetos(false);
                CarregarInformaoesGeraisRankProjetos();
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
                if (ValidarInformacoes())
                {
                    MudarStatusInformacao(StatusInformacao.SELECAO);
                    EnviarInformacoesObjeto();

                    reuniaoRegraNegocio.Salvar();
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
            if (MessageBox.Show(String.Format("Deseja realmente cancelar a {0} das informações?", (statusInformacao.Equals(StatusInformacao.INCLUSAO) ? ("INCLUSÃO") : ("ALTERAÇÃO"))), "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                CarregarInformacoesGerais();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dtgPrincipal.SelectedRows.Count > 0)
            {
                if (reuniaoRegraNegocio.entidade.SITUACAO.Equals("EM OPERAÇÃO"))
                {
                    CarregarInformacoes();
                    MudarStatusInformacao(StatusInformacao.ALTERACAO);
                }
                else
                {
                    MessageBox.Show(String.Format("Não é possivel alterar a reunião, pois a mesma está {0}.", reuniaoRegraNegocio.entidade.SITUACAO), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CarregarInformacoes();
                    MudarStatusInformacao(StatusInformacao.SELECAO);
                }


                }
        }

        private void btnPautaIncluir_Click(object sender, EventArgs e)
        {
            if (this.statusInformacao.Equals(StatusInformacao.INCLUSAO) || this.statusInformacao.Equals(StatusInformacao.ALTERACAO))
            {
                if (reuniaoRegraNegocio.entidade.PAUTAPROJETOS.Count <= 0 ||
                    reuniaoRegraNegocio.entidade.AHPCALCULADO <= 0 ||
                    reuniaoRegraNegocio.entidade.AHPCALCULADO >= 1 && reuniaoRegraNegocio.entidade.PAUTAPROJETOS.Count > 0 &&
                    MessageBox.Show("Deseja realmente incluir um novo projeto com o critério do AHP já priorizado?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MudarStatusInformacaoPautaProjeto(StatusInformacao.INCLUSAO);
                    LimparCamposPautaProjetos();
                    reuniaoRegraNegocio.IncluirPautaProjeto();
                }
            }
        }

        private void btnPautaSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarInformacoesPautaProjetos())
                {
                    EnviarInformacoesObjetoPautaProjetos();

                    if (reuniaoRegraNegocio.VerificarExistenciaProjetoPautaProjeto())
                        MessageBox.Show("Este projeto já está sendo pautado na reunião.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        reuniaoRegraNegocio.SalvarPautaProjeto();

                    MudarStatusInformacaoPautaProjeto(StatusInformacao.SELECAO);
                    CarregarInformacoesGeraisPautaProjetos(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTaxaCustoCapital_Validating(object sender, CancelEventArgs e)
        {
            double valorConversao = 0.00;

            if (!Double.TryParse((sender as TextBox).Text, out valorConversao))
                (sender as TextBox).Text = "0,00";
            else
                (sender as TextBox).Text = String.Format("{0:0.00}", valorConversao);

        }

        private void btnEfetivar_Click(object sender, EventArgs e)
        {
            MudarStatusInformacao(StatusInformacao.EFETIVACAO);

            if (ValidarInformacoes() && reuniaoRegraNegocio.entidade.SITUACAO.Equals("EM OPERAÇÃO"))
            {
                if (MessageBox.Show("Deseja ralmente efetivar esta reunião?", "Efetivar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    reuniaoRegraNegocio.MudarSituacao(RegraNegocio.SituacaoReuniao.EFETIVADO);
                    reuniaoRegraNegocio.Salvar();
                    CarregarInformacoesGerais();
                }
            }
        }

        private void btnCancelarReuniao_Click(object sender, EventArgs e)
        {
            MudarStatusInformacao(StatusInformacao.CANCELAMENTO);

            if (MessageBox.Show("Deseja realmente cancelar esta reunião?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reuniaoRegraNegocio.MudarSituacao(RegraNegocio.SituacaoReuniao.CANCELADO);
                reuniaoRegraNegocio.Salvar();
                MudarStatusInformacao(StatusInformacao.SELECAO);
                CarregarInformacoesGerais();
            }
        }

        private void frmReunioes_Load(object sender, EventArgs e)
        {
            CarregarInformacoesGerais();
        }

        private void dtgPautaProjetos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (dtgPautaProjetos.Columns[e.ColumnIndex].Name)
                {
                    case "dtgPautaProjetoBtnExcluir":
                        btnPautaExcluir_Click(btnPautaExcluir, new EventArgs());
                        break;
                    default:
                        CarregarInformacoesPautaProjeto();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPautaExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgPautaProjetos.SelectedRows.Count > 0)
                {
                    CarregarInformacoesPautaProjeto();

                    if (MessageBox.Show("Deseja realmente excluir este projeto da pauta?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        reuniaoRegraNegocio.ExcluirPautaProjeto();
                        LimparCamposPautaProjetos();
                        CarregarInformacoesGeraisPautaProjetos(true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboPautaProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboPautaProjeto.SelectedItem != null)
                {
                    projetoRegraNegocio.Listar(Convert.ToInt64(cboPautaProjeto.SelectedValue));

                    txtPautaGerente.Text = projetoRegraNegocio.entidade.GERENTEPROJETO.NOME;
                    txtPautaInvestimentoPrevisto.Text = String.Format("R$ {0:0.00}", projetoRegraNegocio.entidade.INVESTIMENTOPREVISTO);
                    txtPautaTempoConclusao.Text = projetoRegraNegocio.entidade.TEMPOPREVISTOCONCLUSAO.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Relatorio.frmImpressao frmImpress = new Relatorio.frmImpressao(Convert.ToInt64(txtCodigo.Text));
                frmImpress.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAHPCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (reuniaoRegraNegocio.entidade.AHPCALCULADO == null ||
                    reuniaoRegraNegocio.entidade.PAUTAPROJETOS.Count > 0 && (reuniaoRegraNegocio.entidade.AHPCALCULADO <= 0 || (reuniaoRegraNegocio.entidade.AHPCALCULADO >= 1
                    && MessageBox.Show("Deseja realmente recalcular o critério do AHP para esta reunião?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)))
                {
                    reuniaoRegraNegocio.CalcularAHP();
                    txtAHPCalculado.Text = "SIM";
                    txtAHPCalculado.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (dtgPrincipal.Columns[e.ColumnIndex].Name)
                {
                    case "btnEditar":
                        btnAlterar_Click(this.btnAlterar, new EventArgs());
                        break;
                    default:
                        CarregarInformacoes();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ColorirDataGridRankProjetos()
        {
            try
            {
                foreach (DataGridViewRow linha in dtgRankProjetos.Rows)
                {
                    switch (linha.Index)
                    {
                        case 0:
                            linha.DefaultCellStyle.BackColor = Color.Green;
                            linha.DefaultCellStyle.ForeColor = Color.White;
                            break;
                        case 1:
                            linha.DefaultCellStyle.BackColor = Color.LightBlue;
                            linha.DefaultCellStyle.ForeColor = Color.White;
                            break;
                        case 2:
                            linha.DefaultCellStyle.BackColor = Color.Yellow;
                            linha.DefaultCellStyle.ForeColor = Color.Black;
                            break;
                        default:
                            linha.DefaultCellStyle.BackColor = Color.White;
                            linha.DefaultCellStyle.ForeColor = Color.Black;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dtgRankProjetos_Sorted(object sender, EventArgs e)
        {
            ColorirDataGridRankProjetos();
        }
    }
}

#region MyRegion
/*
RegraNegocio.Reunioes reuniaoRegraNegocio = new RegraNegocio.Reunioes();

//Muda O Status dos Botoes
//StatusInformacao statusInformacao;

public void AlteraStatusInformacao(StatusInformacao statusInformacao)
{
    this.statusInformacao = statusInformacao;

    switch (this.statusInformacao)
    {

        case StatusInformacao.SELECAO:
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Visible = false;
            btnInativar.Enabled = true;
            btnPesquisar.Enabled = true;
            btnAlterar.Enabled = true;
            btnAHPCalcular.Enabled = false;
            break;
        case StatusInformacao.INCLUSAO:
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Visible = true;
            btnInativar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnAlterar.Enabled = false;
            btnAHPCalcular.Enabled = true;
            break;
        case StatusInformacao.ALTERACAO:
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Visible = true;
            btnInativar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnAlterar.Enabled = false;
            btnAHPCalcular.Enabled = true;
            break;
        default:
            break;
    }
}

//public void CarregarInformacoes()
//{
//    try
//    {
//        #region Carregando Informações Cadastrais

//        txtCodigo.Text = reuniaoRegraNegocio.entidade.ID.ToString();
//        txtDescricao.Text = reuniaoRegraNegocio.entidade.DESCRICAO;
//        dtpDataHoraEvento.Value = reuniaoRegraNegocio.entidade.DATAHORAEVENTO;
//        txtLocal.Text = reuniaoRegraNegocio.entidade.LOCAL;
//        txtDescricaoPauta.Text = reuniaoRegraNegocio.entidade.PAUTADESCRICAO;
//        cboResponsavel.DataSource = new RegraNegocio.Pessoas().Listar();
//        cboResponsavel.SelectedValue = reuniaoRegraNegocio.entidade.RESPONSAVEL;

//        #endregion

//        #region Carregando Pauta Projetos
//        dtgPautaProjetos.DataSource = reuniaoRegraNegocio.ListarProjetosCalculados();


//        if (reuniaoRegraNegocio.entidade.AHPCALCULADO == (byte)1)
//        {
//            txtAHPCalculado.Text = "SIM";
//            txtAHPCalculado.ForeColor = Color.Green;
//        }
//        else
//        {
//            txtAHPCalculado.Text = "SIM";
//            txtAHPCalculado.ForeColor = Color.Firebrick;
//        }


//        #endregion
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
}



private void btnNovo_Click(object sender, EventArgs e)
{
    try
    {
        AlteraStatusInformacao(StatusInformacao.INCLUSAO);
        reuniaoRegraNegocio.Incluir();
        HabilitaEdicaoInformacoes();
        dtgPrincipal.DataSource = reuniaoRegraNegocio.Listar();
        txtCodigo.Text = 0.ToString();
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

        ValidarInformacoes();

        #region Copiando Informações Cadastrais
        reuniaoRegraNegocio.entidade.DESCRICAO = txtDescricao.Text;
        reuniaoRegraNegocio.entidade.DATAHORAEVENTO = dtpDataHoraEvento.Value;
        reuniaoRegraNegocio.entidade.LOCAL = txtLocal.Text;
        reuniaoRegraNegocio.entidade.PAYBACKACEITAVEL = Convert.ToDecimal(txtPayBackAceitavel.Text);
        reuniaoRegraNegocio.entidade.PAUTADESCRICAO = txtDescricaoPauta.Text;
        reuniaoRegraNegocio.entidade.RESPONSAVEL = Convert.ToInt64(cboResponsavel.SelectedValue);
        #endregion

        AlteraStatusInformacao(StatusInformacao.SELECAO);
        reuniaoRegraNegocio.Salvar();
        //CarregarInformacoes();

        dtgRankProjetos.DataSource = reuniaoRegraNegocio.ListarProjetosCalculados();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

private void btnPautaSalvar_Click(object sender, EventArgs e)
{
    try
    {
        if ((reuniaoRegraNegocio.entidade.PAUTAPROJETOS.Count > 0 && (reuniaoRegraNegocio.entidade.AHPCALCULADO != null && reuniaoRegraNegocio.entidade.AHPCALCULADO == (byte)1)
            && MessageBox.Show("Deseja realmente incluir um novo projeto na pauta com os valores de AHP pré existentes?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            || reuniaoRegraNegocio.entidade.PAUTAPROJETOS.Count <= 0
            || reuniaoRegraNegocio.entidade.PAUTAPROJETOS.Count > 0 && (reuniaoRegraNegocio.entidade.AHPCALCULADO == null || reuniaoRegraNegocio.entidade.AHPCALCULADO == (byte)0))
        {
            //btnPautaExcluir.Enabled = true;
            cboPautaProjeto.Enabled = false;

            if (cboPautaProjeto.SelectedValue != null)
                reuniaoRegraNegocio.IncluirProjetoPauta(Convert.ToInt64(cboPautaProjeto.SelectedValue));

            dtgPautaProjetos.DataSource = reuniaoRegraNegocio.ListarProjetosCalculados();

            cboPautaProjeto.Enabled = false;

            txtPautaDataInclusao.Clear();
            //cboPautaProjeto.SelectedValue = null;
            txtPautaGerente.Clear();
            txtPayBackAceitavel.Clear();
            txtPautaTempoConclusao.Clear();

            RegraNegocio.Binding.SortableBindingList<RegraNegocio.View.Projetos.ViewProjetoCalculos> listaProjetos = new RegraNegocio.Binding.SortableBindingList<RegraNegocio.View.Projetos.ViewProjetoCalculos>(reuniaoRegraNegocio.ListarProjetosCalculados());
            //listaProj////etos.s

            dtgRankProjetos.DataSource = listaProjetos;
            MudarCoresDtgRankProjetos();

            txtAHPCalculado.Text = "NÃO";
            txtAHPCalculado.ForeColor = Color.Firebrick;
            btnAHPCalcular.Enabled = true;
        }

        btnPautaSalvar.Enabled = false;
        btnPautaIncluir.Enabled = true;

    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

private void btnPautaIncluir_Click(object sender, EventArgs e)
{
    cboPautaProjeto.DataSource = new RegraNegocio.Projetos().Listar();
    btnPautaIncluir.Enabled = false;
    btnPautaExcluir.Enabled = false;
    cboPautaProjeto.Enabled = true;
    btnPautaSalvar.Enabled = true;

    txtPautaDataInclusao.Text = DateTime.Now.ToString();
}

private void HabilitaEdicaoInformacoes()
{
    if (statusInformacao.Equals(StatusInformacao.INCLUSAO) || statusInformacao.Equals(StatusInformacao.ALTERACAO))
    {
        #region Habilitando Informações Principais
        txtDescricao.ReadOnly = false;
        dtpDataHoraEvento.Enabled = true;
        txtLocal.ReadOnly = false;
        txtPayBackAceitavel.ReadOnly = false;
        txtTIR.ReadOnly = false;
        txtDescricaoPauta.ReadOnly = false;
        cboResponsavel.Enabled = true;
        txtDataHoraInclusao.Visible = false;
        lblDataInclusao.Visible = false;
        #endregion

        grbPautaAcoes.Enabled = true;
        grbPautaInformacoes.Enabled = true;
        cboPautaProjeto.DataSource = new RegraNegocio.Projetos().Listar();
    }
    else
    {
        #region Desabilitando Informações Principais

        txtDescricao.ReadOnly = true;
        dtpDataHoraEvento.Enabled = false;
        txtLocal.ReadOnly = true;
        txtPayBackAceitavel.ReadOnly = true;
        txtTIR.ReadOnly = true;
        txtDescricaoPauta.ReadOnly = true;
        cboResponsavel.Enabled = false;
        txtDataHoraInclusao.Visible = true;
        lblDataInclusao.Visible = true;
        #endregion

        grbPautaAcoes.Enabled = false;
        grbPautaInformacoes.Enabled = false;
        cboPautaProjeto.DataSource = new RegraNegocio.Projetos().Listar();
    }
}

private void LimparCampos()
{
    txtCodigo.Clear();
    txtDescricao.Clear();
    dtpDataHoraEvento.Value = DateTime.Now;
    txtDescricaoPauta.Clear();
    cboPautaProjeto.SelectedValue = null;

    dtgPautaProjetos.DataSource = null;
}

private void frmReunioes_Load(object sender, EventArgs e)
{
    cboResponsavel.DataSource = new RegraNegocio.Pessoas().Listar();
    cboPautaProjeto.DataSource = new RegraNegocio.Projetos().Listar();
    dtgPrincipal.DataSource = reuniaoRegraNegocio.Listar();
}

private void dtgReunioes_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
    try
    {
        switch (dtgPrincipal.Columns[e.ColumnIndex].Name)
        {
            case "btnEditar":
                reuniaoRegraNegocio.Listar(Convert.ToInt64(dtgPrincipal.Rows[e.RowIndex].Cells["Id"].Value));
                if (reuniaoRegraNegocio.entidade != null)
                {
                    CarregarInformacoes();
                    AlteraStatusInformacao(StatusInformacao.ALTERACAO);
                    HabilitaEdicaoInformacoes();
                }
                else
                    dtgPrincipal.DataSource = reuniaoRegraNegocio.Listar();
                break;

            case "btnExcluir":
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Informação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    reuniaoRegraNegocio.MudarStatus(Convert.ToInt64(dtgPrincipal.Rows[e.RowIndex].Cells["Id"].Value));

                dtgPrincipal.DataSource = reuniaoRegraNegocio.Listar();
                break;

            default:
                reuniaoRegraNegocio.Listar(Convert.ToInt64(dtgPrincipal.Rows[e.RowIndex].Cells["Id"].Value));

                if (reuniaoRegraNegocio.entidade != null)
                    CarregarInformacoes();
                else
                    dtgPrincipal.DataSource = reuniaoRegraNegocio.Listar();
                break;
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

private void dtgPautaProjetos_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
    try
    {
        btnPautaExcluir.Enabled = true;

        cboPautaProjeto.SelectedValue = reuniaoRegraNegocio.ListarProjetosCalculados(Convert.ToInt64(dtgPautaProjetos.Rows[e.RowIndex].Cells["IdProjeto"].Value)).ID;
        txtPautaGerente.Text = reuniaoRegraNegocio.ListarProjetosCalculados(Convert.ToInt64(dtgPautaProjetos.Rows[e.RowIndex].Cells["IdProjeto"].Value)).GERENTEPROJETO.NOME;
        txtPautaInvestimentoPrevisto.Text = reuniaoRegraNegocio.ListarProjetosCalculados(Convert.ToInt64(dtgPautaProjetos.Rows[e.RowIndex].Cells["IdProjeto"].Value)).INVESTIMENTOPREVISTO.ToString();
        txtPautaTempoConclusao.Text = reuniaoRegraNegocio.ListarProjetosCalculados(Convert.ToInt64(dtgPautaProjetos.Rows[e.RowIndex].Cells["IdProjeto"].Value)).TEMPOPREVISTOCONCLUSAO + " MESES";

        switch (dtgPautaProjetos.Columns[e.ColumnIndex].Name)
        {
            case "btnExcluirPautaProjeto":
                if (MessageBox.Show("Deseja realmente remover este registro?", "Informação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                    reuniaoRegraNegocio.ExcluirProjetoPauta(Convert.ToInt64(dtgPautaProjetos.Rows[e.RowIndex].Cells["IdProjeto"].Value));

                dtgPautaProjetos.DataSource = reuniaoRegraNegocio.ListarProjetosCalculados();
                break;

            default:
                break;
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

private void btnPautaExcluir_Click(object sender, EventArgs e)
{
    try
    {
        if (dtgPautaProjetos.CurrentRow.Index >= 0 &&
            MessageBox.Show("Deseja realmente excluir este registro?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
        {
            reuniaoRegraNegocio.ExcluirProjetoPauta(Convert.ToInt64(dtgPautaProjetos.CurrentRow.Cells["IdProjeto"].Value));
            dtgPautaProjetos.DataSource = reuniaoRegraNegocio.ListarProjetosCalculados();

            MessageBox.Show("Registro excluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}


public void ValidarInformacoes()
{
    try
    {
        //validar txtDescrição.
        if (String.IsNullOrEmpty(txtDescricao.Text))
        {
            txtDescricao.Focus();
            throw new Exception("O campo descrição da reunião não poderá ser vazio.");
        }

        //validando txtPaybackAceitavel
        try
        {
            Convert.ToDecimal(txtPayBackAceitavel.Text);
        }
        catch (Exception)
        {
            txtPayBackAceitavel.Clear();
            txtPayBackAceitavel.Focus();
            throw new Exception("O campo Payback Aceitável não poderá ser vazio ou conter valores invalidos.");
        }

        //validando txtTirAvaliacao
        try
        {
            Convert.ToDecimal(txtTIR.Text);
        }
        catch (Exception)
        {
            txtTIR.Clear();
            txtTIR.Focus();
            throw new Exception("O campo TIR para avaliação não poderá ser vazio ou conter valores invalidos.");
        }

        //validando cboResponsavel
        if (cboResponsavel.SelectedIndex == -1)
        {
            cboResponsavel.Focus();
            throw new Exception("Deverá ser especificado um responsável pela reunião.");
        }

        //validando quantidade de projetos vinculados a reunião;

        if (reuniaoRegraNegocio.ListarProjetosCalculados().Count() <= 0)
        {
            throw new Exception("A reunião deve ter no minimo um projeto especificado para a priorização");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
}

private void dtgRankProjetos_CellContentClick(object sender, DataGridViewCellEventArgs e)
{

}

private void dtgRankProjetos_CellContentClick(object sender, EventArgs e)
{

}


private void MudarCoresDtgRankProjetos()
{

    DataGridViewRow ln;

    for (int indexLinha = 0; indexLinha < dtgRankProjetos.Rows.Count; indexLinha++)
    {
        ln = dtgRankProjetos.Rows[indexLinha];


        switch (indexLinha)
        {

            case 0:
                dtgRankProjetos.Rows[indexLinha].DefaultCellStyle.BackColor = Color.BlueViolet;
                dtgRankProjetos.Rows[indexLinha].DefaultCellStyle.ForeColor = Color.White;
                break;

            case 1:
                dtgRankProjetos.Rows[indexLinha].DefaultCellStyle.BackColor = Color.Green;
                dtgRankProjetos.Rows[indexLinha].DefaultCellStyle.ForeColor = Color.White;
                break;

            case 2:
                dtgRankProjetos.Rows[indexLinha].DefaultCellStyle.BackColor = Color.Blue;
                dtgRankProjetos.Rows[indexLinha].DefaultCellStyle.ForeColor = Color.White;
                break;
            default:
                dtgRankProjetos.Rows[indexLinha].DefaultCellStyle.BackColor = Color.White;
                dtgRankProjetos.Rows[indexLinha].DefaultCellStyle.ForeColor = Color.Black;
                break;
        }
    }
}

private void dtgRankProjetos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
{
    MudarCoresDtgRankProjetos();
}

private void btnAHPCalcular_Click(object sender, EventArgs e)
{
    try
    {
        if (reuniaoRegraNegocio.entidade.AHPCALCULADO != (byte)1)
        {
            reuniaoRegraNegocio.CalcularAHP();
            dtgPautaProjetos.DataSource = reuniaoRegraNegocio.ListarProjetosCalculados();

            RegraNegocio.Binding.SortableBindingList<RegraNegocio.View.Projetos.ViewProjetoCalculos> listaProjetos = new RegraNegocio.Binding.SortableBindingList<RegraNegocio.View.Projetos.ViewProjetoCalculos>(reuniaoRegraNegocio.ListarProjetosCalculados());
            dtgRankProjetos.DataSource = listaProjetos;
            MudarCoresDtgRankProjetos();
        }

        txtAHPCalculado.Text = "SIM";
        txtAHPCalculado.ForeColor = Color.Green;
        btnAHPCalcular.Enabled = false;
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
} */
#endregion