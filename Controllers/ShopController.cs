using System;
using Microsoft.AspNetCore.Mvc;

namespace AspTask.Controllers
{
	public class ShopController:Controller
	{
		public IActionResult Index()
        {
			return View();
        }
		
	}
}

