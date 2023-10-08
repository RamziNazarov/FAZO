namespace FAZO.Entities;

public class Service
{
    public int Id { get; set; }
    public int ServiceCategoryId { get; set; }
    public string Name { get; set; }
    public string Duration { get; set; }
    public string CoverUrl { get; set; }
    public string Description { get; set; }
    public virtual ServiceCategory ServiceCategory { get; set; }
}