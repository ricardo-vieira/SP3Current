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

namespace projProjetos.Forms.Cadastros
{
    public partial class frmCadastroPessoas : Form
    {
        RegraNegocio.Pessoas pessoasRegraNegocio = new RegraNegocio.Pessoas();

        StatusInformacao _statusInformacao = StatusInformacao.SEMACAO;

        BindingListView<RegraNegocio.View.Pessoas.ViewPessoa> _bindingListView;

        RegraNegocio.View.Pessoas.ViewPessoa _currentObject;

        public frmCadastroPessoas()
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
                    btnEditar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnInativar.Enabled = false;
                    btnPesquisar.Enabled = false;

                    txtNome.ReadOnly = false;
                    txtObservacoes.ReadOnly = false;

                    txtDataEdicao.Visible = false;
                    lblDataCriacao.Visible = false;
                    break;

                case StatusInformacao.ALTERACAO:

                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnInativar.Enabled = false;
                    btnPesquisar.Enabled = false;

                    txtNome.ReadOnly = false;
                    txtObservacoes.ReadOnly = false;

                    txtDataEdicao.Visible = false;
                    lblDataCriacao.Visible = false;
                    break;
                case StatusInformacao.SELECAO:

                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnInativar.Enabled = true;
                    btnPesquisar.Enabled = true;

                    txtNome.ReadOnly = true;
                    txtObservacoes.ReadOnly = true;

                    txtDataEdicao.Visible = true;
                    lblDataCriacao.Visible = true;
                    break;

                case StatusInformacao.SEMACAO:
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnInativar.Enabled = false;
                    btnPesquisar.Enabled = true;

                    txtNome.ReadOnly = true;
                    txtObservacoes.ReadOnly = true;

                    txtDataEdicao.Visible = true;
                    lblDataCriacao.Visible = true;
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
                    _bindingListView = new BindingListView<RegraNegocio.View.Pessoas.ViewPessoa>(pessoasRegraNegocio.ToList());
                    _bindingSource.DataSource = _bindingListView;
                }
                else
                {
                    _bindingListView.RemoveFilter();
                    _bindingListView.DataSource = pessoasRegraNegocio.ToList();
                    _bindingListView.Refresh();
                }



                if ((_currentObject is null) && !(_bindingSource.Current is null))
                {
                    _currentObject = (_bindingSource.Current as ObjectView<RegraNegocio.View.Pessoas.ViewPessoa>).Object;
                }

                RegraNegocio.View.Pessoas.ViewPessoa _bindingSourceCurrentObject = (_bindingSource.Current is null) ? (null) : (_bindingSource.Current as ObjectView<RegraNegocio.View.Pessoas.ViewPessoa>).Object;

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


        private void HabilitarDataBindingComponentes()
        {

        }


        private void DesabilitarDataBindingComponentes()
        {

        }


        private void AtualizarInformacoesCurrentObject()
        {
            try
            {
                _currentObject.EntityObject.NOME = txtNome.Text;
                _currentObject.EntityObject.OBSERVACAO = txtObservacoes.Text;
                _currentObject.EntityObject.DATACRIACAO = DateTime.Now;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private bool ValidarInformacoes()
        {
            if (txtNome.Text == String.Empty)
            {
                MessageBox.Show("O campo nome deve ser preenchido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return false;
            }

            if (txtObservacoes.Text == String.Empty)
            {
                MessageBox.Show("O campo observacoes deve ser preenchido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtObservacoes.Focus();
                return false;
            }

            return true;
        }


        private void CarregarObjetosPesquisa()
        {

        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            //mensagem antes de sair sem salvar as informações
            if ((_statusInformacao.Equals(StatusInformacao.INCLUSAO) || _statusInformacao.Equals(StatusInformacao.ALTERACAO))                                                              // se a informação estiver sendo inserida ou alterada
                && !(MessageBox.Show("Deseja sair do formulário sem salvar as informações?", "Informação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)) // e o resultado da caixa não diferente "SIM"
            {
                return;               //então finaliza o metodo
            }

            this.Close();             //fecha o formulário
            return;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(_currentObject is null))
                {
                    pessoasRegraNegocio.Update(_currentObject.EntityObject);
                    MudarStatusInformacao(StatusInformacao.ALTERACAO);

                    CarregarObjetosPesquisa();
                    DesabilitarDataBindingComponentes();


                }
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
                    pessoasRegraNegocio.ChangeState(_currentObject.EntityObject);
                    pessoasRegraNegocio.Commit();

                    CarregarInformacoesGerais();


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmPessoas_Load(object sender, EventArgs e)
        {
            MudarStatusInformacao(StatusInformacao.SEMACAO);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                _currentObject = new RegraNegocio.View.Pessoas.ViewPessoa(pessoasRegraNegocio.Insert());

                _bindingSource.SuspendBinding();
                MudarStatusInformacao(StatusInformacao.INCLUSAO);
                DesabilitarDataBindingComponentes();


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
                    AtualizarInformacoesCurrentObject();

                    pessoasRegraNegocio.Commit();

                    HabilitarDataBindingComponentes();

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
                if (MessageBox.Show(String.Format("Deseja realmente cancelar a {0} das informações?", (_statusInformacao.Equals(StatusInformacao.INCLUSAO) ? ("INCLUSÃO") : ("ALTERAÇÃO"))), "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pessoasRegraNegocio.RollBackLastOperation();

                    if (_statusInformacao == StatusInformacao.INCLUSAO)
                        _currentObject = null;

                    CarregarInformacoesGerais();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Pesquisa.frmPesquisaPessoa frmPesquisaPessoa = new Pesquisa.frmPesquisaPessoa();

                _currentObject = frmPesquisaPessoa.ShowDialogResultObjectSearch();

                if (_currentObject is null && !(_bindingSource.Current is null))
                    _currentObject = (_bindingSource.Current as ObjectView<RegraNegocio.View.Pessoas.ViewPessoa>).Object;

                if (!(_currentObject is null))
                {
                    CarregarInformacoesGerais();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
