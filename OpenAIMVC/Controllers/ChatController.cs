using Microsoft.AspNetCore.Mvc;

namespace OpenAIMVC.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View("ChatBody");
        }
    }
}
