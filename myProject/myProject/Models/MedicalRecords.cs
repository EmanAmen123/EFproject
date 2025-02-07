using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject.Models
{
    public class MedicalRecords
    {
        public int Id { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Date { get; set; }

        public string Description { get; set; }
        public string Vaccine_name { get; set; }

        public string VetName { get; set; }


        [Column(TypeName = "DateTime")]
        public DateTime NextAppointment { get; set; }

        [ForeignKey("pet")]
        public int petId { get; set; }
        public virtual Pets pet { get; set; }
    }
}
