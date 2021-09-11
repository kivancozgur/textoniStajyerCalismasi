using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Textoni.Models.Entity
{
    public class Adverts
    {
        public int ID { get; set; }
        public string? image { get; set; }
        public string? title { get; set; }
        public int? wordCount { get; set; }
        public decimal? earning { get; set; }
        public int categoryID { get; set; }
        public string? keyWord { get; set; }
        public int languageID { get; set; }
        public string? description { get; set; }
        public int advertTypeID { get; set; }
        public string? subHeaders { get; set; }
        public string? brandImage { get; set; }
        public int languageSourceID { get; set; }
        public string? brandDescription { get; set; }
        public string? advertDeatils { get; set; }

        public virtual Language language { get; set; }
        public virtual SourceLanguage languageSource { get; set; }
        public virtual AdvertTypes advertType { get; set; }
        public virtual Categorie category { get; set; }
    }
}
