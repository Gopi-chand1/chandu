﻿using BookReadingEvent.ProductDomain.AppServices.DTOs;
using BookReadingEvent.ProductDomain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookReadingEvent.ProductDomain.AppServices
{
    public class CreateEventService : ICreateEventService
    {
        private readonly ICreateEventRepositry eventRepositry = null;
        public CreateEventService(ICreateEventRepositry eventrepo)
        {
            eventRepositry = eventrepo;
        }
        public bool AddEvent(CreateEventDTO item)
        {
            eventRepositry.AddEvent(item);
            return true;
        }
        public List<CreateEventDTO> GetAllPublicEvent()
        {
            return eventRepositry.UpcomingEvents();
        }
        public List<CreateEventDTO> GetUpcomingEvents()
        {
            List<CreateEventDTO> result = new List<CreateEventDTO>();
            List<CreateEventDTO> store = eventRepositry.UpcomingEvents();
            foreach (var x in store)
            {
                TimeSpan time;
                TimeSpan.TryParse(x.StartTime, out time);
                if (DateTime.Compare(DateTime.Now.Date, x.Date) < 0)
                    result.Add(x);
                else if ((DateTime.Compare(DateTime.Now.Date, x.Date) == 0) && (DateTime.Now.TimeOfDay.CompareTo(time) < 0))
                    result.Add(x);
            }
            return result;
        }
        public List<CreateEventDTO> GetPastEvents()
        {

            List<CreateEventDTO> result = new List<CreateEventDTO>();
            List<CreateEventDTO> store = eventRepositry.UpcomingEvents();
      
            foreach (var x in store)
            {
                TimeSpan time;
                TimeSpan.TryParse(x.StartTime, out time);
                var y = DateTime.Now.TimeOfDay;
                var z = x.StartTime;
                if (DateTime.Compare(DateTime.Now.Date, x.Date) > 0)
                    result.Add(x);
                else if ((DateTime.Compare(DateTime.Now.Date, x.Date) == 0) && (DateTime.Now.TimeOfDay.CompareTo(time) > 0))
                    result.Add(x);
            }
         
            return result;
        }
        public List<CreateEventDTO> MyEvents(string email)
        {   
        return eventRepositry.MyEvents(email);
        }

        public CreateEventDTO GetEventById(int id)
        {
            return eventRepositry.GetEventById(id);
        }
        public void TagInvitedEventToUser(string InvitedUsers, string authorEmailID)
        {
            List<string> AllMailID = FilterInviteByMailString(InvitedUsers, authorEmailID);
            eventRepositry.TagInvitedEventToUser(AllMailID);
            return;
        }
        public List<string> FilterInviteByMailString(string InvitedUsers, string authorEmailID)
        {
            List<string> AllMailID = new List<string>();
            string newMail = "";
            for (int i = 0; i < InvitedUsers.Length; i++)
            {
                if (InvitedUsers[i] != ' ' && InvitedUsers[i] != ',')
                {
                    newMail += InvitedUsers[i];
                }
                else if (InvitedUsers[i] == ',')
                {
                    if (newMail != authorEmailID)
                        AllMailID.Add(newMail);
                    newMail = "";
                }
            }
            if (newMail != "")
                if (newMail != authorEmailID)
                    AllMailID.Add(newMail);
            return AllMailID;
        }
        public void DeleteByEventId(int id)
        {
            eventRepositry.DeleteByEventId(id);
        }
        public void UpdateEvent(CreateEventDTO newEvent)
        {
            eventRepositry.UpdateEvent(newEvent);
        }
        public List<CreateEventDTO> GetAllEvent()
        {
            return eventRepositry.GetAllEvent();
        }
        public void AddComment(CommentDTO commentDetails)
        {
            eventRepositry.AddComment(commentDetails);
        }
        public List<CommentDTO> GetAllComments(int ID)
        {
            return eventRepositry.GetAllComments(ID);
        }

      /*  public List<CommentDTO> GetCreatorEventComment(string loginemailid)
        {
            return eventRepositry.GetCreatorEventComment(loginemailid);
        }*/
    }
}
