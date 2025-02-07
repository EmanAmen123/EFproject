using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace myProject.Models
{
    public class Adoptions
    {
        [Key]
        public int AdoptionID { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? AdoptionDate { get; set; }
        public string? Notes { get; set; }

        public bool AcceptRequesr { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime RequestDate { get; set; }

        [ForeignKey("AdoptedPet")]
        public int petId { get; set; }
        public virtual Pets AdoptedPet { get; set; }

        [ForeignKey("Adopter")]
        public int adopterId { get; set; }
        public virtual Members Adopter { get; set; }


    }
}
