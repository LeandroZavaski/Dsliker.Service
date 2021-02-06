using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IDslikerRepository
    {
        Task<List<Opinion>> GetAsync();

        Task<Opinion> GetByIdAsync(string id);

        Task<Opinion> CreateAsync(Opinion opinion);

        Task UpdateAsync(string id, Opinion opinion);

        Task RemoveAsync(Opinion opinion);

        Task RemoveByIdAsync(string id);
    }
}
