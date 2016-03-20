using Application.Interfaces;
using Domain;
using Domain.Aggregates.ShippingDocument.Repositories;
using Domain.Entities;
using Domain.Entities.Repositories;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class PackageService : IPackageService
    {
        private IPackageRepository packageRepository;


        public PackageService()
        {
            packageRepository = new PackageMem();
        }

        public PackageService(IPackageRepository shippingDocumentRepository)
        {
            this.packageRepository = shippingDocumentRepository;
        }
        public Package Create() {
            var package = new Package();
            packageRepository.Insert(package);
            return package;
        }

        public void Pack(Package package) { package.Status=Statuses.PACKED; }
        public void PrepareToSend(Package package) { package.Status=Statuses.READYTOSHIP;package.StickerPrinted = true; }
        public void Send(Package package,Person courier) {
            package.Status=Statuses.SENT;
            package.SendDate = DateTime.Now;
            package.Courier = courier;
        }

        public Package Find(int id)
        {
            return packageRepository.Find(id);
        }

        public List<Package> FindAll()
        {
            return packageRepository.FindAll();
        }
    }
}
