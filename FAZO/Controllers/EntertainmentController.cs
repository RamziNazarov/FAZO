using FAZO.Models;
using Microsoft.AspNetCore.Mvc;

namespace FAZO.Controllers;

public class EntertainmentController : Controller
{
    private readonly AppDbContext _context;

    public EntertainmentController(AppDbContext context)
    {
        _context = context;
    }
    
    public IActionResult Search(EntertainmentSearchViewModel model)
    {
        ViewData["ActivePage"] = "Search";
        
        var entertainment = _context.Entertainments.Where(x=>true);
        if(model.DestinationId.HasValue)
            entertainment = entertainment.Where(x => x.DestinationId == model.DestinationId);
        if(model.ServiceId.HasValue)
            entertainment = entertainment.Where(x => x.EntertainmentServices.Any(y=>y.ServiceId ==model.ServiceId));
        if(model.ServiceCategoryId.HasValue) 
            entertainment = entertainment.Where(x => x.EntertainmentServices.Any(y=>y.Service.ServiceCategoryId == model.ServiceCategoryId));
        
        model.Entertainments = entertainment
            .Select(x => new EntertainmentSearchEntertainmentViewModel
            {
                Id = x.Id,
                CoverUrl = x.CoverUrl,
                Name = x.Name,
                Description = x.Description
            }).ToList();

        model.Destinations = _context.Destinations
            .Select(x => new EntertainmentSearchDestinationViewModel
            {
                Id = x.Id,
                Name = x.Name,
                CoverUrl = x.CoverUrl
            }).ToList();
        
        model.ServiceCategories = _context.ServiceCategories
            .Select(x => new EntertainmentSearchServiceCategoryViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        
        model.Services = _context.Services
            .Select(x => new EntertainmentSearchServiceViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        
        return View(model);
    }
}