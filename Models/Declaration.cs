using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RegistrationWeb.Models
{
    public class Declaration
    {
        [Key]
        public int DeclarationId { get; set; }
        [Required]
        [DisplayName("Enter Name in Capital")]
        public string CapitalName { get; set; }
        [Required]
        [DisplayName("Enter today's date")]

        public DateTime signeddate { get; set; }
    }
}
