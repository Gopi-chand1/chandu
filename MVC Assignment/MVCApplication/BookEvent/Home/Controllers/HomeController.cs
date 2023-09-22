
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCApplication.Data;
using MVCApplication.Models;
using MVCApplication.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.BookEvent.Home.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEventRepository _eventRepository = null;

        public HomeController(ILogger<HomeController> logger, IEventRepository eventRepository)
        {
            _logger = logger;
            _eventRepository = eventRepository;
        }

        public async Task<ViewResult> Index()
        {
            var data = await _eventRepository.GetAllEvents();
            return View(data);
        }

        [Route("/customer-support")]
        public IActionResult Help()
        {
            return Redirect("https://servicedesk.nagarro.com");
        }
        public IActionResult Login(string UserName, string Password)
        {
            if (UserName.ToLower() == "admin" & Password == "admin@123")
            {
                return View("AdminDashboard");
            }
            else if (UserName.ToLower() == "gopi" & Password == "rangisetti")
            {
                return View("gopiDashboard");
            }
            else
            {
                return Content("No Authentication");
            }
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
