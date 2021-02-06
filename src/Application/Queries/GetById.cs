using Domain.Entities;
using MediatR;

namespace Application.Queries
{
    public class GetById : IRequest<Opinion>
    {
        public string Id { get; set; }

        public GetById(string id)
        {
            Id = id;
        }
    }
}
