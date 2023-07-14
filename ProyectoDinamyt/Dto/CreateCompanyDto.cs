using System.ComponentModel.DataAnnotations;

namespace ProyectoDinamyt.Dto
{
    public class CreateCompanyDto
    {
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public int TotalJobs { get; set; }
        [Required]
        public DateTime SearchDate { get; set; }
    
    }
}
