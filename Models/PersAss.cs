using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RegistrationWeb.Models
{
    public class PersAss
    {
        [Key]
        public int PersAssId { get; set; }
        [Required]

        [DisplayName("Enter your strengths")]
        public string strength { get; set; }
        [Required]

        [DisplayName("Enter your weaknesses")]
        public string weaknesses { get; set; }

        public string? Hobbies { get; set; }

        public string? Sports { get; set; }


        [DisplayName("Long term goals?")]
        public string? Goals { get; set; }

        [Required]
        [DisplayName("Have you ever attended an interview at any of the MNJ Software Offices across the Globe in the last 6 months? Yes/No (If yes, mention the details)")]
        public string atMNJ { get; set; }
    }
}
