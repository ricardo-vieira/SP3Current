using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.View.Projetos
{
    public class ViewProjetoPessoa : View.ViewEntity<EFDados.PROJETOSPESSOA>
    {
        public long? IdProjeto { get => (!(base.EntityObject.PROJETO is null)) ? base.EntityObject.PROJETO.ID : 0; }
        public long? IdPessoa { get => (!(base.EntityObject.PESSOA is null)) ? base.EntityObject.PESSOA.ID : 0; }
        public string NomeProjeto { get => (!(base.EntityObject.PROJETO is null)) ? base.EntityObject.PROJETO.NOME : null; }
        public string NomePessoa { get => (!(base.EntityObject.PESSOA is null)) ? base.EntityObject.PESSOA.NOME : null; }
        public DateTime? DataIngresso { get => base.EntityObject.DATAINGRESSO; }
        public string Ocupacao { get => base.EntityObject.OCUPACAO; }
        public string Observacoes { get => base.EntityObject.OBSERVACOES; }

        public ViewProjetoPessoa(EFDados.PROJETOSPESSOA projetoPessoa) : base(projetoPessoa)
        {

        }
    }
}
