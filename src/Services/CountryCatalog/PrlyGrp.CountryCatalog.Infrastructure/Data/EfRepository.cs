using Microsoft.EntityFrameworkCore;
using PrlyGrp.CountryCatalog.ApplicationCore.Entities;
using PrlyGrp.CountryCatalog.ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrlyGrp.CountryCatalog.Infrastructure.Data
{
    public class EfRepository<T> : IAsyncRepository<T> where T : DbBaseEntity //, IAggregateRoot
    {
        protected readonly CountryCatalogDbContext _dbContext;

        public EfRepository(CountryCatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<ICollection<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<ICollection<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_dbContext.Set<T>().AsQueryable(), spec);
        }
    }
}
