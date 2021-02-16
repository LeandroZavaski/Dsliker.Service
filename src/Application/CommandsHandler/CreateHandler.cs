using Application.Commands;
using Domain.Entities;
using MediatR;
using Repository.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandsHandler
{
    public class CreateHandler : IRequestHandler<Create, Description>
    {
        private readonly IDslikerRepository _repository;

        public CreateHandler(IDslikerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Description> Handle(Create request, CancellationToken cancellationToken)
        {
            return await _repository.CreateAsync(request.Opinion);
        }
    }
}
