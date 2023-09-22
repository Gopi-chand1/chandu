using AutoMapper;
using BookReadingEvent.ProductDomain.AppServices;
using BookReadingEvent.ProductDomain.AppServices.DTOs;
using BookReadingEvent.ProductDomain.AppServices.Facade;
using BookReadingEvent.ProductDomain.AppServices.Factory;
using BookReadingEvent.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace BookReadingEvent.Web.Controllers
{
    public class SortByDate : IComparer<Event>
    {
        public int Compare(Event x, Event y)
        {
            return (x.Date.ToShortDateString().ToString()).CompareTo((y.Date.ToShortDateString().ToString()));
        }
    }
    public class HomeController : Controller
    {
        // private readonly ICreateEventService _eventServices;
        private readonly FacadeFactory _facadeFactory;
        private readonly IMapper _mapper;
        public HomeController(FacadeFactory facadeFactory, IMapper mapper)
        {
            _mapper = mapper;
            _facadeFactory = facadeFactory;
            //_eventServices = eventser;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("EmailId") !=null)
            {
                return RedirectToAction("Index","Event");
            }
            ViewBag.UpcomingEvents =GetUpComingEvents();
            ViewBag.PastEvents = GetPastEvents();
            var data = GetAllEvents();
            SignUpDTO obj = new SignUpDTO
            {
                EmailID = "myadmin@bookevents.com",
                FirstName = "Admin",
                LastName = "Admin",
                Password = "Admin@123"
            };
            EventFacade _eventFacade = (EventFacade)_facadeFactory.GetFacade("IEventFacade");
            _eventFacade.AddUser(obj);
            return View(data);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
                Event showEvent = new Event();
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
                Event showEvent = new Event();
                result.Add(_mapper.Map<CreateEventDTO, Event>(x));
            }
            SortByDate sortEventByDate = new SortByDate();
            result.Sort(sortEventByDate);
            result.Reverse();
            return result;
        }
    }
}
