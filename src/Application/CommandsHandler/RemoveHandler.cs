using Application.Commands;
using MediatR;
using Repository.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandsHandler
{
    public class RemoveHandler : IRequestHandler<Remove, bool>
    {
        private readonly IDslikerRepository _repository;

        public RemoveHandler(IDslikerRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(Remove notification, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(notification.Id);
            return true;
        }
    }
}
