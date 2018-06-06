using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Equin.ApplicationFramework;


namespace projProjetos.Forms.Cadastros.Pesquisa
{
    public partial class frmPesquisaPessoa : Form
    {
        RegraNegocio.Pessoas pessoasRegranegocio = new RegraNegocio.Pessoas();
        BindingListView<RegraNegocio.View.Pessoas.ViewPessoa> _bindingListView;
        Ferramentas.ObjectFilter<RegraNegocio.View.Pessoas.ViewPessoa> _objectFilter;

        RegraNegocio.View.Pessoas.ViewPessoa _currentObject;


        public frmPesquisaPessoa()
        {
            InitializeComponent();
        }

        private void CarregarInformacoesGerais()
        {
            try
            {

                if (_bindingListView is null)
                    _bindingListView = new BindingListView<RegraNegocio.View.Pessoas.ViewPessoa>(pessoasRegranegocio.ToList());
                else
                {
                    _bindingListView.DataSource = pessoasRegranegocio.ToList();
                    _bindingListView.Refresh();
                }

                _bindingSource.DataSource = _bindingListView;


                CarregarInformacoes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CarregarInformacoes()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarFiltro()
        {
            long id;
            if (txtCodigo.Text != String.Empty && !long.TryParse(txtCodigo.Text, out id))
            {
                MessageBox.Show("O valor digitado no campo Codigo e invalido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Focus();
                return false;
            }

            return true;
        }

        private void AdicionarFiltro(Expression<Predicate<RegraNegocio.View.Pessoas.ViewPessoa>> filtro, bool reiniciarFiltro = false)
        {
            try
            {
                if (_objectFilter is null || reiniciarFiltro)
                {
                    _objectFilter = new Ferramentas.ObjectFilter<RegraNegocio.View.Pessoas.ViewPessoa>(filtro);
                }
                else
                {
                    _objectFilter.AddPredicate(Ferramentas.ObjectFilterBinaryLogicalOperators.AND, filtro);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ApplicarFiltro(bool filtroVazio = false)
        {
            try
            {
                if (filtroVazio)
                    _objectFilter = null;

                if (_objectFilter is null)
                {
                    _bindingListView.RemoveFilter();
                    _bindingListView.Refresh();
                }
                else
                {
                    _bindingListView.ApplyFilter(_objectFilter.Filter);
                    _bindingListView.Refresh();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CriarFiltro()
        {
            try
            {
                ApplicarFiltro(true);

                if (txtCodigo.Text != String.Empty)
                    AdicionarFiltro(x => x.Id == Convert.ToInt64(txtCodigo.Text.ToUpper()));

                if (txtNome.Text != String.Empty)
                    AdicionarFiltro(x => x.Nome.ToUpper().Contains(txtNome.Text));

                if (cboStatus.SelectedIndex > 0)
                    AdicionarFiltro(x => x.Status.ToUpper() == cboStatus.SelectedItem.ToString().ToUpper());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void frmPesquisaPessoa_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarInformacoesGerais();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);;
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                _currentObject = (_bindingSource.Current as ObjectView<RegraNegocio.View.Pessoas.ViewPessoa>).Object;
                this.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public RegraNegocio.View.Pessoas.ViewPessoa ShowDialogResultObjectSearch()
        {
            try
            {

                ShowDialog();

                return _currentObject;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void blnFiltrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (ValidarFiltro())
                {
                    CriarFiltro();
                    ApplicarFiltro();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dtgPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgPrincipal.SelectedRows.Count > 0 )
                {
                    btnSelecionar_Click(btnSelecionar, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
