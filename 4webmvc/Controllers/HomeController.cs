using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class HomeController : Controller
    {

        [HttpGet("/homee")]
        public string Index(){
            return "Hello from Controller";
        }

        public string Header(){
            return "Hello from Header Controller";
        }
    }
}