using Carousel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carousel.ViewModels
{
    public class HomeVM
    {
        public List<Slide> Slides { get; set; }
        public List<Product> Products { get; set; }
        public List<News> News { get; set; }
    }
}
