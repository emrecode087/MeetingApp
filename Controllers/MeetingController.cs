﻿using Microsoft.AspNetCore.Mvc;
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
            //Conrtolled
            //Console.WriteLine(Name,Phone,Email,WillAttend);

            //Database kaydı yapılabilir.

            Repository.AddUser(model);

            ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();

			return View("Thanks",model);
		}

		[HttpGet]
        public IActionResult List()
        {
            var users = Repository.Users;
            return View(users);
        }
    }
}
