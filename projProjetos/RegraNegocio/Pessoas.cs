using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDados;
using System.Data.Linq.SqlClient;

namespace RegraNegocio
{
    public class Pessoas : Entity<EFDados.PESSOA>
    {
        public List<View.Pessoas.ViewPessoa> ToList()
        {
            try
            {
                return base.ToList().Select(x => new View.Pessoas.ViewPessoa(x)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EFDados.PESSOA Update(EFDados.PESSOA entity = null)
        {
            try
            {
                return base.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Delete(EFDados.PESSOA entity)
        {
            try
            {
                return base.Delete(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EFDados.PESSOA Insert()
        {
            try
            {
                EFDados.PESSOA pessoa = base.Insert();
                pessoa.STATUS = 1;

                return pessoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ChangeState(EFDados.PESSOA pessoa)
        {
            try
            {
                Update(pessoa);

                pessoa.STATUS = (pessoa.STATUS >= 1) ? ((byte)0) : ((byte)1);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
