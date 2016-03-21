using System.Collections.Generic;
using Logistics.Application.Interfaces;
using Logistics.Infrastructure.Repositories;
using Logistics.Domain.Aggregates.ShippingDocument.Repositories;
using Logistics.Domain.Aggregates.ShippingDocument;

namespace Logistics.Application.Services
{
    public class ShippingDocumentService : IShippingDocumentService
    {
        private IShippingDocumentRepository shippingRepository;


        public ShippingDocumentService()
        {
            shippingRepository = new ShippingDocumentMem();
        }

        public ShippingDocumentService(IShippingDocumentRepository shippingDocumentRepository)
        {
            this.shippingRepository = shippingDocumentRepository;
        }
        public ShippingDocument Create()
        {
            var shippingDoc = new ShippingDocument() { ID = FindAll().Count+1 };
            shippingRepository.Insert(shippingDoc);
            return shippingDoc;
        }

        public void Delete(ShippingDocument entity)
        {
            shippingRepository.Delete(entity);
        }

        public ShippingDocument Find(int id)
        {
            return shippingRepository.Find(id);
        }

        public List<ShippingDocument> FindAll()
        {
           var ret = shippingRepository.FindAll();
            if (ret == null)
                ret = new List<ShippingDocument>();
            return ret;
        }
    }
}
