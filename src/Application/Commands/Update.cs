using Domain.Entities;
using MediatR;

namespace Application.Commands
{
    public class Update : IRequest<bool>
    {
        public string Id { get; set; }

        public Description Opinion { get; set; }

        public Update(string id, Description opinion)
        {
            Id = id;
            Opinion = opinion;
        }
    }
}
