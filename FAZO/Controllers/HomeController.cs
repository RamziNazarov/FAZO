using FAZO.Models;
using Microsoft.AspNetCore.Mvc;

namespace FAZO.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        ViewData["ActivePage"] = "Home";
        var homeIndexViewModel = new HomeIndexViewModel
        {
            Banners = _context.Banners
                .Select(x => new HomeIndexBannerViewModel
                {
                    Category = x.Category,
                    Title = x.Title,
                    CoverUrl = x.CoverUrl
                }).ToList(),
            Destinations = _context.Destinations
                .Select(x => new HomeIndexDestinationViewModel
                {
                    Id = x.Id,
                    CoverUrl = x.CoverUrl,
                    Name = x.Name
                }).ToList(),
            ServiceCategories = _context.ServiceCategories
                .Select(x => new HomeIndexServiceCategoryViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Icon = x.Icon
                }).ToList(),
            Services = _context.Services
                .Select(x => new HomeIndexServiceViewModel
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList()
        };
        return View(homeIndexViewModel);
    }
}