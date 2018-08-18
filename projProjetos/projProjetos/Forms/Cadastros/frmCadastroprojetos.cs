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

using Equin.ApplicationFramework;

namespace projProjetos.Forms.Cadastros
{
    public partial class FrmCadastroProjetos : Form
    {
        RegraNegocio.Projetos projetosRegraNegocio = new RegraNegocio.Projetos();
        RegraNegocio.Pessoas pessoasRegraNegocio = new RegraNegocio.Pessoas();
        RegraNegocio.ReceitaVariavel receitaVariavelRegraNegocio = new RegraNegocio.ReceitaVariavel();
        RegraNegocio.ProjetosPessoas projetoPessoaRegraNegocio = new RegraNegocio.ProjetosPessoas();

        StatusInformacao _statusInformacao = StatusInformacao.SELECAO;
        StatusInformacao _statusInformacaoReceitaVariavel = StatusInformacao.SEMACAO;
        StatusInformacao _statusInformacaoProjetoPessoa = StatusInformacao.SEMACAO;

        BindingListView<RegraNegocio.View.Projetos.ViewProjeto> _bindingListView;
        BindingListView<RegraNegocio.View.Projetos.ViewProjetosReceitaVariavel> _bindingListViewProjetoReceitaVariavel;
        BindingListView<RegraNegocio.View.Projetos.ViewProjetoPessoa> _bindingListViewProjetoPessoa;

        RegraNegocio.View.Projetos.ViewProjeto _currentObject;
        RegraNegocio.View.Projetos.ViewProjetosReceitaVariavel _currentObjectProjetoRececeitaVariavel;
        RegraNegocio.View.Projetos.ViewProjetoPessoa _currentObjectProjetoPessoa;

        RegraNegocio.View.Pessoas.ViewPessoa _objectPesquisaGerente;
        RegraNegocio.View.Pessoas.ViewPessoa _objectPesquisaProjetoPessoaParticipante;

        public FrmCadastroProjetos()
        {
            InitializeComponent();
        }

