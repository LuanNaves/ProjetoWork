using Microsoft.AspNetCore.Mvc;
using ProjetoFinalAtos.Data;
using ProjetoFinalAtos.Models;

namespace ProjetoFinalAtos.Controllers {
    public class ServiceCategoriesController : Controller {
        private readonly ApplicationDbContext _context;
        public ServiceCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index() {
            List<ServiceCategories> categories = _context.ServicesCategories.ToList();
            return View(categories);
        }
    }
}
