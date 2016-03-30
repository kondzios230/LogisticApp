using System;
using System.Collections.Generic;
using Logistics.Domain.Aggregates.ShippingDocument;
using Logistics.Domain.Aggregates.OrderDocument;
using Logistics.Domain.Aggregates.Package;
using Logistics.Domain;
namespace Tests.ObjectMothers
{
    public class ShippingDocumentObjectMother
    {
        public static ShippingDocument CreateEmptyShippingDocument()
        {
            ShippingDocument p = new ShippingDocument();

            return p;
        }

        public static ShippingDocument CreateShippingDocumentWithPackedPackage()
        {
            ShippingDocument p = new ShippingDocument
            {
                ID = 4,
                Operator = new Operator() { FirstName = "Konrad", LastName = "Dymek" },
                OrderDocument = new OrderDocument()
                {
                    ID = 1,
                    Client = new OrderClient() { FirstName = "Prezes", LastName = "Prezes", EMail = "prezes@man.pl" },
                    Goods = new List<string>() { "Towar 11" },
                    OrderDate = DateTime.Now,
                    OrderDocumentNumber = "ORD/4",
                    ShippingType = Shipment.POST
                },
                ListOfPackages = new List<Package>() { new Package() { ID = 1, Number = "PCG/1", Status = Statuses.PACKED }, },
                ShippingDocumentNumber = "DOC/4"
            };

            return p;
        }
    }
}
