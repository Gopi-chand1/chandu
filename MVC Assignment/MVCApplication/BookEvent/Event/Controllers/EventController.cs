
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCApplication.Data;
using MVCApplication.Helpers;
using MVCApplication.Models;
using MVCApplication.Repository;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.BookEvent.Event.Controllers
{
    [Authorize]

    public class EventController : Controller
    {

        /**/
        string UserName;
        public string GetUserName
        {
            get
            {
                if (User.Identity.IsAuthenticated)
                {
                    UserName = User.Identity.Name;
                }
                return UserName;
            }

        }

        /**/

        /* public ActionResult AllEvents()
         {
             AllEventsBL allEvents = new AllEventsBL();
             IEnumerable<Event> events = allEvents.GetEvents;

             return View(new EventToEventModelHelper().GetEventModels(events));

         }*/

        private readonly IEventRepository _eventRepository = null;

        public EventController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;

        }

        public async Task<ViewResult> Index()
        {
            var data = await _eventRepository.GetAllEvents();
            return View(data);

        }


        public ViewResult CreateEvent(bool isSuccess = false, int eventId = 0)
        {
            var model = new EventModel();
            /*model.Title = "My Title";*/
            ViewBag.IsSuccess = isSuccess;
            ViewBag.EventId = eventId;
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> CreateEvent(EventModel eventModel)
        {
            if (ModelState.IsValid)
            {
                eventModel.UserId = User.Identity.Name;
                /* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! */
                int id = await _eventRepository.CreateEvent(eventModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(CreateEvent), new { isSuccess = true, bookId = id });
                }
            }

            return View();
        }


        /*    [Authorize(Roles = "Admin")]*/

        public async Task<ViewResult> MyEvents()
        {
            List<EventModel> data;
            if (User.FindFirst("UserFullName").Value == "Admin")
            {
                data = await _eventRepository.GetAllEvents();
            }
            else
            {
                data = await _eventRepository.GetUserEvents(User.Identity.Name);
            }

            return View(data);
        }

        [AllowAnonymous]
        public async Task<ViewResult> GetEvent(int id)
        {
            var data = await _eventRepository.GetEventById(id);

            return View(data);
        }


        public async Task<IActionResult> EditEvent(int id, string returnUrl)
        {
            var data = await _eventRepository.GetEventById(id);
            if (data.Date < DateTime.Now)
            {
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return LocalRedirect(returnUrl); // after login return to same url
                }
                return RedirectToAction("Index", "Event");
            }

            return View(data);
        }



        [HttpPost]
        /*    [ValidateAntiForgeryToken]*/
        public async Task<IActionResult> EditEvent(int id, EventModel model)
        {
            /* if (id != model.EventId)
             {
                 return NotFound();
             }*/

            if (ModelState.IsValid)
            {
                model.UserId = User.Identity.Name;
                model.EventId = id;
                int eventId = await _eventRepository.EditEvent(model);

                return RedirectToAction(nameof(MyEvents));
            }
            return View(model);
        }

        [Authorize]
        public IActionResult DeleteEvent(int eventId)
        {
            _eventRepository.DeleteEvent(eventId);
            return RedirectToAction("MyEvents", "Event");
        }



        public async Task<ViewResult> EventLinks()
        {

            var data = await _eventRepository.GetEventLinks();

            return View(data);
        }




        public async Task<ViewResult> GetPublicEvent()
        {
            var data = await _eventRepository.PublicEvents();
            return View(data);
        }

        public async Task<ViewResult> EventsInvitedTo()
        {
            var data = await _eventRepository.GetAllEvents();

            return View(data);

        }



        public async Task<IActionResult> Comments(int id)
        {
            IEnumerable<CommentModel> data;

            data = await _eventRepository.GetComments(id);
            ViewData["Comments"] = data;
            /*return RedirectToAction("GetEvent", id);
*/
            return View(data);

        }


        [HttpPost]
        public async Task<IActionResult> AddComments(CommentModel commentModel)
        {
            commentModel.Date = DateTime.Now;

            int id = await _eventRepository.AddComment(commentModel);
            return RedirectToAction("GetEvent", new { id });


        }

    }
}
