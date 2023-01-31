using CV.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CV.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Introduction()
		{
			return View();
		}

		public IActionResult Hobbies()
		{
			return View();
		}

		public IActionResult Motivation()
		{
			return View();
		}

		public IActionResult Educations()
		{
			return View();
		}

		public IActionResult Skills()
		{
			return View();
		}

		public IActionResult Work()
		{
			return View();
		}

		public IActionResult Internship()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}