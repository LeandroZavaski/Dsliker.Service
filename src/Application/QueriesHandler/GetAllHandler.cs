using Application.Queries;
using Domain.Entities;
using MediatR;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.QueriesHandler
{
    public class GetAllHandler : IRequestHandler<GetAll, List<Description>>
    {
        private readonly IDslikerRepository _repository;

        public GetAllHandler(IDslikerRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Description>> Handle(GetAll request, CancellationToken cancellationToken)
        {
            return await _repository.GetAsync();
        }
    }
}
