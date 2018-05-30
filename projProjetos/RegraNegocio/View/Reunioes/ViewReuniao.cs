using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.View.Reunioes
{
    public class ViewReuniao
    {
        public long ID { get; set; }
        public string DESCRICAO { get; set; }
        public DateTime? DATAHORAEVENTO { get; set; }
        public decimal? PAYBACKACEITAVEL { get; set; }
        public decimal? TAXAREMUNERACAOMERCADO { get; set; }
        public string PAUTADESCRICAO { get; set; }
        public string LOCAL { get; set; }
        public string RESPONSAVEL { get; set; }
        public int QUANTIDADEPROJETOSPAUTA { get; set; }
        public string STATUS { get; set; }
        public string SITUACAO { get; set; }
    }
}
