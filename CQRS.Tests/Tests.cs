using CQRS;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MediatR.Tests
{
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
}
