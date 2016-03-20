using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
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
