using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductViewModel>
    {
        public Task<ProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(GetProductByIdQueryHandler) + "." + nameof(GetProductByIdQuery));

            return Task.FromResult(new ProductViewModel());
        }
    }
}
