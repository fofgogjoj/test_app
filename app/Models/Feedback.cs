using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Models
{
    public class Feedback
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string Surname { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Mail { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string PhoneNumber { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Theme { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(1200)")]
        public string Message { get; set; }
        //[Required]
        //public int Captcha { get; set; }
    }
}
