using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carousel.TagHelpers
{
    public class ButtonTagHelper:TagHelper
    {
        public string tip { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", "btn btn-" + tip);
            output.Attributes.SetAttribute("style",tip=="danger"?"color:yellow":"color:white");
            output.Content.SetContent(tip=="danger"?"Sil":"Düzenle");
        }
    }
}
