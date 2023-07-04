using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalAtos.Data;
using ProjetoFinalAtos.Models;

namespace ProjetoFinalAtos.Controllers
{
    public class HouseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HouseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: House
        public async Task<IActionResult> Index() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Category.Id == 1)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("HouseSharedView", serviceProviders);
        }
        // GET: House/Mason
        public async Task<IActionResult> Mason() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 1)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("HouseSharedView", serviceProviders);
        }
        // GET: House/MasonsHelper
        public async Task<IActionResult> MasonsHelper() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 2)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("HouseSharedView", serviceProviders);
        }
        // GET: House/Carpenter
        public async Task<IActionResult> Carpenter() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 3)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("HouseSharedView", serviceProviders);
        }
        // GET: House/Electrician
        public async Task<IActionResult> Electrician() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 4)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("HouseSharedView", serviceProviders);
        }
        // GET: House/Painter
        public async Task<IActionResult> Painter() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 5)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("HouseSharedView", serviceProviders);
        }
        // GET: House/DayLaborer
        public async Task<IActionResult> DayLaborer() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 6)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("HouseSharedView", serviceProviders);
        }
        // GET: House/Cleaner
        public async Task<IActionResult> Cleaner() {
            var serviceProviders = await _context.ServiceProviders
                .Join(_context.Services,
                    sp => sp.ServiceId,
                    s => s.Id,
                    (sp, s) => new { ServiceProvider = sp, Service = s })
                .Where(x => x.Service.Id == 7)
                .Select(x => x.ServiceProvider)
                .ToListAsync();

            return View("HouseSharedView", serviceProviders);
        }

    }
}
