using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TownplanningEfApp.ModelB
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
         * One to One - One Person One Aadhaar Card 
         * Here Everytime an AadhaarCard is added a related Person (PersonId) should exist first 
         * **/
        public AadhaarCard Aadhaar{get;set;}        
        /** 
         * One to One - One Person One Role 
         * If the RoleId (FK Property) is set as a nullable type 
         * then the Person does not have a ROLE when NULL value is passed to the property
         * **/
        public VillageAdministrationRole Role{get;set;}
        /**
         * Many to Many - One Person can have Many Assets
         *              - One Asset can be Owned by many People
         * May cause CIRCULAR Reference - Check DbContext for solution
         **/
        public List<AssetDetails> Assets{get;set;} 
        /**
         * One to Many - One Village Many People
         *             - One Person One Village
         **/
        public Village HomeTown{get;set;}
        [ForeignKey("HomeTown")]
        public int VillageId{get;set;}
    }
}