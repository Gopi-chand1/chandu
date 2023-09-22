using BookReadingEvent.ProductDomain.AppServices;
using BookReadingEvent.ProductDomain.AppServices.DTOs;
using BookReadingEvent.ProductDomain.AppServices.Facade;
using BookReadingEvent.ProductDomain.AppServices.Factory;
using BookReadingEvent.Web.Models;
using Microsoft.AspNetCore.Mvc;
namespace BookReadingEvent.Web.Controllers
{
    public class SignupController : Controller
    {
        // private readonly IUserService _userService;
        // userservice is called dependency is injected 
        private readonly FacadeFactory _facadeFactory;
        public SignupController(FacadeFactory facadeFactory)
        {
            _facadeFactory = facadeFactory;
            // _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]  
        public IActionResult Index(SignUp userDetails)  
        {
            if (ModelState.IsValid)
            {
                SignUpDTO obj = new SignUpDTO
                {
                    EmailID = userDetails.EmailID,
                    FirstName = userDetails.FirstName,
                    LastName = userDetails.LastName,
                    Password = userDetails.Password
                };
                EventFacade _eventFacade = (EventFacade)_facadeFactory.GetFacade("IEventFacade");
                bool user = _eventFacade.AddUser(obj);
                if (user == true)
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }
    }
}
