using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projProjetos.Forms.Cadastros
{
    public partial class frmPrincipal : Form
    {
        RegraNegocio.Pessoas pessoaRegranegocio = new RegraNegocio.Pessoas();
        RegraNegocio.Projetos projetoRegraNegocio = new RegraNegocio.Projetos();
        RegraNegocio.Reunioes reuniaoRegraNegocio = new RegraNegocio.Reunioes();

        List<RegraNegocio.SituacaoReuniao> listaSituacaoReuniao = new List<RegraNegocio.SituacaoReuniao>();


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCadastroPessoas().ShowDialog();
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCadastroProjetos().ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reuniõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmReunioes().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void critériosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Gerencia.frmCriterios().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comparaçõesDeCritériosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new projProjetos.Forms.Gerencia.frmComparacoesCriterios().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comparaçõesCRITERIOPROJETOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new projProjetos.Forms.Gerencia.frmComparacoesCriteriosProjetos().ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnSegurança_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            CarregarInformacoesReunioes();
        }

        private void CarregarInformacoesPessoas()
        {
            try
            {
                RegraNegocio.CampoPessoas campo;
                RegraNegocio.StatusCadastro status;

                if (cboListaPessoas.SelectedItem != null && cboStatusPessoas.SelectedItem != null)
                {
                    Enum.TryParse<RegraNegocio.CampoPessoas>(cboListaPessoas.SelectedItem.ToString(), out campo);
                    Enum.TryParse<RegraNegocio.StatusCadastro>(cboStatusPessoas.SelectedItem.ToString(), out status);

                    dtgPessoas.DataSource = pessoaRegranegocio.Listar(campo, txtPesquisarPessoas.Text, status);

                    dtgPessoas.Columns["dtgPessoasStatus"].DisplayIndex = 3;
                    dtgPessoas.Columns["dtgPessoasBtnVisualizar"].DisplayIndex = 3;

                    for (int i = 0; i < dtgPessoas.Rows.Count -1; i++)
                    {
                        if (i % 2 == 0)
                            dtgPessoas.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                        else
                            dtgPessoas.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarInformacoesProjetos()
        {
            try
            {
                RegraNegocio.CampoProjetos campo;
                RegraNegocio.StatusCadastro status;

                if (cboListaProjetos.SelectedItem != null && cboStatusProjetos.SelectedItem != null)
                {
                    Enum.TryParse<RegraNegocio.CampoProjetos>(cboListaProjetos.SelectedItem.ToString(), out campo);
                    Enum.TryParse<RegraNegocio.StatusCadastro>(cboStatusProjetos.SelectedItem.ToString(), out status);

                    dtgprojetos.DataSource = projetoRegraNegocio.Listar(campo, txtPesquisarProjetos.Text, status);

                    dtgprojetos.Columns["dtgProjetosNome"].DisplayIndex = 1;
                    dtgprojetos.Columns["dtgProjetosGerente"].DisplayIndex = 2;
                    dtgprojetos.Columns["dtgProjetosStatus"].DisplayIndex = 4;
                    dtgprojetos.Columns["dtgProjetosVisualizar"].DisplayIndex = 4;

                    for (int i = 0; i < dtgprojetos.Rows.Count - 1; i++)
                    {
                        if (i % 2 == 0)
                            dtgprojetos.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                        else
                            dtgprojetos.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarInformacoesReunioes()
        {
            try
            {
                if (listaSituacaoReuniao.Count <= 0)
                    listaSituacaoReuniao.AddRange(new[] { RegraNegocio.SituacaoReuniao.CANCELADO,
                                                          RegraNegocio.SituacaoReuniao.EFETIVADO,
                                                          RegraNegocio.SituacaoReuniao.OPERAÇÃO
                                                        });

                dtgReunioes.DataSource = reuniaoRegraNegocio.Listar(null, mtcReunioes.SelectionRange.Start.Date, listaSituacaoReuniao.ToArray());

                for (int i = 0; i < dtgReunioes.Rows.Count; i++)
                {
                    dtgReunioes.Rows[i].DefaultCellStyle.BackColor = (i % 2 == 0) ? (Color.SkyBlue) : (Color.White);

                    switch (dtgReunioes.Rows[i].Cells["dtgReunioesSituacao"].Value.ToString())
                    {
                        case "EM OPERAÇÃO":
                            dtgReunioes.Rows[i].Cells["dtgReunioesSituacao"].Style.BackColor = Color.Blue;
                            break;

                        case "EFETIVADO":
                            dtgReunioes.Rows[i].Cells["dtgReunioesSituacao"].Style.BackColor = Color.Green;
                            break;

                        case "CANCELADO":
                            dtgReunioes.Rows[i].Cells["dtgReunioesSituacao"].Style.BackColor = Color.Red;
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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                cboListaPessoas.DataSource = Enum.GetValues(typeof(RegraNegocio.CampoPessoas));
                cboListaPessoas.SelectedIndex = 0;

                cboStatusPessoas.DataSource = Enum.GetValues(typeof(RegraNegocio.StatusCadastro));
                cboStatusPessoas.SelectedIndex = 0;

                cboListaProjetos.DataSource = Enum.GetValues(typeof(RegraNegocio.CampoProjetos));
                cboListaProjetos.SelectedIndex = 0;

                cboStatusProjetos.DataSource = Enum.GetValues(typeof(RegraNegocio.StatusCadastro));
                cboStatusProjetos.SelectedIndex = 0;

                CarregarInformacoesReunioes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboListaPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarInformacoesPessoas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboStatusPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarInformacoesPessoas();
        }

        private void txtPesquisarPessoas_TextChanged(object sender, EventArgs e)
        {
            CarregarInformacoesPessoas();
        }

        private void cboListaProjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarInformacoesProjetos();
        }

        private void cboStatusProjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarInformacoesProjetos();
        }

        private void txtPesquisarProjetos_TextChanged(object sender, EventArgs e)
        {
            CarregarInformacoesProjetos();
        }

        private void rbCancelado_CheckedChanged(object sender, EventArgs e)
        {
            listaSituacaoReuniao = new List<RegraNegocio.SituacaoReuniao>();

            if (cbCancelado.Checked)
                listaSituacaoReuniao.Add(RegraNegocio.SituacaoReuniao.CANCELADO);

            if (cbEfetivado.Checked)
                listaSituacaoReuniao.Add(RegraNegocio.SituacaoReuniao.EFETIVADO);

            if (cbEmoperacao.Checked)
                listaSituacaoReuniao.Add(RegraNegocio.SituacaoReuniao.OPERAÇÃO);

            CarregarInformacoesReunioes();
               
        }
    }
}
