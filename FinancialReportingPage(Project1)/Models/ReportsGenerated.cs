using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace FinancialReportingPage_Project1_.Models
{
    [Table("ReportsGenerated")]
    public class ReportsGenerated
    {
        [Key]
        public int GeneratedReportID { get; set; }

        [ForeignKey("ReportType")]
        public virtual int ReportID { get; set; }
        public virtual ReportType ReportType { get; set; }

        [ForeignKey("Users")]
        public virtual int UserID { get; set; }
        public virtual Users Users { get; set; }

        public DateTime ReportDate { get; set; }
    }
}