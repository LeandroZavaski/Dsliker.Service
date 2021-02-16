using Domain.Entities;
using MediatR;

namespace Application.Queries
{
    public class GetById : IRequest<Description>
    {
        public string Id { get; set; }

        public GetById(string id)
        {
            Id = id;
        }
    }
}
