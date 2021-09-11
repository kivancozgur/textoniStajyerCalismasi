using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Textoni.Models.Entity;

namespace Textoni.Models.ViewModel
{
    public class newModel
    {
        public List<Language> AdLanguage { get; set; }
        public List<AdvertTypes> AdType { get; set; }
        public List<SourceLanguage> AdSourceLanguage { get; set; }
        public List<Categorie> AdCategorie { get; set; }
        public List<Adverts> AdvertTable { get; set; }
    }
}
