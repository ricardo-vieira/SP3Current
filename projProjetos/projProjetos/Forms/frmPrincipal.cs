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
using projProjetos.Ferramentas;

namespace projProjetos.Forms
{
    public partial class frmPrincipal : Form
    {
        RegraNegocio.Reunioes reunioesRegraNegocio = new RegraNegocio.Reunioes();
        RegraNegocio.Projetos projetosRegraNegocio = new RegraNegocio.Projetos();
        RegraNegocio.Pessoas pessoasRegraNegocio = new RegraNegocio.Pessoas();


        BindingListView<RegraNegocio.View.Reunioes.ViewReuniao> _bindingListViewAgenda_Reuniao;
        BindingListView<RegraNegocio.View.Projetos.ViewProjeto> _bindingListViewAgenda_Projeto;
        BindingListView<RegraNegocio.View.Pessoas.ViewPessoa> _bindingListViewAgenda_Pessoa;


        ObjectFilter<RegraNegocio.View.Reunioes.ViewReuniao> _objectFilterAgenda_Reuniao;
        ObjectFilter<RegraNegocio.View.Projetos.ViewProjeto> _objectFilterAgenda_Projeto;
        ObjectFilter<RegraNegocio.View.Pessoas.ViewPessoa> _objectFilterAgenda_Pessoa;

        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void CarregarInformacoesGerais()
        {

        }

