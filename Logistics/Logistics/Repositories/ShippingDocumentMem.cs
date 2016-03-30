using System.Collections.Generic;
using System.Linq;
using Logistics.Domain.Aggregates.ShippingDocument.Repositories;
using Logistics.Domain.Aggregates.ShippingDocument;
using Logistics.Domain.Aggregates.Package;

namespace Logistics.Infrastructure.Repositories
{
    public class ShippingDocumentMem : IShippingDocumentRepository
    {
        private List<ShippingDocument> posts = new List<ShippingDocument>();
        PackageMem packages = new PackageMem();
        OrderDocumentMem orders = new OrderDocumentMem();
        public ShippingDocumentMem()
        {
            posts = new List<ShippingDocument>
            {
                new ShippingDocument {  ID = 1,
                                        Operator = new Operator() {FirstName="Adam",LastName="Słodowy" },
                                        OrderDocument =  orders.Find(1),
                                        ListOfPackages = new List<Package>() { packages.Find(1) },
                                        ShippingDocumentNumber ="DOC/1"
                                     } ,
                new ShippingDocument {  ID=2,
                                        Operator = new Operator() {FirstName="Jan",LastName="Kowalski" },
                                        OrderDocument = orders.Find(2),
                                         ListOfPackages = new List<Package>() { packages.Find(2) },
                                        ShippingDocumentNumber ="DOC/2"
                                     },
                 new ShippingDocument { ID=3,
                                        Operator = new Operator() {FirstName="Ewa",LastName="Kowalska" },
                                        OrderDocument =orders.Find(3) ,
                                         ListOfPackages = new List<Package>() { packages.Find(3) },
                                        ShippingDocumentNumber ="DOC/3"
                                     },
                 new ShippingDocument { ID=4,
                                        Operator = new Operator() {FirstName="Konrad",LastName="Dymek" },
                                        OrderDocument = orders.Find(4),
                                         ListOfPackages = new List<Package>() { packages.Find(4) },
                                        ShippingDocumentNumber ="DOC/4"
                                     }
            };
        }
        public void Delete(ShippingDocument entity)
        {
            if (entity.ListOfPackages != null)
            {
                foreach (var package in entity.ListOfPackages)
                    packages.Delete(package);
            }
            if(entity.OrderDocument!=null)
                orders.Delete(entity.OrderDocument);
            posts.Remove(entity);

        }

        public ShippingDocument Find(int id)
        {
            return posts.First(d => d.ID == id);
        }

        public List<ShippingDocument> FindAll()
        {
            if (posts != null)
                return posts;
            return new List<ShippingDocument>();
        }

        public void Insert(ShippingDocument entity)
        {
            posts.Add(entity);
        }
    }
}
