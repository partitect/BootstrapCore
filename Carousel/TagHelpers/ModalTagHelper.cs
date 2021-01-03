using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carousel.TagHelpers
{
    public class ModalTagHelper:TagHelper
    {
        public string modalID { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetHtmlContent(
     $@"<div class=""modal fade"" id={modalID} tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">{title}</h5>
        <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        {content}
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary"">Save changes</button>
      </div>
    </div>
  </div>
</div>");
        }
    }
}
