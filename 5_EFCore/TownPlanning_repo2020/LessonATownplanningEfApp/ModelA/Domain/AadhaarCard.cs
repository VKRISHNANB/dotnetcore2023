using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TownplanningEfApp.ModelA
{
    public class AadhaarCard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AadhaarId{get;set;}
        public DateTime ValidTill{get;set;}
        public DateTime	DateOfIssue{get;set;}           
        public int PersonId{get;set;}
    }
}