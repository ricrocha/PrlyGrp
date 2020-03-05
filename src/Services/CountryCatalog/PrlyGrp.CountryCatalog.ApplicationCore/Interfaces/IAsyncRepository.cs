using PrlyGrp.CountryCatalog.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Interfaces
{
    public interface IAsyncRepository<T> where T : DbBaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<ICollection<T>> ListAllAsync();
        Task<ICollection<T>> ListAsync(ISpecification<T> spec);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<int> CountAsync(ISpecification<T> spec);
    }
}
