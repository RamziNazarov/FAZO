namespace FAZO.Models;

public class HomeServicesViewModel
{
    public IEnumerable<HomeServicesServiceCategoryViewModel> ServiceCategories { get; set; }
    public IEnumerable<HomeServicesServiceViewModel> Services { get; set; }
    public IEnumerable<HomeServicesDestinationViewModel> Destinations { get; set; }
}

public class HomeServicesServiceViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class HomeServicesServiceCategoryViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public string Description { get; set; }
}

public class HomeServicesDestinationViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}