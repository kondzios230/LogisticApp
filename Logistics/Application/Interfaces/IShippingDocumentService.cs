using System.Collections.Generic;
using Logistics.Domain.Aggregates.ShippingDocument;

namespace Logistics.Application.Interfaces
{
    interface IShippingDocumentService
    {
        ShippingDocument Create();
        void Delete(ShippingDocument entity);
        ShippingDocument Find(int id);
        List<ShippingDocument> FindAll();
        
    }
}
