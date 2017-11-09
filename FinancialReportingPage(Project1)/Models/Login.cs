using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinancialReportingPage_Project1_.Models
{
    [Table("Login")]
    public class Login
    {
        [Key]
        public int LoginId { get; set; }

        [ForeignKey("Users")]
        public int UserID{ get; set; }
        public virtual Users Users { get; set; }

        public DateTime LoginDate { get; set; }
        public bool Authentication { get; set; }
    }
}