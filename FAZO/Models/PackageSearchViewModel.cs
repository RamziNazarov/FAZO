namespace FAZO.Models;

public class EntertainmentSearchViewModel
{
    public int? DestinationId { get; set; }
    public int? ServiceId { get; set; }
    public int? ServiceCategoryId { get; set; }
    public IEnumerable<EntertainmentSearchDestinationViewModel> Destinations { get; set; }
    public IEnumerable<EntertainmentSearchEntertainmentViewModel> Entertainments { get; set; }
    public IEnumerable<EntertainmentSearchServiceCategoryViewModel> ServiceCategories { get; set; }
    public IEnumerable<EntertainmentSearchServiceViewModel> Services { get; set; }
}

public class EntertainmentSearchServiceViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class EntertainmentSearchDestinationViewModel
{
    public int Id { get; set; }
    public string CoverUrl { get; set; }
    public string Name { get; set; }
}

public class EntertainmentSearchServiceCategoryViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class EntertainmentSearchEntertainmentViewModel
{
    public int Id { get; set; }
    public string CoverUrl { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
