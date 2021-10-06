using Microsoft.EntityFrameworkCore;
using MovieDbInf.Domain.Entities;
using MovieDbInf.Domain.Repositories;
using MovieDbInf.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbInf.Infrastructure.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly MovieDbInfContext _movieDbContext;
        private DbSet<TEntity> _dbSet;

        protected Repository(MovieDbInfContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
            _dbSet = _movieDbContext.Set<TEntity>();
        }

        public async Task Add(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task Delete(TEntity entity)
        {
             _dbSet.Remove(entity);
            await _movieDbContext.SaveChangesAsync();    
        }

        public async Task Update(TEntity entity)
        {
            _dbSet.Update(entity);
            await _movieDbContext.SaveChangesAsync();
        }

        public Task<List<TEntity>> Get(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Where(filter).ToListAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
