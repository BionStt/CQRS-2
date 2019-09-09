using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS
{
    public class ProductUpdatedNotificationHandler : INotificationHandler<ProductUpdatedNotification>
    {
        public Task Handle(ProductUpdatedNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() => Console.WriteLine(nameof(ProductUpdatedNotificationHandler) + "." + nameof(ProductUpdatedNotification)));
        }
    }
}
