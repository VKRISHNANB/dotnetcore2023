using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LessonATownplanningEfApp.ModelDOwnedType
{
    public class PersonD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonDId { get; set; }
        public String Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        /** 
         * Owned Type
         */
         public Address Address { get; set; }
        /**
         * One to Many - One Village Many People
         *             - One Person One Village
         **/
        public VillageD HomeTown { get; set; }
        [ForeignKey("HomeTown")]
        public int VillageId { get; set; }
    }
}
