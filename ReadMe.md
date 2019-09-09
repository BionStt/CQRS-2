# MediatR

CQRS with MediatR in .NET Core.

## Command

 ```csharp
public class InsertProductCommand : IRequest
{
    public string Description { get; set; }
}
 ```

## CommandHandler

```csharp
    public class InsertProductCommandHandler : AsyncRequestHandler<InsertProductCommand>
    {
        protected override Task Handle(InsertProductCommand request, CancellationToken cancellationToken)
        {
            /// Implementation
        }
    }
```

## Query

```csharp
public class GetProductByIdQuery : IRequest<ProductViewModel>
{
    public long Id { get; set; }
}
```

## QueryHandler

```csharp
public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductViewModel>
{
    public Task<ProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        /// Implementation
    }
}
```

## Notification

```csharp
public class ProductInsertedNotification : INotification
{
    public long Id { get; set; }

    public string Description { get; set; }
}
```

## NotificationHandler

```csharp
public class ProductInsertedNotificationHandler : INotificationHandler<ProductInsertedNotification>
{
    public Task Handle(ProductInsertedNotification notification, CancellationToken cancellationToken)
    {
        /// Implementation
    }
}
```

## Tests

```csharp
[TestClass]
public class Tests
{
    public Tests()
    {
        var services = new ServiceCollection();
        services.AddMediatR(typeof(InsertProductCommand));
        Mediator = services.BuildServiceProvider().GetService<IMediator>();
    }

    private IMediator Mediator { get; }

    [TestMethod]
    public async Task DeleteProductCommand()
    {
        await Mediator.Send(new DeleteProductCommand { Id = 1 });

        await Mediator.Publish(new ProductDeletedNotification());
    }

    [TestMethod]
    public async Task GetProductByIdQuery()
    {
        var result = await Mediator.Send(new GetProductByIdQuery { Id = 1 });
    }

    [TestMethod]
    public async Task InsertProductCommand()
    {
        await Mediator.Send(new InsertProductCommand { Description = "Description" });

        await Mediator.Publish(new ProductInsertedNotification());
    }

    [TestMethod]
    public async Task UpdateProductCommand()
    {
        await Mediator.Send(new UpdateProductCommand { Id = 1, Description = "Description" });

        await Mediator.Publish(new ProductUpdatedNotification());
    }
}
```
