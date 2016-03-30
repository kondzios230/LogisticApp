using System;
using System.Collections.Generic;
using System.Linq;
using Logistics.Domain.Aggregates.OrderDocument;
using Logistics.Domain.Aggregates.OrderDocument.Repositories;

namespace Logistics.Infrastructure.Repositories
{
    public class OrderDocumentMem : IOrderDocumentRepository
    {
        private List<OrderDocument> orderDocuments = new List<OrderDocument>();

        public OrderDocumentMem()
        {
            orderDocuments = new List<OrderDocument>()
            {
                new OrderDocument(){
                    ID =1,
                                                                            Client = new OrderClient(){FirstName="Prezes",LastName="Prezes",EMail="prezes@man.pl" },
                                                                            Goods= new List<string>() {
                                                                                "Towar 11",
                                                                                "Towar 21",
                                                                                "Towar 31",
                                                                                "Towar 41"
                                                                            },
                                                                            OrderDate = DateTime.Now,
                                                                            OrderDocumentNumber="ORD/4",
                                                                            ShippingType=Shipment.POST
                                                                            }
                ,new OrderDocument(){
                    ID=2,
                                                                            Client = new OrderClient(){FirstName="Man",LastName="Dude",EMail="dude@man.pl" },
                                                                            Goods= new List<string>() {
                                                                                "Towar 11",
                                                                                "Towar 22",
                                                                                "Towar 23",
                                                                                "Towar 24"
                                                                            },
                                                                            OrderDate = DateTime.Now,
                                                                            OrderDocumentNumber="ORD/3",
                                                                            ShippingType=Shipment.COURIER
                                                                            }
                ,new OrderDocument(){
                    ID=3,
                                                                            Client = new OrderClient() {FirstName="XY",LastName="ZX",EMail="email@post.pl" },
                                                                            Goods= new List<string>() {
                                                                                "Towar 5",
                                                                                "Towar 6",
                                                                                "Towar 7",
                                                                                "Towar 8"
                                                                            },
                                                                            OrderDate = DateTime.Now,
                                                                            OrderDocumentNumber="ORD/2",
                                                                            ShippingType=Shipment.POST
                                                                            }
    ,new OrderDocument() {
        ID=4,
                                                                                Client = new OrderClient(){FirstName="Ixinski",LastName="Prezes",EMail="Prezes@post.pl" },
                                                                                Goods= new List<string>() {
                                                                                    "Towar 1",
                                                                                    "Towar 2",
                                                                                    "Towar 3",
                                                                                    "Towar 4"
                                                                                },
                                                                                OrderDate = DateTime.Now,
                                                                                OrderDocumentNumber="ORD/1",
                                                                                ShippingType=Shipment.COURIER
                                                                            }

            };
        }
        public void Delete(OrderDocument entity)
        {
            orderDocuments.Remove(entity);
        }

        public OrderDocument Find(int id)
        {
            return orderDocuments.First(d => d.ID == id);
        }

        public List<OrderDocument> FindAll()
        {
            return orderDocuments;
        }

        public void Insert(OrderDocument entity)
        {
            orderDocuments.Add(entity);
        }
    }
}
