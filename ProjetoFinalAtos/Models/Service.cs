using ProjetoFinalAtos.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinalAtos.Models {
    public class Service {
        [Key]
        public int Id { get; set; }
        public Services Name { get; set; }
        public ServiceCategory Category { get; set; }

    }
}