        private void MudarStatusInformacao(StatusInformacao statusinformacao)
        {
            this._statusInformacao = statusinformacao;

            switch (statusinformacao)
            {
                case StatusInformacao.INCLUSAO:

                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnInativar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnPesquisar.Enabled = false;

                    txtNome.ReadOnly = false;
                    btnPesquisaGerenteProjeto.Enabled = true;
                    txtPrazoConclusao.ReadOnly = false;
                    txtInvestimentoPrevisto.ReadOnly = false;
                    txtDescricao.ReadOnly = false;

                    cboApoioSteakholders.Enabled = true;
                    cboCapacidadeEntregaEquipe.Enabled = true;
                    cboApoioAltaGestao.Enabled = true;

                    rbEsforcoAdicionalAte10porCento.Enabled = true;
                    rbEsforcoAdicional11A20PorCento.Enabled = true;
                    rbEsforcoAdicional21A40PorCento.Enabled = true;
                    rbEsforcoAdicionalAcima40PorCento.Enabled = true;

                    break;
                case StatusInformacao.ALTERACAO:

                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnInativar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnPesquisar.Enabled = false;

                    txtNome.ReadOnly = false;
                    btnPesquisaGerenteProjeto.Enabled = true;
                    txtPrazoConclusao.ReadOnly = false;
                    txtInvestimentoPrevisto.ReadOnly = false;
                    txtDescricao.ReadOnly = false;

                    cboApoioSteakholders.Enabled = true;
                    cboCapacidadeEntregaEquipe.Enabled = true;
                    cboApoioAltaGestao.Enabled = true;

                    rbEsforcoAdicionalAte10porCento.Enabled = true;
                    rbEsforcoAdicional11A20PorCento.Enabled = true;
                    rbEsforcoAdicional21A40PorCento.Enabled = true;
                    rbEsforcoAdicionalAcima40PorCento.Enabled = true;
                    break;
                case StatusInformacao.SELECAO:

                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnAlterar.Enabled = true;
                    btnInativar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnPesquisar.Enabled = true;

                    txtNome.ReadOnly = true;
                    btnPesquisaGerenteProjeto.Enabled = false;
                    txtPrazoConclusao.ReadOnly = true;
                    txtInvestimentoPrevisto.ReadOnly = true;
                    txtDescricao.ReadOnly = true;

                    cboApoioSteakholders.Enabled = false;
                    cboCapacidadeEntregaEquipe.Enabled = false;
                    cboApoioAltaGestao.Enabled = false;

                    rbEsforcoAdicionalAte10porCento.Enabled = false;
                    rbEsforcoAdicional11A20PorCento.Enabled = false;
                    rbEsforcoAdicional21A40PorCento.Enabled = false;
                    rbEsforcoAdicionalAcima40PorCento.Enabled = false;
                    break;
                case StatusInformacao.SEMACAO:

                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnInativar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnPesquisar.Enabled = true;

                    txtNome.ReadOnly = true;
                    btnPesquisaGerenteProjeto.Enabled = false;
                    txtPrazoConclusao.ReadOnly = true;
                    txtInvestimentoPrevisto.ReadOnly = true;
                    txtDescricao.ReadOnly = true;

                    cboApoioSteakholders.Enabled = false;
                    cboCapacidadeEntregaEquipe.Enabled = false;
                    cboApoioAltaGestao.Enabled = false;

                    rbEsforcoAdicionalAte10porCento.Enabled = false;
                    rbEsforcoAdicional11A20PorCento.Enabled = false;
                    rbEsforcoAdicional21A40PorCento.Enabled = false;
                    rbEsforcoAdicionalAcima40PorCento.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void MudarStatusInformacaoProjetoReceitaVariavel(StatusInformacao statusinformacao)
        {

            this._statusInformacaoReceitaVariavel = statusinformacao;

            switch (statusinformacao)
            {
                case StatusInformacao.INCLUSAO:
                    btnReceitaVariavelIncluir.Enabled = false;
                    btnReceitaVariavelExcluir.Enabled = false;
                    btnReceitaVariavelEditar.Enabled = false;

                    btnReceitaVariavelSalvar.Enabled = true;
                    btnReceitaVariavelCancelar.Visible = true;

                    dtpReceitaVariavelPeriodo.Enabled = true;
                    cboReceitaVariavelFluxo.Enabled = true;
                    txtReceitaVariavelValor.ReadOnly = false;
                    txtReceitaVariavelObservacoes.ReadOnly = false;

                    dtgReceitaVariavel.Enabled = false;
                    break;
                case StatusInformacao.ALTERACAO:
                    btnReceitaVariavelIncluir.Enabled = false;
                    btnReceitaVariavelExcluir.Enabled = false;
                    btnReceitaVariavelEditar.Enabled = false;

                    btnReceitaVariavelSalvar.Enabled = true;
                    btnReceitaVariavelCancelar.Visible = true;

                    dtpReceitaVariavelPeriodo.Enabled = true;
                    cboReceitaVariavelFluxo.Enabled = true;
                    txtReceitaVariavelValor.ReadOnly = false;
                    txtReceitaVariavelObservacoes.ReadOnly = false;

                    dtgReceitaVariavel.Enabled = false;
                    break;
                case StatusInformacao.SELECAO:
                    btnReceitaVariavelIncluir.Enabled = true;
                    btnReceitaVariavelExcluir.Enabled = true;
                    btnReceitaVariavelEditar.Enabled = true;

                    btnReceitaVariavelSalvar.Enabled = false;
                    btnReceitaVariavelCancelar.Visible = false;

                    dtpReceitaVariavelPeriodo.Enabled = false;
                    cboReceitaVariavelFluxo.Enabled = false;
                    txtReceitaVariavelValor.ReadOnly = true;
                    txtReceitaVariavelObservacoes.ReadOnly = true;

                    dtgReceitaVariavel.Enabled = true;
                    break;
                case StatusInformacao.SEMACAO:
                    btnReceitaVariavelIncluir.Enabled = false;
                    btnReceitaVariavelExcluir.Enabled = false;
                    btnReceitaVariavelEditar.Enabled = false;

                    btnReceitaVariavelSalvar.Enabled = false;
                    btnReceitaVariavelCancelar.Visible = false;

                    dtpReceitaVariavelPeriodo.Enabled = false;
                    cboReceitaVariavelFluxo.Enabled = false;
                    txtReceitaVariavelValor.ReadOnly = true;
                    txtReceitaVariavelObservacoes.ReadOnly = true;

                    dtgReceitaVariavel.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void MudarStatusInformacaoProjetoPessoa(StatusInformacao statusInformacao)
        {
            this._statusInformacaoProjetoPessoa = statusInformacao;

            switch (statusInformacao)
            {
                case StatusInformacao.INCLUSAO:
                    btnProjetoPessoaIncluir.Enabled = false;
                    btnProjetoPessoaEditar.Enabled = false;
                    btnprojetoPessoaExcluir.Enabled = false;

                    btnProjetoPessoaCancelar.Enabled = true;
                    btnprojetoPessoaSalvar.Enabled = true;

                    btnProjetoPessoaPesquisaPessoa.Enabled = true;
                    txtProjetoPessoaOcupacao.ReadOnly = false;
                    txtProjetoPessoaObservacoes.ReadOnly = false;
                    dtpProjetoPessoaDataIngresso.Enabled = true;

                    dtgProjetoPessoa.Enabled = false;
                    break;

                case StatusInformacao.ALTERACAO:
                    btnProjetoPessoaIncluir.Enabled = false;
                    btnProjetoPessoaEditar.Enabled = false;
                    btnprojetoPessoaExcluir.Enabled = false;

                    btnProjetoPessoaCancelar.Enabled = true;
                    btnprojetoPessoaSalvar.Enabled = true;

                    btnProjetoPessoaPesquisaPessoa.Enabled = true;
                    txtProjetoPessoaOcupacao.ReadOnly = false;
                    txtProjetoPessoaObservacoes.ReadOnly = false;
                    dtpProjetoPessoaDataIngresso.Enabled = true;

                    dtgProjetoPessoa.Enabled = false;
                    break;
                case StatusInformacao.SELECAO:

                    btnProjetoPessoaIncluir.Enabled = true;
                    btnProjetoPessoaEditar.Enabled = true;
                    btnprojetoPessoaExcluir.Enabled = true;

                    btnProjetoPessoaCancelar.Enabled = false;
                    btnprojetoPessoaSalvar.Enabled = false;

                    btnProjetoPessoaPesquisaPessoa.Enabled = false;
                    txtProjetoPessoaOcupacao.ReadOnly = true;
                    txtProjetoPessoaObservacoes.ReadOnly = true;
                    dtpProjetoPessoaDataIngresso.Enabled = false;

                    dtgProjetoPessoa.Enabled = true;
                    break;

                case StatusInformacao.SEMACAO:
                    btnProjetoPessoaIncluir.Enabled = false;
                    btnProjetoPessoaEditar.Enabled = false;
                    btnprojetoPessoaExcluir.Enabled = false;

                    btnProjetoPessoaCancelar.Enabled = false;
                    btnprojetoPessoaSalvar.Enabled = false;

                    btnProjetoPessoaPesquisaPessoa.Enabled = false;
                    txtProjetoPessoaOcupacao.ReadOnly = true;
                    txtProjetoPessoaObservacoes.ReadOnly = true;
                    dtpProjetoPessoaDataIngresso.Enabled = false;

                    dtgProjetoPessoa.Enabled = false;
                    break;
                default:
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
                    _bindingListView = new BindingListView<RegraNegocio.View.Projetos.ViewProjeto>(projetosRegraNegocio.ToList());
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
                    _currentObject = (_bindingSource.Current as ObjectView<RegraNegocio.View.Projetos.ViewProjeto>).Object;
                }

                RegraNegocio.View.Projetos.ViewProjeto _bindingSourceCurrentObject = (_bindingSource.Current is null) ? (null) : (_bindingSource.Current as ObjectView<RegraNegocio.View.Projetos.ViewProjeto>).Object;

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
                if (_bindingListViewProjetoReceitaVariavel is null)
                {
                    _bindingListViewProjetoReceitaVariavel = new BindingListView<RegraNegocio.View.Projetos.ViewProjetosReceitaVariavel>(receitaVariavelRegraNegocio.ToList());
                    _bindingSourceReceitaVariavel.DataSource = _bindingListViewProjetoReceitaVariavel;
                }
                else
                {
                    _bindingListViewProjetoReceitaVariavel.RemoveFilter();
                    _bindingListViewProjetoReceitaVariavel.DataSource = receitaVariavelRegraNegocio.ToList();
                    _bindingListViewProjetoReceitaVariavel.Refresh();
                }

                _bindingListViewProjetoReceitaVariavel.ApplyFilter(x => x.EntityObject.PROJETO == _currentObject.EntityObject);
                _bindingListViewProjetoReceitaVariavel.Refresh();


                RegraNegocio.View.Projetos.ViewProjetosReceitaVariavel _bindingSourceReceitaVariavelCurrentObject = (_bindingSourceReceitaVariavel.Current is null) ? (null) : (_bindingSourceReceitaVariavel.Current as ObjectView<RegraNegocio.View.Projetos.ViewProjetosReceitaVariavel>).Object;

                if (!(_currentObjectProjetoRececeitaVariavel is null) && (_bindingSourceReceitaVariavelCurrentObject is null || _bindingSourceReceitaVariavelCurrentObject.EntityObject != _currentObjectProjetoRececeitaVariavel.EntityObject))
                {
                    //identifica a linha que contem o currentObjectProjetoReceitaVariavel na propriedade databounditem e atribui true a propriedade selected
                    IEnumerable<DataGridViewRow> dtgReceitaVariavelRowsEnumerable = System.Linq.Enumerable.Cast<DataGridViewRow>(dtgReceitaVariavel.Rows);

                    DataGridViewRow dataRow = new List<DataGridViewRow>(dtgReceitaVariavelRowsEnumerable).First(row => (row.DataBoundItem as ObjectView<RegraNegocio.View.Projetos.ViewProjetosReceitaVariavel>).Object.EntityObject == _currentObjectProjetoRececeitaVariavel.EntityObject);

                    dataRow.Selected = true;


                }

                if (_statusInformacao == StatusInformacao.SELECAO)
                    MudarStatusInformacaoProjetoReceitaVariavel(StatusInformacao.SEMACAO);
                else
                    MudarStatusInformacaoProjetoReceitaVariavel(StatusInformacao.SELECAO);

                _bindingSourceReceitaVariavel.ResumeBinding();

                CarregarInformacoesProjetoReceitaVariavel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarInformacoesGeraisProjetoPessoa()
        {
            try
            {
                ///caso o bindinglist estiver vazio, recebera uma nova instancia
                if (_bindingListViewProjetoPessoa is null)
                {
                    _bindingListViewProjetoPessoa = new BindingListView<RegraNegocio.View.Projetos.ViewProjetoPessoa>(projetoPessoaRegraNegocio.ToList());
                    _bindingSourceProjetoPessoa.DataSource = _bindingListViewProjetoPessoa;
                }
                else
                {
                    _bindingListViewProjetoPessoa.RemoveFilter();
                    _bindingListViewProjetoPessoa.DataSource = projetoPessoaRegraNegocio.ToList();
                    _bindingListViewProjetoPessoa.Refresh();
                }

                _bindingListViewProjetoPessoa.ApplyFilter(x => x.EntityObject.PROJETO == _currentObject.EntityObject);
                _bindingListViewProjetoPessoa.Refresh();


                RegraNegocio.View.Projetos.ViewProjetoPessoa _bindingSourceProjetoPessoaCurrentObject = (_bindingSourceProjetoPessoa.Current is null) ? (null) : (_bindingSourceProjetoPessoa.Current as ObjectView<RegraNegocio.View.Projetos.ViewProjetoPessoa>).Object;

                if (!(_currentObjectProjetoPessoa is null) && (_bindingSourceProjetoPessoaCurrentObject is null || _bindingSourceProjetoPessoaCurrentObject != _currentObjectProjetoPessoa))
                {
                    //identifica a linha que contem o currentObjectProjetoReceitaVariavel na propriedade databounditem e atribui true a propriedade selected
                    IEnumerable<DataGridViewRow> dtgProjetoPessoaRowsEnumerable = System.Linq.Enumerable.Cast<DataGridViewRow>(dtgProjetoPessoa.Rows);

                    DataGridViewRow dataRow = new List<DataGridViewRow>(dtgProjetoPessoaRowsEnumerable).First(row => (row.DataBoundItem as ObjectView<RegraNegocio.View.Projetos.ViewProjetoPessoa>).Object.EntityObject == _currentObjectProjetoPessoa.EntityObject);

                    dataRow.Selected = true;


                }

                if (_statusInformacao == StatusInformacao.SELECAO)
                    MudarStatusInformacaoProjetoPessoa(StatusInformacao.SEMACAO);
                else
                    MudarStatusInformacaoProjetoPessoa(StatusInformacao.SELECAO);

                _bindingSourceProjetoPessoa.ResumeBinding();

                CarregarInformacoesProjetoPessoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CarregarInformacoes()
        {
            try
            {
                if (!(_currentObject is null))
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CarregarInformacoesProjetoReceitaVariavel()
        {

        }

        private void CarregarInformacoesProjetoPessoa()
        {

        }


        public void HabilitarDataBindingComponentes()
        {
            try
            {
                cboApoioAltaGestao.DataSource = _bindingSource;
                cboApoioAltaGestao.ValueMember = "DescricaoApoioAltaGestao";
                cboApoioAltaGestao.DisplayMember = "DescricaoApoioAltaGestao";

                cboApoioSteakholders.DataSource = _bindingSource;
                cboApoioSteakholders.ValueMember = "DescricaoApoioSteakHolders";
                cboApoioSteakholders.DisplayMember = "DescricaoApoioSteakHolders";

                cboCapacidadeEntregaEquipe.DataSource = _bindingSource;
                cboCapacidadeEntregaEquipe.ValueMember = "DescricaoCapacidadeEntregaEquipe";
                cboCapacidadeEntregaEquipe.DisplayMember = "DescricaoCapacidadeEntregaEquipe";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void HabilitarDataBindingComponentesProjetoReceitaVariavel()
        {
            try
            {
                cboReceitaVariavelFluxo.DataSource = _bindingSourceReceitaVariavel;
                cboReceitaVariavelFluxo.ValueMember = "Tipo";
                cboReceitaVariavelFluxo.DisplayMember = "Tipo";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void HabilitarDataBindingComponentesProjetoPessoa()
        {

        }


        private void DesabilitarDataBindingComponentes()
        {
            //Obtem o valor selecionado;
            cboApoioAltaGestao.DataSource = null;
            cboApoioAltaGestao.Items.Clear();
            cboApoioAltaGestao.Items.Add("Apoio Formal e Total");
            cboApoioAltaGestao.Items.Add("Desejam o Sucesso");
            cboApoioAltaGestao.Items.Add("Neutro");
            cboApoioAltaGestao.Items.Add("Relutantes");
            cboApoioAltaGestao.SelectedItem = _currentObject.DescricaoApoioAltaGestao;

            cboApoioSteakholders.DataSource = null;
            cboApoioSteakholders.Items.Clear();
            cboApoioSteakholders.Items.Add("Anciosos");
            cboApoioSteakholders.Items.Add("Dispostos");
            cboApoioSteakholders.Items.Add("Relutantes");
            cboApoioSteakholders.Items.Add("Fortemente Relutantes");
            cboApoioSteakholders.SelectedItem = _currentObject.DescricaoApoioSteakHolders;

            cboCapacidadeEntregaEquipe.DataSource = null;
            cboCapacidadeEntregaEquipe.Items.Clear();
            cboCapacidadeEntregaEquipe.Items.Add("Muito Bom");
            cboCapacidadeEntregaEquipe.Items.Add("Bom");
            cboCapacidadeEntregaEquipe.Items.Add("Médio");
            cboCapacidadeEntregaEquipe.Items.Add("Pobre");
            cboCapacidadeEntregaEquipe.SelectedItem = _currentObject.DescricaoCapacidadeEntregaEquipe;
        }

        private void DesabilitarDataBindingComponentesProjetoPessoa()
        {

        }

        private void DesabilitarDataBindingComponentesProjetoReceitaVariavel()
        {
            cboReceitaVariavelFluxo.DataSource = null;
            cboReceitaVariavelFluxo.Items.Clear();
            cboReceitaVariavelFluxo.Items.Add("RECEITA");
            cboReceitaVariavelFluxo.Items.Add("DESPESA");
            cboReceitaVariavelFluxo.SelectedItem = _currentObjectProjetoRececeitaVariavel.Tipo;
        }


        private void AtualizarInformacoesCurrentObject()
        {
            try
            {
                _currentObject.EntityObject.NOME = txtNome.Text;
                _currentObject.EntityObject.GERENTEPROJETO = _objectPesquisaGerente.EntityObject;
                _currentObject.EntityObject.TEMPOPREVISTOCONCLUSAO = Convert.ToDecimal(txtPrazoConclusao.Text);
                _currentObject.EntityObject.INVESTIMENTOPREVISTO = Convert.ToDecimal(txtInvestimentoPrevisto.Text);

                _currentObject.EntityObject.APOIOSTEAKHOLDERS = RegraNegocio.Ferramentas.FrameworkDICE.RetornarIndiceApoioSteakHolders(cboApoioSteakholders.SelectedItem.ToString());
                _currentObject.EntityObject.CAPACIDADEENTREGAEQUIPE = RegraNegocio.Ferramentas.FrameworkDICE.RetornarIndiceCapacidadeEntregaEquipe(cboCapacidadeEntregaEquipe.SelectedItem.ToString());
                _currentObject.EntityObject.APOIOALTAGESTAO = RegraNegocio.Ferramentas.FrameworkDICE.RetornarIndiceApoioAltaGestao(cboApoioAltaGestao.SelectedItem.ToString());


                if (rbEsforcoAdicionalAte10porCento.Checked)
                    _currentObject.EntityObject.ESFORCOADICIONAL = RegraNegocio.Ferramentas.FrameworkDICE.RetornarIndiceEsforcoAdicional(rbEsforcoAdicionalAte10porCento.Text);

                else if (rbEsforcoAdicional11A20PorCento.Checked)
                    _currentObject.EntityObject.ESFORCOADICIONAL = RegraNegocio.Ferramentas.FrameworkDICE.RetornarIndiceEsforcoAdicional(rbEsforcoAdicional11A20PorCento.Text);

                else if (rbEsforcoAdicional21A40PorCento.Checked)
                    _currentObject.EntityObject.ESFORCOADICIONAL = RegraNegocio.Ferramentas.FrameworkDICE.RetornarIndiceEsforcoAdicional(rbEsforcoAdicional21A40PorCento.Text);

                else if (rbEsforcoAdicionalAcima40PorCento.Checked)
                    _currentObject.EntityObject.ESFORCOADICIONAL = RegraNegocio.Ferramentas.FrameworkDICE.RetornarIndiceEsforcoAdicional(rbEsforcoAdicionalAcima40PorCento.Text);


                _currentObject.EntityObject.DESCRICAO = txtDescricao.Text;

                _currentObject.EntityObject.DATACRIACAO = DateTime.Now;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AtualizarInformacoesCurrentObjectProjetoReceitaVariavel()
        {
            try
            {
                _currentObjectProjetoRececeitaVariavel.EntityObject.DATAPERIODO = dtpReceitaVariavelPeriodo.Value;
                _currentObjectProjetoRececeitaVariavel.EntityObject.TIPO = cboReceitaVariavelFluxo.SelectedItem.ToString();
                _currentObjectProjetoRececeitaVariavel.EntityObject.VALOR = Convert.ToDecimal(txtReceitaVariavelValor.Text);
                _currentObjectProjetoRececeitaVariavel.EntityObject.OBSERVACOES = txtReceitaVariavelObservacoes.Text;

                _currentObjectProjetoRececeitaVariavel.EntityObject.STATUS = 1;
                _currentObjectProjetoRececeitaVariavel.EntityObject.PROJETO = _currentObject.EntityObject;
                _currentObjectProjetoRececeitaVariavel.EntityObject.DATACRIACAO = DateTime.Now;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AtualizarInformacoesCurrentObjectProjetoPessoa()
        {
            try
            {
                _currentObjectProjetoPessoa.EntityObject.PESSOA = _objectPesquisaProjetoPessoaParticipante.EntityObject;
                _currentObjectProjetoPessoa.EntityObject.OCUPACAO = txtProjetoPessoaOcupacao.Text;
                _currentObjectProjetoPessoa.EntityObject.DATAINGRESSO = dtpProjetoPessoaDataIngresso.Value;
                _currentObjectProjetoPessoa.EntityObject.OBSERVACOES = txtProjetoPessoaObservacoes.Text;

                _currentObjectProjetoPessoa.EntityObject.PROJETO = _currentObject.EntityObject;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        private bool ValidarInformacoes()
        {
            try
            {
                if (txtNome.Text == String.Empty)
                {
                    MessageBox.Show("O campo nome do projeto nao pode ser vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Focus();
                    return false;
                }

                if (_objectPesquisaGerente is null)
                {
                    MessageBox.Show("'E necessario informar o gerente do projeto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnPesquisaGerenteProjeto.Focus();
                    return false;
                }

                int prazoConclusao;
                if (!Int32.TryParse(txtPrazoConclusao.Text, out prazoConclusao))
                {
                    MessageBox.Show("O campo Prazo de duracao nao foi preenchido ou contem valores invalidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrazoConclusao.Focus();
                    return false;
                }

                decimal investimentoPrevisto;
                if (!Decimal.TryParse(txtInvestimentoPrevisto.Text, out investimentoPrevisto))
                {
                    MessageBox.Show("O campo Investimento previsto nao foi preenchido ou contem valores invalidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrazoConclusao.Focus();
                    return false;
                }


                if (cboApoioSteakholders.SelectedIndex < 0)
                {
                    MessageBox.Show("A caixa de selecao Apoio SteakHolders deve ser preenchida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboApoioSteakholders.Focus();
                    return false;
                }


                if (cboCapacidadeEntregaEquipe.SelectedIndex < 0)
                {
                    MessageBox.Show("A caixa de selecao Capacidade de Entrega da Equipe deve ser preenchida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboCapacidadeEntregaEquipe.Focus();
                    return false;
                }


                if (cboApoioAltaGestao.SelectedIndex < 0)
                {
                    MessageBox.Show("A caixa de selecao Apoio da Alta Gestao deve ser preenchida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboApoioAltaGestao.Focus();
                    return false;
                }


                if (txtDescricao.Text == String.Empty)
                {
                    MessageBox.Show("O campo Descricao nao pode ser vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescricao.Focus();
                    return false;
                }


                if (!rbEsforcoAdicionalAte10porCento.Checked 
                    && !rbEsforcoAdicional11A20PorCento.Checked
                    && !rbEsforcoAdicional21A40PorCento.Checked
                    && !rbEsforcoAdicionalAcima40PorCento.Checked)
                {
                    MessageBox.Show("E necessario informar o esforco Adicional para cadastrar o projeto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }


                if (_bindingSourceReceitaVariavel.Count <= 0)
                {
                    MessageBox.Show("O cadastro de projeto deve conter ao menos um lancamento de Receita/Despesa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbFluxoDeCaixa.Select();
                    return false;
                }


                if (_bindingSourceProjetoPessoa.Count <= 0)
                {
                    MessageBox.Show("O cadastro de projeto deve conter ao menos um lancamento de Participantes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbParticipantes.Select();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private bool ValidarInformacoesProjetoReceitaVariavel()
        {
            try
            {

                if (dtpReceitaVariavelPeriodo.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("O periodo do fluxo de caixa do projeto deve ser maior ou igual a data atual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpReceitaVariavelPeriodo.Focus();
                    return false;
                }

                if (cboReceitaVariavelFluxo.SelectedIndex < 0)
                {
                    MessageBox.Show("E necessario informar o tipo do fluxo a ser cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboReceitaVariavelFluxo.Focus();
                    return false;
                }

                decimal valorFluxoCaixa;
                if (!Decimal.TryParse(txtReceitaVariavelValor.Text, out valorFluxoCaixa))
                {
                    MessageBox.Show("O campo Valor do fluxo de caixa digitado e vazio ou possui um valor invalido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReceitaVariavelValor.Focus();
                    return false;
                }


                if (txtReceitaVariavelObservacoes.Text == String.Empty)
                {
                    MessageBox.Show("O campo Observacoes do fluxo de caixa nao pode ser vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReceitaVariavelObservacoes.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private bool ValidarInformacoesProjetoPessoa()
        {
            if (_objectPesquisaProjetoPessoaParticipante is null)
            {
                MessageBox.Show("Deve ser informado a Pessoa para cadastrar o participante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnProjetoPessoaPesquisaPessoa.Focus();
                return false;
            }


            if (txtProjetoPessoaOcupacao.Text == String.Empty)
            {
                MessageBox.Show("O campo Ocupacao deve ser preenchido para cadastrar o participante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProjetoPessoaOcupacao.Focus();
                return false;
            }


            if (txtProjetoPessoaObservacoes.Text == String.Empty)
            {
                MessageBox.Show("O campo Observacoes deve ser preenchido para cadastrar o participante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProjetoPessoaObservacoes.Focus();
                return false;
            }


            return true;
        }


        private void CarregarObjetosPesquisa()
        {
            try
            {
                if (!(_currentObject is null))
                {
                    if (!(_currentObject.EntityObject.GERENTEPROJETO is null))
                        _objectPesquisaGerente = new RegraNegocio.View.Pessoas.ViewPessoa(_currentObject.EntityObject.GERENTEPROJETO);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CarregarObjetosPesquisaProjetoReceitaVariavel()
        {

        }

        private void CarregarObjetosPesquisaProjetoPessoa()
        {
            try
            {

                if (!(_currentObjectProjetoPessoa is null))
                {
                    if (!(_currentObjectProjetoPessoa.EntityObject.PESSOA is null))
                        _objectPesquisaProjetoPessoaParticipante = new RegraNegocio.View.Pessoas.ViewPessoa(_currentObjectProjetoPessoa.EntityObject.PESSOA);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void frmCadastroProjetos_Load(object sender, EventArgs e)
        {
            MudarStatusInformacao(StatusInformacao.SEMACAO);
            MudarStatusInformacaoProjetoReceitaVariavel(StatusInformacao.SEMACAO);
            MudarStatusInformacaoProjetoPessoa(StatusInformacao.SEMACAO);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Cadastros.Pesquisa.frmPesquisaProjeto frmPesquisaProjeto = new Cadastros.Pesquisa.frmPesquisaProjeto();

                _currentObject = frmPesquisaProjeto.ShowDialogResultObjectSearch();

                if (_currentObject is null && !(_bindingSource.Current is null))
                    _currentObject = (_bindingSource.Current as ObjectView<RegraNegocio.View.Projetos.ViewProjeto>).Object;

                if (!(_currentObject is null))
                {
                    CarregarInformacoesGerais();
                    CarregarInformacoesGeraisProjetoReceitaVariavel();
                    CarregarInformacoesGeraisProjetoPessoa();
                }
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
                _currentObject = new RegraNegocio.View.Projetos.ViewProjeto(projetosRegraNegocio.Insert());

                _bindingSource.SuspendBinding();
                MudarStatusInformacao(StatusInformacao.INCLUSAO);
                DesabilitarDataBindingComponentes();

                CarregarInformacoesGeraisProjetoReceitaVariavel();
                CarregarInformacoesGeraisProjetoPessoa();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!(_currentObject is null))
                {
                    projetosRegraNegocio.Update(_currentObject.EntityObject);
                    MudarStatusInformacao(StatusInformacao.ALTERACAO);

                    CarregarObjetosPesquisa();
                    DesabilitarDataBindingComponentes();

                    CarregarInformacoesGeraisProjetoReceitaVariavel();
                    CarregarInformacoesGeraisProjetoPessoa();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(String.Format("Deseja realmente cancelar a {0} das informações?", (_statusInformacao.Equals(StatusInformacao.INCLUSAO) ? ("INCLUSÃO") : ("ALTERAÇÃO"))), "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    projetosRegraNegocio.RollBackLastOperation();

                    receitaVariavelRegraNegocio.RollBack();
                    projetoPessoaRegraNegocio.RollBack();

                    if (_statusInformacao == StatusInformacao.INCLUSAO)
                        _currentObject = null;

                    CarregarInformacoesGerais();
                    CarregarInformacoesGeraisProjetoReceitaVariavel();
                    CarregarInformacoesGeraisProjetoPessoa();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReceitaVariavelIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                _currentObjectProjetoRececeitaVariavel = new RegraNegocio.View.Projetos.ViewProjetosReceitaVariavel(receitaVariavelRegraNegocio.Insert());

                _bindingSourceReceitaVariavel.SuspendBinding();
                MudarStatusInformacaoProjetoReceitaVariavel(StatusInformacao.INCLUSAO);

                DesabilitarDataBindingComponentesProjetoReceitaVariavel();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnReceitaVariavelEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(_currentObjectProjetoRececeitaVariavel is null))
                {
                    receitaVariavelRegraNegocio.Update(_currentObjectProjetoRececeitaVariavel.EntityObject);
                    MudarStatusInformacaoProjetoReceitaVariavel(StatusInformacao.ALTERACAO);

                    CarregarObjetosPesquisaProjetoReceitaVariavel();

                    DesabilitarDataBindingComponentesProjetoReceitaVariavel();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnReceitaVariavelExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(_currentObjectProjetoRececeitaVariavel is null))
                {
                    receitaVariavelRegraNegocio.Delete(_currentObjectProjetoRececeitaVariavel.EntityObject);
                    CarregarInformacoesGeraisProjetoReceitaVariavel();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnReceitaVariavelCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                _currentObjectProjetoRececeitaVariavel = null;
                receitaVariavelRegraNegocio.RollBackLastOperation();
                CarregarInformacoesGeraisProjetoReceitaVariavel();
                HabilitarDataBindingComponentesProjetoReceitaVariavel();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnProjetoPessoaPesquisaPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                Cadastros.Pesquisa.frmPesquisaPessoa frmPesquisaPessoa = new Cadastros.Pesquisa.frmPesquisaPessoa();

                _objectPesquisaProjetoPessoaParticipante = frmPesquisaPessoa.ShowDialogResultObjectSearch();

                if (!(_objectPesquisaProjetoPessoaParticipante is null))
                {
                    txtProjetoPessoaCodPessoa.Text = _objectPesquisaProjetoPessoaParticipante.Id.ToString();
                    txtProjetoPessoaNome.Text = _objectPesquisaProjetoPessoaParticipante.Nome;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnProjetoPessoaIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                _currentObjectProjetoPessoa = new RegraNegocio.View.Projetos.ViewProjetoPessoa(projetoPessoaRegraNegocio.Insert());

                _bindingSourceProjetoPessoa.SuspendBinding();
                MudarStatusInformacaoProjetoPessoa(StatusInformacao.INCLUSAO);

                DesabilitarDataBindingComponentesProjetoPessoa();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnProjetoPessoaEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(_currentObjectProjetoPessoa is null))
                {
                    projetoPessoaRegraNegocio.Update(_currentObjectProjetoPessoa.EntityObject);
                    MudarStatusInformacaoProjetoPessoa(StatusInformacao.ALTERACAO);

                    CarregarObjetosPesquisaProjetoPessoa();

                    DesabilitarDataBindingComponentesProjetoPessoa();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnprojetoPessoaExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(_currentObjectProjetoPessoa is null))
                {
                    projetoPessoaRegraNegocio.Delete(_currentObjectProjetoPessoa.EntityObject);
                    CarregarInformacoesGeraisProjetoPessoa();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnprojetoPessoaSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (ValidarInformacoesProjetoPessoa())
                    {
                        AtualizarInformacoesCurrentObjectProjetoPessoa();
                        CarregarInformacoesGeraisProjetoPessoa();
                        HabilitarDataBindingComponentesProjetoPessoa();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnReceitaVariavelSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarInformacoesProjetoReceitaVariavel())
                {
                    AtualizarInformacoesCurrentObjectProjetoReceitaVariavel();
                    CarregarInformacoesGeraisProjetoReceitaVariavel();
                    HabilitarDataBindingComponentesProjetoReceitaVariavel();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnProjetoPessoaCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                _currentObjectProjetoPessoa = null;
                projetoPessoaRegraNegocio.RollBackLastOperation();
                CarregarInformacoesGeraisProjetoPessoa();
                HabilitarDataBindingComponentesProjetoPessoa();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarInformacoes())
                {
                    AtualizarInformacoesCurrentObject();

                    projetosRegraNegocio.Commit();
                    receitaVariavelRegraNegocio.Commit();
                    projetoPessoaRegraNegocio.Commit();

                    HabilitarDataBindingComponentes();
                    HabilitarDataBindingComponentesProjetoReceitaVariavel();
                    HabilitarDataBindingComponentesProjetoPessoa();

                    CarregarInformacoesGerais();
                    CarregarInformacoesGeraisProjetoReceitaVariavel();
                    CarregarInformacoesGeraisProjetoPessoa();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dtgReceitaVariavel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgReceitaVariavel.SelectedRows.Count > 0)
                {
                    if (dtgReceitaVariavel.Columns[e.ColumnIndex].Name == "dtgReceitaVariavelBtnEditar")
                        btnReceitaVariavelEditar_Click(btnReceitaVariavelEditar, new EventArgs());

                    if (dtgReceitaVariavel.Columns[e.ColumnIndex].Name == "dtgReceitaVariavelBtnExcluir")
                        btnReceitaVariavelExcluir_Click(btnReceitaVariavelExcluir, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnPesquisaGerenteProjeto_Click(object sender, EventArgs e)
        {
            try
            {
                Cadastros.Pesquisa.frmPesquisaPessoa frmPesquisaPessoa = new Pesquisa.frmPesquisaPessoa();

                _objectPesquisaGerente = frmPesquisaPessoa.ShowDialogResultObjectSearch();

                if (!(_objectPesquisaGerente is null))
                {
                    txtCodigoGerente.Text = _objectPesquisaGerente.Id.ToString();
                    txtNomeGerenteProjeto.Text = _objectPesquisaGerente.Nome.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void _bindingSourceReceitaVariavel_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //se o objecto corrent do bindingsourcereceitavariavel for diferente de nulo, atribui ao _currentObject projeto receita variavel, se não atribui null
                if (!(_bindingSourceReceitaVariavel.Current is null))
                    _currentObjectProjetoRececeitaVariavel = (_bindingSourceReceitaVariavel.Current as ObjectView<RegraNegocio.View.Projetos.ViewProjetosReceitaVariavel>).Object;
                else
                    _currentObjectProjetoRececeitaVariavel = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void _bindingSourceProjetoPessoa_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //se o objecto corrent do bindingSourceProjetoPessoa for diferente de nulo, atribui ao _currentObjectProjetopessoa, se não atribui null
                if (!(_bindingSourceProjetoPessoa.Current is null))
                    _currentObjectProjetoPessoa = (_bindingSourceProjetoPessoa.Current as ObjectView<RegraNegocio.View.Projetos.ViewProjetoPessoa>).Object;
                else
                    _currentObjectProjetoPessoa = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente " + btnInativar.Text + " o registro {Id =" + _currentObject.Id + " Nome = " + _currentObject.Nome + "} ?", "Mudar Status",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    projetosRegraNegocio.ChangeState(_currentObject.EntityObject);
                    projetosRegraNegocio.Commit();

                    CarregarInformacoesGerais();
                    CarregarInformacoesGeraisProjetoReceitaVariavel();
                    CarregarInformacoesGeraisProjetoPessoa(); 
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dtgProjetoPessoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgProjetoPessoa.SelectedRows.Count > 0)
                {
                    if (dtgProjetoPessoa.Columns[e.ColumnIndex].Name == "dtgProjetoPessoaBtnEditar")
                        btnProjetoPessoaEditar_Click(btnProjetoPessoaEditar, new EventArgs());

                    if (dtgProjetoPessoa.Columns[e.ColumnIndex].Name == "dtgProjetoPessoaBtnExcluir")
                        btnprojetoPessoaExcluir_Click(btnprojetoPessoaExcluir, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void _bindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
