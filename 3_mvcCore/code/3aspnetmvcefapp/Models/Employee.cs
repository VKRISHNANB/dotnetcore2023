using System.ComponentModel.DataAnnotations;
namespace Aspnetmvcapp
{
    public class Employee
    {
        public int ID{get;set;}
        [Required]
        [StringLength(25)]
        [MinLength(3,ErrorMessage="First Name must be more than 3 char")]
        public string FirstName{get;set;}

        [Required]
        [StringLength(25)]
        [MinLength(3,ErrorMessage="Last Name must be more than 3 char")] 
        public string LastName{get;set;}

        [Range(10000,500000)]
        public int Salary{get;set;}
    }
}