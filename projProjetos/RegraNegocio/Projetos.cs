using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDados;
using RegraNegocio.View.Pessoas;

namespace RegraNegocio
{
    public class Projetos : Entity<EFDados.PROJETO>
    {
        public List<View.Projetos.ViewProjeto> ToList()
        {
            try
            {
                return base.ToList().Select(x => new View.Projetos.ViewProjeto(x)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EFDados.PROJETO Insert()
        {
            try
            {
                EFDados.PROJETO insertItem = base.Insert();
                insertItem.STATUS = (byte)1;

                return insertItem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EFDados.PROJETO Update(EFDados.PROJETO projeto)
        {
            try
            {
                return base.Update(projeto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(EFDados.PROJETO projeto)
        {
            try
            {
                return base.Delete(projeto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ChangeState(EFDados.PROJETO projeto)
        {
            try
            {
                Update(projeto);

                projeto.STATUS = (projeto.STATUS >= 1) ? ((byte)0) : ((byte)1);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
