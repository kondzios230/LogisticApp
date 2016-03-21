using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logistics.Domain.Entities;
namespace ObjectMothers
{
    public class ReportObjectMother
    {
        public static Report CreateEmptyReport()
        {
            Report p = new Report();

            return p;
        }
    }
}
