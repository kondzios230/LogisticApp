using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
namespace Domain.ValueObjects
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
        public Package Package { get; set; }
        #endregion

        #region PublicMethods
        
        #endregion  
    }
}
