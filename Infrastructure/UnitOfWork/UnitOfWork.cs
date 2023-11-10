using Core.Interfaces;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T:class
    {
        private readonly DbContext context;
        private IGeneric<T> _entity;

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        public IGeneric<T> Entity
        {
            get
            {
                return _entity ?? (_entity = new GenericRepository<T>(context));
            }
        
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
