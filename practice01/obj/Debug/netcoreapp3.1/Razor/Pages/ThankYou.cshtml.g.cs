#pragma checksum "C:\Users\User\Desktop\exam practice\practice01\practice01\Pages\ThankYou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba807d68a9f1f8ae4e090f9dcace6ac4e643ba65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(practice01.Pages.Pages_ThankYou), @"mvc.1.0.razor-page", @"/Pages/ThankYou.cshtml")]
namespace practice01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Desktop\exam practice\practice01\practice01\Pages\_ViewImports.cshtml"
using practice01;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba807d68a9f1f8ae4e090f9dcace6ac4e643ba65", @"/Pages/ThankYou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e4b2d6d3e750a3c836ebdb332a8cff710c50f83", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ThankYou : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\User\Desktop\exam practice\practice01\practice01\Pages\ThankYou.cshtml"
  
    var imagepath = "./Images/" + (Model.Imagename + ".jpg");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>Thank you for Ordering! Your Order Details are...!</h1>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 227, "\"", 243, 1);
#nullable restore
#line 12 "C:\Users\User\Desktop\exam practice\practice01\practice01\Pages\ThankYou.cshtml"
WriteAttributeValue("", 233, imagepath, 233, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-25\" />\r\n    <h4>Customer Name is ");
#nullable restore
#line 13 "C:\Users\User\Desktop\exam practice\practice01\practice01\Pages\ThankYou.cshtml"
                    Write(Model.BreadName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>Bread Size is ");
#nullable restore
#line 14 "C:\Users\User\Desktop\exam practice\practice01\practice01\Pages\ThankYou.cshtml"
                 Write(Model.BreadSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<practice01.Pages.ThankYouModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<practice01.Pages.ThankYouModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<practice01.Pages.ThankYouModel>)PageContext?.ViewData;
        public practice01.Pages.ThankYouModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
