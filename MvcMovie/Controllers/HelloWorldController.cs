using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers  ///[Controller]/[ActionName]/[Parameters]
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        //Index is called by default (if nothing specified)
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        //https://localhost:{PORT}/HelloWorld/Welcome/3?name=Rick
        //pattern: "{controller=Home}/{action=Index}/{id?}");
        //The ? (question mark) in the above URL is a separator, and the query string follows.
        //The & character separates field-value pairs.
        /*public string Welcome(string name, int ID = 1) //defaults to 1 if no value
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }*/
        public IActionResult Welcome(string name, int numTimes = 1)
        {   //HelloWorld/Welcome?name=Rick&numtimes=4
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}