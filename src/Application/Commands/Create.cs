using Domain.Entities;
using MediatR;

namespace Application.Commands
{
    public class Create : IRequest<Opinion>
    {
        public Opinion Opinion { get; set; }

        public Create(Opinion opinion)
        {
            Opinion = opinion;
        }
    }
}
