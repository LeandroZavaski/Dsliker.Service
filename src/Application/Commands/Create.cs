using Domain.Entities;
using MediatR;

namespace Application.Commands
{
    public class Create : IRequest<Description>
    {
        public Description Opinion { get; set; }

        public Create(Description opinion)
        {
            Opinion = opinion;
        }
    }
}
