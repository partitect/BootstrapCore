﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolMusic.ViewComponents
{
	public class SubscriptionSectionViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
