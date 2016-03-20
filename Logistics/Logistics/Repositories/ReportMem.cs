using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using CommonComponents;
using Domain.Aggregates.ShippingDocument.Repositories;
using Domain.Aggregates.ShippingDocument;
using Domain.ValueObjects;
using Domain.Entities;
using Domain.Entities.Repositories;
namespace Infrastructure.Repositories
{
    public class ReportMem : IReportRepository
    {
        private List<Report> reports = new List<Report>();
        PackageMem packages = new PackageMem();
        ShippingDocumentMem documents = new ShippingDocumentMem();
        OrderDocumentMem orderDocuments = new OrderDocumentMem();

        public ReportMem()
        {
            reports = new List<Report>
            {
              new Report () { ID = 1,
                            DateFrom =new DateTime(2016,3,1),
                            DateTo =new DateTime(2016,3,31),
                            ListOfPackages = packages.FindAll(),
                            ListOfOrders = orderDocuments.FindAll(),
                            ListOfShippingDocuments = documents.FindAll()
                            ,WasPrinted =false
              }
            };
        }
        public void Delete(Report entity)
        {
            reports.Remove(entity);
        }

        public Report Find(int id)
        {
            return reports.First(d => d.ID == id);
        }

        public List<Report> FindAll()
        {
            return reports;
        }

        public void Insert(Report entity)
        {
            reports.Add(entity);
        }
    }
}
