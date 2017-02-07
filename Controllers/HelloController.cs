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
            return View("Index");
        }



        [HttpPost]
        [Route("method")]
        public IActionResult Method(string TextField, int NumberField)
        {
            System.Console.WriteLine("FORM SUBMITTING!");
            System.Console.WriteLine(TextField);
            return View("Index");
        }
    }
}