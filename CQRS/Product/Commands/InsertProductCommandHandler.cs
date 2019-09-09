using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS
{
    public class InsertProductCommandHandler : AsyncRequestHandler<InsertProductCommand>
    {
        protected override Task Handle(InsertProductCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => Console.WriteLine(nameof(InsertProductCommandHandler) + "." + nameof(InsertProductCommand)));
        }
    }
}
