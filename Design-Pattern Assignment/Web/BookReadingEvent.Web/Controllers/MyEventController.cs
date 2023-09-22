using BookReadingEvent.ProductDomain.AppServices;
using BookReadingEvent.ProductDomain.AppServices.DTOs;
using BookReadingEvent.ProductDomain.AppServices.Facade;
using BookReadingEvent.ProductDomain.AppServices.Factory;
using BookReadingEvent.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookReadingEvent.Web.Controllers
{
    public class MyEventController : Controller
    {
        private readonly FacadeFactory _facadeFactory;
        // private readonly ICreateEventService _eventServices;
        public MyEventController(FacadeFactory facadeFactory)
        {
            _facadeFactory = facadeFactory;
            // _eventServices = eventser;
        }
        public IActionResult Index()
        {
            ViewBag.emailId = HttpContext.Session.GetString("EmailId");
            ViewBag.MyEvents = MyEvents();
            string email = HttpContext.Session.GetString("EmailId");
            if (email != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public List<Event> MyEvents()
        {
            List<Event> result = new List<Event>();
            var email = HttpContext.Session.GetString("EmailId");
            EventFacade _eventFacade = (EventFacade)_facadeFactory.GetFacade("IEventFacade");
            List<CreateEventDTO> store = _eventFacade.MyEvents(email);
            foreach (var x in store)
            {
                Event showEvent = new Event();
                showEvent.Date = x.Date;
                showEvent.Description = x.Description;
                showEvent.Duration = x.Duration;
                showEvent.InviteByEmail = x.InviteByEmail;
                showEvent.Location = x.Location;
                showEvent.OtherDetails = x.OtherDetails;
                showEvent.StartTime = x.StartTime;
                showEvent.Title = x.Title;
                showEvent.Type = x.Type;
                showEvent.EventId = x.EventId;
                result.Add(showEvent);
            }
            return result;
        }
    }
}
