using Application.Commands;
using Domain.Entities;
using MediatR;
using Repository.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandsHandler
{
    public class CreateHandler : IRequestHandler<Create, Opinion>
    {
        private readonly IDslikerRepository _repository;

        public CreateHandler(IDslikerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Opinion> Handle(Create request, CancellationToken cancellationToken)
        {
            return await _repository.CreateAsync(request.Opinion);
        }
    }
}
