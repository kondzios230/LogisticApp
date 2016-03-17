using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OrderDocument
    {
        #region Properties
        public string OrderDocumentNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public Shipment ShippingType { get; set; }
        public Client Client { get; set; }
        public List<string> Goods { get; set; }
        public ShippingDocument ShipmentDocument { get; set; }
        public Package Package { get; set; }
        #endregion

        #region PublicMethods
        public OrderDocument() { }
        public void Delete() { }
        public void ReportData() { }
        public void GetShipmentStatus() { }
        #endregion  
    }
}
