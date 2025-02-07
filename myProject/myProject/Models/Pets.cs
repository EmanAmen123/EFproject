using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject.Models
{
    public class Pets
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }

        public string Gender { get; set; }
        public string Color { get; set; }
        public string Age { get; set; }
        public bool AdoptionStatus { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime DateAdded { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public virtual List<MedicalRecords> Records { get; } = new List<MedicalRecords>();
        public virtual List<Adoptions> adoptions { get;} = new List<Adoptions>();
        [ForeignKey("Adopter")]
        public int? AdopterId { get; set; }
        public virtual Members Adopter { get; set; }

    }
}
