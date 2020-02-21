using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Surname { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Mail { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string PhoneNumber { get; set; }

        public Customer (string Surname, string Mail, string PhoneNumber)
        {
            this.Surname = Surname;
            this.Mail = Mail;
            this.PhoneNumber = PhoneNumber;
        }

        public Customer(int ID, string Surname, string Mail, string PhoneNumber) : this(Surname, Mail, PhoneNumber)
        {
            this.ID = ID;
        }
    }
}
