using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegistrationWeb.Models
{
    public class PrevEmp
    {
        [Key]
        public int PrevEmpId { get; set; }
        [DisplayName("Company Name")]
        public string? CompName { get; set; }

        [DisplayName("Company Address")]
        public string? CompAddress { get; set; }

        [DisplayName("HR Name")]
        public string? HRName { get; set; }

        [DisplayName("HR's Contact")]
        public string? HRMobile { get; set; }

        [DisplayName("HR's email")]
        public string? HREmail { get; set; }

        [DisplayName("Name of Reporting Manager")]
        public string? RepManager { get; set; }

        [DisplayName("Contact of Reporting Manager")]
        public string? ContRepManager { get; set; }

        public string? CTC { get; set; }
    }
}
