using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

		[HttpPost]
		public IActionResult Apply(UserInfo model)
		{
            if (ModelState.IsValid)
            {
                Repository.AddUser(model);
                ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
                return View("Thanks", model);
            }
            else
			{
				return View(model);
			}
		}

		[HttpGet]
        public IActionResult List()
        {
            var users = Repository.Users;
            return View(users);
        }

        // /Meeting/Details/1
        [HttpGet]
        public IActionResult Details(int id)
		{
			var user = Repository.GetById(id);
			return View(user);
		}
    }
}
