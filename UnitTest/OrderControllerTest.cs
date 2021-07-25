using Ecommerce.Controllers;
using Ecommerce.Domain.Models;
using Ecommerce.Infrastructure.Interfaces;
using Moq;
using NUnit.Framework;

namespace UnitTest
{
    public class OrderControllerTest
    {
        private OrdersController controller; 
        [SetUp]
        public void Setup()
        {
            var orderRepository = new Mock<IRepository<Order>>();
            controller = new OrdersController(orderRepository.Object);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}