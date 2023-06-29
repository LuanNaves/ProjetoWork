using System.ComponentModel.DataAnnotations;

namespace ProjetoFinalAtos.Models {
    public class AppUser {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
