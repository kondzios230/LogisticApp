using Logistics.Application.Services;
using System.Collections.Generic;

namespace Logistics.Application.Interfaces
{
    interface IReportService
    {
        Report Generate();
        string Print(Report entity);
        void Save(Report entity);
    }
}
