using ProyectoDinamyt.Dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoDinamyt.Repository.Tables
{
    [Table("Companies")]
    public class CompaniesTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? IdCompany { get; set; }
        //[Required]
        public string CompanyName { get; set; }
        //[Required]
        public int TotalJobs { get; set; }
        //[Required]
        public DateTime SearchDate { get; set; }


        //Tambien se agrego, aun funcionaba. cualquier error comentar o modificar
        //Este es un mapper, se puede hacer tambien en una clase estatica
        public CompanyDto ToDto()
        {
            return new CompanyDto()
            {
                CompanyName = CompanyName,
                TotalJobs = TotalJobs,
                SearchDate = SearchDate,
                IdCompany = IdCompany ?? throw new Exception("El id no puede ser null")
            };
        }
    }
}
