using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace RegraNegocio.View
{
    public abstract class ViewEntity<T> where T : class
    {
        private T _entityObject;
        public T EntityObject { get => _entityObject; }

        public ViewEntity(T entityObject)
        {
            try
            {
                _entityObject = entityObject;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
