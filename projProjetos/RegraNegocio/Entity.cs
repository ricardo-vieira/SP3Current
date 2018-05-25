using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDados;
using System.Data.Entity;


namespace RegraNegocio
{
    public abstract class Entity<TEntity>
    where TEntity : class, new()
    {
        private TEntity _modifyObject;

        private static dbProjetosEntities _ctoProjetos = new dbProjetosEntities();
        protected dbProjetosEntities CtoProjetos { get { return _ctoProjetos; } }

        protected DbSet<TEntity> DbEntity
        {
            get
            {
                try
                {
                    return _ctoProjetos.Set<TEntity>();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private List<Infraestrutura.Modifieditem<TEntity>> _modifiedItens = new List<Infraestrutura.Modifieditem<TEntity>>();

        public virtual List<TEntity> ToList()
        {
            try
            {
                return DbEntity.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual TEntity Insert()
        {
            try
            {
                if (!(_modifyObject is null) || _ctoProjetos.Entry(_modifyObject).State != EntityState.Added)
                {
                    _modifyObject = new TEntity();
                    DbEntity.Add(_modifyObject);
                    _ctoProjetos.Entry(_modifyObject).State = EntityState.Added;

                    _modifiedItens.Add(new Infraestrutura.Modifieditem<TEntity>(_modifyObject, EntityState.Added));
                }

                return _modifyObject;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual TEntity Update(TEntity entity = null)
        {
            try
            {
                if (!(entity is null))
                {
                    if (DbEntity.Any(x => x.Equals(entity)))
                    {
                        if (_modifyObject is null || !_modifyObject.Equals(entity))
                        {
                            _modifyObject = entity;
                            _ctoProjetos.Entry(_modifyObject).State = EntityState.Modified;

                            _modifiedItens.Add(new Infraestrutura.Modifieditem<TEntity>(_modifyObject, EntityState.Modified));
                        }
                    }
                    else
                    {
                        throw new Exception("O objeto indicado não pode ser editado por não pertencer a essa entidade.");
                    }
                }
                else
                {
                    if (_modifyObject is null || _ctoProjetos.Entry(_modifyObject).State != EntityState.Modified)
                    {
                        throw new Exception("Não existe nenhum objecto em modo de edição. Especifique o objeto para edição nos parâmetros da função.");
                    }
                }

                return _modifyObject;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual bool Delete(TEntity entity)
        {
            try
            {
                if (DbEntity.Any(x => x.Equals(entity)))
                {
                    _modifyObject = entity;
                    DbEntity.Remove(_modifyObject);
                    _ctoProjetos.Entry(_modifyObject).State = EntityState.Deleted;

                    _modifiedItens.Add(new Infraestrutura.Modifieditem<TEntity>(_modifyObject, EntityState.Deleted));

                    return true;
                }

                throw new Exception("O objecto indicado não pode ser removido pois não pertence a listagem de dados.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Commit()
        {
            try
            {
                _ctoProjetos.SaveChanges();
                _modifiedItens.Clear();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RollBack()
        {
            try
            {
                foreach (var item in _modifiedItens.OrderByDescending(x => x.DateLog).ToList())
                {
                    switch (item.status)
                    {
                        case EntityState.Added:
                            _ctoProjetos.Entry(item.entity).State = EntityState.Detached;
                            break;
                        case EntityState.Deleted:
                            DbEntity.Add(item.entity);
                            _ctoProjetos.Entry(item.entity).State = EntityState.Unchanged;
                            break;
                        case EntityState.Modified:
                            _ctoProjetos.Entry(item.entity).CurrentValues.SetValues(_ctoProjetos.Entry(item.entity).OriginalValues);
                            _ctoProjetos.Entry(item.entity).State = EntityState.Unchanged;
                            break;
                    }

                    _modifiedItens.Remove(item);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
