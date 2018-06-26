using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.View.Projetos
{
    public class ViewProjetosReceitaVariavel : View.ViewEntity<EFDados.RECEITAVARIAVEL>
    {
        public long IdProjeto { get => base.EntityObject.IDPROJETO; }
        public System.DateTime DataPeriodo { get => base.EntityObject.DATAPERIODO; }
        public string Tipo { get => base.EntityObject.TIPO; }
        public DateTime? DataCriacao { get => base.EntityObject.DATACRIACAO; }
        public decimal? Valor { get => base.EntityObject.VALOR; }
        public string Status { get => (base.EntityObject.STATUS == 1) ? ("ATIVO") : ("INATIVO"); }
        public string Observacoes { get => base.EntityObject.OBSERVACOES; }

        public ViewProjetosReceitaVariavel(EFDados.RECEITAVARIAVEL receitaVariavel) : base(receitaVariavel)
        {

        }
    }
}
