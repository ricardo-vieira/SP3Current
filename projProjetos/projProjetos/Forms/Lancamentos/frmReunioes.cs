using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Equin.ApplicationFramework;

namespace projProjetos.Forms
{
    public partial class frmReunioes : Form
    {

        RegraNegocio.Reunioes reunioesRegraNegocio = new RegraNegocio.Reunioes();
        RegraNegocio.Projetos projetosRegraNegocio = new RegraNegocio.Projetos();
        RegraNegocio.Pessoas pessoasRegraNegocio = new RegraNegocio.Pessoas();
        RegraNegocio.PautaProjetos pautaProjetosRegraNegocio = new RegraNegocio.PautaProjetos();

        StatusInformacao _statusInformacao = StatusInformacao.SELECAO;
        StatusInformacao _statusInformacaoPautaProjeto = StatusInformacao.SELECAO;

        BindingListView<RegraNegocio.View.Reunioes.ViewReuniao> _bindingListView;
        BindingListView<RegraNegocio.View.Projetos.ViewProjeto> _bindingListViewProjetos;
        BindingListView<RegraNegocio.View.Pessoas.ViewPessoa> _bindingListViewPessoa;
        BindingListView<RegraNegocio.View.Projetos.ViewPautaProjeto> _bindingListViewPautaProjetos;

        RegraNegocio.View.Reunioes.ViewReuniao _currentObject;
        RegraNegocio.View.Projetos.ViewPautaProjeto _currentObjectPautaProjeto;

        RegraNegocio.View.Pessoas.ViewPessoa _objectPesquisaResponsavel;
        RegraNegocio.View.Projetos.ViewPautaProjeto _objectPesquisaPautaProjetoProjeto;

        public frmReunioes()
        {
            InitializeComponent();
        }

        private void MudarStatusInformacao(StatusInformacao statusInformacao)
        {
            this._statusInformacao = statusInformacao;

            switch (statusInformacao)
            {
                case StatusInformacao.INCLUSAO:
                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnPesquisar.Enabled = false;

                    txtDescricao.Enabled = true;
                    dtpDataHoraEvento.Enabled = true;
                    txtLocal.Enabled = true;
                    txtPayBackAceitavel.Enabled = true;
                    txtTIR.Enabled = true;
                    txtTaxaCustoCapital.Enabled = true;
                    txtDescricaoPauta.Enabled = true;
                    btnPesquisaResponsavel.Enabled = true;
                    break;

                case StatusInformacao.ALTERACAO:
                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnPesquisar.Enabled = false;


                    txtDescricao.Enabled = true;
                    dtpDataHoraEvento.Enabled = true;
                    txtLocal.Enabled = true;
                    txtPayBackAceitavel.Enabled = true;
                    txtTIR.Enabled = true;
                    txtTaxaCustoCapital.Enabled = true;
                    txtDescricaoPauta.Enabled = true;
                    btnPesquisaResponsavel.Enabled = true;
                    break;

                case StatusInformacao.SELECAO:
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnAlterar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnPesquisar.Enabled = true;

                    txtDescricao.Enabled = true;
                    dtpDataHoraEvento.Enabled = true;
                    txtLocal.Enabled = true;
                    txtPayBackAceitavel.Enabled = true;
                    txtTIR.Enabled = true;
                    txtTaxaCustoCapital.Enabled = true;
                    txtDescricaoPauta.Enabled = true;
                    btnPesquisaResponsavel.Enabled = false;
                    break;

                case StatusInformacao.SEMACAO:
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnPesquisar.Enabled = true;

                    txtDescricao.ReadOnly = true;
                    dtpDataHoraEvento.Enabled = false;
                    txtLocal.ReadOnly = true;
                    txtPayBackAceitavel.ReadOnly = true;
                    txtTIR.ReadOnly = true;
                    txtTaxaCustoCapital.ReadOnly = true;
                    txtDescricaoPauta.ReadOnly = true;
                    btnPesquisaResponsavel.Enabled = false;
                    break;
            }
        }

