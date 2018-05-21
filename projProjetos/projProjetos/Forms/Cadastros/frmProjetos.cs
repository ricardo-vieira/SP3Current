using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace projProjetos.Forms
{
    public partial class frmProjetos : Form
    {
        public frmProjetos()
        {
            InitializeComponent();
        }

        RegraNegocio.Projetos projetosRegraNegocio = new RegraNegocio.Projetos();
        RegraNegocio.Pessoas pessoaRegraNegocio = new RegraNegocio.Pessoas();

        StatusInformacao statusInformacao = StatusInformacao.SELECAO;
        StatusInformacao statusInformacaoReceitasDespesasPrev = StatusInformacao.SELECAO;
        StatusInformacao statusInformacaoParticipantesProjeto = StatusInformacao.SELECAO;

        private void MudarStatusInformacao(StatusInformacao statusInformacao)
        {

            this.statusInformacao = statusInformacao;

            switch (this.statusInformacao)
            {
                case StatusInformacao.INCLUSAO:

                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnInativar.Enabled = false;

                    txtCodigo.ReadOnly = false;
                    txtNome.ReadOnly = false;
                    txtDescricao.ReadOnly = false;

                    txtDataAlteracao.Visible = false;
                    lblDataAlteracao.Enabled = false;

                    cboGerenteProjeto.Enabled = true;
                    txtPrazoConclusao.ReadOnly = false;
                    txtInvestimentoPrevisto.ReadOnly = false;
                    cboApoioSteakholders.Enabled = true;
                    cboCapacidadeEntregaEquipe.Enabled = true;
                    cboApoioAltaGestao.Enabled = true;

                    rbEsforcoAdicionalAte10porCento.Enabled = true;
                    rbEsforcoAdicional11A20PorCento.Enabled = true;
                    rbEsforcoAdicional21A40PorCento.Enabled = true;
                    rbEsforcoAdicionalAcima40PorCento.Enabled = true;

                    MudarStatusInformacaoReceitasDespesasPrev(StatusInformacao.SELECAO);
                    btnFluxoEditar.Enabled = false;
                    btnFluxoExcluir.Enabled = false;

                    MudarStatusInformacaoParticipantesProjeto(StatusInformacao.SELECAO);
                    btnParticipanteEditar.Enabled = false;
                    btnParticipanteExcluir.Enabled = false;

                    break;

                case StatusInformacao.ALTERACAO:

                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnInativar.Enabled = false;

                    txtCodigo.ReadOnly = false;
                    txtNome.ReadOnly = false;
                    txtDescricao.ReadOnly = false;
                    txtDataAlteracao.Visible = false;
                    lblDataAlteracao.Enabled = false;


                    cboGerenteProjeto.Enabled = true;
                    txtPrazoConclusao.ReadOnly = false;
                    txtInvestimentoPrevisto.ReadOnly = false;
                    cboApoioSteakholders.Enabled = true;
                    cboCapacidadeEntregaEquipe.Enabled = true;
                    cboApoioAltaGestao.Enabled = true;

                    rbEsforcoAdicionalAte10porCento.Enabled = true;
                    rbEsforcoAdicional11A20PorCento.Enabled = true;
                    rbEsforcoAdicional21A40PorCento.Enabled = true;
                    rbEsforcoAdicionalAcima40PorCento.Enabled = true;

                    MudarStatusInformacaoReceitasDespesasPrev(StatusInformacao.SELECAO);
                    btnFluxoEditar.Enabled = false;
                    btnFluxoExcluir.Enabled = false;

                    MudarStatusInformacaoParticipantesProjeto(StatusInformacao.SELECAO);
                    btnParticipanteEditar.Enabled = false;
                    btnParticipanteExcluir.Enabled = false;
                    break;

                case StatusInformacao.SELECAO:

                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnAlterar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnInativar.Enabled = true;

                    txtCodigo.ReadOnly = true;
                    txtNome.ReadOnly = true;
                    txtDescricao.ReadOnly = true;

                    txtDataAlteracao.Visible = true;
                    lblDataAlteracao.Enabled = true;

                    cboGerenteProjeto.Enabled = false;
                    txtPrazoConclusao.ReadOnly = true;
                    txtInvestimentoPrevisto.ReadOnly = true;
                    cboApoioSteakholders.Enabled = false;
                    cboCapacidadeEntregaEquipe.Enabled = false;
                    cboApoioAltaGestao.Enabled = false;

                    rbEsforcoAdicionalAte10porCento.Enabled = false;
                    rbEsforcoAdicional11A20PorCento.Enabled = false;
                    rbEsforcoAdicional21A40PorCento.Enabled = false;
                    rbEsforcoAdicionalAcima40PorCento.Enabled = false;

                    MudarStatusInformacaoReceitasDespesasPrev(StatusInformacao.SELECAO);

                    MudarStatusInformacaoParticipantesProjeto(StatusInformacao.SELECAO);

                    break;
            }
        }

        private void MudarStatusInformacaoReceitasDespesasPrev(StatusInformacao statusInformacaoReceitasDespesasPrev)
        {
            this.statusInformacaoReceitasDespesasPrev = statusInformacaoReceitasDespesasPrev;

            switch (this.statusInformacaoReceitasDespesasPrev)
            {
                case StatusInformacao.INCLUSAO:
                    if (this.statusInformacao.Equals(StatusInformacao.INCLUSAO) || this.statusInformacao.Equals(StatusInformacao.ALTERACAO))
                    {
                        btnFluxoIncluir.Enabled = false;
                        btnFluxoEditar.Enabled = false;
                        btnFluxoExcluir.Enabled = false;
                        btnFluxoSalvar.Enabled = true;

                        dtpFluxoCaixaPeriodo.Enabled = true;
                        dtpFluxoCaixaPeriodo.Value = DateTime.Now;

                        cboFluxoTipo.Enabled = true;
                        txtFluxoValor.ReadOnly = false;
                        txtFluxoObservacoes.ReadOnly = false;
                    }

                    break;

                case StatusInformacao.ALTERACAO:
                    if (this.statusInformacao.Equals(StatusInformacao.INCLUSAO) || this.statusInformacao.Equals(StatusInformacao.ALTERACAO))
                    {
                        btnFluxoIncluir.Enabled = false;
                        btnFluxoEditar.Enabled = false;
                        btnFluxoExcluir.Enabled = false;
                        btnFluxoSalvar.Enabled = true;

                        dtpFluxoCaixaPeriodo.Enabled = true;

                        cboFluxoTipo.Enabled = true;
                        txtFluxoValor.ReadOnly = false;
                        txtFluxoObservacoes.ReadOnly = false;
                    }
                    break;

                case StatusInformacao.SELECAO:

                    if (this.statusInformacao.Equals(StatusInformacao.SELECAO))
                        btnFluxoIncluir.Enabled = false;
                    else
                        btnFluxoIncluir.Enabled = true;

                    btnFluxoEditar.Enabled = false;
                    btnFluxoExcluir.Enabled = false;
                    btnFluxoSalvar.Enabled = false;

                    dtpFluxoCaixaPeriodo.Enabled = false;

                    cboFluxoTipo.Enabled = false;
                    txtFluxoValor.ReadOnly = true;
                    txtFluxoObservacoes.ReadOnly = true;
                    break;
            }
        }

        private void MudarStatusInformacaoParticipantesProjeto(StatusInformacao statusInformacaoParticipantesProjeto)
        {
            this.statusInformacaoParticipantesProjeto = statusInformacaoParticipantesProjeto;

            switch (this.statusInformacaoParticipantesProjeto)
            {
                case StatusInformacao.INCLUSAO:
                    if (this.statusInformacao.Equals(StatusInformacao.INCLUSAO) || this.statusInformacao.Equals(StatusInformacao.ALTERACAO))
                    {

                        btnParticipanteIncluir.Enabled = false;
                        btnParticipanteEditar.Enabled = false;
                        btnParticipanteExcluir.Enabled = false;
                        btnParticipanteSalvar.Enabled = true;

                        dtpParticipantesIngresso.Enabled = true;
                        dtpParticipantesIngresso.Value = DateTime.Now;

                        cboParticipantesPessoas.Enabled = true;
                        txtParticipantesOcupacao.ReadOnly = false;
                        txtParticipantesObservacoes.ReadOnly = false;
                    }
                    break;
                case StatusInformacao.ALTERACAO:
                    if (this.statusInformacao.Equals(StatusInformacao.INCLUSAO) || this.Equals(StatusInformacao.ALTERACAO))
                    {
                        btnParticipanteIncluir.Enabled = false;
                        btnParticipanteEditar.Enabled = false;
                        btnParticipanteExcluir.Enabled = false;
                        btnParticipanteSalvar.Enabled = true;

                        dtpParticipantesIngresso.Enabled = true;

                        cboParticipantesPessoas.Enabled = true;
                        txtParticipantesOcupacao.ReadOnly = false;
                        txtParticipantesObservacoes.ReadOnly = false;
                    }
                    break;

                case StatusInformacao.SELECAO:

                    if (this.statusInformacao.Equals(StatusInformacao.SELECAO))
                        btnParticipanteIncluir.Enabled = false;
                    else
                        btnParticipanteIncluir.Enabled = true;

                    btnParticipanteEditar.Enabled = false;
                    btnParticipanteExcluir.Enabled = false;
                    btnParticipanteSalvar.Enabled = false;

                    dtpParticipantesIngresso.Enabled = true;

                    cboParticipantesPessoas.Enabled = false;
                    txtParticipantesOcupacao.ReadOnly = true;
                    txtParticipantesObservacoes.ReadOnly = true;
                    break;
                default:
                    break;
            }
        }

        private void CarregarInformacoes()
        {
            try
            {
                if (dtgPrincipal.SelectedRows.Count > 0)
                {
                    MudarStatusInformacao(StatusInformacao.SELECAO);

                    projetosRegraNegocio.Listar(Convert.ToInt64(dtgPrincipal.SelectedRows[0].Cells["dtgPrincipalTxtID"].Value));

                    txtCodigo.Text = projetosRegraNegocio.entidade.ID.ToString();
                    txtNome.Text = projetosRegraNegocio.entidade.NOME;
                    txtDescricao.Text = projetosRegraNegocio.entidade.DESCRICAO;
                    txtDataAlteracao.Text = projetosRegraNegocio.entidade.DATACRIACAO.ToString();

                    cboGerenteProjeto.DataSource = pessoaRegraNegocio.Listar();
                    cboGerenteProjeto.SelectedValue = projetosRegraNegocio.entidade.GERENTEPROJETO.ID;

                    txtPrazoConclusao.Text = projetosRegraNegocio.entidade.TEMPOPREVISTOCONCLUSAO.ToString();
                    txtInvestimentoPrevisto.Text = projetosRegraNegocio.entidade.INVESTIMENTOPREVISTO.ToString();

                    cboApoioAltaGestao.SelectedIndex = Convert.ToInt32(projetosRegraNegocio.entidade.APOIOALTAGESTAO) - 1;
                    cboApoioSteakholders.SelectedIndex = Convert.ToInt32(projetosRegraNegocio.entidade.APOIOSTEAKHOLDERS) - 1;
                    cboCapacidadeEntregaEquipe.SelectedIndex = Convert.ToInt32(projetosRegraNegocio.entidade.CAPACIDADEENTREGAEQUIPE) - 1;

                    if (projetosRegraNegocio.entidade.STATUS >= 1)
                        btnInativar.Image = projProjetos.Properties.Resources.inativar;
                    else
                        btnInativar.Image = projProjetos.Properties.Resources.ativar;


                    switch (projetosRegraNegocio.entidade.ESFORCOADICIONAL)
                    {
                        case 1:
                            rbEsforcoAdicionalAte10porCento.Checked = true;
                            break;
                        case 2:
                            rbEsforcoAdicional11A20PorCento.Checked = true;
                            break;
                        case 3:
                            rbEsforcoAdicional21A40PorCento.Checked = true;
                            break;
                        case 4:
                            rbEsforcoAdicionalAcima40PorCento.Checked = true;
                            break;
                    }

                    txtDescricao.Text = projetosRegraNegocio.entidade.DESCRICAO.ToString();

                    CarregarInformacoesGeraisReceitasDespesasVar(true);

                    CarregarInformacoesGeraisParticipantesProjeto(true);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarInformacoesReceitasDespesasPrevistas()
        {
            try
            {
                if (dtgFluxoCaixaProjeto.SelectedRows.Count > 0)
                {
                    projetosRegraNegocio.ListarReceitasDespesas(Convert.ToDateTime(dtgFluxoCaixaProjeto.SelectedRows[0].Cells["dtgFluxoCaixaProjetoTxtDataPeriodo"].Value));

                    dtpFluxoCaixaPeriodo.Value = projetosRegraNegocio.receitaDespesa.DATAPERIODO;
                    cboFluxoTipo.SelectedItem = projetosRegraNegocio.receitaDespesa.TIPO.ToString();
                    txtFluxoObservacoes.Text = projetosRegraNegocio.receitaDespesa.OBSERVACOES;
                    txtFluxoValor.Text = projetosRegraNegocio.receitaDespesa.VALOR.ToString();

                    if (!this.statusInformacao.Equals(StatusInformacao.SELECAO) && this.statusInformacaoReceitasDespesasPrev.Equals(StatusInformacao.SELECAO))
                    {
                        btnFluxoEditar.Enabled = true;
                        btnFluxoExcluir.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarInformacoesParticipantesProjetos()
        {
            try
            {
                if (dtgParticipantes.SelectedRows.Count > 0)
                {
                    projetosRegraNegocio.ListarParticipantesProjetos(Convert.ToInt64(dtgParticipantes.SelectedRows[0].Cells["dtgParticipantesTxtProjetosPessoasID"].Value));

                    cboParticipantesPessoas.DataSource = projetosRegraNegocio.ListarParticipantesProjetos();
                    cboParticipantesPessoas.SelectedValue = projetosRegraNegocio.participanteProjeto.IDPESSOA;

                    txtParticipantesOcupacao.Text = projetosRegraNegocio.participanteProjeto.OCUPACAO;
                    txtParticipantesObservacoes.Text = projetosRegraNegocio.participanteProjeto.OBSERVACOES;
                    dtpParticipantesIngresso.Value = Convert.ToDateTime(projetosRegraNegocio.participanteProjeto.DATAINGRESSO);

                    if (!this.statusInformacao.Equals(StatusInformacao.SELECAO) && this.statusInformacaoParticipantesProjeto.Equals(StatusInformacao.SELECAO))
                    {
                        btnParticipanteEditar.Enabled = true;
                        btnParticipanteExcluir.Enabled = true;
                    }

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
                dtgPrincipal.DataSource = projetosRegraNegocio.Listar();
                dtgPrincipal.Columns["dtgPrincipalBtnInativar"].DisplayIndex = 13;
                dtgPrincipal.Columns["dtgPrincipalBtnEditar"].DisplayIndex = 12;


                if (dtgPrincipal.Rows.Count > 0)
                {
                    foreach (DataGridViewRow linha in dtgPrincipal.Rows)
                    {
                        if (linha.Cells["dtgPrincipalTxtStatus"].Value.ToString().Equals("ATIVO"))
                            linha.Cells["dtgPrincipalBtnInativar"].Value = projProjetos.Properties.Resources.excluir;
                        else
                            linha.Cells["dtgPrincipalBtnInativar"].Value = projProjetos.Properties.Resources.miniAtivar;
                    }

                    dtgPrincipal.Rows[dtgPrincipal.Rows.Count - 1].Selected = true;

                    CarregarInformacoes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarInformacoesGeraisReceitasDespesasVar(bool selecionarRegistroAutomaticamente)
        {
            try
            {
                MudarStatusInformacaoReceitasDespesasPrev(StatusInformacao.SELECAO);
                dtgFluxoCaixaProjeto.DataSource = projetosRegraNegocio.ListarReceitasDespesas();

                if (dtgFluxoCaixaProjeto.Rows.Count > 0)
                {
                    dtgFluxoCaixaProjeto.Rows[dtgFluxoCaixaProjeto.Rows.Count - 1].Selected = true;
                    dtgFluxoCaixaProjeto.Columns["dtgFluxoCaixaProjetoBtnExcluir"].DisplayIndex = 7;
                    dtgFluxoCaixaProjeto.Columns["dtgFluxoCaixaProjetoBtnEditar"].DisplayIndex = 6;
                    dtgFluxoCaixaProjeto.Columns["dtgFluxoCaixaProjetoTxtValor"].DisplayIndex = 5;

                    if (selecionarRegistroAutomaticamente) //carrega automaticamente o registro a sofrer alterações
                        CarregarInformacoesReceitasDespesasPrevistas();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CarregarInformacoesGeraisParticipantesProjeto(bool selecionarRegistroAutomaticamente)
        {
            try
            {
                MudarStatusInformacaoParticipantesProjeto(StatusInformacao.SELECAO);

                cboParticipantesPessoas.DataSource = pessoaRegraNegocio.Listar();
                cboParticipantesPessoas.SelectedItem = null;

                dtgParticipantes.DataSource = projetosRegraNegocio.ListarParticipantesProjetos();

                if (dtgParticipantes.Rows.Count > 0)
                {
                    dtgParticipantes.Rows[dtgParticipantes.Rows.Count - 1].Selected = true;
                    dtgParticipantes.Columns["dtgParticipantesBtnExcluir"].DisplayIndex = 9;
                    dtgParticipantes.Columns["dtgParticipantesBtnEditar"].DisplayIndex = 8;

                    if (selecionarRegistroAutomaticamente) //carrega automaticamente o registro a sofrer alterações
                        CarregarInformacoesParticipantesProjetos();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();

            cboGerenteProjeto.SelectedItem = null;

            txtPrazoConclusao.Clear();
            txtInvestimentoPrevisto.Clear();

            cboApoioAltaGestao.SelectedIndex = -1;
            cboApoioSteakholders.SelectedIndex = -1;
            cboCapacidadeEntregaEquipe.SelectedIndex = -1;

            rbEsforcoAdicionalAte10porCento.Checked = false;
            rbEsforcoAdicional11A20PorCento.Checked = false;
            rbEsforcoAdicional21A40PorCento.Checked = false;
            rbEsforcoAdicionalAcima40PorCento.Checked = false;

            txtDescricao.Clear();

            txtDataAlteracao.Clear();

            LimparCamposReceitasDespesas();
            LimparCamposParticipantesProjetos();
        }

        private void LimparCamposReceitasDespesas()
        {
            dtpFluxoCaixaPeriodo.Value = DateTime.Now;
            cboFluxoTipo.SelectedValue = null;
            txtFluxoObservacoes.Clear();
            txtFluxoValor.Clear();

            CarregarInformacoesGeraisReceitasDespesasVar(false);
        }

        private void LimparCamposParticipantesProjetos()
        {
            cboParticipantesPessoas.SelectedItem = null;
            txtParticipantesOcupacao.Clear();
            txtParticipantesObservacoes.Clear();
            dtpParticipantesIngresso.Value = DateTime.Now;

            CarregarInformacoesGeraisParticipantesProjeto(false);
        }

        private bool ValidarInformacoes()
        {
            if (txtNome.Text.Trim().Length < 5)
            {
                MessageBox.Show("O campo \"Nome\" Não atende o tamanho minimo ou contem apenas espaços em branco.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return false;
            }

            if (cboGerenteProjeto.SelectedIndex < 0)
            {
                MessageBox.Show("A caixa de seleção \"Gerente do Projeto\" não poderá estar vazia.", "Informação.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboGerenteProjeto.Focus();
                return false;
            }

            try
            {
                Convert.ToDouble(txtPrazoConclusao.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("O campo \"Prazo de Conclusão\" contem valores invalidos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrazoConclusao.Focus();
                return false;
            }

            try
            {
                Convert.ToDouble(txtInvestimentoPrevisto.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("O campo \"Investimento Previsto\" contem valores invalidos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInvestimentoPrevisto.Focus();
                return false;
            }

            if (cboApoioAltaGestao.SelectedIndex < 0)
            {
                MessageBox.Show("A caixa de seleção \"Apoio da Alta Gestão\" não pode estar vazia.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboApoioAltaGestao.Focus();
                return false;
            }

            if (cboApoioSteakholders.SelectedIndex < 0)
            {
                MessageBox.Show("A caixa de seleção \"Apoio SteakHolders\" não pode estar vazia.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboApoioAltaGestao.Focus();
                return false;
            }

            if (cboCapacidadeEntregaEquipe.SelectedIndex < 0)
            {
                MessageBox.Show("A caixa de seleção \"Capacidade de Entrega Equipe\" não pode estar vazia.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboApoioAltaGestao.Focus();
                return false;
            }

            if (!rbEsforcoAdicionalAte10porCento.Checked && !rbEsforcoAdicional11A20PorCento.Checked
                && !rbEsforcoAdicional21A40PorCento.Checked && !rbEsforcoAdicionalAcima40PorCento.Checked)
            {
                MessageBox.Show("Dese ser escolhido uma opção para a informação do \"Esforço Adicional\".", "informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rbEsforcoAdicionalAte10porCento.Focus();
                return false;
            }

            if (txtDescricao.Text.Trim().Length < 5)
            {
                MessageBox.Show("O campo \"Observações\" não contem a quantidade de caracteres mínima ou contem apenas espaçõs em branco.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricao.Focus();
                return false;
            }

            if (dtgFluxoCaixaProjeto.Rows.Count <= 0)
            {
                MessageBox.Show("O projeto não pode ser salvo sem fluxo de Receitas-Despesas.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbFluxoDeCaixa.Focus();
                return false;
            }

            if (dtgParticipantes.Rows.Count <= 0)
            {
                MessageBox.Show("O projeto não pode ser salvo sem Participantes cadastrados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbParticipantes.Focus();
                return false;
            }

            return true;
        }

        private bool ValidarInformacoesReceitasDespesas()
        {
            if (cboFluxoTipo.SelectedIndex < 0)
            {
                MessageBox.Show("O campo \"Fluxo Despesas-Receitas Tipo\" não pode ser vazio.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboFluxoTipo.Focus();
                return false;
            }

            try
            {
                Convert.ToDouble(txtFluxoValor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("O campo \"Fluxo Despesas-Receitas Valor\" contem valores invalidos", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFluxoValor.Focus();
                return false;
            }

            if (txtFluxoObservacoes.Text.Trim().Length < 5)
            {
                MessageBox.Show("O campo \"Fluxo Despesas-Receitas Observações\" não contem a quantidade de caracteres mínimas ou contem apenas espaços em branco.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFluxoObservacoes.Focus();
                return false;
            }

            return true;
        }

        private bool ValidarInformacoesParticipantesProjetos()
        {
            if (cboParticipantesPessoas.SelectedIndex < 0)
            {
                MessageBox.Show("O campo \"Participantes pessoa\" não pode ser vazio.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboParticipantesPessoas.Focus();
                return false;
            }

            if (txtParticipantesOcupacao.Text.Trim().Length < 5)
            {
                MessageBox.Show("O campo \"Participantes ocupação\" não contem a quantidade de caracteres mínima ou contem apenas espaços em branco.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtParticipantesOcupacao.Focus();
                return false;
            }

            if (txtParticipantesObservacoes.Text.Trim().Length < 5)
            {
                MessageBox.Show("O campo \"Participantes Observação\" não contem a quantidade de caracteres mínima ou contem apenas espaços em branco.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtParticipantesOcupacao.Focus();
                return false;
            }

            return true;
        }

        private void EnviarInformacoesObjeto()
        {
            try
            {
                projetosRegraNegocio.entidade.NOME = txtNome.Text;
                projetosRegraNegocio.entidade.GERENTE = Convert.ToInt64(cboGerenteProjeto.SelectedValue);
                projetosRegraNegocio.entidade.TEMPOPREVISTOCONCLUSAO = Convert.ToDecimal(txtPrazoConclusao.Text);
                projetosRegraNegocio.entidade.INVESTIMENTOPREVISTO = Convert.ToDecimal(txtInvestimentoPrevisto.Text);

                projetosRegraNegocio.entidade.APOIOALTAGESTAO = cboApoioAltaGestao.SelectedIndex + 1;
                projetosRegraNegocio.entidade.APOIOSTEAKHOLDERS = cboApoioSteakholders.SelectedIndex + 1;
                projetosRegraNegocio.entidade.CAPACIDADEENTREGAEQUIPE = cboCapacidadeEntregaEquipe.SelectedIndex + 1;

                projetosRegraNegocio.entidade.DESCRICAO = txtDescricao.Text;
                projetosRegraNegocio.entidade.OBSERVACAO = txtDescricao.Text;

                if (rbEsforcoAdicionalAte10porCento.Checked)
                    projetosRegraNegocio.entidade.ESFORCOADICIONAL = 1;

                else if (rbEsforcoAdicional11A20PorCento.Checked)
                    projetosRegraNegocio.entidade.ESFORCOADICIONAL = 2;

                else if (rbEsforcoAdicional21A40PorCento.Checked)
                    projetosRegraNegocio.entidade.ESFORCOADICIONAL = 3;

                else if (rbEsforcoAdicionalAcima40PorCento.Checked)
                    projetosRegraNegocio.entidade.ESFORCOADICIONAL = 4;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnviarInformacoesObjetoReceitaDespesa()
        {
            projetosRegraNegocio.receitaDespesa.DATAPERIODO = dtpFluxoCaixaPeriodo.Value;
            projetosRegraNegocio.receitaDespesa.TIPO = cboFluxoTipo.SelectedItem.ToString();
            projetosRegraNegocio.receitaDespesa.VALOR = Convert.ToDecimal(txtFluxoValor.Text);
            projetosRegraNegocio.receitaDespesa.OBSERVACOES = txtFluxoObservacoes.Text;
        }

        private void EnviarInformacoesObjetoParticipantesProjeto()
        {
            projetosRegraNegocio.participanteProjeto.IDPESSOA = Convert.ToInt64(cboParticipantesPessoas.SelectedValue);
            projetosRegraNegocio.participanteProjeto.OCUPACAO = txtParticipantesOcupacao.Text;
            projetosRegraNegocio.participanteProjeto.OBSERVACOES = txtParticipantesObservacoes.Text;
            projetosRegraNegocio.participanteProjeto.DATAINGRESSO = dtpParticipantesIngresso.Value;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                projetosRegraNegocio.Incluir();
                LimparCampos();
                MudarStatusInformacao(StatusInformacao.INCLUSAO);
                txtCodigo.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    projetosRegraNegocio.Salvar();

                    CarregarInformacoesGerais();
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
                if (dtgPrincipal.SelectedRows.Count > 0)
                {
                    switch (dtgPrincipal.Columns[e.ColumnIndex].Name)
                    {
                        case "dtgPrincipalBtnEditar":
                            btnAlterar_Click(btnAlterar, new EventArgs());
                            break;

                        case "dtgPrincipalBtnInativar":
                            btnInativar_Click(btnInativar, new EventArgs());
                            break;
                        default:
                            MudarStatusInformacao(StatusInformacao.SELECAO);
                            CarregarInformacoes();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            CarregarInformacoes();
            MudarStatusInformacao(StatusInformacao.SELECAO);

            if (!(MessageBox.Show(String.Format("Deseja realmente {0} o cadastro \n" +
                                               "ID: {1} \n" +
                                               "Nome: {2} ?", (projetosRegraNegocio.entidade.STATUS >= (byte)1) ? ("INATIVAR") : ("ATIVAR"),
                                               projetosRegraNegocio.entidade.ID, projetosRegraNegocio.entidade.NOME), "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                return;
            }

            projetosRegraNegocio.MudarStatus();
            CarregarInformacoesGerais();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dtgPrincipal.SelectedRows.Count > 0)
            {
                CarregarInformacoes();
                MudarStatusInformacao(StatusInformacao.ALTERACAO);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(String.Format("Deseja realmente cancelar a {0} das informações?", (statusInformacao.Equals(StatusInformacao.INCLUSAO) ? ("INCLUSÃO") : ("ALTERAÇÃO"))), "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                CarregarInformacoesGerais();
        }

        private void dtgFluxoCaixaProjeto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgFluxoCaixaProjeto.SelectedRows.Count > 0)
            {
                switch (dtgFluxoCaixaProjeto.Columns[e.ColumnIndex].Name)
                {
                    case "dtgFluxoCaixaProjetoBtnEditar":
                        btnFluxoEditar_Click(btnFluxoEditar, new EventArgs());
                        break;

                    case "dtgFluxoCaixaProjetoBtnExcluir":
                        btnFluxoExcluir_Click(btnFluxoExcluir, new EventArgs());
                        break;
                    default:
                        MudarStatusInformacaoReceitasDespesasPrev(StatusInformacao.SELECAO);
                        CarregarInformacoesReceitasDespesasPrevistas();
                        break;
                }
            }
        }

        private void btnFluxoIncluir_Click(object sender, EventArgs e)
        {
            projetosRegraNegocio.IncluirReceitaDespesaVariavel();
            LimparCamposReceitasDespesas();
            MudarStatusInformacaoReceitasDespesasPrev(StatusInformacao.INCLUSAO);
        }

        private void btnFluxoEditar_Click(object sender, EventArgs e)
        {
            CarregarInformacoesReceitasDespesasPrevistas();
            MudarStatusInformacaoReceitasDespesasPrev(StatusInformacao.ALTERACAO);
        }

        private void btnParticipanteIncluir_Click(object sender, EventArgs e)
        {
            projetosRegraNegocio.IncluirParticipanteProjeto();
            LimparCamposParticipantesProjetos();
            MudarStatusInformacaoParticipantesProjeto(StatusInformacao.INCLUSAO);
        }

        private void btnParticipanteEditar_Click(object sender, EventArgs e)
        {
            CarregarInformacoesParticipantesProjetos();
            MudarStatusInformacaoParticipantesProjeto(StatusInformacao.ALTERACAO);
        }

        private void btnFluxoSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarInformacoesReceitasDespesas())
            {
                EnviarInformacoesObjetoReceitaDespesa();
                projetosRegraNegocio.SalvarReceitaDespesaVariavel();
                CarregarInformacoesGeraisReceitasDespesasVar(true);
            }
        }

        private void frmProjetos_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarInformacoesGerais();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFluxoExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarInformacoesReceitasDespesasPrevistas();

                if (MessageBox.Show(String.Format("Deseja realmente excluir a {0} selecionada com a data de {1}?", projetosRegraNegocio.receitaDespesa.TIPO, projetosRegraNegocio.receitaDespesa.DATAPERIODO.ToShortDateString()), "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    projetosRegraNegocio.ExcluirReceitaDespesaVariavel();

                CarregarInformacoesGeraisReceitasDespesasVar(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnParticipanteSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarInformacoesParticipantesProjetos())
            {
                EnviarInformacoesObjetoParticipantesProjeto();
                projetosRegraNegocio.SalvarParticipanteProjeto();
                CarregarInformacoesGeraisParticipantesProjeto(true);
            }
        }

        private void dtgFluxoCaixaProjeto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgParticipantes.SelectedRows.Count > 0)
            {
                switch (dtgParticipantes.Columns[e.ColumnIndex].Name)
                {
                    case "dtgParticipantesBtnEditar":
                        btnParticipanteEditar_Click(btnParticipanteEditar, new EventArgs());
                        break;

                    case "dtgParticipantesBtnExcluir":
                        btnParticipanteExcluir_Click(btnParticipanteExcluir, new EventArgs());
                        break;
                    default:
                        MudarStatusInformacaoParticipantesProjeto(StatusInformacao.SELECAO);
                        CarregarInformacoesParticipantesProjetos();
                        break;
                }
            }
        }

        private void btnParticipanteExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarInformacoesParticipantesProjetos();

                if (MessageBox.Show("Deseja realmente excluir o Participante selecionado?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    projetosRegraNegocio.ExcluirParticipanteProjeto();

                CarregarInformacoesGeraisParticipantesProjeto(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public enum StatusInformacao
    {
        INCLUSAO = 0,
        ALTERACAO = 1,
        SELECAO = 2,

        EFETIVACAO = 3,
        CANCELAMENTO = 4

    }

    /* alta probalideade de sucesso de 7 a 14
 * 15 a 17 - sucesso preocupante
 * acima de 17 - probabilidade de insucesso 
 */

    /* de 0 a 99 meses */ /*integers */

    /* VALIDAÇÃO 
     * 1 E 2 MESES = 1.
     * ENTRE 3 E 4 = 2
     * ENTRE 5 A 8 = 3
     * > 8 = 4 */


    /*EQUAÇÃO:  DICE = D + (2 * I) + (2 * C1) + C2 + E;
     * 
     * {
     *  D = DURAÇÃO;
     *  E = ESFORÇO ADICIONAL;
     *  I = CAPACIDADE DE ENTREGA;
     *  C1 = APOIO DA ALTA GESTÃO;
     *  C2 = APOIO DOS STEAKEHOLDERS.
     * }
     * */
}
