using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Textoni.Models.Entity
{
    public class Advert
    {
        public int ID { get; set; }
        public string image { get; set; }
        public string categoryAndServiceType { get; set; }
        public string title { get; set; }
        public int wordCount { get; set; }
        public string advertType { get; set; }
        public decimal earning { get; set; }
        public string description { get; set; }
        public string language { get; set; }
        public string advertDeatils { get; set; }
        public string keyWord { get; set; }
        public string subHeaders { get; set; }
        public string brandDescription { get; set; }
        public string brandImage { get; set; }
    }
}
