using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client2.Model
{
    [Table("Name")]
    public class NameModel
    {
        [Key]
        [Column("NameID")]
        public int Id { get; set; }

        [Column("Name")]
        public string DogName { get; set; }

    }
}
