using MediatR;

namespace CQRS
{
    public class ProductUpdatedNotification : INotification
    {
        public long Id { get; set; }

        public string Description { get; set; }
    }
}
