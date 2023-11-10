using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class GenericRepository<T> : IGeneric<T> where T : class
    {
        private readonly DbContext context;
        private DbSet<T> table = null;

        public GenericRepository(DbContext context)
        {
            this.context = context;
            table = context.Set<T>();
        }

        public bool Add(T entity)
        {
            try
            {
                table.Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(object id)
        {
            try
            {
                var entity = table.Find(id);

                if (entity == null)
                    return false;

                table.Remove(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public bool Update(T entity)
        {
            try
            {
                table.Attach(entity);
                context.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
