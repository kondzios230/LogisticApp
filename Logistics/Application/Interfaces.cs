using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    interface IReportMethods
    {
        void Generate();
        void Print();
        void Save();
        void Delete();
    }
    interface IShippingDocumentMethods
    {
        void Create();//ShopApp
        void Delete(); //Cascade
        void GetPackageStatus();
        void Pack();
        void PrepareToSend();
        void Send();
    }
    interface IPackageMethods
    {
        void Create();
        void Pack();
        void PrepareToSend();
        void Send();
    }
}
