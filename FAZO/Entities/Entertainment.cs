namespace FAZO.Entities;

public class Entertainment
{
    public int Id { get; set; }
    public int DestinationId { get; set; }
    public string CoverUrl { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public virtual Destination Destination { get; set; }
    public virtual List<EntertainmentService> EntertainmentServices { get; set; }
}