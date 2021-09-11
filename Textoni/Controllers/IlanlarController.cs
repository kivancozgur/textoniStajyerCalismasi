using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Textoni.Models;
using Textoni.Models.Entity;
using Textoni.Models.ViewModel;

namespace Textoni.Controllers
{
    public class IlanlarController : Controller
    {

        public ViewResult ilan(int id)
        {
            TextoniContext ctx = new TextoniContext();
            GozatModel gm = new GozatModel();
            gm.AdCategorie = ctx.AdCategorie.ToList();
            gm.AdvertTable = ctx.AdvertTable.Where(x => x.ID == id).ToList();
            gm.AdLanguage = ctx.AdLanguage.ToList();
            gm.AdSourceLanguage = ctx.AdSourceLanguage.ToList();
            return View(gm);
        }

        public IActionResult ilanGozat()
        {
            TextoniContext ctx = new TextoniContext();
            GozatModel gm = new GozatModel();
            gm.AdCategorie = ctx.AdCategorie.ToList();
            gm.AdvertTable = ctx.AdvertTable.ToList();
            return View(gm);
        }

        [HttpGet]
        public IActionResult ilanOlustur()
        {
            TextoniContext ctx = new TextoniContext();
            newModel nm = new newModel();
            nm.AdLanguage = ctx.AdLanguage.ToList();
            nm.AdCategorie = ctx.AdCategorie.ToList();
            nm.AdSourceLanguage = ctx.AdSourceLanguage.ToList();
            nm.AdType = ctx.AdType.ToList();
            
            
            return View(nm);
        }

        [HttpPost]
        public IActionResult ilanOlustur(Adverts advert)
        {
            TextoniContext ctx = new TextoniContext();

            ctx.AdvertTable.Add(advert);
            ctx.SaveChanges();

            return RedirectToAction("ilanGozat","Ilanlar");
        }
       
    }
}
