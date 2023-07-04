using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalAtos.Models {
    public class Services {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ServiceCategories Category { get; set; }
    }
}
