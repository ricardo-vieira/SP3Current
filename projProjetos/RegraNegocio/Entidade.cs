using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDados;
using System.Data.Entity;


namespace RegraNegocio
{
    public abstract class Entidade
    {
        protected static  dbProjetosEntities ctoProjetos = new dbProjetosEntities();  
    }
}
