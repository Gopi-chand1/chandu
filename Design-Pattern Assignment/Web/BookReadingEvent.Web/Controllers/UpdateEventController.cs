using AutoMapper;
using BookReadingEvent.ProductDomain.AppServices;
using BookReadingEvent.ProductDomain.AppServices.DTOs;
using BookReadingEvent.ProductDomain.AppServices.Facade;
using BookReadingEvent.ProductDomain.AppServices.Factory;
using BookReadingEvent.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookReadingEvent.Web.Controllers
{
    public class UpdateEventController : Controller
    {
        //private readonly ICreateEventService _userEventService;
        private readonly FacadeFactory _facadeFactory;
        private readonly IMapper _mapper;
        // userservice is called dependency is injected 
        public UpdateEventController(FacadeFactory facadeFactory, IMapper mapper)
        {
            _mapper = mapper;
            _facadeFactory = facadeFactory;
            //_userEventService = usereventService;
        }
        public IActionResult Index(int id)
        {
            ViewBag.emailId = HttpContext.Session.GetString("EmailId");
            HttpContext.Session.SetString("EventId", id.ToString());
            return View();
        }
        [HttpPost]
        public IActionResult Index(Event EventDetails)
        {
            CreateEventDTO newEvent = new CreateEventDTO();
            newEvent.Date = EventDetails.Date; 
            newEvent.Description = EventDetails.Description;
            newEvent.Duration = EventDetails.Duration;
            newEvent.Location = EventDetails.Location; 
            newEvent.StartTime = EventDetails.StartTime;
            newEvent.Title = EventDetails.Title; 
            newEvent.Type = EventDetails.Type;
            newEvent.EventId = int.Parse(HttpContext.Session.GetString("EventId"));

            EventFacade _eventFacade = (EventFacade)_facadeFactory.GetFacade("IEventFacade");
            _eventFacade.UpdateEvent(newEvent);
           // _userEventService.UpdateEvent(newEvent);
            return RedirectToAction("Index","MyEvent");
        }
        public JsonResult GetEventById()
        {
            int eventid = int.Parse(HttpContext.Session.GetString("EventId"));
            EventFacade _eventFacade = (EventFacade)_facadeFactory.GetFacade("IEventFacade");
            CreateEventDTO eventDetailsStore  =_eventFacade.GetEventById(eventid);
            Event eventdetails=_mapper.Map<CreateEventDTO, Event>(eventDetailsStore);
            var json = JsonConvert.SerializeObject(eventdetails);           
            return Json(json);
        }
    }
}
