using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.View.Pessoas
{
    public class ViewPessoasParticipantesProjetos : IView<EFDados.PROJETOSPESSOA>
    {
        public ViewPessoasParticipantesProjetos(EFDados.PROJETOSPESSOA projetopessoa) : base(projetopessoa)
        {

        }

        public string NOME { get => base.EntityObject.PESSOA.NOME; }
        public long? IDPROJETO { get => base.EntityObject.IDPROJETO; }
        public string OCUPACAO { get => base.EntityObject.OCUPACAO; }
        public DateTime? DATAINGRESSO { get => base.EntityObject.DATAINGRESSO; }
        public string OBSERVACOESPARTICIPANTE { get => base.EntityObject.OBSERVACOES; }
    }
}
