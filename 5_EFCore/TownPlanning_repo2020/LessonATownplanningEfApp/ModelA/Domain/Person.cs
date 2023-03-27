using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TownplanningEfApp.ModelA
{
    public class Person
    {      
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId{get;set;}
        public String Name{get;set;}
        public DateTime	DateOfBirth{get;set;}
        /**  Navigation Properties **/
        /**  One to One - One Person One Aadhaar Card **/
        public AadhaarCard AadhaarCard{get;set;}       
        /**  One to Many - One Village Many People
        *                - One Person One Village
        **/
        public Village HomeTown{get;set;}
        [ForeignKey("HomeTown")]
        public int VillageId{get;set;}
    }
}