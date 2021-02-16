using Domain.Entities;
using MongoDB.Driver;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class DslikerRepository : IDslikerRepository
    {
        private readonly IMongoCollection<Description> _description;

        public DslikerRepository(IDslikerDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _description = database.GetCollection<Description>(settings.DslikerCollectionName);
        }

        public Task<List<Description>> GetAsync() =>
                        Task.FromResult(_description.Find(book => true).ToList());

        public Task<Description> GetByIdAsync(string id) =>
                        Task.FromResult(_description.Find<Description>(book => book.Id == id).FirstOrDefault());

        public Task<Description> CreateAsync(Description description)
        {
            _description.InsertOne(description);
            return Task.FromResult(description);
        }

        public Task UpdateAsync(string id, Description descriptionIn)
        {
            _description.ReplaceOne(book => book.Id == id, descriptionIn);
            return Task.CompletedTask;
        }

        public Task RemoveAsync(Description descriptionIn)
        {
            _description.DeleteOne(book => book.Id == descriptionIn.Id);
            return Task.CompletedTask;
        }

        public Task RemoveByIdAsync(string id)
        {
            _description.DeleteOne(book => book.Id == id);
            return Task.CompletedTask;
        }
    }
}
