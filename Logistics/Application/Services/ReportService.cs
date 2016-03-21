using System;
using System.Collections.Generic;
using Logistics.Application.Interfaces;
using Logistics.Domain.Entities.Repositories;
using Logistics.Infrastructure.Repositories;
using Logistics.Domain.Entities;

namespace Logistics.Application.Services
{
    public class ReportService : IReportService
    {
        private IReportRepository reportRepository;


        public ReportService()
        {
            reportRepository = new ReportMem();
        }

        public ReportService(IReportRepository reportRepository)
        {
            this.reportRepository = reportRepository;
        }
             
        public Report Generate()
        {
            var report = new Report();
            reportRepository.Insert(report);
            return report;
        }

        public string Print(Report entity)
        {
            entity.WasPrinted = true;
            return "RAPORT WYDRUKOWANY";
        }

        public void Save(Report entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Report entity)
        {
            reportRepository.Delete(entity);
        }

        public Report Find(int id)
        {
           return  reportRepository.Find(id);
        }

        public List<Report> FindAll()
        {
            return reportRepository.FindAll();
        }
    }

}
