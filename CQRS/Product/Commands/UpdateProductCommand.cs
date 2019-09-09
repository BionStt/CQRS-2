using MediatR;

namespace CQRS
{
    public class UpdateProductCommand : IRequest
    {
        public long Id { get; set; }

        public string Description { get; set; }
    }
}
