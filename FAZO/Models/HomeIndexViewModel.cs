namespace FAZO.Models;

public class HomeIndexViewModel
{
    public IEnumerable<HomeIndexServiceCategoryViewModel> ServiceCategories { get; set; }
    public IEnumerable<HomeIndexServiceViewModel> Services { get; set; }
    public IEnumerable<HomeIndexDestinationViewModel> Destinations { get; set; }
    public IEnumerable<HomeIndexBannerViewModel> Banners { get; set; }
}

public class HomeIndexServiceViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class HomeIndexServiceCategoryViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
}

public class HomeIndexBannerViewModel
{
    public string Category { get; set; }
    public string Title { get; set; }
    public string CoverUrl { get; set; }
}

public class HomeIndexDestinationViewModel
{
    public int Id { get; set; }
    public string CoverUrl { get; set; }
    public string Name { get; set; }
}