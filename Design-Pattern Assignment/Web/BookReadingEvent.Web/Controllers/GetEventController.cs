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
    public class GetEventController : Controller
    {
        //private readonly ICreateEventService _eventServices;
        private readonly FacadeFactory _facadeFactory;
        private readonly IMapper _mapper;
        public GetEventController(FacadeFactory facadeFactory, IMapper mapper)
        {
            _facadeFactory = facadeFactory;
            _mapper = mapper;
          //  _eventServices = eventser;
        }
        public IActionResult Index(int id , string name,string layout)
        {
            ViewBag.checkLayout = layout;
            ViewBag.emailId = HttpContext.Session.GetString("EmailId");
            ViewBag.check = name;
            EventFacade _eventFacade = (EventFacade)_facadeFactory.GetFacade("IEventFacade");
            if (_mapper.Map<List<CommentDTO>, List<Comment>>(_eventFacade.GetAllComments(id)).Count > 0)
            {
                ViewBag.count = 1;
            }
            ViewBag.Comments = _mapper.Map<List<CommentDTO>, List<Comment>>(_eventFacade.GetAllComments(id));
            CreateEventDTO newEvent = GetEventById(id);
            Event storeEvent = new Event();
            storeEvent.Date = newEvent.Date;
            storeEvent.Description = newEvent.Description;
            storeEvent.Title = newEvent.Title;
            storeEvent.StartTime = newEvent.StartTime;
            storeEvent.Location = newEvent.Location;
            storeEvent.Duration = newEvent.Duration;
            storeEvent.EventId = newEvent.EventId;
            storeEvent.OtherDetails = newEvent.OtherDetails;
            storeEvent.Creator = newEvent.Creator;
            return View(storeEvent);
        }
        public CreateEventDTO GetEventById(int id)
        {
            EventFacade _eventFacade = (EventFacade)_facadeFactory.GetFacade("IEventFacade");
            return  _eventFacade.GetEventById(id);
        }
        public IActionResult DeleteByEventId(int id)
        {
            EventFacade _eventFacade = (EventFacade)_facadeFactory.GetFacade("IEventFacade");
            _eventFacade.DeleteByEventId(id);
            return RedirectToAction("Index","MyEvent");
        }       
    } 
}
