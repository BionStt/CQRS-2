using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS
{
    public class DeleteProductCommandHandler : AsyncRequestHandler<DeleteProductCommand>
    {
        protected override Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => Console.WriteLine(nameof(DeleteProductCommandHandler) + "." + nameof(DeleteProductCommand)));
        }
    }
}
