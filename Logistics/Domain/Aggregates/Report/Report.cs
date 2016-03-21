using System;
using System.Collections.Generic;
using System.Linq;
namespace Logistics.Domain.Aggregates.Report
{

    public class Report
    {
        #region Properties
        public int ID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public List<OrderDocument.OrderDocument> ListOfOrders { get; set; }
        public List<Package.Package> ListOfPackages { get; set; }
        public List<ShippingDocument.ShippingDocument> ListOfShippingDocuments { get; set; }
        public bool WasPrinted { get; set; }
        #endregion

        #region PublicMethods
        public bool IsAllPackagesSent()
        {
            if (ListOfPackages == null || ListOfPackages.Count == 0)
                return true;
            return ListOfPackages.All(p => p.Status == ValueObjects.Statuses.SENT);
        }
        #endregion
    }
}
