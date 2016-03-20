using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;
using Domain.ValueObjects;

namespace Application.Interfaces
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
