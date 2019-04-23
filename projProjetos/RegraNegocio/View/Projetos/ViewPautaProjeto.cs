using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.View.Projetos
{
    public class ViewPautaProjeto : ViewEntity<EFDados.PAUTAPROJETO>
    {
        public long IdProjeto { get => base.EntityObject.PROJETO != null ? base.EntityObject.PROJETO.ID : 0; }
        public string NomeProjeto { get => base.EntityObject.PROJETO?.NOME; }
        public string Descricao { get => base.EntityObject.PROJETO.DESCRICAO; }
        public string Observacao { get => base.EntityObject.PROJETO.OBSERVACAO; }
        public string GerenteProjeto { get => base.EntityObject.PROJETO.GERENTEPROJETO.NOME; }
        public decimal? InvestimentoPrevisto { get => base.EntityObject.PROJETO.INVESTIMENTOPREVISTO; }
        public decimal? ReceitaConstante { get => base.EntityObject.PROJETO.RECEITACONSTANTE; }
        public decimal? RazaoReceitaPercentual { get => base.EntityObject.PROJETO.RAZAORECEITAPERCENTUAL; }
        public decimal? RazaoReceitaValor { get => base.EntityObject.PROJETO.RAZAORECEITAVALOR; }
        public decimal? TempoPrevistoConclusao { get => base.EntityObject.PROJETO.TEMPOPREVISTOCONCLUSAO; }
        public long IdPautaProjetos { get => base.EntityObject.ID; }
        public int? CapacidadeEntregaEquipe { get => base.EntityObject.CAPACIDADEENTREGAEQUPE; }
        public int? ApoioAltaGestao { get => base.EntityObject.APOIOALTAGESTAO; }
        public int? ApoioSteakHolders { get => base.EntityObject.APOIOSTEAKHOLDERS; }
        public int? EsforcoAdicional { get => base.EntityObject.ESFORCOADICIONAL; }
        public decimal? TotalValorDespesaPrevista { get => base.EntityObject.PAUTARECEITAVARIAVELs.Where(x => x.TIPO.Equals("DESPESA")).Sum(x => x.VALOR); }
        public decimal? TotalValorReceitaPrevista { get => base.EntityObject.PAUTARECEITAVARIAVELs.Where(x => x.TIPO.Equals("RECEITA")).Sum(x => x.VALOR); }

        // Resultado Calculos da Pauta
        public decimal? ResultadoPayBack { get => base.EntityObject.RESULTADOPAYBACK; }
        public int? OdemResultadoPayBack { get => base.EntityObject.ORDEMRESULTADOPAYBACK; }
        public string AprovacaoResultadoPayBack { get => base.EntityObject.APROVACAORESULTADOPAYBACK; }

        public decimal? ResultadoTaxaInternaRetorno { get => base.EntityObject.RESULTADOTAXAINTERNARETORNO; }
        public int? OrdemResultadoTaxaInternaRetorno { get => base.EntityObject.ORDEMRESULTADOTAXAINTERNARETORNO; }
        public string AprovacaoTaxaInternaRetorno { get => base.EntityObject.APROVACAORESULTADOTAXAINTERNARETORNO; }

        public decimal? ResultadoValorPresenteLiquido { get => base.EntityObject.RESULTADOVALORPRESENTELIQUIDO; }
        public int? OrdemResultadoValorPresenteLiquido { get => base.EntityObject.ORDEMRESULTADOVALORPRESENTELIQUIDO; }
        public string AprovacaoResultadoValorPresenteLiquido { get => base.EntityObject.APROVACAORESULTADOVALORPRESENTELIQUIDO; }

        public string ResultadoDICE { get => Ferramentas.FrameworkDICE.RetornarStatusDice(Convert.ToInt32(base.EntityObject.RESULTADODICE)); }
        public int? OrdemResultadoDICE { get => base.EntityObject.ORDEMRESULTADODICE; }
        public string AprovacaoResultadoDICE { get => base.EntityObject.APROVACAORESULTADODICE; }

        public decimal? ResultadoAHP { get => base.EntityObject.RESULTADOAHP; }
        public int? OrdemResultadoAHP { get => base.EntityObject.ORDEMRESULTADOAHP; }
        public string AprovacaoResultadoAHP { get => base.EntityObject.APROVACAORESULTADOAHP; }

        public string AHPCalculado { get => (base.EntityObject.REUNIO.AHPCALCULADO == (byte)1) ? ("SIM") : ("NÃO"); }

        public ViewPautaProjeto(EFDados.PAUTAPROJETO pautaProjeto) : base(pautaProjeto)
        {

        }
    }
}