        private void CarregarInformacoesGeraisAgenda()
        {
            try
            {
                CarregarInformacoesGeraisAgenda_Reuniao();
                CarregarInformacoesGeraisAgenda_Pessoa();
                CarregarInformacoesGeraisAgenda_Projeto();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CarregarInformacoesGeraisAgenda_Reuniao()
        {
            try
            {
                ///caso o bindinglist estiver vazio, recebera uma nova instancia
                if (_bindingListViewAgenda_Reuniao is null)
                {
                    _bindingListViewAgenda_Reuniao = new BindingListView<RegraNegocio.View.Reunioes.ViewReuniao>(reunioesRegraNegocio.ToList());
                    _bindingSourceAgenda_Reunioes.DataSource = _bindingListViewAgenda_Reuniao;
                }
                else
                {
                    _bindingListViewAgenda_Reuniao.RemoveFilter();
                    _bindingListViewAgenda_Reuniao.DataSource = reunioesRegraNegocio.ToList();
                    _bindingListViewAgenda_Reuniao.Refresh();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CarregarInformacoesGeraisAgenda_Pessoa()
        {
            try
            {
                ///caso o bindinglist estiver vazio, recebera uma nova instancia
                if (_bindingListViewAgenda_Pessoa is null)
                {
                    _bindingListViewAgenda_Pessoa = new BindingListView<RegraNegocio.View.Pessoas.ViewPessoa>(pessoasRegraNegocio.ToList());
                    _bindingSourceAgenda_Pessoas.DataSource = _bindingListViewAgenda_Pessoa;
                }
                else
                {
                    _bindingListViewAgenda_Pessoa.RemoveFilter();
                    _bindingListViewAgenda_Pessoa.DataSource = pessoasRegraNegocio.ToList();
                    _bindingListViewAgenda_Pessoa.Refresh();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CarregarInformacoesGeraisAgenda_Projeto()
        {
            try
            {
                ///caso o bindinglist estiver vazio, recebera uma nova instancia
                if (_bindingListViewAgenda_Projeto is null)
                {
                    _bindingListViewAgenda_Projeto = new BindingListView<RegraNegocio.View.Projetos.ViewProjeto>(projetosRegraNegocio.ToList());
                    _bindingSourceAgenda_Projetos.DataSource = _bindingListViewAgenda_Projeto;
                }
                else
                {
                    _bindingListViewAgenda_Projeto.RemoveFilter();
                    _bindingListViewAgenda_Projeto.DataSource = projetosRegraNegocio.ToList();
                    _bindingListViewAgenda_Projeto.Refresh();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private bool ValidarFiltroAgenda_Reuniao()
        {
            return true;
        }

        private bool ValidarFiltroAgenda_Pessoa()
        {
            long id;
            if (txtAgendaFiltroPessoasCodigo.Text != String.Empty && !long.TryParse(txtAgendaFiltroPessoasCodigo.Text, out id))
            {
                MessageBox.Show("O valor digitado no campo Codigo de Pessoa e invalido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAgendaFiltroPessoasCodigo.Focus();
                return false;
            }

            return true;
        }

        private bool ValidarFiltroAgenda_Projeto()
        {
            long id;
            if (txtAgendaFiltroProjetosCodigo.Text != String.Empty && !long.TryParse(txtAgendaFiltroProjetosCodigo.Text, out id))
            {
                MessageBox.Show("O valor digitado no campo Codigo de Projetos e invalido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAgendaFiltroProjetosCodigo.Focus();
                return false;
            }

            return true;
        }


        private void AdicionarFiltroAgenda_Reuniao(Expression<Predicate<RegraNegocio.View.Reunioes.ViewReuniao>> filtro, bool reiniciarFiltro = false)
        {
            try
            {
                if (_objectFilterAgenda_Reuniao is null || reiniciarFiltro)
                {
                    _objectFilterAgenda_Reuniao = new Ferramentas.ObjectFilter<RegraNegocio.View.Reunioes.ViewReuniao>(filtro);
                }
                else
                {
                    _objectFilterAgenda_Reuniao.AddPredicate(Ferramentas.ObjectFilterBinaryLogicalOperators.AND, filtro);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AdicionarFiltroAgenda_Pessoa(Expression<Predicate<RegraNegocio.View.Pessoas.ViewPessoa>> filtro, bool reiniciarFiltro = false)
        {
            try
            {
                if (_objectFilterAgenda_Pessoa is null || reiniciarFiltro)
                {
                    _objectFilterAgenda_Pessoa = new Ferramentas.ObjectFilter<RegraNegocio.View.Pessoas.ViewPessoa>(filtro);
                }
                else
                {
                    _objectFilterAgenda_Pessoa.AddPredicate(Ferramentas.ObjectFilterBinaryLogicalOperators.AND, filtro);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AdicionarFiltroAgenda_Projeto(Expression<Predicate<RegraNegocio.View.Projetos.ViewProjeto>> filtro, bool reiniciarFiltro = false)
        {
            try
            {
                if (_objectFilterAgenda_Projeto is null || reiniciarFiltro)
                {
                    _objectFilterAgenda_Projeto = new Ferramentas.ObjectFilter<RegraNegocio.View.Projetos.ViewProjeto>(filtro);
                }
                else
                {
                    _objectFilterAgenda_Projeto.AddPredicate(Ferramentas.ObjectFilterBinaryLogicalOperators.AND, filtro);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void AplicarFiltroAgenda(bool filtroVazio = false)
        {
            try
            {
                AplicarFiltroAgenda_Pessoa(filtroVazio);
                AplicarFiltroAgenda_Projeto(filtroVazio);
                AplicarFiltroAgenda_Reuniao(filtroVazio);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void AplicarFiltroAgenda_Reuniao(bool filtroVazio = false)
        {
            try
            {
                if (filtroVazio)
                    _objectFilterAgenda_Reuniao = null;

                if (_objectFilterAgenda_Reuniao is null)
                {
                    _bindingListViewAgenda_Reuniao.RemoveFilter();
                    _bindingListViewAgenda_Reuniao.Refresh();
                }
                else
                {
                    _bindingListViewAgenda_Reuniao.ApplyFilter(_objectFilterAgenda_Reuniao.Filter);
                    _bindingListViewAgenda_Reuniao.Refresh();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AplicarFiltroAgenda_Pessoa(bool filtroVazio = false)
        {
            try
            {
                if (filtroVazio)
                    _objectFilterAgenda_Pessoa = null;

                if (_objectFilterAgenda_Pessoa is null)
                {
                    _bindingListViewAgenda_Pessoa.RemoveFilter();
                    _bindingListViewAgenda_Pessoa.Refresh();
                }
                else
                {
                    _bindingListViewAgenda_Pessoa.ApplyFilter(_objectFilterAgenda_Pessoa.Filter);
                    _bindingListViewAgenda_Pessoa.Refresh();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AplicarFiltroAgenda_Projeto(bool filtroVazio = false)
        {
            try
            {
                if (filtroVazio)
                    _objectFilterAgenda_Projeto = null;

                if (_objectFilterAgenda_Projeto is null)
                {
                    _bindingListViewAgenda_Projeto.RemoveFilter();
                    _bindingListViewAgenda_Projeto.Refresh();
                }
                else
                {
                    _bindingListViewAgenda_Projeto.ApplyFilter(_objectFilterAgenda_Projeto.Filter);
                    _bindingListViewAgenda_Projeto.Refresh();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void CriarFiltroAgenda()
        {
            try
            {
                CriarFiltroAgenda_Reuniao();
                CriarFiltroAgenda_Projeto();
                CriarFiltroAgenda_Pessoa();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CriarFiltroAgenda_Reuniao()
        {
            try
            {
                AplicarFiltroAgenda_Reuniao(true);

                if (cblAgendaFiltroReuniao.SelectedItems.Count > 0)
                {
                    List<string> situacaoReuniao = new List<string>();

                    foreach (var cboSelectedItem in cblAgendaFiltroReuniao.SelectedItems)
                    {
                        situacaoReuniao.Add(cboSelectedItem.ToString().ToUpper());
                    }

                    AdicionarFiltroAgenda_Reuniao(x => situacaoReuniao.Contains(x.Situacao.ToUpper()));
                }

                if (ckbFiltroReuniaoData.Checked)
                {
                    if (cboAgendaFiltroReuniaoData.SelectedItem.ToString() == "Cadastro")
                        AdicionarFiltroAgenda_Reuniao(x => x.DataHoraCriacao.Date >= mtcAgendaFiltroReuniao.SelectionStart && x.DataHoraCriacao.Date <= mtcAgendaFiltroReuniao.SelectionEnd);

                    else if (cboAgendaFiltroReuniaoData.SelectedItem.ToString() == "Agendamento")
                        AdicionarFiltroAgenda_Reuniao(x => x.DataHoraEvento.Date >= mtcAgendaFiltroReuniao.SelectionStart && x.DataHoraEvento.Date <= mtcAgendaFiltroReuniao.SelectionEnd);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CriarFiltroAgenda_Pessoa()
        {
            try
            {
                AplicarFiltroAgenda_Pessoa(true);

                if (txtAgendaFiltroPessoasCodigo.Text != String.Empty)
                    AdicionarFiltroAgenda_Pessoa(x => x.Id == Convert.ToInt64(txtAgendaFiltroPessoasCodigo.Text));

                if (txtAgendaFiltroPessoasNome.Text != String.Empty)
                    AdicionarFiltroAgenda_Pessoa(x => x.Nome.Contains(txtAgendaFiltroPessoasNome.Text));

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CriarFiltroAgenda_Projeto()
        {
            try
            {
                AplicarFiltroAgenda_Projeto(true);

                if (txtAgendaFiltroProjetosCodigo.Text != String.Empty)
                    AdicionarFiltroAgenda_Projeto(x => x.Id == Convert.ToInt64(txtAgendaFiltroProjetosCodigo.Text));

                if (txtAgendaFiltroProjetosNome.Text != String.Empty)
                    AdicionarFiltroAgenda_Projeto(x => x.Nome.Contains(txtAgendaFiltroProjetosNome.Text));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void ExecutarFiltroAgenda_Reuniao()
        {
            try
            {
                if (ValidarFiltroAgenda_Reuniao())
                {
                    CriarFiltroAgenda_Reuniao();
                    AplicarFiltroAgenda_Reuniao();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ExecutarFiltroAgenda_Pessoa()
        {
            try
            {
                if (ValidarFiltroAgenda_Pessoa())
                {
                    CriarFiltroAgenda_Pessoa();
                    AplicarFiltroAgenda_Pessoa();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ExecutarFiltroAgenda_Projeto()
        {
            try
            {
                if (ValidarFiltroAgenda_Projeto())
                {
                    CriarFiltroAgenda_Projeto();
                    AplicarFiltroAgenda_Projeto();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void RedimensionarComponentes()
        {

        }

        private void RedimensionarComponentesAgenda()
        {
            grbReunioes.Width = (tbpAgenda.Width - 20);
            grbReunioes.Height = Convert.ToInt32(tbpAgenda.Height * 0.45);

            grbPessoas.Location = new Point(grbPessoas.Location.X, grbReunioes.Height + 15);
            grbPessoas.Width = Convert.ToInt32((tbpAgenda.Width - 40) * 0.40);
            grbPessoas.Height = (tbcParincipal.Height - grbPessoas.Location.Y - 40);

            grbProjetos.Location = new Point(grbPessoas.Width + 20, grbReunioes.Height + 15);
            grbProjetos.Width = (tbpAgenda.Width - grbProjetos.Location.X - 14);
            grbProjetos.Height = (tbcParincipal.Height - grbProjetos.Location.Y - 40);


            cblAgendaFiltroReuniao.Height = ckbFiltroReuniaoData.Location.Y - 35;

        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            RedimensionarComponentesAgenda();
            CarregarInformacoesGerais();
            CarregarInformacoesGeraisAgenda();
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            RedimensionarComponentesAgenda();
        }

        private void timmer_Tick(object sender, EventArgs e)
        {
            try
            {
                CarregarInformacoesGeraisAgenda();
                AplicarFiltroAgenda();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ckbFiltroReuniaoData_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cboAgendaFiltroReuniaoData.Visible = ckbFiltroReuniaoData.Checked;
                mtcAgendaFiltroReuniao.Visible = ckbFiltroReuniaoData.Checked;

                ExecutarFiltroAgenda_Reuniao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cklAgendaFiltroReuniao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ExecutarFiltroAgenda_Reuniao();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cboAgendaFiltroReuniaoData_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ExecutarFiltroAgenda_Reuniao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mtcAgendaFiltroReuniao_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                ExecutarFiltroAgenda_Reuniao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtAgendaFiltroPessoasCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ExecutarFiltroAgenda_Pessoa();
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        private void txtAgendaFiltroPessoasNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ExecutarFiltroAgenda_Pessoa();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtAgendaFiltroProjetosCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ExecutarFiltroAgenda_Projeto();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtAgendaFiltroProjetosNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ExecutarFiltroAgenda_Projeto();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cboAgendaFiltroProjetosSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ExecutarFiltroAgenda_Projeto();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void tbpAgenda_Resize(object sender, EventArgs e)
        {
            RedimensionarComponentesAgenda();
        }
    }
}
