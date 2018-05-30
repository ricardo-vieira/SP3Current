using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace RegraNegocio.View
{
    public class IView<T> where T : class
    {
        private EFDados.dbProjetosEntities ctoProjetos;

        public long? ID { get; set; }

        //public virtual T getRegistro()
        //{
        //    try
        //    {
        //        HashSet<T> entitie = getEntitie();
        //        T registro = entitie.AsEnumerable().First(x => getVelueAtributeID((T)x) == ID);
        //        return registro;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //private HashSet<T> getEntitie()
        //{
        //    try
        //    {
        //        PropertyInfo[] atributosClasse = typeof(EFDados.dbProjetosEntities).GetProperties();
        //        PropertyInfo tipoAtributo = atributosClasse.First(x => x.GetType().Equals(typeof(HashSet<T>)));

        //        //HashSet<T> entidade = tipoAtributo.GetValue(ctoProjetos) as HashSet<T>;

        //        return entidade;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        /*private long? getVelueAtributeID(T registro)
        {
            try
            {
                PropertyInfo[] atributosClasse = typeof(T).GetProperties();

                if (atributosClasse.Any(x => x.Name.Equals("ID")))
                {
                    PropertyInfo propriedade = atributosClasse.First(x => x.Name.Equals("ID"));
                    return Convert.ToInt64(propriedade.GetValue(registro));
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }*/
    }
}
