using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinancialReportingPage_Project1_.Models
{
    [Table("Net")]
    public class Net
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransactionId { get; set; }
        public string PaymentType { get; set; }
        public decimal TansactionTotal { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal AmountofCosts { get; set; }
    }
}