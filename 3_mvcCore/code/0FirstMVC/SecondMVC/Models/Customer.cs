using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMVC
{
    /***
     * Create table Customer
     * (
     *  [id] [int] NOT NULL,
     *  [name] [nvarchar](25) NOT NULL,
     *  [emailaddress] [nvarchar](50) NOT NULL,
     *  [advance] [numeric](18, 0) NOT NULL,
     *  CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ( [id] ASC ) 
     * ) 
     */
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(1, 10000)]
        public int Id { get; set; }
        [StringLength(25)]
        [MinLength(3, ErrorMessage = "Name must be more than 3 char")]
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        [Required]
        public string EmailAddress { get; set; }
        [Range(0, 500000)]
        public decimal Advance { get; set; }
    }
}
