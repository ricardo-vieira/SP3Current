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
        BindingListView<RegraNegocio.View.Projetos.ViewPautaProjeto> _bindingListViewPautaProjetos;
        BindingListView<RegraNegocio.View.Projetos.ViewPautaProjeto> _bindingListViewRankProjetos;

        RegraNegocio.View.Reunioes.ViewReuniao _currentObject;
        RegraNegocio.View.Projetos.ViewPautaProjeto _currentObjectPautaProjeto;

        RegraNegocio.View.Pessoas.ViewPessoa _objectPesquisaResponsavel;
        RegraNegocio.View.Projetos.ViewProjeto _objectPesquisaPautaProjetoProjeto;

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
                    btnCancelar.Visible = true;
                    btnEfetivarReuniao.Enabled = false;
                    
                    txtDescricao.ReadOnly = false;
                    dtpDataHoraEvento.Enabled = true;
                    txtLocal.ReadOnly = false;
                    txtPayBackAceitavel.ReadOnly = false;
                    txtTIR.ReadOnly = false;
                    txtTaxaCustoCapital.ReadOnly = false;
                    txtDescricaoPauta.ReadOnly = false;
                    btnPesquisaResponsavel.Enabled = true;
                    btnAHPCalcular.Enabled = false;
                    break;

                case StatusInformacao.ALTERACAO:
                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnCancelar.Visible = true;
                    btnEfetivarReuniao.Enabled = false;

                    txtDescricao.ReadOnly = false;
                    dtpDataHoraEvento.Enabled = true;
                    txtLocal.ReadOnly = false;
                    txtPayBackAceitavel.ReadOnly = false;
                    txtTIR.ReadOnly = false;
                    txtTaxaCustoCapital.ReadOnly = false;
                    txtDescricaoPauta.ReadOnly = false;
                    btnPesquisaResponsavel.Enabled = true;
                    btnAHPCalcular.Enabled = true;
                    break;

                case StatusInformacao.SELECAO:
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnAlterar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnCancelar.Visible = false;
                    btnEfetivarReuniao.Enabled = false;

                    txtDescricao.ReadOnly = true;
                    dtpDataHoraEvento.Enabled = false;
                    txtLocal.ReadOnly = true;
                    txtPayBackAceitavel.ReadOnly = true;
                    txtTIR.ReadOnly = true;
                    txtTaxaCustoCapital.ReadOnly = true;
                    txtDescricaoPauta.ReadOnly = true;
                    btnPesquisaResponsavel.Enabled = true;
                    btnAHPCalcular.Enabled = false;
                    break;

                case StatusInformacao.SEMACAO:
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnCancelar.Visible = false;
                    btnEfetivarReuniao.Enabled = false;

                    txtDescricao.ReadOnly = true;
                    dtpDataHoraEvento.Enabled = false;
                    txtLocal.ReadOnly = true;
                    txtPayBackAceitavel.ReadOnly = true;
                    txtTIR.ReadOnly = true;
                    txtTaxaCustoCapital.ReadOnly = true;
                    txtDescricaoPauta.ReadOnly = true;
                    btnPesquisaResponsavel.Enabled = false;
                    btnAHPCalcular.Enabled = false;
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
                    btnPesquisarPautaProjeto.Enabled = true;
                    break;
                case StatusInformacao.ALTERACAO:
                    btnPautaIncluir.Enabled = false;
                    btnPautaExcluir.Enabled = false;
                    btnPautaEditar.Enabled = false;

                    btnPautaSalvar.Enabled = true;
                    btnPautaCancelar.Enabled = true;

                    btnPesquisarPautaProjeto.Enabled = true;

                    dtgPautaProjetos.Enabled = false;
                    btnPesquisarPautaProjeto.Enabled = false;
                    break;
                case StatusInformacao.SELECAO:
                    btnPautaIncluir.Enabled = true;
                    btnPautaExcluir.Enabled = true;
                    btnPautaEditar.Enabled = true;

                    btnPautaSalvar.Enabled = false;
                    btnPautaCancelar.Enabled = false;

                    btnPesquisarPautaProjeto.Enabled = false;

                    dtgPautaProjetos.Enabled = true;
                    btnPesquisarPautaProjeto.Enabled = false;
                    break;
                case StatusInformacao.SEMACAO:
                    btnPautaIncluir.Enabled = false;
                    btnPautaExcluir.Enabled = false;
                    btnPautaEditar.Enabled = false;

                    btnPautaSalvar.Enabled = false;
                    btnPautaCancelar.Enabled = false;

                    btnPesquisarPautaProjeto.Enabled = false;

                    dtgPautaProjetos.Enabled = false;
                    btnPesquisarPautaProjeto.Enabled = false;
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
                    _bindingListView.DataSource = reunioesRegraNegocio.ToList();
                }


                //RegraNegocio.View.Reunioes.ViewReuniao _bindingSourceCurrentObject = (_bindingSource.Current is null) ? (null) : (_bindingSource.Current as ObjectView<RegraNegocio.View.Reunioes.ViewReuniao>).Object;

                // if (!(_currentObject is null) && (_bindingSourceCurrentObject is null || _bindingSourceCurrentObject != _currentObject || _bindingSource.Count > 1))
                // {
                //   _bindingListView.ApplyFilter(x => x.EntityObject.Equals(_currentObject.EntityObject));
                MudarStatusInformacao(StatusInformacao.SELECAO);
                //}
                //else
                //{
                //    MudarStatusInformacao(StatusInformacao.SEMACAO);
                //}

                _bindingListView.Refresh();
                _bindingSource.ResumeBinding();
                CarregarInformacoes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DesabilitarDataBindingComponentes()
        {

        }


        private void CarregarInformacoes()
        {
            switch (txtSituacao.Text)
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
                    btnEfetivarReuniao.Enabled = false;
                    btnCancelarReuniao.Enabled = false;
                    txtSituacao.BackColor = Color.White;
                    break;
            }

            _objectPesquisaResponsavel = new RegraNegocio.View.Pessoas.ViewPessoa(_currentObject.EntityObject.PESSOA);

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
            if (_statusInformacao == StatusInformacao.INCLUSAO
                || _statusInformacao == StatusInformacao.ALTERACAO)
            {
                MudarStatusInformacaoPautaProjeto(StatusInformacao.SELECAO);
            }
            else
            {
                MudarStatusInformacaoPautaProjeto(StatusInformacao.SEMACAO);
            }

            /*try
            {
                if (dtgPautaProjetos.SelectedRows.Count > 0)
                {
                    if (Convert.ToInt64(dtgPautaProjetos.SelectedRows[0].Cells["dtgPautaProjetosTxtIdPautaProjeto"].Value) == 0)
                    {
                        _c reunioesRegraNegocio.ListarPautaProjetoSemId(_currentObject.EntityObject, Convert.ToInt64(dtgPautaProjetos.SelectedRows[0].Cells["dtgPautaProjetosTxtIdProjeto"].Value));
                    }
                    else
                    {
                        reunioesRegraNegocio.RetornarPautaProjeto(_currentObject.EntityObject, Convert.ToInt64(dtgPautaProjetos.SelectedRows[0].Cells["dtgPautaProjetosTxtIdPautaProjeto"].Value));
                    }

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
            } */
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

        private void CarregarInformacoesGeraisPautaProjetos()
        {
            try
            {
                if (_bindingListViewPautaProjetos == null)
                {
                    _bindingListViewPautaProjetos = new BindingListView<RegraNegocio.View.Projetos.ViewPautaProjeto>(pautaProjetosRegraNegocio.ToList());

                    _bindingSourcePauta.DataSource = _bindingListViewPautaProjetos;
                }
                else
                {
                    _bindingListViewPautaProjetos.DataSource = pautaProjetosRegraNegocio.ToList();
                    _bindingListViewPautaProjetos.RemoveFilter();
                    _bindingListViewPautaProjetos.Refresh();
                }

                _bindingListViewPautaProjetos.ApplyFilter(x => x.EntityObject.REUNIO == _currentObject.EntityObject);
                _bindingListViewPautaProjetos.Refresh();

                RegraNegocio.View.Projetos.ViewPautaProjeto _bindingSourcePautaProjetoCurrentObject = (_bindingSourcePauta.Current is null)
                                                                                                      ? (null)
                                                                                                      : (_bindingSourcePauta.Current as ObjectView<RegraNegocio.View.Projetos.ViewPautaProjeto>).Object;


                if (!(_currentObjectPautaProjeto is null)
                    && (_bindingSourcePautaProjetoCurrentObject is null
                       || _bindingSourcePautaProjetoCurrentObject != _currentObjectPautaProjeto)
                    && dtgPautaProjetos.Rows.Count > 0)
                {
                    //identifica a linha que contem o currentObjectProjetoReceitaVariavel na propriedade databounditem e atribui true a propriedade selected
                    IEnumerable<DataGridViewRow> dtgPautaProjetosRowsEnumerable = System.Linq.Enumerable.Cast<DataGridViewRow>(dtgPautaProjetos.Rows);
                    DataGridViewRow dataRow = new List<DataGridViewRow>(dtgPautaProjetosRowsEnumerable)
                                                  .First(row => (row.DataBoundItem as ObjectView<RegraNegocio.View.Projetos.ViewPautaProjeto>)
                                                                                              .Object
                                                                                              .EntityObject == _currentObjectPautaProjeto.EntityObject);

                    dataRow.Selected = true;
                }


                MudarStatusInformacaoPautaProjeto(StatusInformacao.SEMACAO);

                _bindingSourcePauta.ResumeBinding();
                CarregarInformacoesPautaProjeto();


                if (_currentObject.EntityObject.AHPCALCULADO != null && _currentObject.EntityObject.AHPCALCULADO >= 1)
                {
                    txtAHPCalculado.Text = "SIM";
                    txtAHPCalculado.ForeColor = Color.Green;
                }
                else
                {
                    txtAHPCalculado.Text = "NÃO";
                    txtAHPCalculado.ForeColor = Color.Red;
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
                _bindingListViewRankProjetos = new BindingListView<RegraNegocio.View.Projetos.ViewPautaProjeto>(reunioesRegraNegocio.ListarProjetosCalculados(_currentObject.EntityObject));
                dtgRankProjetos.DataSource = _bindingListViewRankProjetos;
                MudarCoresDtgRankProjetos();

                if (_currentObject.EntityObject.SITUACAO == "EFETIVADO"
                    || (_currentObject.EntityObject.SITUACAO == "CANCELADO"
                        && _currentObject.EntityObject.AHPCALCULADO != null
                        && _currentObject.EntityObject.AHPCALCULADO >= 1))
                {
                    dtgRankProjetos.Visible = true;
                    //dtgRankProjetos.DataSource = null;
                    //dtgRankProjetos.Columns.Clear();
                    //RecarregarColunasdtgPrincipal();
                    ColorirDataGridRankProjetos();
                    btnImprimir.Enabled = true;

                    //dtgRankProjetos.Sort(dtgRankProjetos.Columns["dtgRankProjetosNome"], ListSortDirection.Ascending);
                    //dtgRankProjetos_Sorted(dtgRankProjetos, new EventArgs());
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

            if (_objectPesquisaResponsavel == null)
            {
                MessageBox.Show("É necessário informar um responsável pela reunião.");
                btnPesquisaResponsavel.Focus();
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

                if (_currentObject.EntityObject.PAUTAPROJETOS.Count < 0)
                {
                    MessageBox.Show("A reunião não pode ser efetivada pois não contem projetos na pauta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbpPautaProjetos.Focus();
                    return false;
                }

                if (_currentObject.EntityObject.AHPCALCULADO == null || _currentObject.EntityObject.AHPCALCULADO < 1)
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
            if (_objectPesquisaPautaProjetoProjeto == null)
            {
                MessageBox.Show("É necessário informar um projeto para a inclusão");
                btnPesquisarPautaProjeto.Focus();
                return false;
            }

            if (reunioesRegraNegocio.ListarPautaProjeto(_currentObject.EntityObject)
                                         .Any(pt => pt.EntityObject.PROJETO == _objectPesquisaPautaProjetoProjeto.EntityObject))
            {
                MessageBox.Show("Este projeto já está lançado para esta reunião.");
                return false;
            }

            return true;
        }

        private void EnviarInformacoesObjeto()
        {
            try
            {
                _currentObject.EntityObject.DESCRICAO = txtDescricao.Text;
                _currentObject.EntityObject.LOCAL = txtLocal.Text;
                _currentObject.EntityObject.DATAHORAEVENTO = dtpDataHoraEvento.Value;
                //reunioesRegraNegocio.entidade.RESPONSAVEL = Convert.ToInt64(cboResponsavel.SelectedValue);
                _currentObject.EntityObject.PAYBACKACEITAVEL = Convert.ToDecimal(txtPayBackAceitavel.Text);
                _currentObject.EntityObject.TAXAREMUNERACAOMERCADO = Convert.ToDecimal(txtTIR.Text);
                _currentObject.EntityObject.TAXACUSTOCAPITAL = Convert.ToDecimal(txtTaxaCustoCapital.Text);
                _currentObject.EntityObject.PAUTADESCRICAO = txtDescricaoPauta.Text;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EnviarInformacoesObjetoPautaProjetos()
        {
       
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _currentObject = new RegraNegocio.View.Reunioes.ViewReuniao(reunioesRegraNegocio.Insert());
            _bindingSource.SuspendBinding();
            txtSituacao.Text = _currentObject.Situacao;
            MudarStatusInformacao(StatusInformacao.INCLUSAO);
            DesabilitarDataBindingComponentes();

            CarregarInformacoes();
            CarregarInformacoesGeraisPautaProjetos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarInformacoes())
                {
                    AtualizaInformacoesCurrentObject();

                    reunioesRegraNegocio.Commit();
                    pautaProjetosRegraNegocio.Commit();
                    CarregarInformacoesGerais();
                    CarregarInformacoesGeraisPautaProjetos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizaInformacoesCurrentObject()
        {
            _currentObject.EntityObject.DESCRICAO = txtDescricao.Text;
            _currentObject.EntityObject.DATAHORAEVENTO = dtpDataHoraEvento.Value;
            _currentObject.EntityObject.LOCAL = txtLocal.Text;
            _currentObject.EntityObject.PAYBACKACEITAVEL = Convert.ToDecimal(txtPayBackAceitavel.Text);
            _currentObject.EntityObject.TAXAREMUNERACAOMERCADO = Convert.ToDecimal(txtTIR.Text);
            _currentObject.EntityObject.TAXACUSTOCAPITAL = Convert.ToDecimal(txtTaxaCustoCapital.Text);
            _currentObject.EntityObject.PAUTADESCRICAO = txtDescricaoPauta.Text;

            _currentObject.EntityObject.PESSOA = _objectPesquisaResponsavel.EntityObject;
            _objectPesquisaResponsavel = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(String.Format("Deseja realmente cancelar a {0} das informações?",
                               (_statusInformacao.Equals(StatusInformacao.INCLUSAO) ? ("INCLUSÃO") : ("ALTERAÇÃO"))),
                               "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                reunioesRegraNegocio.RollBackLastOperation();

                if (_statusInformacao == StatusInformacao.INCLUSAO)
                {
                    _currentObject = null;
                }

                CarregarInformacoesGerais();
                CarregarInformacoesGeraisPautaProjetos();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!(_currentObject is null))
            {
                if (_currentObject.EntityObject.SITUACAO.Equals("EM OPERAÇÃO"))
                {
                    reunioesRegraNegocio.Update(_currentObject.EntityObject);
                    MudarStatusInformacao(StatusInformacao.ALTERACAO);

                    CarregarObjetosPesquisa();
                    DesabilitarDataBindingComponentes();

                    CarregarInformacoesGeraisPautaProjetos();

                }
            }
        }

        private void CarregarObjetosPesquisa()
        {
            if (!(_currentObject is null))
            {
                if (!(_currentObject.EntityObject.PESSOA is null))
                {
                    _objectPesquisaResponsavel = new RegraNegocio.View
                                                                 .Pessoas
                                                                 .ViewPessoa(_currentObject.EntityObject.PESSOA);
                }
            }
        }

        private void btnPautaIncluir_Click(object sender, EventArgs e)
        {
            _currentObjectPautaProjeto = new RegraNegocio.View
                                                         .Projetos
                                                         .ViewPautaProjeto(pautaProjetosRegraNegocio.Insert());

            _bindingSourcePauta.SuspendBinding();
            MudarStatusInformacaoPautaProjeto(StatusInformacao.INCLUSAO);
            DesabilitarDataBindingComponentesPautaProjetos();
        }

        private void DesabilitarDataBindingComponentesPautaProjetos()
        {

        }

        private void btnPautaSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarInformacoesPautaProjetos())
            {
                AtualizaInformacoesCurrentObjectPautaProjeto();
                CarregarInformacoesGeraisPautaProjetos();
                HabilitarDataBindingComponentesPautaProjetos();
            }
        }

        private void AtualizaInformacoesCurrentObjectPautaProjeto()
        {
            _currentObjectPautaProjeto.EntityObject.PROJETO = _objectPesquisaPautaProjetoProjeto.EntityObject;
            _currentObjectPautaProjeto.EntityObject.REUNIO = _currentObject.EntityObject;
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

            if (ValidarInformacoes() && _currentObject.EntityObject.SITUACAO.Equals("EM OPERAÇÃO"))
            {
                if (MessageBox.Show("Deseja ralmente efetivar esta reunião?", "Efetivar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    reunioesRegraNegocio.MudarSituacao(_currentObject.EntityObject, RegraNegocio.SituacaoReuniao.EFETIVADO);
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
                reunioesRegraNegocio.MudarSituacao(_currentObject.EntityObject, RegraNegocio.SituacaoReuniao.CANCELADO);
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
            if (dtgPautaProjetos.SelectedRows.Count > 0)
            {
                switch (dtgPautaProjetos.Columns[e.ColumnIndex].Name)
                {
                    case "dtgPautaProjetoBtnExcluir":
                        btnPautaExcluir_Click(btnPautaExcluir, new EventArgs());
                        break;

                    case "dtgPautaProjetoBtnEditar":
                        btnPautaEditar_Click(btnPautaEditar, new EventArgs());
                        break;

                    default:
                        CarregarInformacoesPautaProjeto();
                        break;
                }

            }
        }

        private void btnPautaExcluir_Click(object sender, EventArgs e)
        {
            if (_currentObjectPautaProjeto != null)
            {
                pautaProjetosRegraNegocio.Delete(_currentObjectPautaProjeto.EntityObject);
                CarregarInformacoesGeraisPautaProjetos();
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
            if (_currentObject.EntityObject.AHPCALCULADO == null ||
                _currentObject.EntityObject.PAUTAPROJETOS.Count > 0 && (_currentObject.EntityObject.AHPCALCULADO <= 0 || (_currentObject.EntityObject.AHPCALCULADO >= 1
                && MessageBox.Show("Deseja realmente recalcular o critério do AHP para esta reunião?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)))
            {
                reunioesRegraNegocio.CalcularAHP(_currentObject.EntityObject);
                txtAHPCalculado.Text = "SIM";
                txtAHPCalculado.ForeColor = Color.Green;
            }
        }

        private void dtgPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgPrincipal.CurrentRow != null)
            {

                if (_currentObject != null)
                {
                    if (dtgPrincipal.Columns[e.ColumnIndex].Name.Equals("btnEditar"))
                    {
                        btnAlterar_Click(sender, new EventArgs());
                    }
                }
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

        private void btnPautaEditar_Click(object sender, EventArgs e)
        {
            if (_currentObjectPautaProjeto != null)
            {
                pautaProjetosRegraNegocio.Update(_currentObjectPautaProjeto.EntityObject);
                MudarStatusInformacaoPautaProjeto(StatusInformacao.ALTERACAO);
                CarregarObjetosPesquisaPautaProjetos();
                DesabilitarDataBindingComponentesPautaProjetos();
            }
        }

        private void CarregarObjetosPesquisaPautaProjetos()
        {
            if (_currentObjectPautaProjeto != null)
            {
                if (_currentObjectPautaProjeto.EntityObject.PROJETO != null)
                {
                    _objectPesquisaPautaProjetoProjeto = new RegraNegocio
                                                             .View
                                                             .Projetos
                                                             .ViewProjeto(_currentObjectPautaProjeto
                                                                          .EntityObject.PROJETO);
                }
            }
        }

        private void btnPautaCancelar_Click(object sender, EventArgs e)
        {
            _currentObjectPautaProjeto = null;
            pautaProjetosRegraNegocio.RollBackLastOperation();
            CarregarInformacoesGeraisPautaProjetos();
            HabilitarDataBindingComponentesPautaProjetos();
        }

        private void HabilitarDataBindingComponentesPautaProjetos()
        {

        }

        private void btnPesquisarPautaProjeto_Click(object sender, EventArgs e)
        {
            var frmPesquisaProjeto = new Cadastros.Pesquisa.frmPesquisaProjeto();
            _objectPesquisaPautaProjetoProjeto = frmPesquisaProjeto.ShowDialogResultObjectSearch();

            if (_objectPesquisaPautaProjetoProjeto != null)
            {
                txtPautaCodigo.Text = _objectPesquisaPautaProjetoProjeto.Id.ToString();
                txtPautaDescricao.Text = _objectPesquisaPautaProjetoProjeto.Descricao;

                txtPautaGerente.Text = _objectPesquisaPautaProjetoProjeto.NomeGerenteProjeto;
                txtPautaInvestimentoPrevisto.Text = _objectPesquisaPautaProjetoProjeto.InvestimentoPrevisto.ToString();
                txtPautaTempoConclusao.Text = _objectPesquisaPautaProjetoProjeto.TempoPrevistoConclusao.ToString();
            }
        }

        private void _bindingSourcePauta_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //se o objecto corrent do bindingSourceProjetoPessoa for diferente de nulo, atribui ao _currentObjectProjetopessoa, se não atribui null
                if (!(_bindingSourcePauta.Current is null))
                    _currentObjectPautaProjeto = (_bindingSourcePauta.Current as ObjectView<RegraNegocio.View.Projetos.ViewPautaProjeto>).Object;
                else
                    _currentObjectPautaProjeto = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void _bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //se o objecto corrent do bindingSourceProjetoPessoa for diferente de nulo, atribui ao _currentObjectProjetopessoa, se não atribui null
                if (!(_bindingSource.Current is null))
                {
                    _currentObject = (_bindingSource.Current as ObjectView<RegraNegocio.View.Reunioes.ViewReuniao>).Object;
                    CarregarInformacoes();
                    CarregarInformacoesGeraisPautaProjetos();
                    CarregarInformaoesGeraisRankProjetos();
                }
                else
                    _currentObject = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnPesquisaResponsavel_Click(object sender, EventArgs e)
        {
            Cadastros.Pesquisa.frmPesquisaPessoa frmPesquisaPessoa = new Cadastros.Pesquisa.frmPesquisaPessoa();

            _objectPesquisaResponsavel = frmPesquisaPessoa.ShowDialogResultObjectSearch();

            if (!(_objectPesquisaResponsavel is null))
            {
                txtResponsavelCodigo.Text = _objectPesquisaResponsavel.Id.ToString();
                txtResponsavelNome.Text = _objectPesquisaResponsavel.Nome;
            }
        }

        private void dtgPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSituacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgPautaProjetos_SelectionChanged(object sender, EventArgs e)
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

    }
}

#region MyRegion

/*
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