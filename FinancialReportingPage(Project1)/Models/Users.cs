using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinancialReportingPage_Project1_.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        [StringLength(30, ErrorMessage ="Too many characters. Must be under 30 characters long.")]
        [Required]
        public string UserName { get; set; }
        [StringLength(30, ErrorMessage = "Too many characters. Must be under 30 characters long.")]
        [Required]
        public string Password { get; set; }
        [StringLength(50, ErrorMessage = "Too many characters. Must be under 50 characters long.")]
        [Required]
        public string UserFirstName { get; set; }
        [StringLength(50, ErrorMessage = "Too many characters. Must be under 50 characters long.")]
        [Required]
        public string UserLastName { get; set; }
    }
}