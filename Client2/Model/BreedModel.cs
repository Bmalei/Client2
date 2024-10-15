using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client2.Model
{
    [Table("Breed")]
    public class BreedModel
    {
        [Key]
        [Column("BreedID")]
        public int Id { get; set; }

        [Column("Breed")]
        public string Breed { get; set; }

    }
}
