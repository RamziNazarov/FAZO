namespace FAZO.Entities;

public class Destination
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string CoverUrl { get; set; }
    public string Temperature { get; set; }
    public string DayLength { get; set; }
    public string MoonsCount { get; set; }
    public string AtmospherePressure { get; set; }
    public string SurfaceType { get; set; }
    
    public virtual List<Entertainment> Entertainments { get; set; }
}