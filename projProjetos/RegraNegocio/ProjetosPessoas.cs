using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDados;

namespace RegraNegocio
{
    public class ProjetosPessoas : Entity<EFDados.PROJETOSPESSOA>
    {
        public List<RegraNegocio.View.Projetos.ViewProjetoPessoa> ToList()
        {
            try
            {
                return base.ToList().Select(x => new View.Projetos.ViewProjetoPessoa(x)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EFDados.PROJETOSPESSOA Insert()
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

        public EFDados.PROJETOSPESSOA Update(EFDados.PROJETOSPESSOA projetoPessoa = null)
        {
            try
            {
                return base.Update(projetoPessoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(EFDados.PROJETOSPESSOA projetoPessoa)
        {
            try
            {
                return base.Delete(projetoPessoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
