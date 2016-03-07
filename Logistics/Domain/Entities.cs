using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Package
    {
        #region Properties
        public string Number { get; set; }
        public DateTime SendDate { get; set; }
        public Person Courier { get; set; }
        public Statuses Status { get; set; }
        #endregion

        #region PublicMethods
        public Package() { }
        public void Delete() { }
        public void ChangePackageStatus(Statuses newStatus) { }
        public void CreateShippingSticker() { }
        public void FillCourierData(Person Courier) { }
        public void ReportData() { }
        #endregion
    }
    public class Report
    {
        #region Properties
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public List<OrderDocument> ListOfOrders { get; set; }
        public List<ShippingDocument> ListOfShippingDocuments { get; set; }
        #endregion

        #region PublicMethods
        public void Generate() { }
        public void Save() { }
        public void Print() { }
        public void Delete() { }
        #endregion
    }
}
