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

using projProjetos.Forms.Cadastros;

namespace projProjetos.Forms
{
    public partial class FrmPrincipal : Form
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


        FrmCadastroPessoas frmCadastroPessoas;
        FrmCadastroProjetos frmCadastroProjetos;
        frmReunioes frmReunioes;

        public FrmPrincipal()
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
                FinalizarEdicaoComponentesAgenda();

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
                    _bindingListViewAgenda_Pessoa.DataSource = ListarObjetosAgenda_Pessoa();
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


        private void FinalizarEdicaoComponentes()
        {

        }

        private void FinalizarEdicaoComponentesAgenda()
        {
            try
            {
                dtgAgendaReunioes.EndEdit();
                dtgAgendaPessoas.EndEdit();
                dtgAgendaProjetos.EndEdit();
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

                if (lvwAgendaReuniaoSituacao.CheckedItems.Count > 0)
                {
                    List<string> situacaoReuniao = new List<string>();

                    foreach (ListViewItem lvwAgendaReuniaoSituacaoItem in lvwAgendaReuniaoSituacao.CheckedItems)
                    {
                        situacaoReuniao.Add(lvwAgendaReuniaoSituacaoItem.Text.ToUpper());
                    }

                    AdicionarFiltroAgenda_Reuniao(x => situacaoReuniao.Contains(x.Situacao.ToUpper()));
                }

                if (ckbFiltroReuniaoData.Checked && !(cboAgendaFiltroReuniaoData.SelectedItem is null))
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
                    AdicionarFiltroAgenda_Pessoa(x => x.Nome.ToUpper().Contains(txtAgendaFiltroPessoasNome.Text.ToUpper()));

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
                    AdicionarFiltroAgenda_Projeto(x => x.Nome.ToUpper().Contains(txtAgendaFiltroProjetosNome.Text.ToUpper()));
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


            lvwAgendaReuniaoSituacao.Height = (ckbFiltroReuniaoData.Location.Y - 5 - lvwAgendaReuniaoSituacao.Location.Y);

        }


        private List<RegraNegocio.View.Reunioes.ViewReuniao> ListarObjetosSelecionadosAgenda_Reuniao()
        {
            throw new NotImplementedException();
        }

        private List<RegraNegocio.View.Pessoas.ViewPessoa> ListarObjetosSelecionadosAgenda_Pessoa()
        {
            try
            {
                return _bindingListViewAgenda_Pessoa.Where(x => x.SelecaoGerente || x.SelecaoResponsavel).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<RegraNegocio.View.Projetos.ViewProjeto> ListarObjetosSelecionadosAgenda_Projeto()
        {
            try
            {
                return _bindingListViewAgenda_Projeto.Where(x => x.SelecaoPautado || x.SelecaoPriorizado).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private List<RegraNegocio.View.Reunioes.ViewReuniao> ListarObjetosAgenda_Reuniao()
        {
            throw new NotImplementedException();
        }

        private List<RegraNegocio.View.Pessoas.ViewPessoa> ListarObjetosAgenda_Pessoa()
        {
            try
            {
                List<RegraNegocio.View.Pessoas.ViewPessoa> objetosSelecionadosAgenda_Pessoa = ListarObjetosSelecionadosAgenda_Pessoa();

                List<RegraNegocio.View.Pessoas.ViewPessoa> novosObjetosPessoa = pessoasRegraNegocio.ToList();

                return novosObjetosPessoa
                       .Select(novo => (objetosSelecionadosAgenda_Pessoa.Any(selecionado => selecionado.EntityObject == novo.EntityObject)) 
                                        ? (objetosSelecionadosAgenda_Pessoa.First(selecionado => selecionado.EntityObject == novo.EntityObject)) 
                                        : (novo))
                       .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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


        private void lvwAgendaReuniaoSituacao_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                e.Item.Checked.ToString();
                ExecutarFiltroAgenda_Reuniao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ckbAgendaFiltroPessoaSelecionarResponsavel_CheckedChanged(object sender, EventArgs e)
        {
            dtgAgendapessoaCkbSelecaoResponsavel.Visible = ckbAgendaFiltroPessoaSelecionarResponsavel.Checked;
        }

        private void ckbAgendaFiltroPessoaSelecionarGerente_CheckedChanged(object sender, EventArgs e)
        {
            dtgAgendaPessoaCkbSelecaoGerente.Visible = ckbAgendaFiltroPessoaSelecionarGerente.Checked;
        }

        private void ckbAgendaFiltroProjetoPautado_CheckedChanged(object sender, EventArgs e)
        {
            dtgAgendaProjetosCkbSelecaoPautado.Visible = ckbAgendaFiltroProjetoSelecaoPautado.Checked;
        }

        private void ckbAgendaFiltroProjetoSelecaoPriorizado_CheckedChanged(object sender, EventArgs e)
        {
            dtgAgendaProjetosCkbSelecaoPriorizado.Visible = ckbAgendaFiltroProjetoSelecaoPriorizado.Checked;
        }

        private void dtgAgendaPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroPessoas = new FrmCadastroPessoas();
                frmCadastroPessoas.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroProjetos = new FrmCadastroProjetos();
                frmCadastroProjetos.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void reuniõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmReunioes = new frmReunioes();
                frmReunioes.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void comparaçõesDeCritériosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmComparacoesCriterios = new Gerencia.frmComparacoesCriterios();
            frmComparacoesCriterios.ShowDialog();
        }

        private void comparaçõesCRITERIOPROJETOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmComparacoesCriteriosProjetos = new Gerencia.frmComparacoesCriteriosProjetos();
            frmComparacoesCriteriosProjetos.ShowDialog();
        }

        private void criteriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCriterios = new Gerencia.frmCriterios();
            frmCriterios.ShowDialog();
        }
    }
}
