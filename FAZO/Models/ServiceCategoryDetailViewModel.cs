namespace FAZO.Models;

public class ServiceCategoryDetailViewModel
{
    public string CoverUrl { get; set; }
    public List<ServiceViewModel> Services { get; set; }
}

public class ServiceViewModel
{
    public int Id { get; set; }
    public int ServiceCategoryId { get; set; }
    public string Name { get; set; }
    public string Duration { get; set; }
    public string CoverUrl { get; set; }
    public string Description { get; set; }
}