using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Textoni.Models;
using Textoni.Models.Entity;

namespace Textoni.Controllers
{
    public class IlanlarController : Controller
    {

        public ViewResult ilan()
        {
            TextoniContext ctx = new TextoniContext();
            List<Advert> adverts = ctx.Ad.ToList();
            return View(adverts);
        }

        public IActionResult ilanGozat()
        {
            TextoniContext ctx = new TextoniContext();
            List<Advert> adverts = ctx.Ad.ToList();
            return View(adverts);
        }

        public IActionResult ilanOlustur()
        {
            return View();
        }

    }
}
