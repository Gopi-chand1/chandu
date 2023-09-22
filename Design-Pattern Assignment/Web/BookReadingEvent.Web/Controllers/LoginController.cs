using BookReadingEvent.ProductDomain.AppServices;
using BookReadingEvent.ProductDomain.AppServices.DTOs;
using BookReadingEvent.ProductDomain.AppServices.Facade;
using BookReadingEvent.ProductDomain.AppServices.Factory;
using BookReadingEvent.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookReadingEvent.Web.Controllers
{
    public class LoginController : Controller
    {
        //private readonly IUserLoginService _userLogin;
        private readonly FacadeFactory _facadeFactory;
        public LoginController(FacadeFactory facadeFactory)
        {
            // _userLogin = userService;
            _facadeFactory = facadeFactory;
        }
        public IActionResult Index(bool isSucess = false)
        {
            ViewBag.IsSucess = isSucess;
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserLogin userDetails)
        {         
            LoginDTO obj = new LoginDTO
            {
                EmailID = userDetails.EmailID,
                Password = userDetails.Password
            };
            if (userDetails.EmailID== "myadmin@bookevents.com" && userDetails.Password== "Admin@123")
            {
                HttpContext.Session.SetString("EmailId", userDetails.EmailID);
                return RedirectToAction("Index","Admin");
            }

            UserLoginFacade _userLoginFacade = (UserLoginFacade)_facadeFactory.GetFacade("");
            bool user = _userLoginFacade.LoginUser(obj);
            //bool user = _userLogin.AddUser(obj);
            if (user== true)
            {
                HttpContext.Session.SetString("EmailId",userDetails.EmailID);
                return RedirectToAction("Index","Event");
            }
            else
            {
                ViewBag.IsSucess = true;
                return View();
            }         
        }
    }
}
