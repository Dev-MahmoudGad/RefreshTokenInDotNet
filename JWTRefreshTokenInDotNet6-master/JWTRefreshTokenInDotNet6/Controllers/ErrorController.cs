﻿using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace JWTRefreshTokenInDotNet6.Controllers
{
    public class ErrorController : Controller
    {
        [HttpGet]
        public IActionResult GetError()
        {
            var ex = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            return Problem(title: ex.Error.Message);
            return View();
        }
    }
}
