using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Will.Models;

namespace Will.Controllers;

public class WillController : Controller
{
    private readonly ILogger<WillController> _logger;

    public WillController(ILogger<WillController> logger)
    {
        _logger = logger;
    }

    public IActionResult Will()
    {
        return View();
    }

   

  
}
