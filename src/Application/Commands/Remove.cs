using MediatR;

namespace Application.Commands
{
    public class Remove : IRequest<bool>
    {
        public string Id { get; set; }

        public Remove(string id)
        {
            Id = id;
        }
    }
}
