using Microsoft.AspNetCore.Mvc;
using Drew.Models;
using System.Diagnostics;

namespace Drew.Controllers;

public class InfoController : Controller   {

    // Our Views
    public IActionResult Index()
    {
        ViewBag.Message = "Bio";
        return View();
    }
    
    public IActionResult Contact()
    {
        ViewBag.Message = "Contact";                       
        return View();
    }
    public IActionResult TOS()
    {
        ViewBag.Message = "TOS";
        return View();
    }
    public IActionResult Privacy()
    {
        ViewBag.Message = "Privacy";
        return View();
    }
    public IActionResult Calendar()        
    {
        ViewBag.Message = "Calendar";            
        return View();
    }
    public IActionResult Flyer()
    {
        ViewBag.Message = "Flyer";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
