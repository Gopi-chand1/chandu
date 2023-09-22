using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCApplication.Data;
using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Repository
{

    public class EventRepository : IEventRepository
    {
        private readonly EventStoreContext _context = null;
        public EventRepository(EventStoreContext context)
        {
            _context = context;
        }

        public async Task<int> CreateEvent(EventModel model)
        {
            int count = model.InviteByEmail.Split(',').Length;
            model.Count = count;
            var newEvent = new Event()
            {   UserId =model.UserId,
                Title = model.Title,
                Date = model.Date,
                Description = model.Description,

                Duration = model.Duration,
                Location = model.Location,

                OtherDetails = model.OtherDetails,
                StartTime = model.StartTime,
                Type = model.Type,
                InviteByEmail = model.InviteByEmail,
                Count = model.Count,

            };

            await _context.Events.AddAsync(newEvent);
            await _context.SaveChangesAsync();

            return newEvent.EventId;
        }

        public async Task<List<EventModel>> GetAllEvents()
        {
          
            return await _context.Events
                  .Select(events => new EventModel()
                  {
                      EventId = events.EventId,
                      Title = events.Title,
                      Date = events.Date,
                      Description = events.Description,

                      Duration = events.Duration,
                      Location = events.Location,

                      OtherDetails = events.OtherDetails,
                      StartTime = events.StartTime,
                      Type = events.Type,
                      InviteByEmail = events.InviteByEmail,
                      Count=events.Count

                  }).OrderByDescending(e=> e.Date) .ToListAsync();
        }

        public async Task<EventModel> GetEventById(int id)
        {
            return await _context.Events.Where(x => x.EventId == id)
                 .Select(events => new EventModel()
                 {   EventId = events.EventId,
                     Title = events.Title,
                     Date = events.Date,
                     Description = events.Description,

                     Duration = events.Duration,
                     Location = events.Location,

                     OtherDetails = events.OtherDetails,
                     StartTime = events.StartTime,
                     Type = events.Type,
                     InviteByEmail = events.InviteByEmail,
                     Count=events.Count
                 }).FirstOrDefaultAsync();
        }




        public async Task<int> EditEvent(EventModel model)
        {
            var newEvent = new Event()
            {   EventId=model.EventId,
                UserId=model.UserId,
                Title = model.Title,
                Date = model.Date,
                Description = model.Description,

                Duration = model.Duration,
                Location = model.Location,

                OtherDetails = model.OtherDetails,
                StartTime = model.StartTime,
                Type = model.Type,
                InviteByEmail = model.InviteByEmail
            };
            _context.Events.Update(newEvent);
            await _context.SaveChangesAsync();

            return model.EventId;

        }

        public void DeleteEvent(int id)
        {
            var result = (from e in _context.Events
                          where e.EventId == id
                          select e).ToList().First();

            _context.Events.Remove(result);
            _context.SaveChanges();

        }


        public async Task<List<EventModel>> GetUserEvents(string userId)
        {
            return await _context.Events
                .Where(x => x.UserId == userId)
                  .Select(events => new EventModel()
                   {
                       EventId = events.EventId,
                       Title = events.Title,
                       Date = events.Date,
                       Description = events.Description,

                       Duration = events.Duration,
                       Location = events.Location,

                       OtherDetails = events.OtherDetails,
                       StartTime = events.StartTime,
                       Type = events.Type,
                       InviteByEmail = events.InviteByEmail

                   }).OrderByDescending(e => e.Date).ToListAsync();
        }

        public async Task<List<EventModel>> GetEventLinks()
        {
            return await _context.Events
                  .Select(events => new EventModel()
                  {
                      EventId=events.EventId,
                      Title = events.Title
                  }).ToListAsync();
        }

        public async Task<List<EventModel>> PublicEvents()
        {
            return await _context.Events.Where(e => e.Type == "Public")
                .Select(events => new EventModel()
                {

                    EventId = events.EventId,
                    Title = events.Title,
                    Date = events.Date,
                    Description = events.Description,

                    Duration = events.Duration,
                    Location = events.Location,

                    OtherDetails = events.OtherDetails,
                    StartTime = events.StartTime,
                    Type = events.Type,
                    InviteByEmail = events.InviteByEmail
                }).ToListAsync();
        }


        public async Task<int> AddComment(CommentModel model)
        {
           
            var newEvent = new Comment()
            {   
                EventId=model.EventId,
                CommentAdded = model.CommentAdded,
                Date = model.Date,
            };

            await _context.Comments.AddAsync(newEvent);
            await _context.SaveChangesAsync();

            return newEvent.EventId;
        }

        public async Task<List<CommentModel>> GetComments(int eventId)
        {

            return await _context.Comments.Where(e=>e.EventId==eventId)
                  .Select(events => new CommentModel()
                  {
                      EventId = events.EventId,
                      Date = events.Date,
                      CommentAdded = events.CommentAdded


                  }).OrderByDescending(e => e.Date).ToListAsync();
        }


    }

}

