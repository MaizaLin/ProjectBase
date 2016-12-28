using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ProjectBase.Domain.Models;

namespace ProjectBase.Domain.Repositories
{
    public interface IRepository<TAggregateRoot, TPrimaryKey> where TAggregateRoot : AggregateRoot<TPrimaryKey>, new()
    {
        void Insert(TAggregateRoot entity);

        void Update(TAggregateRoot entity);

        void Remove(TAggregateRoot entity);

        DbSet<TAggregateRoot> Set { get; }

        #region query

        TAggregateRoot Get(TPrimaryKey id);

        TAggregateRoot FirstOrDefault(Expression<Func<TAggregateRoot, bool>> wherelambda);

        IQueryable<TAggregateRoot> Get(Expression<Func<TAggregateRoot, bool>> wherelambda);

        IQueryable<TAggregateRoot> GetAll();

        IQueryable<TAggregateRoot> GetPager<S>(int pageSize, int pageIndex, bool isLoadAll,
            out int total, Expression<Func<TAggregateRoot, bool>> whereLambda, bool isAsc, Expression<Func<TAggregateRoot, S>> orderByLambda);

        #endregion
    }
}
