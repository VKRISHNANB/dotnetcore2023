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
        // Navigation Properties
        /** 
         * One to One - One Person (Principle) One AadhaarCard (Dependent)
         *              A person (Principle) can exist with out an AadhaarCard (Dependent)
         *              But an AadhaarCard (Dependent) cannot exist without Person
         */
        public Person Owner { get; set; }
        [ForeignKey("Owner")]
        public int PersonId{get;set;}
    }
}