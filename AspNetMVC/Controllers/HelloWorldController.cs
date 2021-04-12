using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace AspNetMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /helloWorld/

        public IActionResult Index()
        {
            return View();
        }


        // GET: /helloWorld/Welcome
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }


    }
}
