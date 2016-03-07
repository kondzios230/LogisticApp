using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
namespace Application
{
    public class ReportMethods : IReportMethods
    {
        public void Print() { }
        public void Generate() { }
        public void Save() { }
        public void Delete() { }
    }
    public class ShippingDocumentMethods : IShippingDocumentMethods
    {
        public void Create() { }//ShopApp
        public void Delete() { }//Cascade
        public void GetPackageStatus() { }
        public void Pack() { }
        public void PrepareToSend() { }
        public void Send() { }
    }
    public class PackageMethods : IPackageMethods
    {
        public void Create() { }
        public void Pack() { }
        public void PrepareToSend() { }
        public void Send() { }
    }
  
}
