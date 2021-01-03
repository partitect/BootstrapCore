using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carousel.TagHelpers
{
    [HtmlTargetElement("img")]
    public class IMGTagHelper : TagHelper
    {
        public string tur { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            switch (tur)
            {
                case "yuvarlak":
                    output.Attributes.SetAttribute("style", "width:200px;height:200px;border-radius:100px;padding:10px;border:solid 1px #ccc");
                    break;
                case "kare":
                    output.Attributes.SetAttribute("style", "width:200px;height:200px;padding:10px;border:solid 1px #ccc");
                    break;
                case "hazirlaniyor":
                    output.Attributes.SetAttribute("style", "width:200px;height:200px;padding:10px;border:solid 1px #ccc");
                    output.Attributes.SetAttribute("src", "/images/hazirlaniyor.png");
                    break;
            }
           
        }
    }
}
