using MediatR;

namespace CQRS
{
    public class ProductInsertedNotification : INotification
    {
        public long Id { get; set; }

        public string Description { get; set; }
    }
}
