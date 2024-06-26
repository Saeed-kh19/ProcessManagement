﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class GenericRepository<TEntity> where TEntity : class
    {

        private Accounting_DBEntities _db;

        //DbSet is a table that TEntity wants to connect with
        private DbSet<TEntity> _dbSet;
        public GenericRepository(Accounting_DBEntities db)
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
        }

        //Expression: Lambda / Func: => / where: conditions
        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            //IQueryable has Lazy Load (Doesn't run until it called!)
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            return query.ToList();
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _db.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Deleted;
        }
    }
}
