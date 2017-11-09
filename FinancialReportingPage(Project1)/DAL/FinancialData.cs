using FinancialReportingPage_Project1_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Configuration;

namespace FinancialReportingPage_Project1_.DAL
{
    public class FinancialData : DbContext
    {

        public FinancialData() : base("FinancialData")
        {

        }
        public DbSet<Audited> Auditeds { get; set; }
        public DbSet<Gross> Grosss { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Net> Nets { get; set; }
        public DbSet<PaymentType> Payments { get; set; }
        public DbSet<ReportsGenerated> ReportsGenerates { get; set; }
        public DbSet<ReportType> ReportTypes { get; set; }
        public DbSet<Users> User { get; set; }
    }
}