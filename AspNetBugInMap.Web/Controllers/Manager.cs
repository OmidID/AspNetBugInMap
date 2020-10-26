using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetBugInMap.Web.Models;

namespace AspNetBugInMap.Web.Controllers
{
    [Route("manager")]
    public class ManagerController : Controller
    {
        [Route("{*path}")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
