using System.ComponentModel.DataAnnotations;
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
    }
}