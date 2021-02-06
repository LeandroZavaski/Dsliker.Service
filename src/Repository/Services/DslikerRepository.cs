using Domain.Entities;
using MongoDB.Driver;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class DslikerRepository : IDslikerRepository
    {
        private readonly IMongoCollection<Opinion> _opinion;

        public DslikerRepository(IDslikerDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _opinion = database.GetCollection<Opinion>(settings.DslikerCollectionName);
        }

        public Task<List<Opinion>> GetAsync() =>
                        Task.FromResult(_opinion.Find(book => true).ToList());

        public Task<Opinion> GetByIdAsync(string id) =>
                        Task.FromResult(_opinion.Find<Opinion>(book => book.Id == id).FirstOrDefault());

        public Task<Opinion> CreateAsync(Opinion opinion)
        {
            _opinion.InsertOne(opinion);
            return Task.FromResult(opinion);
        }

        public Task UpdateAsync(string id, Opinion opinionIn)
        {
            _opinion.ReplaceOne(book => book.Id == id, opinionIn);
            return Task.CompletedTask;
        }

        public Task RemoveAsync(Opinion opinionIn)
        {
            _opinion.DeleteOne(book => book.Id == opinionIn.Id);
            return Task.CompletedTask;
        }

        public Task RemoveByIdAsync(string id)
        {
            _opinion.DeleteOne(book => book.Id == id);
            return Task.CompletedTask;
        }
    }
}
