using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Selamlama = hour > 12 ? "İyi günler" : "Günaydın"; // ViewBag ile view'e veri gönderme 
            ViewBag.userName = "EMRE";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
				Location = "İstanbul",
				Date = new DateTime(2024, 09, 20),
				numberOfPeople = "100"
            };

            return View(meetingInfo);
        }
    }
}
