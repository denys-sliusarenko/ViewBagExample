﻿using Microsoft.AspNetCore.Mvc;
using ViewBagExample.Models;

namespace ViewBagExample.Controllers
{
    public class RegexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ValideRegexEmail([FromForm] RegexEmail model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            return Content("Success!");
        }
    }


}