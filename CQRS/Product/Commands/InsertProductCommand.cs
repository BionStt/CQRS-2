using MediatR;

namespace CQRS
{
    public class InsertProductCommand : IRequest
    {
        public string Description { get; set; }
    }
}
