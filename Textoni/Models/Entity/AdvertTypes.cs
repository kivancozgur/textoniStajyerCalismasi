using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Textoni.Models.Entity
{
    public class AdvertTypes
    {

        public int ID { get; set; }
        public string? AdvertType { get; set; }

        public virtual List<Adverts> AdvertTable { get; set; }
    }
}
