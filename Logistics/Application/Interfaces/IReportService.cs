using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    interface IReportService
    {
        void Generate();
        void Print();
        void Save();
        void Delete();
    }
}
