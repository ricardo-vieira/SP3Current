using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace projProjetos.Ferramentas
{
    public class ObjectFilter<T> : List<PredicateOperator<T>>
    {

        public void AddPredicate(ObjectFilterLogicalOperators objectFilterLogicalOperator, Func<T, bool> predicate)
        {
            try
            {
                PredicateOperator<T> predicateOperator = new PredicateOperator<T> { objectfilterlocalOperator = objectFilterLogicalOperator, predicate = predicate };

                base.Add(predicateOperator);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual Predicate<T> GetFilter()
        {
            try
            {
                if (base.Count > 0)
                {
                    PredicateOperator<T> predicateOperator = this.ToList().ElementAt(0);
                    Expression _finalExpression = Expression.Lambda<Func<T, bool>>(Expression.Call(predicateOperator.predicate.Method));

                    for (int i = 0; i < base.Count; i++)
                    {
                        Expression nextExpression = Expression.Lambda<Func<T, bool>>(Expression.Call(base[i].predicate.Method));

                        if (i == 0)
                        {
                            if (!(base[i].objectfilterlocalOperator is null) && base[i].objectfilterlocalOperator == ObjectFilterLogicalOperators.NOT)
                                _finalExpression = CreateExpression(base[i].objectfilterlocalOperator, nextExpression, null);
                            else
                                _finalExpression = nextExpression;
                        }
                        else
                            _finalExpression = CreateExpression(base[i].objectfilterlocalOperator, _finalExpression, nextExpression);
                    }

                    Predicate<T> predicateExpression = new Predicate<T>(Expression.Lambda<Func<T, bool>>(_finalExpression).Compile());

                    return predicateExpression; 
                }

                throw new Exception("Não ha nenhum objeto na lista");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected Expression CreateExpression(ObjectFilterLogicalOperators? objectFilterLogicalOperator, Expression leftExpression, Expression rightExpression)
        {
            try
            {

                Expression returnExpression;

                switch (objectFilterLogicalOperator)
                {
                    case ObjectFilterLogicalOperators.AND:

                        returnExpression = Expression.And(leftExpression, rightExpression);
                        break;
                    case ObjectFilterLogicalOperators.OR:

                        returnExpression = Expression.Or(leftExpression, rightExpression);
                        break;
                    case ObjectFilterLogicalOperators.NOT:

                        returnExpression = Expression.Not(leftExpression);
                        break;

                    default:
                        throw new ArgumentException("Operador lógico desconhecido ou não definido para este método.");
                }

                return returnExpression;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public enum ObjectFilterLogicalOperators
    {
        AND,
        OR,
        NOT
    }

    public struct PredicateOperator<T>
    {
        public ObjectFilterLogicalOperators? objectfilterlocalOperator;
        public Func<T, bool> predicate;
    }
}
