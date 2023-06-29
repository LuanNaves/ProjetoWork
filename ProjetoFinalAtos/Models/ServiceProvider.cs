using ProjetoFinalAtos.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalAtos.Models {
    public class ServiceProvider {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [ForeignKey("Service")]
        public int ServiceId { get; set; }
        public ServiceCategory Category { get; set; }
        public Services Service { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string District { get; set; }

    }
}
