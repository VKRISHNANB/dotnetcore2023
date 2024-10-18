using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspFirstMVCCore.Models
{
    public class Doctor
    {
        [Key]
        [Column("doctorno")]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be between 3  and 20 chars")] 
        public string Name { get; set; }=string.Empty;
        [Required]
        public string Speciality { get; set; } = string.Empty;
        [Required]
        public DateTime DateofBirth  { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,2)")]
        public decimal VisitingFees { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,0)")]
        public long PhoneNumber { get; set; }

        //public List<Patient> Patients { get; set; }
    }
}
