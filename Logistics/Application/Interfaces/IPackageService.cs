using System.Collections.Generic;
using Logistics.Domain.Entities;
using Logistics.Domain.ValueObjects;

namespace Logistics.Application.Interfaces
{
    interface IPackageService
    {
        Package Create();
        void Pack(Package package);
        void PrepareToSend(Package package);
        void Send(Package package,Person courier);
        Package Find(int id);
        List<Package> FindAll();
    }
}
