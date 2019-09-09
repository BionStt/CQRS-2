using MediatR;

namespace CQRS
{
    public class DeleteProductCommand : IRequest
    {
        public long Id { get; set; }
    }
}
