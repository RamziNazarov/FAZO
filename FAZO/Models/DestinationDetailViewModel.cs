namespace FAZO.Models;

public class DestinationDetailViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string CoverUrl { get; set; }
    public string Temperature { get; set; }
    public string DayLength { get; set; }
    public string MoonsCount { get; set; }
    public string AtmospherePressure { get; set; }
    public string SurfaceType { get; set; }
    public List<EntertainmentViewModel> Entertainments { get; set; }
}

public class EntertainmentViewModel
{
    public int Id { get; set; }
    public int DestinationId { get; set; }
    public string CoverUrl { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}