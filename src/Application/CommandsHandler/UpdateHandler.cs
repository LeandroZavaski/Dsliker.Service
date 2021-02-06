using Application.Commands;
using MediatR;
using Repository.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandsHandler
{
    public class UpdateHandler : IRequestHandler<Update, bool>
    {
        private readonly IDslikerRepository _repository;

        public UpdateHandler(IDslikerRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(Update notification, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(notification.Id, notification.Opinion);
            return true;
        }
    }
}
