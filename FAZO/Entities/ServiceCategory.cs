namespace FAZO.Entities;

public class ServiceCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public string Description { get; set; }
    public string CoverUrl { get; set; }
    public virtual ICollection<Service> Services { get; set; }
}
