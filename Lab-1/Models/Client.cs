using System.ComponentModel.DataAnnotations;

namespace Lab_1.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [StringLength(25,ErrorMessage ="First name must be between 3 and 25 characters", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Last name must be between 3 and 25 characters", MinimumLength = 3)]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone number is required")]
        [Display(Name = "Phone Number")]
        [RegularExpression (@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid phone number")]
        public int PhoneNumber { get; set; }

    }
}
