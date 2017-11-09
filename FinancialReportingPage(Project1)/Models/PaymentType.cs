using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinancialReportingPage_Project1_.Models
{
    [Table("PaymentType")]
    public class PaymentType
    {
        [Key]
        public int PaymentID { get; set; }
        public string PaymentDescription { get; set; }
    }
}