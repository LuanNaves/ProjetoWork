using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoFinalAtos.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalAtos.ViewModels {
    public class RegisterViewModel {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string District { get; set; }

        [Required]
        public int ServiceId { get; set; } // Para selecionar o Service correspondente
        public List<SelectListItem> Services { get; set; } // Para exibir as opções de Services

        [Required]
        public int CategoryId { get; set; } // Para selecionar a Category correspondente
        public List<SelectListItem> Categories { get; set; } // Para exibir as opções de Categories
    }
}