        private void MudarStatusInformacaoPautaProjeto(StatusInformacao statusInformacao)
        {
            this._statusInformacaoPautaProjeto = statusInformacao;

            switch (statusInformacao)
            {
                case StatusInformacao.INCLUSAO:
                    btnPautaIncluir.Enabled = false;
                    btnPautaExcluir.Enabled = false;
                    btnPautaEditar.Enabled = false;

                    btnPautaSalvar.Enabled = true;
                    btnPautaCancelar.Enabled = true;

                    btnPesquisarPautaProjeto.Enabled = true;

                    dtgPautaProjetos.Enabled = false;
                    break;
                case StatusInformacao.ALTERACAO:
                    btnPautaIncluir.Enabled = false;
                    btnPautaExcluir.Enabled = false;
                    btnPautaEditar.Enabled = false;

                    btnPautaSalvar.Enabled = true;
                    btnPautaCancelar.Enabled = true;

                    btnPesquisarPautaProjeto.Enabled = true;

                    dtgPautaProjetos.Enabled = false;
                    break;
                case StatusInformacao.SELECAO:
                    btnPautaIncluir.Enabled = true;
                    btnPautaExcluir.Enabled = true;
                    btnPautaEditar.Enabled = true;

                    btnPautaSalvar.Enabled = false;
                    btnPautaCancelar.Enabled = false;

                    btnPesquisarPautaProjeto.Enabled = false;

                    dtgPautaProjetos.Enabled = true;
                    break;
                case StatusInformacao.SEMACAO:
                    btnPautaIncluir.Enabled = false;
                    btnPautaExcluir.Enabled = false;
                    btnPautaEditar.Enabled = false;

                    btnPautaSalvar.Enabled = false;
                    btnPautaCancelar.Enabled = false;

                    btnPesquisarPautaProjeto.Enabled = false;

                    dtgPautaProjetos.Enabled = false;
                    break;

            }
        }

