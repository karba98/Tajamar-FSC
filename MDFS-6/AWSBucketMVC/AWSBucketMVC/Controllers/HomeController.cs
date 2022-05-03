using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWSBucketMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace AWSBucketMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
