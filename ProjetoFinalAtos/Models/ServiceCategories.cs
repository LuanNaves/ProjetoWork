using ProjetoFinalAtos.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinalAtos.Models {
    public class ServiceCategories {
        [Key]
        public int Id { get; set; }
        [Required]
        public ServiceCategory Category { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
    }
}
