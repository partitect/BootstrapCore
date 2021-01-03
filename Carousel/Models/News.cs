using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carousel.Models
{
    public class News
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Detail { get; set; }
        public DateTime RecDate { get; set; }
    }
}
