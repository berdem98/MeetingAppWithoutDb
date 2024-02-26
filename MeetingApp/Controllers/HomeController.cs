using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeetingApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			int saat = DateTime.Now.Hour;
			//int saat = 11;
			//var selamlama = saat > 12 ? "İyi günler" : "İyi Sabahlar";
			//ViewBag.userName = "Metehan";
			//ViewBag.Selamlama = saat > 12 ? "İyi günler" : "İyi Sabahlar";

			ViewData["Selamlama"] = saat > 12 ? "İyi günler" : "İyi Sabahlar";
			ViewData["userName"] = "Deniz";
			var meetingInfo = new MeetingInfo() {
				Id = 1,
				Konum = "Ankara, Atatürk Kültür Merkezi",
				Tarih = new DateTime(2024, 01, 26, 18, 0, 0),
				KatilimSayisi = Repository.Users.Where(info => info.KatilimDurumu == true).Count()
			};
			
			return View(meetingInfo);
		}
	}
}