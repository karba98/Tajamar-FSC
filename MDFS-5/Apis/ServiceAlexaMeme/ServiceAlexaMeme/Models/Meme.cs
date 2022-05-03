using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceAlexaMeme.Models
{
    [Table("MEMES")]
    public class Meme
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("FRASE")]
        public String Frase{ get; set; }
    }
}
