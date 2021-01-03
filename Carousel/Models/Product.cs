using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carousel.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Detail { get; set; }
        public int DisplayIndex { get; set; }
    }
}
