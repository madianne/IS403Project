using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinancialReportingPage_Project1_.Models
{
    public class FinancialReport
    {
        public int TransactionId { get; set; }
        public string PaymentType { get; set; }
        public decimal TransactionTotal { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal AdjustedAmount { get; set; }
        public decimal AmountofCosts { get; set; }
        public decimal ExtraInfo { get; set; }
    }
}