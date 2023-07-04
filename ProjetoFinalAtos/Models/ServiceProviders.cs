using Microsoft.EntityFrameworkCore;
using ProjetoFinalAtos.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalAtos.Models {
    public class ServiceProviders {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [ForeignKey("ServiceId")]
        public int ServiceId { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public string Password { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string District { get; set; }

    }
}
