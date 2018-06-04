using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDados;

namespace RegraNegocio
{
    public class ReceitaVariavel : Entity<EFDados.RECEITAVARIAVEL>
    {
        public List<RegraNegocio.View.Projetos.ViewProjetosReceitaVariavel> ToList()
        {
            try
            {
                return base.ToList().Select(x => new View.Projetos.ViewProjetosReceitaVariavel(x)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EFDados.RECEITAVARIAVEL Insert()
        {
            try
            {
                return base.Insert();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EFDados.RECEITAVARIAVEL Update(EFDados.RECEITAVARIAVEL receitaVariavel = null)
        {
            try
            {
                return base.Update(receitaVariavel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(EFDados.RECEITAVARIAVEL receitaVariavel)
        {
            try
            {
                return base.Delete(receitaVariavel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
