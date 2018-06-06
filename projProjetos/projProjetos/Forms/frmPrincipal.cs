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
    public partial class frmPrincipal : Form
    {
        int originaltbpPrincipalWidth;
        int originaltbpPrincipalHeight;
        int originaltbpPrincipalLocationX;
        int originaltbpPrincipalLocationY;

        RegraNegocio.Projetos projetosRegraNegocio = new RegraNegocio.Projetos();
        RegraNegocio.Pessoas pessoasRegraNegocio = new RegraNegocio.Pessoas();
        RegraNegocio.Reunioes reunioesRegraNegocio = new RegraNegocio.Reunioes();

        BindingListView<RegraNegocio.View.Projetos.ViewProjeto> _bindingListViewProjeto;
        BindingListView<RegraNegocio.View.Pessoas.ViewPessoa> _bindingListViewPessoa;
        BindingListView<RegraNegocio.View.Reunioes.ViewReuniao> _bindingListViewReuniao;

        private void CarregarInformacoesGerais()
        {

        }

        private void CarregarInformacoesGeraisProjeto()
        {

        }

        private void CarregarInformacoesGeraisPessoa()
        {

        }

        private void CarregarInformacoesGeraisReuniao()
        {

        }




        private void RedimensionarComponentes()
        {
            grbReunioes.Width = (tbPrincipal.Width - 20);
            grbReunioes.Height = Convert.ToInt32(tbPrincipal.Height * 0.45);

            grbPessoas.Location = new Point(grbPessoas.Location.X, grbReunioes.Height + 15);
            grbPessoas.Width = Convert.ToInt32((tbPrincipal.Width - 40) * 0.40);
            grbPessoas.Height = (tbcParincipal.Height - grbPessoas.Location.Y - 40);

            grbProjetos.Location = new Point(grbPessoas.Width + 20, grbReunioes.Height + 15);
            grbProjetos.Width = (tbPrincipal.Width - grbProjetos.Location.X - 14);
            grbProjetos.Height = (tbcParincipal.Height - grbProjetos.Location.Y - 40);



        }


        public frmPrincipal()
        {
            InitializeComponent();

            originaltbpPrincipalHeight = tbPrincipal.Height;
            originaltbpPrincipalWidth = tbPrincipal.Width;
            originaltbpPrincipalLocationX = tbcParincipal.Location.X;
            originaltbpPrincipalLocationY = tbcParincipal.Location.Y;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            RedimensionarComponentes();
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            RedimensionarComponentes();
        }
    }
}
