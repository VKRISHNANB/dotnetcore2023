using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPWebAPIDemoA
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [StringLength(25)]
        [MinLength(3, ErrorMessage = "Name must be more than 3 char")]
        public string Name { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Range(0, 500000)]
        public decimal Advance { get; set; }
    }
}
