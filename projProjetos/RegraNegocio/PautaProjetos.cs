using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDados;

namespace RegraNegocio
{
    public class PautaProjetos : Entity<EFDados.PAUTAPROJETO>
    {
        public List<RegraNegocio.View.Projetos.ViewPautaProjeto> ToList()
        {
            try
            {
                return base.ToList().Select(x => new View.Projetos.ViewPautaProjeto(x)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EFDados.PAUTAPROJETO Insert()
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

        public EFDados.PAUTAPROJETO Update(EFDados.PAUTAPROJETO pautaProjeto)
        {
            try
            {
                return base.Update(pautaProjeto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(EFDados.PAUTAPROJETO pautaProjeto)
        {
            try
            {
                return base.Delete(pautaProjeto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
