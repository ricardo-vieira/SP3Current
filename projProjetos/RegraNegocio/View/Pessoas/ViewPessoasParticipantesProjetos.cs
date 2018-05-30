using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.View.Pessoas
{
    public class ViewPessoasParticipantesProjetos : ViewPessoa
    {
        public long? IDPROJETO { get; set; }
        public string OCUPACAO { get; set; }
        public DateTime? DATAINGRESSO { get; set; }
        public string OBSERVACOESPARTICIPANTE { get; set; }
    }
}
