using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using testweb.Models;

namespace testweb.Controllers
{
	public class HomeController : Controller
	{
		private VacansiesModel model { get; set; }

	
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger, VacansiesModel model)
		{
			_logger = logger;
			this.model = model;
		}

		public IActionResult Index()
		{
			return View(model);
		}

		public IActionResult Privacy()
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
