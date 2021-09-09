using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Textoni.Models.Entity
{
    public class CreateAd
    {
        public string? language { get; set; }
        public string? sourceLanguage { get; set; }
        public string? categories { get; set; }
        public string? advertTypes { get; set; }
        public int? maxWord { get; set; }
        public int? minWord { get; set; }
        public int ID { get; set; }

        public virtual Advert Advert { get; set; }
    }
}
