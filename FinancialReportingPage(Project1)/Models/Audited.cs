using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinancialReportingPage_Project1_.Models
{
    [Table("Audited")]
    public class Audited
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransactionID { get; set; }

        [ForeignKey("PaymentType")]
        public int PaymentId { get; set; }
        public virtual PaymentType PaymentType { get; set; }

        public decimal TransactionTotal { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal AdjustedAmount { get; set; }

    }
}