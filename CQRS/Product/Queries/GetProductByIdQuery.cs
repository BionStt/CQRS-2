using MediatR;

namespace CQRS
{
    public class GetProductByIdQuery : IRequest<ProductViewModel>
    {
        public long Id { get; set; }
    }
}
