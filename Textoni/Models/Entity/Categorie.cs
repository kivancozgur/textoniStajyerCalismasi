using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Textoni.Models.Entity
{
    public class Categorie
    {

        public int ID { get; set; }
        public string? AdvertCategorie { get; set; }

        public virtual List<Adverts> AdvertTable { get; set; }
    }

    
}
