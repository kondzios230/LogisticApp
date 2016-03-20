using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectMothers;
namespace Domain.UnitTest
{
    [TestClass]
    public class ReportTests
    {
        [TestMethod]
        public void CheckIfAllSentInEmptyReport()
        {
            // Arrange
            var rep = ReportObjectMother.CreateEmptyReport();

            // Act
            var result = rep.IsAllPackagesSent();

            // Assert
            Assert.IsTrue(result);
        }
       

    }
}
