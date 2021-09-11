using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Textoni.Models.Entity;

namespace Textoni.Models.ViewModel
{
    public class GozatModel
    {
        public List<Categorie> AdCategorie { get; set; }
        public List<Language> AdLanguage { get; set; }
        public List<Adverts> AdvertTable { get; set; }
        public List<SourceLanguage> AdSourceLanguage { get; set; }
    }
}
