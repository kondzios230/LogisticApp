using System.Collections.Generic;
using Logistics.Domain.Aggregates.Package;

namespace Logistics.Application.Interfaces
{
    interface IPackageService
    {
        Package Create();
        void Pack(Package package);
        void PrepareToSend(Package package);
        void Send(Package package,Courier courier);
        Package Find(int id);
        List<Package> FindAll();
    }
}
