using Logistics.Domain.Entities;
using System.Collections.Generic;

namespace Logistics.Application.Interfaces
{
    interface IReportService
    {
        Report Generate();
        string Print(Report entity);
        void Save(Report entity);
        void Delete(Report entity);
        Report Find(int id);
        List<Report> FindAll();
    }
}
