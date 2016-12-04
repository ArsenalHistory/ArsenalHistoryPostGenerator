using System.Collections.Generic;
using System.Linq;
using ArsenalHistoryPostGenerator.Domain;
using ArsenalHistoryPostGenerator.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ArsenalHistoryPostGenerator.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenerateFile _generateFile;

        public HomeController(IGenerateFile generateFile)
        {
            _generateFile = generateFile;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Dictionary<string, string> parameters, string filename)
        {
            _generateFile.GenerateMarkdownFile(filename, parameters);


            return View();
        }
    }
}
