using Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Application.Queries
{
    public class GetAll : IRequest<List<Description>> { }
}
