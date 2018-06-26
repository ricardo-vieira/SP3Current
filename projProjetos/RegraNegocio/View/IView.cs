using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace RegraNegocio.View
{
    public abstract class IView<T> where T : class
    {
        public long? ID { get; set; }


        private T _entityObject;
        public T EntityObject { get => _entityObject; }

        public IView()
        {
        }
        public IView(T entityObject)
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
