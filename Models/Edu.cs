using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RegistrationWeb.Models
{
    public class Edu
    {
        [Key]
        public int EduId { get; set; }
        [Required]

        [DisplayName("Enter 10th Percentage")]
        public int tenth { get; set; }
        [DisplayName("Enter 10th board")]
        public string? tenthboard { get; set; }
        [Required]

        [DisplayName("Enter 12th Percentage")]
        public int twelth { get; set; }

        [DisplayName("Enter 12th board")]
        public string? twelthboard { get; set; }
        [Required]

        [DisplayName("Enter UG Course name")]
        public string UGCousre { get; set; }
        [Required]
        public string University { get; set; }
        [Required]

        [DisplayName("Enter UG Percentage")]
        public int UG { get; set; }

        [DisplayName("Enter PG Course name")]
        public string? PGCousre { get; set; }

        [DisplayName("University")]
        public string? PGUniversity { get; set; }

        [DisplayName("Enter PG Percentage")]
        public int? PG { get; set; }

        [DisplayName("Enter any project if done")]
        public string? project { get; set; }

        [DisplayName("Self learned course/software if any")]
        public string? software { get; set; }
    }
}
