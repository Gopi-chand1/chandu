using MVCApplication.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCApplication.Repository
{
    public interface IEventRepository
    {
        Task<int> CreateEvent(EventModel model);
        
        Task<int> EditEvent(EventModel model);

        Task<List<EventModel>> GetAllEvents();

        Task<EventModel> GetEventById(int id);
        Task<List<EventModel>> GetEventLinks();
        Task<List<EventModel>> GetUserEvents(string userId);
        Task<List<EventModel>> PublicEvents();

        void DeleteEvent(int id);
        Task<int> AddComment(CommentModel model);
        Task<List<CommentModel>> GetComments(int eventId);
    }
}