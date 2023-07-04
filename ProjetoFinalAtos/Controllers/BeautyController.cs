using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalAtos.Data;

namespace ProjetoFinalAtos.Controllers {
    public class BeautyController : Controller {
        private readonly ApplicationDbContext _context;

        public BeautyController(ApplicationDbContext context) {
            _context = context;
        }

        // GET: Beauty
        public async Task<IActionResult> Index() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Category.Id == 4)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("BeautySharedView", serviceProviders);
        }
        // GET: Beauty/HairDresser
        public async Task<IActionResult> HairDresser() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 20)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("BeautySharedView", serviceProviders);
        }
        // GET: Beauty/Barber
        public async Task<IActionResult> Barber() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 21)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("BeautySharedView", serviceProviders);
        }
        // GET: Beauty/Makeup
        public async Task<IActionResult> Makeup() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 22)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("BeautySharedView", serviceProviders);
        }
        // GET: Beauty/Manicurist
        public async Task<IActionResult> Manicurist() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 23)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("BeautySharedView", serviceProviders);
        }
        // GET: Beauty/Stylist
        public async Task<IActionResult> Stylist() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 24)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("BeautySharedView", serviceProviders);
        }
    }
}
