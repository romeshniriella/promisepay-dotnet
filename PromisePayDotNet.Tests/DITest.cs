using NUnit.Framework;
using PromisePayDotNet.DI;
using PromisePayDotNet.Interfaces;
using Unity;

namespace PromisePayDotNet.Tests
{
    public class DITest
    {
        [Test]
        public void TestDIContainer()
        {
            var container = new UnityContainer();
            InitUnityContainer.Init(container);
            var userService = container.Resolve<IUserRepository>();
            Assert.IsNotNull(userService);
        }
    }
}
