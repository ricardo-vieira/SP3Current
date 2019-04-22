using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.View.Reunioes
{
    public class ViewReuniao : ViewEntity<EFDados.REUNIO>
    {
        public long Id { get => base.EntityObject.ID; }
        public string Descricao { get => base.EntityObject.DESCRICAO ?? String.Empty; }
        public DateTime DataHoraEvento { get => base.EntityObject.DATAHORAEVENTO ?? DateTime.MinValue; }
        public decimal? PayBackAceitavel { get => base.EntityObject.PAYBACKACEITAVEL; }
        public decimal? TaxaRemuneracaoMercado { get => base.EntityObject.TAXAREMUNERACAOMERCADO; }
        public string PautaDescricao { get => base.EntityObject.PAUTADESCRICAO ?? String.Empty; }
        public string Local { get => base.EntityObject.LOCAL ?? String.Empty; }
        public long IdResponsavel { get => base.EntityObject.RESPONSAVEL ?? 0; }
        public string Responsavel { get => base.EntityObject.PESSOA?.NOME; }
        public int QuantidadeProjetosPauta { get => base.EntityObject.PAUTAPROJETOS.Count(); }
        public string Status { get => String.Empty; }
        public string Situacao { get => base.EntityObject.SITUACAO ?? String.Empty; }
        public DateTime DataHoraCriacao { get => base.EntityObject.DATACRIACAO ?? DateTime.MinValue; }
        public decimal? TaxaCustoCapital { get => base.EntityObject.TAXACUSTOCAPITAL; }
        public ViewReuniao(EFDados.REUNIO reuniao) : base(reuniao)
        {
        }
    }
}
