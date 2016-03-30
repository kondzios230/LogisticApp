using System;
using System.Collections.Generic;
using Logistics.Application.Interfaces;
using Logistics.Domain.Aggregates.OrderDocument;
using Logistics.Domain.Aggregates.Package;
using Logistics.Domain.Aggregates.ShippingDocument;

namespace Logistics.Application.Services
{
    public class ReportService : IReportService
    {
        
             
        public Report Generate()
        {
            var report = new Report();
            return report;
        }

        public string Print(Report entity)
        {
            entity.WasPrinted = true;
            return "RAPORT WYDRUKOWANY";
        }

        public void Save(Report entity)
        {
            throw new NotImplementedException();
        }

       

    
    }

    public class Report
    {
        #region Properties
        public int ID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public List<OrderDocument> ListOfOrders { get; set; }
        public List<Package> ListOfPackages { get; set; }
        public List<ShippingDocument> ListOfShippingDocuments { get; set; }
        public bool WasPrinted { get; set; }
        #endregion

       
    }

}
