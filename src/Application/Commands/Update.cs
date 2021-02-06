using Domain.Entities;
using MediatR;

namespace Application.Commands
{
    public class Update : IRequest<bool>
    {
        public string Id { get; set; }

        public Opinion Opinion { get; set; }

        public Update(string id, Opinion opinion)
        {
            Id = id;
            Opinion = opinion;
        }
    }
}
