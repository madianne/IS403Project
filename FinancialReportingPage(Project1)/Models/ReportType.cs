using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinancialReportingPage_Project1_.Models
{
    [Table("ReportType")]
    public class ReportType
    {
        [Key]
        public int ReportID { get; set; }
        public string description { get; set; }
    }
}