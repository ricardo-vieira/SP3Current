using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.View.Projetos
{
    /// <summary>
    /// Classe para representação de consulta basica de Projetos
    /// </summary>
    public class ViewProjeto : View.ViewEntity<EFDados.PROJETO>
    {
        public long Id { get => base.EntityObject.ID; }
        public string Nome { get => base.EntityObject.NOME; }
        public string Descricao { get => base.EntityObject.DESCRICAO; }
        public string Observacao { get => base.EntityObject.OBSERVACAO; }
        public long IdGerenteProjeto { get => base.EntityObject.GERENTE; }
        public string NomeGerenteProjeto { get => (!(base.EntityObject.GERENTEPROJETO is null)) ? base.EntityObject.GERENTEPROJETO.NOME: null; }
        public decimal? InvestimentoPrevisto { get => base.EntityObject.INVESTIMENTOPREVISTO; }
        public decimal? ReceitaConstante { get => base.EntityObject.RECEITACONSTANTE; }
        public decimal? RazaoReceitaValor { get => base.EntityObject.RAZAORECEITAVALOR; }
        public decimal? RazaoReceitaPercentual { get => base.EntityObject.RAZAORECEITAPERCENTUAL; }
        public int? TempoPrevistoConclusao { get => Convert.ToInt32(base.EntityObject.TEMPOPREVISTOCONCLUSAO); }
        public DateTime? DataCricao { get => base.EntityObject.DATACRIACAO; }
        public string Status { get => (base.EntityObject.STATUS == 1) ? ("ATIVO") : ("INATIVO"); }


        public string DescricaoApoioSteakHolders { get => Ferramentas.FrameworkDICE.RetornarDescricaoApoioSteakHolders(base.EntityObject.APOIOSTEAKHOLDERS); }
        public string DescricaoCapacidadeEntregaEquipe { get => Ferramentas.FrameworkDICE.RetornarDescricaoCapacidadeEntregaEquipe(base.EntityObject.CAPACIDADEENTREGAEQUIPE); }
        public string DescricaoApoioAltaGestao { get => Ferramentas.FrameworkDICE.RetornarDescricaoApoioAltaGestao(base.EntityObject.APOIOALTAGESTAO); }


        public bool BoolEsforcoAdicionalAte10PorCento { get => base.EntityObject.ESFORCOADICIONAL == 0; }
        public bool BoolEsforcoAdicionalEntre11e20PorCento { get => base.EntityObject.ESFORCOADICIONAL == 1; }
        public bool BoolEsforcoAdicionalEntre21e40PorCento { get => base.EntityObject.ESFORCOADICIONAL == 2; }
        public bool BoolEsforcoAdicionalmaior40PorCento { get => base.EntityObject.ESFORCOADICIONAL == 3; }

        public ViewProjeto(EFDados.PROJETO projeto) : base(projeto)
        {
        }
    }
}
