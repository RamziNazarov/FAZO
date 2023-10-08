namespace FAZO.Models;

public class HomeAboutViewModel
{
    public IEnumerable<HomeAboutServiceCategoryViewModel> ServiceCategories { get; set; }
    public IEnumerable<HomeAboutDestinationViewModel> Destinations { get; set; }
    public IEnumerable<HomeAboutServiceViewModel> Services { get; set; }
}

public class HomeAboutServiceViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class HomeAboutServiceCategoryViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class HomeAboutDestinationViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}
