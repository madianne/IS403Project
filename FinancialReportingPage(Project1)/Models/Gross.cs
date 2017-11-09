using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinancialReportingPage_Project1_.Models
{
    [Table("Gross")]
    public class Gross
    {
        [Key]
        public int TransactionId { get; set; }
        public string PaymentType { get; set; }
        public decimal TransactionTotal { get; set; }
        public DateTime TransactionDate { get; set; }

    }
}