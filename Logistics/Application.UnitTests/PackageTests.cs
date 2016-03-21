using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logistics.Application.Services;
using Logistics.Domain.ValueObjects;
namespace Tests.Application.UnitTests
{
    [TestClass]
    public class PackageTests
    {
        [TestMethod]
        public void PackMethodStatusChangedTest()
        {
            // Arrange
            PackageService service = new PackageService();

            // Act
            var package = service.Create();
            service.Pack(package);

            // Assert
            Assert.AreEqual(package.Status, Statuses.PACKED);
        }
        [TestMethod]
        public void PrepareToSendMethodStatusChangedTest()
        {
            // Arrange
            PackageService service = new PackageService();

            // Act
            var package = service.Create();
            service.PrepareToSend(package);

            // Assert
            Assert.AreEqual(package.Status, Statuses.READYTOSHIP);
        }
        [TestMethod]
        public void PrepareToSendMethodPropertyChangedTest()
        {
            // Arrange
            PackageService service = new PackageService();

            // Act
            var package = service.Create();
            service.PrepareToSend(package);

            // Assert
            Assert.IsTrue(package.StickerPrinted);
        }

        [TestMethod]
        public void SendMethodStatusChangedTest()
        {
            // Arrange
            PackageService service = new PackageService();

            // Act
            var package = service.Create();
            service.Send(package,new Logistics.Domain.ValueObjects.Person());

            // Assert
            Assert.AreEqual(package.Status, Statuses.SENT);
        }

        [TestMethod]
        public void SendMethodDateTimeTest()
        {
            // Arrange
            PackageService service = new PackageService();

            // Act
            var package = service.Create();
            service.Send(package, new Logistics.Domain.ValueObjects.Person());
            var dt = DateTime.Now;

            // Assert
            Assert.AreEqual(package.SendDate, dt);
        }

        [TestMethod]
        public void SendMethodCourierTest()
        {
            // Arrange
            PackageService service = new PackageService();

            // Act
            var package = service.Create();
            var courier = new Logistics.Domain.ValueObjects.Person();
            service.Send(package,courier);

            // Assert
            Assert.AreEqual(package.Courier, courier);
        }
        
    }
}
