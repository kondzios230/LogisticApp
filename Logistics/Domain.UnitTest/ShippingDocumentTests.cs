using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.ObjectMothers;
namespace Tests.Domain.UnitTest
{
    [TestClass]
    public class ShippingDocumentTests
    {
        [TestMethod]
        public void CheckIfAllSentInEmptyShipDoc()
        {
            // Arrange
            var doc = ShippingDocumentObjectMother.CreateEmptyShippingDocument();

            // Act
            var result = doc.IsAllPackagesSent();

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckIfAllStickersPrintedInEmptyShipDoc()
        {
            // Arrange
            var doc = ShippingDocumentObjectMother.CreateEmptyShippingDocument();

            // Act
            var result = doc.IsAllStickersPrinted();

            // Assert
            Assert.IsTrue(result);
        }
       

    }
}
