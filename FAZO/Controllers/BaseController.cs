using Microsoft.AspNetCore.Mvc;

namespace FAZO.Controllers;

[Route("[controller]/[action]")]
public class BaseController : Controller
{
    protected readonly AppDbContext Context;

    public BaseController(AppDbContext context)
    {
        Context = context;
    }
}