using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Logistics.Domain.Entities.Repositories;
using Logistics.Application.Services;
namespace Tests.Application.UnitTests
{
    [TestClass]
    public class ReportTests
    {
        [TestMethod]
        public void GenerateMethodTest()
        {
            // Arrange
            Mock<IReportRepository> repositoryMock = new Mock<IReportRepository>();
            ReportService service = new ReportService(repositoryMock.Object);

            // Act
            var rep = service.Generate();

            // Assert
            repositoryMock.Verify(k => k.Insert(rep), Times.Once());
        }
        [TestMethod]
        public void PrintMethodReturnTest()
        {
            // Arrange
            Mock<IReportRepository> repositoryMock = new Mock<IReportRepository>();
            ReportService service = new ReportService(repositoryMock.Object);

            // Act
            var rep = service.Generate();
            var returned = service.Print(rep);

            // Assert
            Assert.IsNotNull(returned);
        }
        [TestMethod]
        public void PrintMethodPropertyChangedTest()
        {
            // Arrange
            Mock<IReportRepository> repositoryMock = new Mock<IReportRepository>();
            ReportService service = new ReportService(repositoryMock.Object);

            // Act
            var rep = service.Generate();
            service.Print(rep);

            // Assert
            Assert.IsTrue(rep.WasPrinted);
        }
        
    }
}
