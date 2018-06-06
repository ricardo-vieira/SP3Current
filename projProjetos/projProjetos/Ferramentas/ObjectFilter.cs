using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace projProjetos.Ferramentas
{
    public class ObjectFilter<T>
    {
        PredicateOperator<T> _inicialPredicateOperator;
        List<PredicateOperator<T>> _listPredicateExpression= new List<PredicateOperator<T>>();

        public ObjectFilter(Expression<Predicate<T>> initialPredicateParameter, bool negativeObjectFilterLogicalOperator = false)
        {
            try
            {
                this._inicialPredicateOperator = new PredicateOperator<T>
                {
                    predicate = initialPredicateParameter
                };

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddPredicate(ObjectFilterBinaryLogicalOperators objectFilterLogicalOperators, Expression<Predicate<T>> predicateParameter)
        {
            try
            {
                PredicateOperator<T> predicateOperator = new PredicateOperator<T>
                {
                    objectfilterBinaryLogicalOperator = objectFilterLogicalOperators,
                    predicate = predicateParameter
                };

                _listPredicateExpression.Add(predicateOperator);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Predicate<T> Filter
        {
            get
            {
                Expression<Predicate<T>> resultExpression = _inicialPredicateOperator.predicate;
                ParameterExpression parameter = _inicialPredicateOperator.predicate.Parameters.Single();

                foreach (PredicateOperator<T> p in _listPredicateExpression)
                {
                    switch (p.objectfilterBinaryLogicalOperator)
                    {
                        case ObjectFilterBinaryLogicalOperators.AND:
                            resultExpression = Expression.Lambda<Predicate<T>>(Expression.And(resultExpression.Body, Expression.Invoke(p.predicate, parameter)), parameter);
                            break;

                        case ObjectFilterBinaryLogicalOperators.OR:
                            resultExpression = Expression.Lambda<Predicate<T>>(Expression.Or(resultExpression.Body, Expression.Invoke(p.predicate, parameter)), parameter);
                            break;
                        default:
                            throw new Exception("Operador nao tratado pelo ObjectFilter");
                    }

                }


                return resultExpression.Compile();
            }
        }

    }


    public enum ObjectFilterBinaryLogicalOperators
    {
        AND,
        OR
    }

    public struct PredicateOperator<T>
    {
        public ObjectFilterBinaryLogicalOperators? objectfilterBinaryLogicalOperator;
        public Expression<Predicate<T>> predicate;
    }
}
