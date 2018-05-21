using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CRM_dentalClinic.Controllers
{
    public class PacientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}