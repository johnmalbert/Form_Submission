using System.ComponentModel.DataAnnotations;
using System;
namespace Form_Submission.Models
{
    public class User
    {
        [Required]
        [MinLength(3)]
        [Display(Name = "Your First Name:")] 
        public string FirstName{get;set;}
        
        [Required]
        [MinLength(3)]
        [Display(Name = "Your Last Name")]
        public string LastName{get;set;}

        [Required]
        public int Age{get;set;}

        [Required]
        [EmailAddress]
        public string Email{get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password{get;set;}

        [Required]
        [FutureDate]
        [DataType(DataType.Date)]
        public DateTime Birthday{get;set;}
    }
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string dt = value.ToString();
            if(DateTime.Parse(dt) < DateTime.Now){
                Console.WriteLine("The date entered is before today.");
                return ValidationResult.Success;
            }
            Console.WriteLine("The date given is after today. ");
            return new ValidationResult("The Birthdate entered must be in the past.");

        }
    }
}