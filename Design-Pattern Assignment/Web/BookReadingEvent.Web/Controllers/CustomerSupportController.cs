using Microsoft.AspNetCore.Mvc;

namespace BookReadingEvent.Web.Controllers
{
    public class CustomerSupportController : Controller
    {
        public RedirectResult Index()
        {
           return new RedirectResult("https://servicedesk.nagarro.com/");          
        }
    }
}
