using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDados.Infraestrutura
{
    public class Modifieditem<T>
    {
        public T entity;
        public EntityState status;

        private DateTime _dateLog = DateTime.Now;
		public DateTime DateLog { get { return _dateLog; } }

        public Modifieditem(T entity, EntityState status)
        {
            this.entity = entity;
            this.status = status;
        }
    }
}
