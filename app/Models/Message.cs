using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Models
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(1200)")]
        public string MessageText { get; set; }
        public int IdC { get; set; }
        public int IdT { get; set; }

        public Message(string MessageText, int IdC, int IdT)
        {
            this.MessageText = MessageText;
            this.IdC = IdC;
            this.IdT = IdT;
        }

        public Message(int ID, string MessageText, int IdC, int IdT) : this(MessageText, IdC, IdT)
        {
            this.ID = ID;
        }
    }
}
