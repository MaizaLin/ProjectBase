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
    public abstract class RepositoryBase<TAggregateRoot, TPrimaryKey> : IRepository<TAggregateRoot, TPrimaryKey> where TAggregateRoot : AggregateRoot<TPrimaryKey>, new()
    {


        public DbSet<TAggregateRoot> Set
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public TAggregateRoot FirstOrDefault(Expression<Func<TAggregateRoot, bool>> wherelambda)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TAggregateRoot> Get(Expression<Func<TAggregateRoot, bool>> wherelambda)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TAggregateRoot> GetAll()
        {
            throw new NotImplementedException();
        }

        public TAggregateRoot Get(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TAggregateRoot> GetPager<S>(int pageSize, int pageIndex, bool isLoadAll, out int total, Expression<Func<TAggregateRoot, bool>> whereLambda, bool isAsc, Expression<Func<TAggregateRoot, S>> orderByLambda)
        {
            throw new NotImplementedException();
        }

        public void Insert(TAggregateRoot entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(TAggregateRoot entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TAggregateRoot entity)
        {
            throw new NotImplementedException();
        }
    }
}
