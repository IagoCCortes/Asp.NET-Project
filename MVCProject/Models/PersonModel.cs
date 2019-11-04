using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class PersonModel
    {
        [Display(Name = "Person Id")]
        [Range(100000, 999999, ErrorMessage = "Enter a valid Person Id.")]
        [Required(ErrorMessage = "You need to provide the person's id.")]
        public int PersonId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to provide the person's first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to provide the person's last name.")]
        public string LastName { get; set; }

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You need to provide the person's e-mail.")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "You need to provide a long enough password.")]
        [Required(ErrorMessage = "You must have a password.")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and the confirm password must match.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}