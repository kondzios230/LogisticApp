using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Logistics.Domain.Aggregates.ShippingDocument.Repositories;
using Logistics.Application.Services;
namespace Tests.Application.UnitTests
{
    [TestClass]
    public class ShippingDocumentTests
    {
        [TestMethod]
        public void FindAllTest()
        {
            // Arrange
            Mock<IShippingDocumentRepository> repositoryMock = new Mock<IShippingDocumentRepository>();
            ShippingDocumentService service = new ShippingDocumentService(repositoryMock.Object);

            // Act
            service.FindAll();

            // Assert
            repositoryMock.Verify(k => k.FindAll(), Times.Once());
        }

        [TestMethod]
        public void CreateTest()
        {
            // Arrange
            Mock<IShippingDocumentRepository> repositoryMock = new Mock<IShippingDocumentRepository>();
            ShippingDocumentService service = new ShippingDocumentService(repositoryMock.Object);

            // Act
            var doc =  service.Create();

            // Assert
            repositoryMock.Verify(k => k.Insert(doc), Times.Once());
        }

        [TestMethod]
        public void FindIDNotExisting()
        {
            // Arrange
            Mock<IShippingDocumentRepository> repositoryMock = new Mock<IShippingDocumentRepository>();
            ShippingDocumentService service = new ShippingDocumentService(repositoryMock.Object);

            // Act
            var doc = service.Find(0);

            // Assert
            Assert.IsNull(doc);
        }
        [TestMethod]
        public void FindIDExisting()
        {
            // Arrange
            ShippingDocumentService service = new ShippingDocumentService();

            // Act
            var doc = service.Create();
            var find = service.Find(doc.ID);

            // Assert
            Assert.AreEqual(find,doc);
        }
        [TestMethod]
        public void DeleteExistingDoc()
        {
            // Arrange
            ShippingDocumentService service = new ShippingDocumentService();

            // Act
            var countBefore = service.FindAll().Count;
            var doc = service.Create();
            service.Delete(doc);
            var countAfter = service.FindAll().Count;
            // Assert
            Assert.AreEqual(countBefore, countAfter);
        }
        [TestMethod]
        public void DeleteNotExistingDoc()
        {
            // Arrange
            ShippingDocumentService service = new ShippingDocumentService();

            // Act
            var countBefore = service.FindAll().Count;
            var doc = service.Create();
            service.Delete(doc);
            service.Delete(doc);
            var countAfter = service.FindAll().Count;
            // Assert
            Assert.AreEqual(countBefore, countAfter);
        }
    }
}
