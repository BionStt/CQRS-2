using MediatR;

namespace CQRS
{
    public class ProductDeletedNotification : INotification
    {
        public long Id { get; set; }

        public string Description { get; set; }
    }
}
