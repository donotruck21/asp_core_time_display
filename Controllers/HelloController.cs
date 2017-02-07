using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            System.Console.WriteLine(CurrentTime);
            System.Console.WriteLine(CurrentTime.ToString("MMMM dd, yyyy hh:mm tt"));
            ViewBag.Time = CurrentTime.ToString("MMMM dd, yyyy hh:mm tt");
            return View("Index");
        }
    }
}