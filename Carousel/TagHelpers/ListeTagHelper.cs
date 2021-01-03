using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carousel.TagHelpers
{
    [HtmlTargetElement("ozelliste")]
    public class ListeTagHelper : TagHelper
    {
        public string[] items { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent("<ul class='list-group'>");
            StringBuilder sb = new StringBuilder();
            foreach (string item in items) sb.Append("<li class='list-group-item'>" + item + "</li>");
            sb.Append("</ul>");
           output.PostContent.SetHtmlContent(sb.ToString());
        }
    }
}
