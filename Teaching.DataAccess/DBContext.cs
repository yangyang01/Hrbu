using Hrbu.Teaching.Utility;
using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Transactions;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity.Validation;

namespace Hrbu.Teaching.DataAccess
{
    public class DBContext<T> : IDisposable where T : class,new()
    {
        protected static IConfig Config { get { return ConfigFactory.CreateConfigInstance(); } }
        public DBContext()
        {
        }

        protected static DbContext CreateContext()
        {
            return new DBContextBase(Config.ConnectionString);
        }
        protected static ObjectContext CreateObjectContext()
        {
            DbContext context = CreateContext();
            return ((IObjectContextAdapter)context).ObjectContext;
        }

        protected static TransactionScope CreateTransacationScope()
        {
            TransactionOptions o = new TransactionOptions();
            o.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
            return new TransactionScope(TransactionScopeOption.Required, o);
        }

        public static void Delete(Expression<Func<T, bool>> func)
        {
            using (var ctx = CreateContext())
            {
                try
                {
                    var dbSet = ctx.Set<T>();
                    dbSet.Where(func).ToList().ForEach(x => dbSet.Remove(x));
                    ctx.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    throw;
                }
            }
        }
        public static void DeleteAll()
        {
            using (var ctx = CreateContext())
            {
                try
                {
                    var dbSet = ctx.Set<T>();
                    dbSet.ToList().ForEach(x => dbSet.Remove(x));
                    ctx.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    throw;
                }
            }
        }

        public static void Update(T entity)
        {
            using (var ctx = CreateContext())
            {
                try
                {
                    var dbSet = ctx.Set<T>();

                    dbSet.Attach(entity);
                    ctx.Entry(entity).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    throw;
                }
            }
        }

        public static void UpdateBatch(List<T> entities)
        {
            using (var tran = CreateTransacationScope())
            {
                for (int i = 0; i < entities.Count; i++)
                {
                    Update(entities[i]);
                }

                tran.Complete();
            }
        }

        public static void Add(T entity)
        {
            if (entity == null) return;
            using (var ctx = CreateContext())
            {
                try
                {
                    ctx.Set<T>().Add(entity);
                    ctx.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    throw;
                }
            }
        }

        public static void AddBatch(List<T> entities)
        {
            using (var tran = CreateTransacationScope())
            {
                foreach (var entity in entities)
                {
                    Add(entity);
                }
                tran.Complete();
            }
        }

        public static T Get(params object[] keys)
        {
            using (var ctx = CreateContext())
            {
                return ctx.Set<T>().Find(keys);
            }
        }

        public static T Get(Expression<Func<T, bool>> func, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            using (var ctx = CreateContext())
            {
                var entity = default(T);
                var query = ctx.Set<T>().AsQueryable();
                if (orderBy != null)
                {
                    entity = orderBy(query).FirstOrDefault(func);
                }
                else
                {
                    entity = query.FirstOrDefault(func);
                }
                return entity;
            }
        }

        public static List<T> GetByConditions(Expression<Func<T, bool>> filter)
        {
            return GetByConditions(filter, null);
        }

        public static T FirstOrDefault(Expression<Func<T, bool>> filter, bool IsNull = true)
        {
            using (var ctx = CreateContext())
            {
                var query = ctx.Set<T>().AsQueryable();

                var ret = query.FirstOrDefault(filter);
                if (IsNull && ret == null)
                {
                    ret = new T();
                }
                return ret;
            }
        }

        public static List<T> GetByConditions(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> order = null)
        {
            using (var ctx = CreateContext())
            {
                IQueryable<T> query = ctx.Set<T>().AsQueryable();
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                if (order != null)
                {
                    query = order(query);
                }
                return query.ToList();
            }
        }

        public static List<T> GetByPage(int startIndex, int pageSize, Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> order, out int recordTotal)
        {
            using (var ctx = CreateContext())
            {
                IQueryable<T> query = ctx.Set<T>().AsQueryable();
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                if (startIndex <= 0)
                {
                    startIndex = 1;
                }
                recordTotal = query.Count();
                if (order == null)
                {
                    throw new Exception("Orderby can not be null!");
                }
                query = order(query);
                recordTotal = query.Count();
                return query.Skip((startIndex - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public static List<T> GetAllInfo()
        {
            using (var ctx = CreateContext())
            {
                return ctx.Set<T>().ToList();
            }
        }

        public static List<T> GetByPage<TKey>(int startIndex, int pageSize, Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> order, bool desc, out int recordTotal)
        {
            using (var ctx = CreateContext())
            {
                IQueryable<T> query = ctx.Set<T>().AsQueryable();
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                if (order != null)
                {
                    if (desc)
                        query = query.OrderByDescending(order);
                    else
                        query = query.OrderBy(order);
                }
                if (startIndex <= 0)
                {
                    startIndex = 1;
                }
                recordTotal = query.Count();
                return query.Skip((startIndex - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public static void ExecSql(string sql, params object[] par)
        {
            using (var ctx = CreateContext())
            {
                ctx.Database.ExecuteSqlCommand(sql, par);
            }
        }

        public static IEnumerable<T> SqlQuery(string sql, params object[] par)
        {
            using (var ctx = CreateContext())
            {
                return ctx.Database.SqlQuery<T>(sql, par);
            }
        }

        public void Dispose()
        {
            GC.Collect();
        }

    }
}
