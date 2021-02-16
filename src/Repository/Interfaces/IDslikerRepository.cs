using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IDslikerRepository
    {
        Task<List<Description>> GetAsync();

        Task<Description> GetByIdAsync(string id);

        Task<Description> CreateAsync(Description opinion);

        Task UpdateAsync(string id, Description opinion);

        Task RemoveAsync(Description opinion);

        Task RemoveByIdAsync(string id);
    }
}
