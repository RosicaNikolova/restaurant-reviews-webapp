#pragma checksum "C:\Users\Rositsa\source\repos\restaurant_reviews_rositsa_wad\RestaurantReviews\RestaurantReviews\Pages\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a37321c6da51999df852cc9d42c6e6012141388"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RestaurantReviews.Pages.Pages_Home), @"mvc.1.0.razor-page", @"/Pages/Home.cshtml")]
namespace RestaurantReviews.Pages
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
#line 1 "C:\Users\Rositsa\source\repos\restaurant_reviews_rositsa_wad\RestaurantReviews\RestaurantReviews\Pages\_ViewImports.cshtml"
using RestaurantReviews;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a37321c6da51999df852cc9d42c6e6012141388", @"/Pages/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5207267de3536f8d79dd590ebfe99ae95ab0202d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Home : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Rositsa\source\repos\restaurant_reviews_rositsa_wad\RestaurantReviews\RestaurantReviews\Pages\Home.cshtml"
  
    ViewData["Title"] = "Home";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"homepage_content\">\r\n    <ul class=\"restaurant_list\">\r\n        <li>\r\n            <div class=\"restaurant_card\">\r\n                <div class=\"card_picture_div\">\r\n                    <img src=\"pic/istockphoto-1248298343-612x612.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 358, "\"", 364, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>

                <div class=""card_content"">
                    <h2 class=""card_r_name"">Johny's pizzеria</h2>
                    <div class=""card_ratings"">
                        <div>
                            Score: 9.6
                        </div>
                        <div>
                            56 reviews
                        </div>
                        <div>
                            Price range: 3/5
                        </div>
                        <div>
                            Service: 4/5
                        </div>

                    </div>
                    <p>
                        Characteristics:  romantic, cozy, beautiful view
                    </p>
                    <p>
                        Cuisine:  Italian, grill, pizza
                    </p>

                </div>
                <div class=""card_buttons"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 1328, "\"", 1335, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"button_add_list\">Add to list</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1400, "\"", 1407, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""button_view"">View</a>
                </div>

            </div>
        </li>
        <li>
            <div class=""restaurant_card"">
                <div class=""card_picture_div"">
                    <img src=""pic/069ff33e-5aa1-11e9-bbcc-84176f6dd1e7_image_hires_105559.webp""");
            BeginWriteAttribute("alt", " alt=\"", 1700, "\"", 1706, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>


                <div class=""card_content"">
                    <h2 class=""card_r_name"">Name</h2>
                    <div class=""card_ratings"">
                        <div>

                        </div>
                        <div>

                        </div>
                    </div>
                    <p>

                    </p>
                    <p>

                    </p>

                </div>
                <div class=""card_buttons"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 2241, "\"", 2248, 0);
            EndWriteAttribute();
            WriteLiteral(">Add to list</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2289, "\"", 2296, 0);
            EndWriteAttribute();
            WriteLiteral(">View</a>\r\n                </div>\r\n\r\n            </div>\r\n        </li>\r\n    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantReviews.Pages.HomeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantReviews.Pages.HomeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantReviews.Pages.HomeModel>)PageContext?.ViewData;
        public RestaurantReviews.Pages.HomeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
