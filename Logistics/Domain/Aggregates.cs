using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ShippingDocument
    {
        #region Properties
        public string ShippingDocumentNumber { get; set; }
        public Person Operator { get; set; }
        public Package Package { get; set; }
        public OrderDocument OrderDocument { get; set; }
        #endregion

        #region PublicMethods
        public ShippingDocument(){  }
        public void Delete() { }//Cascade
        public void GetPackageStatus() { }
        public void ChangePackageStatus(Statuses newStatus) { Package.ChangePackageStatus(newStatus); }
        #endregion
    }
    
}
