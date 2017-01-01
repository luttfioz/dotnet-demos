using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class HomeController : Controller
    {
        readonly ICalculator calculatorService;
        public HomeController(ICalculator calc )
        {
            calculatorService = calc;
        }

        [HttpGet("/homee")]
        public string Index(){
            int result = calculatorService.add(5,6);

            return "Hello from Controller "+result.ToString();
        }

        public string Header(){
            return "Hello from Header Controller";
        }
    }
}