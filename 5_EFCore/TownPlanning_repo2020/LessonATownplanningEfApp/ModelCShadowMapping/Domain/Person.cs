using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TownplanningEfApp.ModelC
{
    public class Person
    {      
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId{get;set;}
        public String Name{get;set;}
        public DateTime	DateOfBirth{get;set;}
        /**  Navigation Properties **/        
        /** 
         * One to One - One Person One Role 
         * If the RoleId (FK Property) is set as a nullable type 
         * then the Person does not have a ROLE when NULL value is passed to the property
         * **/
        public VillageAdministrationRole Role{get;set;}       
        /**
         * One to Many - One Village Many People
         *             - One Person One Village
         **/
        public Village HomeTown{get;set;}
        [ForeignKey("HomeTown")]
        public int VillageId{get;set;}
    }
}