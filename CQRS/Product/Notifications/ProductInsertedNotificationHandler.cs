using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS
{
    public class ProductInsertedNotificationHandler : INotificationHandler<ProductInsertedNotification>
    {
        public Task Handle(ProductInsertedNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() => Console.WriteLine(nameof(ProductInsertedNotificationHandler) + "." + nameof(ProductInsertedNotification)));
        }
    }
}
