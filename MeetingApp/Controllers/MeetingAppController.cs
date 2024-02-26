using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
	public class MeetingAppController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		
		public IActionResult List()
		{
			return View(Repository.Users);
		}
		public IActionResult Apply()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Apply(UserInfo model)
		{
			if (ModelState.IsValid)
			{
				Repository.CreateUser(model);
				ViewBag.UserCount = Repository.Users.Where(info => info.KatilimDurumu == true).Count();
				return View("Thanks", model);
			}
			else
			{
				return View(model);
			}
			
		}

		// MeetingApp/Detay/3
		public IActionResult Detay(int id)
		{			
			return View(Repository.GetById(id));
		}
		
	}
}
