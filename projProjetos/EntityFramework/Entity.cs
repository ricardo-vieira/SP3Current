using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDados;
using System.Data.Entity;
using System.Data.Objects;

namespace EFDados
{
    public abstract class Entity<TEntity>
    where TEntity : class, new()
    {
        private static dbProjetosEntities _ctoProjetos = Contexto._coProjetoEntities;

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
        private List<TEntity> _addedItens
        {
            get
            {
                return _modifiedItens.Where(x => x.status == EntityState.Added).Select(x => x.entity).ToList();
            }
        }
        private List<TEntity> _updatdeItens
        {
            get
            {
                return _modifiedItens.Where(x => x.status == EntityState.Modified).Select(x => x.entity).ToList();
            }
        }
        private List<TEntity> _deletedItens
        {
            get
            {
                return _modifiedItens.Where(x => x.status == EntityState.Deleted).Select(x => x.entity).ToList();
            }
        }

        private List<TEntity> _allItens
        {
            get
            {
                try
                {
                    

                    IEnumerable<TEntity> addItens = _addedItens.AsEnumerable();
                    IEnumerable<TEntity> updateItens = _updatdeItens.AsEnumerable();
                    IEnumerable<TEntity> deletedItens = _deletedItens.AsEnumerable();

                    IEnumerable<TEntity> finalItens = DbEntity.AsEnumerable().Union(addItens)
                                                                             .Except(deletedItens);

                    return finalItens.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        protected virtual List<TEntity> ToList()
        {
            try
            {
                return _allItens;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected virtual TEntity Insert()
        {
            try
            {
                TEntity _modifyObject = new TEntity();
                DbEntity.Add(_modifyObject);
                _ctoProjetos.Entry(_modifyObject).State = EntityState.Added;

                _modifiedItens.Add(new Infraestrutura.Modifieditem<TEntity>(_modifyObject, EntityState.Added));

                return _modifyObject;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected virtual TEntity Update(TEntity entity)
        {
            try
            {
                if (_allItens.Any(x => x.Equals(entity)))
                {
                    _modifiedItens.Add(new Infraestrutura.Modifieditem<TEntity>(entity, EntityState.Modified));
                    return entity;
                }

                throw new Exception("O elemento indicado nao pertente ao set de dados.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected virtual bool Delete(TEntity entity)
        {
            try
            {
                if (!(entity is null))
                {
                    if (_allItens.Any(x => x.Equals(entity)) && (!_modifiedItens.Any(x => x.entity == entity) || _modifiedItens.OrderByDescending(x => x.DateLog).First(x => x.entity == entity).status != EntityState.Deleted))
                    {

                        DbEntity.Remove(entity);
                        _modifiedItens.Add(new Infraestrutura.Modifieditem<TEntity>(entity, EntityState.Deleted));
                        return true;
                    }

                    throw new Exception("O objecto indicado não pode ser removido pois não pertence a listagem de dados.");
                }

                throw new ArgumentNullException("o Parametro entity nao pode ser nulo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual bool Commit()
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

        public virtual bool RollBack()
        {
            try
            {
                foreach (var item in _modifiedItens.OrderByDescending(x => x.DateLog).ToList())
                {
                    switch (item.status)
                    {
                        case EntityState.Added:
                            DbEntity.Remove(item.entity);
                            break;
                        case EntityState.Deleted:
                            DbEntity.Add(item.entity);
                            break;
                        case EntityState.Modified:
                            if (DbEntity.AsEnumerable().Any(x => x == item.entity))
                            {
                                _ctoProjetos.Entry(item.entity).CurrentValues.SetValues(_ctoProjetos.Entry(item.entity).OriginalValues);
                                _ctoProjetos.Entry(item.entity).State = EntityState.Unchanged; 
                            }
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

        public virtual bool RollBackLastOperation()
        {
            try
            {
                Infraestrutura.Modifieditem<TEntity> lastItem = _modifiedItens.Last();

                if (!(lastItem is null))
                {
                    switch (lastItem.status)
                    {
                        case EntityState.Added:
                            DbEntity.Remove(lastItem.entity);
                            break;
                        case EntityState.Deleted:
                            DbEntity.Add(lastItem.entity);
                            break;
                        case EntityState.Modified:
                            if (DbEntity.AsEnumerable().Any(x => x == lastItem.entity))
                            {
                                _ctoProjetos.Entry(lastItem.entity).CurrentValues.SetValues(_ctoProjetos.Entry(lastItem.entity).OriginalValues);
                                _ctoProjetos.Entry(lastItem.entity).State = EntityState.Unchanged;
                            }
                            break;
                    }

                    _modifiedItens.Remove(lastItem);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
