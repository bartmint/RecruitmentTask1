using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecruitmentTaskNr1.BL;
using RecruitmentTaskNr1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentTaskNr1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringComparator _stringComparator;

        public HomeController(IStringComparator stringComparator)
        {
            _stringComparator = stringComparator;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EmptyComparison()
        {
            return PartialView("_ComparisonPlace", new StringComparationVM { }); ;
        }
        public IActionResult CompareStrings(string str1, string str2)
        {
            if (str1 == null || str2 == null)
            {
                return PartialView("_ComparisonPlace", new StringComparationVM {});
            }

            var results = _stringComparator.CompareStrings(str1, str2);
            return PartialView("_ComparisonPlace", results);
        }
    }
}
