using FAZO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FAZO.Controllers;

public class DestinationController : Controller
{
    private readonly AppDbContext _context;

    public DestinationController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Detail2(int id)
    {
        var destination = _context.Destinations
            .Include(destination => destination.Entertainments)
            .FirstOrDefault(x => x.Id == id);

        if (destination == null)
            return NotFound();

        var destinationViewModel = new DestinationDetailViewModel
        {
            Id = destination.Id,
            Name = destination.Name,
            CoverUrl = destination.CoverUrl,
            Temperature = destination.Temperature,
            DayLength = destination.DayLength,
            MoonsCount = destination.MoonsCount,
            AtmospherePressure = destination.AtmospherePressure,
            SurfaceType = destination.SurfaceType,
            Entertainments = destination.Entertainments.Select(x => new EntertainmentViewModel
            {
                Id = x.Id,
                DestinationId = x.DestinationId,
                CoverUrl = x.CoverUrl,
                Name = x.Name,
                Description = x.Description
            }).ToList()
        };
        
        return View(destinationViewModel);
    }
}