namespace FAZO.Entities;

public class EntertainmentService
{
    public int EntertainmentId { get; set; }
    public int ServiceId { get; set; }
    public virtual Entertainment Entertainment { get; set; }
    public virtual Service Service { get; set; }
}