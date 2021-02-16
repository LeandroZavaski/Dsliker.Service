using Application.Queries;
using Domain.Entities;
using MediatR;
using Repository.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Application.QueriesHandler
{
    public class GetByIdhandler : IRequestHandler<GetById, Description>
    {
        private readonly IDslikerRepository _repository;

        public GetByIdhandler(IDslikerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Description> Handle(GetById request, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(request.Id);
        }
    }
}
