using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TownplanningEfApp.Models
{
    public class AadhaarCard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AadhaarNo{get;set;}
        public DateTime ValidTill{get;set;}
        public DateTime	DateOfIssue{get;set;}
        /** 
         * Navigation Properties 
         * For BI-Directional Association between Person and AadhaarCard
         * use Fluent API - OnModelCreating(...) OR
         * have the PersonID as nullable - not advicable in this case
         * **/
        //public Person Owner { get; set; }
        //[ForeignKey("Owner")]
        public int PersonId{get;set;}
    }
}