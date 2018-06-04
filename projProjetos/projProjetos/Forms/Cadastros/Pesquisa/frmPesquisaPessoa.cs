﻿using System;
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

        private void frmPesquisaPessoa_Load(object sender, EventArgs e)
        {

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
                CarregarInformacoesGerais();
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
                _objectFilter = new Ferramentas.ObjectFilter<RegraNegocio.View.Pessoas.ViewPessoa>();


                if (txtNome.Text.Length > 0)
                    _objectFilter.AddPredicate(Ferramentas.ObjectFilterLogicalOperators.AND, pessoa => pessoa.Nome.Contains(txtNome.Text));

                if (_objectFilter.Count > 0)
                {
                    _bindingListView.ApplyFilter(_objectFilter.GetFilter());
                    _bindingListView.Refresh();
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