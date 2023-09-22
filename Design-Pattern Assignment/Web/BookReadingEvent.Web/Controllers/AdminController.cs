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
    public class AdminController : Controller
    {
        // private readonly ICreateEventService _userEventService;
        private readonly IMapper _mapper;
        private readonly FacadeFactory _facadefactory;

        /// <summary>
        /// userservice is called dependency is injected
        /// </summary> 
        public AdminController(FacadeFactory facadeFactory, IMapper mapper)
        {
            _facadefactory = facadeFactory;
            _mapper = mapper;
           // _userEventService = usereventService;
        }

        public IActionResult Index()
        {
            ViewBag.emailId = HttpContext.Session.GetString("EmailId");
            EventFacade _eventFacade = (EventFacade)_facadefactory.GetFacade("IEventFacade");

            List<CreateEventDTO> allEvent = _eventFacade.GetAllEvent();
            List<Event> allEventList= _mapper.Map<List<CreateEventDTO>, List<Event>>(allEvent);
            ViewBag.AdminEvent = allEventList;
            return View();
        }
    }
}
