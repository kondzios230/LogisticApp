using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Aggregates.ShippingDocument;
namespace Application.Interfaces
{
    interface IShippingDocumentService
    {
        ShippingDocument Create();
        void Delete(ShippingDocument entity);
        ShippingDocument Find(int id);
        List<ShippingDocument> FindAll();
        
    }
}
