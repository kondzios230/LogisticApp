using System;
using System.Collections.Generic;
using System.Linq;
using Logistics.Domain.ValueObjects;
using Logistics.Domain.Aggregates.ShippingDocument;
namespace Logistics.Domain.Entities
{

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

        #region PublicMethods
        public bool IsAllPackagesSent()
        {
            if (ListOfPackages == null || ListOfPackages.Count == 0)
                return true;
            return ListOfPackages.All(p => p.Status == Statuses.SENT);
        }
        #endregion
    }
}
