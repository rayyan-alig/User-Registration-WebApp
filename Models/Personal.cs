using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RegistrationWeb.Models
{
    public class Personal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [DisplayName("Father's Name")]

        public string FName { get; set; }
        public string? Nationality { get; set; }

        [Required]
        public DateTime DOB { get; set; }
        public string? Address { get; set; }

        [DisplayName("PAN Number")]
        public string? PAN { get; set; }
        public string? City { get; set; }



        [DisplayName("Mobile Number")]
        public string? mobile { get; set; }
        [Required]
        public string Email { get; set; }

        [DisplayName("Passport Number")]
        public string? Passport { get; set; }
    }
}
