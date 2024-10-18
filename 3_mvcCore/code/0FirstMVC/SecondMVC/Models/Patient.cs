using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AspFirstMVCCore.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be between 3  and 20 chars")]
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public DateTime DateofBirth { get; set; }
        [Column(TypeName = "numeric(18,0)")]
        public long PhoneNumber { get; set; }

       // public List<Doctor> Doctors { get; set; }
    }
}
