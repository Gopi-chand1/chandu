using BookReadingEvent.Core.AppServices;
using BookReadingEvent.ProductDomain.AppServices.DTOs;

namespace BookReadingEvent.ProductDomain.AppServices
{
    public interface IUserLoginService : IAppService
    {
        bool AddUser(LoginDTO item);
    }
}
