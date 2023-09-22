using BookReadingEvent.ProductDomain.AppServices;
using BookReadingEvent.ProductDomain.AppServices.DTOs;
using BookReadingEvent.ProductDomain.AppServices.Facade;
using BookReadingEvent.ProductDomain.AppServices.Factory;
using BookReadingEvent.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookReadingEvent.Web.Controllers
{
    public class CreateEventController : Controller
    {
        private readonly FacadeFactory _facadeFactory;
        // private readonly ICreateEventService _userService;
        // userservice is called dependency is injected 
        public CreateEventController(FacadeFactory facadeFactory)
        {
            _facadeFactory = facadeFactory;
        }   
        public IActionResult Index()
        {
            ViewBag.emailId = HttpContext.Session.GetString("EmailId");
            return View();
        }

        [HttpPost]
        public IActionResult Index(Event EventDetails)
        {
            CreateEventDTO newEvent = new CreateEventDTO();
            newEvent.Date = EventDetails.Date;
            newEvent.Description = EventDetails.Description;
            newEvent.Duration = EventDetails.Duration;
            newEvent.InviteByEmail = EventDetails.InviteByEmail;
            newEvent.Location = EventDetails.Location;
            newEvent.OtherDetails = EventDetails.OtherDetails;
            newEvent.StartTime = EventDetails.StartTime;
            newEvent.Title = EventDetails.Title;
            newEvent.Type = EventDetails.Type;
            newEvent.Creator = HttpContext.Session.GetString("EmailId");
            EventFacade _eventFacade = (EventFacade)_facadeFactory.GetFacade("IEventFacade");
            _eventFacade.AddEvent(newEvent);
            if (EventDetails.InviteByEmail != null)
            {
                string EmailID = HttpContext.Session.GetString("EmailId");
                _eventFacade.TagInvitedEventToUser(EventDetails.InviteByEmail, EmailID);
            }           
            return RedirectToAction("Index","MyEvent");
        }
    }
}
