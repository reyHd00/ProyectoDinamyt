using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoDinamyt.Repository.Tables
{
    [Table("Users")]
    public class UsersTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdUser { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Pass { get; set; }
        

    }
}
