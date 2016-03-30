using System;
using System.Collections.Generic;
using System.Linq;
using Logistics.Domain.Aggregates.Package;
using Logistics.Domain.Aggregates.Package.Repositories;

namespace Logistics.Infrastructure.Repositories
{
    public class PackageMem : IPackageRepository
    {
        private List<Package> packages = new List<Package>();

        public PackageMem()
        {
            packages = new List<Package>
            {
               new Package ()
                                        {
                                            ID=1,
                                            Number="PCG/1",
                                            Status=Statuses.PACKED
                                        },
                new Package ()
                                        { ID=2,
                                            Number="PCG/2",
                                            Status=Statuses.READYTOSHIP
                                        },
                new Package ()
                                        { ID=3,
                                            Number="PCG/3",
                                            Status=Statuses.SENT,
                                            Courier = new Courier() {FirstName = "Kurier", LastName = "Kurierewicz" },
                                            SendDate = DateTime.Now
                                        },
               new Package ()
                                        { ID=4,
                                            Number="PCG/4",
                                            Status=Statuses.SENT,
                                            Courier = new Courier() {FirstName = "Kurier", LastName = "Kurierewicz" },
                                            SendDate = DateTime.Now
               }
            };
        }
        public void Delete(Package entity)
        {
            packages.Remove(entity);
        }

        public Package Find(int id)
        {
            return packages.First(d => d.ID == id);
        }

        public List<Package> FindAll()
        {
            return packages;
        }

        public void Insert(Package entity)
        {
            packages.Add(entity);
        }
    }
}
