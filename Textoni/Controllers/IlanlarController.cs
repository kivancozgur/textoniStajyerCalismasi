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
            List<Advert> adverts = ctx.Ad.Where(x => x.ID == id).ToList();
            return View(adverts);
        }

        public IActionResult ilanGozat()
        {
            TextoniContext ctx = new TextoniContext();
            List<Advert> adverts = ctx.Ad.ToList();
            return View(adverts);
        }

        public IActionResult ilanOlustur(Advert advert)
        {
            TextoniContext ctx = new TextoniContext();
            ilanOlusturVM vm = new ilanOlusturVM();
            vm.Ad = ctx.Ad.ToList();
            vm.CreateAdvert = ctx.CreateAdvert.ToList();

            //Advert ilanUpdate = ctx.Ad.SingleOrDefault(ad => ad.ID == advert.ID);

            //ilanUpdate.advertDeatils = advert.advertDeatils;
            //ilanUpdate.advertType = advert.advertType;
            //ilanUpdate.brandDescription = advert.brandDescription;
            //ilanUpdate.brandImage = advert.brandImage;
            //ilanUpdate.categoryAndServiceType = advert.categoryAndServiceType;
            //ilanUpdate.description = advert.description;
            //ilanUpdate.earning = advert.earning;
            //ilanUpdate.image = advert.image;
            //ilanUpdate.keyWord = advert.keyWord;
            //ilanUpdate.language = advert.language;
            //ilanUpdate.languageSource = advert.languageSource;
            //ilanUpdate.subHeaders = advert.subHeaders;
            //ilanUpdate.title = advert.title;
            //ilanUpdate.wordCount = advert.wordCount;

            return View(vm);
        }
        
    }
}
