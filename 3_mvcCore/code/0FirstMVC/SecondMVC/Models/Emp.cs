using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace AspFirstMVCCore.Models
{
    /**
     * CREATE TABLE [dbo].[emptbl](
	[eno] [int] NOT NULL, 	[name] [nvarchar](20) NOT NULL, 
	[salary] [numeric](18, 0) NOT NULL, 	[city] [nvarchar](20) NOT NULL,
     */
    public class Emp
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be between 3  and 20 chars")] 
        public string Name { get; set; }=string.Empty;
        [Required]
        [Range(10000, 500000)]
        [Column(TypeName = "numeric")]
        public decimal Salary {  get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "City must be between 3  and 20 chars")]
        [StringRange(AllowableValues = new[] { "Chennai", "Bgl" }, ErrorMessage = "City must be either 'Chennai' or 'Bgl'.")]
        public string City {  get; set; }=string.Empty;        
    }
    public class StringRangeAttribute : ValidationAttribute
    {
        public string[] AllowableValues { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (AllowableValues?.Contains(value?.ToString()) == true)
            {
                return ValidationResult.Success;
            }
            var msg = $"Please enter one of the allowable values: {string.Join(", ", (AllowableValues ?? new string[] { "No allowable values found" }))}.";
            return new ValidationResult(msg);
        }
    }
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = false)]
    public sealed class EnumValidateExistsAttribute : DataTypeAttribute
    {
        public EnumValidateExistsAttribute(Type enumType)
            : base("Enumeration")
        {
            this.EnumType = enumType;
        }

        public override bool IsValid(object value)
        {
            if (this.EnumType == null)
            {
                throw new InvalidOperationException("Type cannot be null");
            }
            if (!this.EnumType.IsEnum)
            {
                throw new InvalidOperationException("Type must be an enum");
            }
            if (!Enum.IsDefined(EnumType, value))
            {
                return false;
            }
            return true;
        }

        public Type EnumType
        {
            get;
            set;
        }
    }
}
