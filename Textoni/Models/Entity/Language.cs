using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Textoni.Models.Entity
{
    public class Language
    {
        public int ID { get; set; }
        public string? AdvertLanguage { get; set; }

        public virtual List<Adverts> AdvertTable { get; set; }
    }

    
}
