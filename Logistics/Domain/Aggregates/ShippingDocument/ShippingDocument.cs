using System.Collections.Generic;
using System.Linq;
using Logistics.Domain.ValueObjects;

namespace Logistics.Domain.Aggregates.ShippingDocument
{
    public class ShippingDocument
    {
        #region Properties
        public int ID { get; set; }
        public string ShippingDocumentNumber { get; set; }
        public Person Operator { get; set; }
        public List<Package.Package> ListOfPackages { get; set; }
        public OrderDocument.OrderDocument OrderDocument { get; set; }
        #endregion

        #region PublicMethods
        public bool IsAllPackagesSent()
        {
            if(ListOfPackages==null || ListOfPackages.Count==0)
                return true;
            return ListOfPackages.All(p => p.Status == Statuses.SENT);
        }
        public bool IsAllStickersPrinted()
        {
            if (ListOfPackages == null || ListOfPackages.Count == 0)
                return true;
            return ListOfPackages.All(p => p.StickerPrinted);
        }
        #endregion
    }
    
}
