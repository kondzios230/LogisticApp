using System;
using System.Collections.Generic;
using Logistics.Domain.ValueObjects;

namespace Logistics.Domain.Aggregates.OrderDocument
{
    public class OrderDocument
    {
        #region Properties
        public int ID { get; set; }
        public string OrderDocumentNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public Shipment ShippingType { get; set; }
        public Client Client { get; set; }
        public List<string> Goods { get; set; }
        public Package.Package Package { get; set; }
        #endregion

        #region PublicMethods
        
        #endregion  
    }
}
