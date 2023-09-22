using AutoMapper;
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
    
    public class EventController : Controller
    {
       // private readonly ICreateEventService _eventServices;
        private readonly IMapper _mapper;
        private readonly FacadeFactory _facadeFactory;

        public EventController(FacadeFactory facadeFactory, IMapper mapper)
        { 
            _facadeFactory = facadeFactory;
            _mapper = mapper;
           // _eventServices = eventser;
        }
        public IActionResult Index()
        {
            ViewBag.emailId = HttpContext.Session.GetString("EmailId");
            ViewBag.UpcomingEvents = GetUpComingEvents();
            ViewBag.PastEvents = GetPastEvents();
            
            var data = GetAllEvents();
            return View(data);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }
        public List<Event> GetAllEvents()
        {
            List<Event> result = new List<Event>();
            EventFacade _eventFacade = (EventFacade)_facadeFactory.GetFacade("IEventFacade");
            List<CreateEventDTO> store = _eventFacade.GetAllPublicEvent();

            foreach (var x in store)
            {
                result.Add(_mapper.Map<CreateEventDTO, Event>(x));
            }
            return result;
        }
        public List<Event> GetUpComingEvents()
        {
            List<Event> result = new List<Event>();
            EventFacade _eventFacade = (EventFacade)_facadeFactory.GetFacade("IEventFacade");
            List<CreateEventDTO> store = _eventFacade.GetUpcomingEvents();

            foreach (var x in store)
            {
                result.Add(_mapper.Map<CreateEventDTO, Event>(x));
            }
            SortByDate sortEventByDate = new SortByDate();
            result.Sort(sortEventByDate);
            result.Reverse();
            return result;
            
        }
        public List<Event> GetPastEvents()
        {
            List<Event> result = new List<Event>();
            EventFacade _eventFacade = (EventFacade)_facadeFactory.GetFacade("IEventFacade");
            List<CreateEventDTO> store = _eventFacade.GetPastEvents();
            foreach (var x in store)
            {
                result.Add(_mapper.Map<CreateEventDTO, Event>(x));
            }
            SortByDate sortEventByDate = new SortByDate();
            result.Sort(sortEventByDate);
            result.Reverse();
            return result;
        }
      
    }
}
