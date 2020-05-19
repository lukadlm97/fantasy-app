﻿using fantasy_app.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_app.EntityFramework.Services.Common
{
    public class NonQueryDataService<T> where T:DomainObject 
    {
        private readonly DesignTimeDbContextFactory _contextFactory;

        public NonQueryDataService(DesignTimeDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<T> Create(T entity)
        {
            using(ApplicationDbContext context = _contextFactory.CreateDbContext(null))
            {
                EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();

                return createdResult.Entity;
            }
        }

        public async Task<T> Update(int id,T entity)
        {
            using (ApplicationDbContext context = _contextFactory.CreateDbContext(null))
            {
                entity.Id = id;

                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();

                return entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (ApplicationDbContext context = _contextFactory.CreateDbContext(null))
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();

                return true;
            }
        }
    }
}
