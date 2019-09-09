using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS
{
    public class UpdateProductCommandHandler : AsyncRequestHandler<UpdateProductCommand>
    {
        protected override Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => Console.WriteLine(nameof(UpdateProductCommandHandler) + "." + nameof(UpdateProductCommand)));
        }
    }
}