        private void CarregarInformacoesGerais()
        {
            try
            {
                ///caso o bindinglist estiver vazio, recebera uma nova instancia
                if (_bindingListView is null)
                {
                    _bindingListView = new BindingListView<RegraNegocio.View.Reunioes.ViewReuniao>(reunioesRegraNegocio.ToList());
                    _bindingSource.DataSource = _bindingListView;
                }
                else
                {
                    _bindingListView.RemoveFilter();
                    _bindingListView.DataSource = projetosRegraNegocio.ToList();
                    _bindingListView.Refresh();
                }



                if ((_currentObject is null) && !(_bindingSource.Current is null))
                {
                    _currentObject = (_bindingSource.Current as ObjectView<RegraNegocio.View.Reunioes.ViewReuniao>).Object;
                }

                RegraNegocio.View.Reunioes.ViewReuniao _bindingSourceCurrentObject = (_bindingSource.Current is null) ? (null) : (_bindingSource.Current as ObjectView<RegraNegocio.View.Reunioes.ViewReuniao>).Object;

                if (!(_currentObject is null) && (_bindingSourceCurrentObject is null || _bindingSourceCurrentObject != _currentObject || _bindingSource.Count > 1))
                {
                    _bindingListView.ApplyFilter(x => x.EntityObject.Equals(_currentObject.EntityObject));
                    MudarStatusInformacao(StatusInformacao.SELECAO);
                }
                else
                {
                    MudarStatusInformacao(StatusInformacao.SEMACAO);
                }

                _bindingListView.Refresh();

                _bindingSource.ResumeBinding();

                CarregarInformacoes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarInformacoesGeraisProjetoReceitaVariavel()
        {
            try
            {
                ///caso o bindinglist estiver vazio, recebera uma nova instancia
                if (_bindingListViewPautaProjetos is null)
                {
                    _bindingListViewPautaProjetos = new BindingListView<RegraNegocio.View.Projetos.ViewPautaProjeto>(pautaProjetosRegraNegocio.ToList());
                    _bindingSourcePauta.DataSource = _bindingListViewPautaProjetos;
                }
                else
                {
                    _bindingListViewPautaProjetos.RemoveFilter();
                    _bindingListViewPautaProjetos.DataSource = pautaProjetosRegraNegocio.ToList();
                    _bindingListViewPautaProjetos.Refresh();
                }

                _bindingListViewPautaProjetos.ApplyFilter(x => x.EntityObject.REUNIO == _currentObject.EntityObject);
                _bindingListViewPautaProjetos.Refresh();


                RegraNegocio.View.Projetos.ViewPautaProjeto _bindingSourcePautaProjetosCurrentObject = (_bindingSourcePauta.Current is null) ? (null) : (_bindingSourcePauta.Current as ObjectView<RegraNegocio.View.Projetos.ViewPautaProjeto>).Object;

                if (!(_currentObjectPautaProjeto is null) && (_bindingSourcePautaProjetosCurrentObject is null || _bindingSourcePautaProjetosCurrentObject.EntityObject != _currentObjectPautaProjeto.EntityObject))
                {
                    //identifica a linha que contem o currentObjectProjetoReceitaVariavel na propriedade databounditem e atribui true a propriedade selected
                    IEnumerable<DataGridViewRow> dtgReceitaVariavelRowsEnumerable = System.Linq.Enumerable.Cast<DataGridViewRow>(dtgPautaProjetos.Rows);

                    DataGridViewRow dataRow = new List<DataGridViewRow>(dtgReceitaVariavelRowsEnumerable).First(row => (row.DataBoundItem as ObjectView<RegraNegocio.View.Projetos.ViewPautaProjeto>).Object.EntityObject == _currentObjectPautaProjeto.EntityObject);

                    dataRow.Selected = true;


                }

                if (_statusInformacao == StatusInformacao.SELECAO)
                    MudarStatusInformacaoPautaProjeto(StatusInformacao.SEMACAO);
                else
                    MudarStatusInformacaoPautaProjeto(StatusInformacao.SELECAO);

                _bindingSourcePauta.ResumeBinding();

                CarregarInformacoesPautaProjeto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarInformacoes()
        {
            /* try
            {
                /*if (!(_currentObject is null))
                {
                    if (_currentObject.EntityObject.STATUS >= (byte)1)
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
            } */
        }

        /* ------------------------------------------------------------- */

        /*private void MudarStatusInformacao(StatusInformacao statusInformacao)
        {
            this._statusInformacao = statusInformacao;

            switch (this._statusInformacao)
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


                    if (reunioesRegraNegocio.entidade.SITUACAO.Equals("EM OPERAÇÃO"))
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
                        MessageBox.Show(String.Format("Não é possivel alterar esta reunião, pois a mesma está {0}", reunioesRegraNegocio.entidade.SITUACAO), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        } */

        /* private void MudarStatusInformacaoPautaProjeto(StatusInformacao statusInformacaoPautaProjeto)
        {
            this._statusInformacaoPautaProjeto = statusInformacaoPautaProjeto;

            switch (this._statusInformacaoPautaProjeto)
            {
                case StatusInformacao.INCLUSAO:
                    if (this._statusInformacao.Equals(StatusInformacao.INCLUSAO) || this._statusInformacao.Equals(StatusInformacao.ALTERACAO))
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
                    if (this._statusInformacao.Equals(StatusInformacao.INCLUSAO) || this._statusInformacao.Equals(StatusInformacao.ALTERACAO))
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
        } */

        /* private void CarregarInformacoes()
        {
            try
            {
                tbcReunioes.SelectTab(tbpPrincipal);

                if (dtgPrincipal.SelectedRows.Count > 0)
                {
                    MudarStatusInformacao(StatusInformacao.SELECAO);
                    //reuniaoRegraNegocio.Listar(Convert.ToInt64(dtgPrincipal.SelectedRows[0].Cells["dtgPrincipalTxtId"].Value));

                    txtCodigo.Text = reunioesRegraNegocio.entidade.ID.ToString();
                    txtDescricao.Text = reunioesRegraNegocio.entidade.DESCRICAO.ToString();
                    txtSituacao.Text = reunioesRegraNegocio.entidade.SITUACAO;
                    txtLocal.Text = reunioesRegraNegocio.entidade.LOCAL.ToString();
                    dtpDataHoraEvento.Value = Convert.ToDateTime(reunioesRegraNegocio.entidade.DATAHORAEVENTO);
                    txtDescricaoPauta.Text = reunioesRegraNegocio.entidade.PAUTADESCRICAO;

                    txtPayBackAceitavel.Text = String.Format("{0:0.00}",reunioesRegraNegocio.entidade.PAYBACKACEITAVEL);
                    txtTIR.Text = String.Format("{0:0.00}", reunioesRegraNegocio.entidade.TAXAREMUNERACAOMERCADO);
                    txtTaxaCustoCapital.Text = String.Format("{0:0.00}", reunioesRegraNegocio.entidade.TAXACUSTOCAPITAL);

                    txtDataHoraInclusao.Text = reunioesRegraNegocio.entidade.DATACRIACAO.ToString();

                    cboResponsavel.DataSource = pessoasRegraNegocio.ToList();
                    cboResponsavel.SelectedValue = reunioesRegraNegocio.entidade.RESPONSAVEL;

                    CarregarInformacoesGeraisPautaProjetos(true);
                    CarregarInformaoesGeraisRankProjetos();

                    switch (reunioesRegraNegocio.entidade.SITUACAO)
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
        } */

        private void CarregarInformacoesPautaProjeto()
        {
            try
            {
                if (dtgPautaProjetos.SelectedRows.Count > 0)
                {
                    if (Convert.ToInt64(dtgPautaProjetos.SelectedRows[0].Cells["dtgPautaProjetosTxtIdPautaProjeto"].Value) == 0)
                        reunioesRegraNegocio.ListarPautaProjetoSemId(Convert.ToInt64(dtgPautaProjetos.SelectedRows[0].Cells["dtgPautaProjetosTxtIdProjeto"].Value));

                    else
                        reunioesRegraNegocio.ListarPautaProjetos(Convert.ToInt64(dtgPautaProjetos.SelectedRows[0].Cells["dtgPautaProjetosTxtIdPautaProjeto"].Value));

                    //cboPautaProjeto.DataSource = projetosRegraNegocio.ToList();
                    //cboPautaProjeto.SelectedValue = reunioesRegraNegocio.pautaProjeto.IDPROJETO;

                    //projetoRegraNegocio.ToList(reuniaoRegraNegocio.pautaProjeto.IDPROJETO);

                    //txtPautaGerente.Text = projetoRegraNegocio.entidade.GERENTEPROJETO.NOME;
                    txtPautaInvestimentoPrevisto.Text = String.Format("R$ {0:0.00}", reunioesRegraNegocio.pautaProjeto.INVESTIMENTOPREVISTO);
                    txtPautaTempoConclusao.Text = reunioesRegraNegocio.pautaProjeto.TEMPOPREVISTOCONCLUSAO.ToString();

                    if (!this._statusInformacao.Equals(StatusInformacao.SELECAO) && this._statusInformacaoPautaProjeto.Equals(StatusInformacao.SELECAO))
                        btnPautaExcluir.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* private void CarregarInformacoesGerais()
        {
            try
            {

                dtgPrincipal.DataSource = reunioesRegraNegocio.ToList();
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
        } */

        private void CarregarInformacoesGeraisPautaProjetos(bool selecionarRegistroAutomaticamente)
        {
            try
            {
                MudarStatusInformacaoPautaProjeto(StatusInformacao.SELECAO);
                dtgPautaProjetos.DataSource = reunioesRegraNegocio.ListarPautaProjeto();

                if (reunioesRegraNegocio.entidade.AHPCALCULADO != null && reunioesRegraNegocio.entidade.AHPCALCULADO >= 1)
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
                dtgRankProjetos.DataSource = reunioesRegraNegocio.ListarProjetosCalculados();

                if (reunioesRegraNegocio.entidade.SITUACAO.Equals("EFETIVADO") || (reunioesRegraNegocio.entidade.SITUACAO.Equals("CANCELADO") && reunioesRegraNegocio.entidade.AHPCALCULADO != null && reunioesRegraNegocio.entidade.AHPCALCULADO >= 1))
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

            //cboResponsavel.DataSource = pessoasRegraNegocio.ToList();
            //cboResponsavel.SelectedItem = null;

            LimparCamposPautaProjetos();
        }

        private void LimparCamposPautaProjetos()
        {
            //cboPautaProjeto.DataSource = projetosRegraNegocio.ToList();
            //cboPautaProjeto.SelectedItem = null;
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

            /*if (cboResponsavel.SelectedItem == null)
            {
                MessageBox.Show("Deve ser selecionado o resposável pela reunião", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboResponsavel.Focus();
                return false;
            }*/

            if (this._statusInformacao.Equals(StatusInformacao.EFETIVACAO))
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

                if (reunioesRegraNegocio.entidade.PAUTAPROJETOS.Count < 0)
                {
                    MessageBox.Show("A reunião não pode ser efetivada pois não contem projetos na pauta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbpPautaProjetos.Focus();
                    return false;
                }

                if (reunioesRegraNegocio.entidade.AHPCALCULADO == null || reunioesRegraNegocio.entidade.AHPCALCULADO < 1)
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
            /*if (cboPautaProjeto.SelectedItem == null)
            {
                MessageBox.Show("Deve ser indicado o projeto a ser incluso na pauta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPautaProjeto.Focus();
                return false;
            }*/

            return true;
        }

        private void EnviarInformacoesObjeto()
        {
            try
            {
                reunioesRegraNegocio.entidade.DESCRICAO = txtDescricao.Text;
                reunioesRegraNegocio.entidade.LOCAL = txtLocal.Text;
                reunioesRegraNegocio.entidade.DATAHORAEVENTO = dtpDataHoraEvento.Value;
                //reunioesRegraNegocio.entidade.RESPONSAVEL = Convert.ToInt64(cboResponsavel.SelectedValue);
                reunioesRegraNegocio.entidade.PAYBACKACEITAVEL = Convert.ToDecimal(txtPayBackAceitavel.Text);
                reunioesRegraNegocio.entidade.TAXAREMUNERACAOMERCADO = Convert.ToDecimal(txtTIR.Text);
                reunioesRegraNegocio.entidade.TAXACUSTOCAPITAL = Convert.ToDecimal(txtTaxaCustoCapital.Text);
                reunioesRegraNegocio.entidade.PAUTADESCRICAO = txtDescricaoPauta.Text;
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
                //reunioesRegraNegocio.pautaProjeto.IDPROJETO = Convert.ToInt64(cboPautaProjeto.SelectedValue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
                MudarStatusInformacao(StatusInformacao.INCLUSAO);
                LimparCampos();
                reunioesRegraNegocio.Insert();
                txtCodigo.Text = 0.ToString();
                CarregarInformacoesGeraisPautaProjetos(false);
                CarregarInformaoesGeraisRankProjetos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarInformacoes())
                {
                    MudarStatusInformacao(StatusInformacao.SELECAO);
                    EnviarInformacoesObjeto();

                    reunioesRegraNegocio.Commit();
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
            if (MessageBox.Show(String.Format("Deseja realmente cancelar a {0} das informações?", (_statusInformacao.Equals(StatusInformacao.INCLUSAO) ? ("INCLUSÃO") : ("ALTERAÇÃO"))), "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                CarregarInformacoesGerais();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dtgPrincipal.SelectedRows.Count > 0)
            {
                if (reunioesRegraNegocio.entidade.SITUACAO.Equals("EM OPERAÇÃO"))
                {
                    CarregarInformacoes();
                    MudarStatusInformacao(StatusInformacao.ALTERACAO);
                }
                else
                {
                    MessageBox.Show(String.Format("Não é possivel alterar a reunião, pois a mesma está {0}.", reunioesRegraNegocio.entidade.SITUACAO), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CarregarInformacoes();
                    MudarStatusInformacao(StatusInformacao.SELECAO);
                }


                }
        }

        private void btnPautaIncluir_Click(object sender, EventArgs e)
        {
            if (this._statusInformacao.Equals(StatusInformacao.INCLUSAO) || this._statusInformacao.Equals(StatusInformacao.ALTERACAO))
            {
                if (reunioesRegraNegocio.entidade.PAUTAPROJETOS.Count <= 0 ||
                    reunioesRegraNegocio.entidade.AHPCALCULADO <= 0 ||
                    reunioesRegraNegocio.entidade.AHPCALCULADO >= 1 && reunioesRegraNegocio.entidade.PAUTAPROJETOS.Count > 0 &&
                    MessageBox.Show("Deseja realmente incluir um novo projeto com o critério do AHP já priorizado?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MudarStatusInformacaoPautaProjeto(StatusInformacao.INCLUSAO);
                    LimparCamposPautaProjetos();
                    reunioesRegraNegocio.IncluirPautaProjeto();
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

                    if (reunioesRegraNegocio.VerificarExistenciaProjetoPautaProjeto())
                        MessageBox.Show("Este projeto já está sendo pautado na reunião.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        reunioesRegraNegocio.SalvarPautaProjeto();

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

            if (ValidarInformacoes() && reunioesRegraNegocio.entidade.SITUACAO.Equals("EM OPERAÇÃO"))
            {
                if (MessageBox.Show("Deseja ralmente efetivar esta reunião?", "Efetivar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    reunioesRegraNegocio.MudarSituacao(RegraNegocio.SituacaoReuniao.EFETIVADO);
                    reunioesRegraNegocio.Commit();
                    CarregarInformacoesGerais();
                }
            }
        }

        private void btnCancelarReuniao_Click(object sender, EventArgs e)
        {
            MudarStatusInformacao(StatusInformacao.CANCELAMENTO);

            if (MessageBox.Show("Deseja realmente cancelar esta reunião?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reunioesRegraNegocio.MudarSituacao(RegraNegocio.SituacaoReuniao.CANCELADO);
                reunioesRegraNegocio.Commit();
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
                        reunioesRegraNegocio.ExcluirPautaProjeto();
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
            /* try
            {
                if (cboPautaProjeto.SelectedItem != null)
                {
                    //projetoRegraNegocio.Listar(Convert.ToInt64(cboPautaProjeto.SelectedValue));

                   // txtPautaGerente.Text = projetoRegraNegocio.entidade.GERENTEPROJETO.NOME;
                    //txtPautaInvestimentoPrevisto.Text = String.Format("R$ {0:0.00}", projetoRegraNegocio.entidade.INVESTIMENTOPREVISTO);
                    //txtPautaTempoConclusao.Text = projetoRegraNegocio.entidade.TEMPOPREVISTOCONCLUSAO.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } */
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
                if (reunioesRegraNegocio.entidade.AHPCALCULADO == null ||
                    reunioesRegraNegocio.entidade.PAUTAPROJETOS.Count > 0 && (reunioesRegraNegocio.entidade.AHPCALCULADO <= 0 || (reunioesRegraNegocio.entidade.AHPCALCULADO >= 1
                    && MessageBox.Show("Deseja realmente recalcular o critério do AHP para esta reunião?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)))
                {
                    reunioesRegraNegocio.CalcularAHP();
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

        private void button1_Click(object sender, EventArgs e)
        {

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