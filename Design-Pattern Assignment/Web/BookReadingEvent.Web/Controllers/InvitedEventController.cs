﻿using BookReadingEvent.ProductDomain.AppServices;
using BookReadingEvent.ProductDomain.AppServices.DTOs;
using BookReadingEvent.ProductDomain.AppServices.Facade;
using BookReadingEvent.ProductDomain.AppServices.Factory;
using BookReadingEvent.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookReadingEvent.Web.Controllers
{
    public class InvitedEventController : Controller
    {
        //private readonly ICreateEventService _userEventService;
        //private readonly IUserService        _userService;
        // userservice is called dependency is injected 

        private readonly FacadeFactory _facadeFactory;
        public InvitedEventController(FacadeFactory facadeFactory)
        {
            _facadeFactory = facadeFactory;
           // _userEventService = usereventService;
            // _userService = userservice;
        }
        public IActionResult Index()
        {
            string Email = HttpContext.Session.GetString("EmailId");
            @ViewBag.emailId = HttpContext.Session.GetString("EmailId");

            EventFacade _eventFacade = (EventFacade)_facadeFactory.GetFacade("IEventFacade");
            string AllEventId = _eventFacade.GetInvitedEventId(Email);

            List<int> allEventIds = FilterInvitedEventsString(AllEventId);
            List<CreateEventDTO> store = new List<CreateEventDTO>();
            foreach(int id in allEventIds)
            {
               store.Add(_eventFacade.GetEventById(id));
            }
            List<Event> result = new List<Event>();
            foreach(var item in store)
            {
                if(item == null)
                {
                    continue;
                }
                Event e = new Event();
                e.Creator = item.Creator;
                e.Date = item.Date;
                e.Description = item.Description;
                e.Duration = item.Duration;
                e.EventId = item.EventId;
                e.Location = item.Location;
                e.OtherDetails = item.OtherDetails;
                e.StartTime = item.StartTime;
                e.Title = item.Title;
                result.Add(e);
            }
            ViewBag.AllEvents = result;
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
        public List<int> FilterInvitedEventsString(string invitedEvents)
        {
            List<int> AllEventID = new List<int>();
            string newID = "";
            for (int i = 0; i < invitedEvents.Length; i++)
            {
                if (invitedEvents[i] != ',')
                {
                    newID += invitedEvents[i];
                }
                else if (invitedEvents[i] == ',')
                {
                    var temp = int.Parse(newID);
                    AllEventID.Add(temp);
                    newID = "";
                }
            }
            return AllEventID;
        }
    }
}
