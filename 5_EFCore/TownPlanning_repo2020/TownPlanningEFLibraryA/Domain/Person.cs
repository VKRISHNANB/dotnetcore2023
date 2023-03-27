using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TownplanningEfApp.Models
{
    public class Person
    {      
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId{get;set;}
        public String Name{get;set;}
        public DateTime	DateOfBirth{get;set; }
        /**  Navigation Properties **/
        /**  One to One - One Person (Principle) One AadhaarCard (Dependent)
         *              A person can exist with out an AadhaarCard
         *              Making this 1:0, and then 1:1
         * NOTES:             
         * You can only use [Required] on properties on the dependent entity to impact the requiredness of
         * the relationship. [Required] on the navigation from the principal entity is usually ignored,
         * but it may cause the entity to become the dependent one. 
         * 
         * The data annotations[ForeignKey] and [InverseProperty] are available in
         * the System.ComponentModel.DataAnnotations.Schema namespace.
         * [Required] is available in the System.ComponentModel.DataAnnotations namespace.
         * */
        public AadhaarCard Aadhaar{get;set;}
        [ForeignKey("Aadhaar")]
        public int AadhaarNo{get;set;}
        /** 
         * One to One - One Person One Role 
         * If the RoleId (FK Property) is set as a nullable type 
         * then the Person does not have a ROLE 
         * **/
        public VillageAdministrationRole Role{get;set;}
        [ForeignKey("Role")]
        public int? RoleId{get;set;}
        /**  Many to Many - One Person can have Many Assets
        *                 - One Asset can be Owned by many People
        *  May cause CIRCULAR Reference - Check DbContext for solution
        */
        public List<AssetDetails> Assets{get;set;} 
        /**  One to One  - One Person One Village     */
        public Village HomeTown{get;set;}
        [ForeignKey("HomeTown")]
        public int VillageId{get;set;}
    }
}