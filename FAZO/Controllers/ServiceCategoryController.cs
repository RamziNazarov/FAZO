using FAZO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FAZO.Controllers;

public class ServiceCategoryController : Controller
{
    private readonly AppDbContext _context;

    public ServiceCategoryController(AppDbContext context)
    {
        _context = context;
    }
    
    public IActionResult Detail2(int id)
    {
        var serviceCategory = _context.ServiceCategories
            .Include(serviceCategory => serviceCategory.Services)
            .FirstOrDefault(x => x.Id == id);
        if(serviceCategory == null)
            return NotFound();
        var serviceCategoryViewModel = new ServiceCategoryDetailViewModel
        {
            Services = serviceCategory.Services.Select(x => new ServiceViewModel
            {
                Id = x.Id,
                CoverUrl = x.CoverUrl,
                Name = x.Name,
                Description = x.Description,
                Duration = x.Duration
            }).ToList()
        };
        
        return View(serviceCategoryViewModel);
    }
}