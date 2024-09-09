using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Model
{
    public class User
    {
        [Required]
        //[Range(100,1000,ErrorMessage ="UserID must be between 100 and 1000")]
        public int UserID { get; set; }
        [Required]
        [StringLength(15,MinimumLength =3,
            ErrorMessage ="Name must be between 3 char to 15 char")]
        public String Name { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 8,
            ErrorMessage = "Password must be between 8 char to 15 char")]
        public String Password { get; set; }
    }
}
