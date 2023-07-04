using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalAtos.Data;
using ProjetoFinalAtos.Models;
using ProjetoFinalAtos.ViewModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Runtime.Intrinsics.X86;

namespace ProjetoFinalAtos.Controllers {
    public class RegisterController : Controller {
        private readonly ApplicationDbContext _context;

        public RegisterController(ApplicationDbContext context) {
            _context = context;
        }

        public IActionResult Create() {
            var viewModel = new RegisterViewModel();

            // Obtenha os Services e mapeie para a propriedade Services da ViewModel
            viewModel.Services = _context.Services.Select(s => new SelectListItem {
                Value = s.Id.ToString(),
                Text = s.Name
            }).ToList();

            // Obtenha as Categories e mapeie para a propriedade Categories da ViewModel
            viewModel.Categories = _context.ServiceCategories.Select(c => new SelectListItem {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();

            return View(viewModel);
        }

        // POST: Register

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Cpf,BirthDate,Phone,Email,ServiceId,CategoryId,Password,State,City,District")] ServiceProviders serviceProviders) {
            var viewModel = new RegisterViewModel();

            if (ModelState.IsValid) {
                viewModel.Services = _context.Services.Select(s => new SelectListItem {
                    Value = s.Id.ToString(),
                    Text = s.Name
                }).ToList();

                viewModel.Categories = _context.ServiceCategories.Select(c => new SelectListItem {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }).ToList();

                _context.Add(serviceProviders);
                await _context.SaveChangesAsync();
                return RedirectToAction("RegisterSuccess");
            }
            // Se houver erros de validação, retorne a view Register com os erros
            viewModel.Services = _context.Services.Select(s => new SelectListItem {
                Value = s.Id.ToString(),
                Text = s.Name
            }).ToList();

            viewModel.Categories = _context.ServiceCategories.Select(c => new SelectListItem {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();

            return View("Create", viewModel);
        }

        //GET: Register
        public IActionResult Index() {
            return View("Register");
        }

        public IActionResult RegisterSuccess() {
            return View();
        }

        //[HttpPost]
        //public IActionResult GetServicesByCategory(int categoryId) {
        //    // Obtenha os serviços correspondentes à categoria selecionada
        //    var services = _context.Services
        //        .Where(s => s.Category.Id == categoryId)
        //        .Select(s => new { Value = s.Id, Text = s.Name })
        //        .ToList();

        //    return Json(services);
        //}






    }
}
