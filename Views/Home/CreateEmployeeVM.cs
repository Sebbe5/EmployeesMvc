using System.ComponentModel.DataAnnotations;

namespace EmployeesMvc.Views.Home
{
    public class CreateEmployeeVM
    {
        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "E-mail is required")]
        [EmailAddress(ErrorMessage = "Invalid E-mail format")]
        public string Email { get; set; }

        [Display(Name = "What is 2+2?")]
        [Required(ErrorMessage = "Enter an answer!")]
        [Range(4, 4, ErrorMessage = "*BEEP BOOP* That is not correct!")]
        public int BotCheck { get; set; }
    }
}
