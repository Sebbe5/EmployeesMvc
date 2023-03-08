using System.ComponentModel.DataAnnotations;

namespace EmployeesMvc.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "E-mail is required")]
        [EmailAddress(ErrorMessage = "Invalid E-mail format")]
        public string Email { get; set; }
    }
}
