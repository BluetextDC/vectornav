#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/FullwidthFiftyFiftyCarousel/Index.cshtml")]
    public partial class _MVC_Views_FullwidthFiftyFiftyCarousel_Index_cshtml : System.Web.Mvc.WebViewPage<SitefinityWebApp.Mvc.Models.FullwidthFiftyFiftyCarouselModel>
    {
        public _MVC_Views_FullwidthFiftyFiftyCarousel_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
Write(Html.StyleSheet(Url.WidgetContent("~/ResourcePackages/BT/css/bootstrap.min.css"), "head"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 3 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
Write(Html.StyleSheet(Url.WidgetContent("~/ResourcePackages/BT/css/custom.min.css"), "head"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 6 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
  
    int cnt = 1;
    string className = "carousel-item active";
    int count = 0;
    string ActiveSlide = "active";

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

WriteLiteral(" class=\"wraper career_page\"");

WriteLiteral(">\r\n    <section");

WriteLiteral(" class=\"engineer_sec\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" id=\"employeeCarousel\"");

WriteLiteral(" class=\"carousel slide\"");

WriteLiteral(" data-ride=\"carousel\"");

WriteLiteral(">\r\n            <ol");

WriteLiteral(" class=\"carousel-indicators mb-0\"");

WriteLiteral(">\r\n");

            
            #line 16 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 16 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
                 foreach (var item in Model.GetList())
                {
                    if (count != 0)
                    {
                        ActiveSlide = "";
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" data-target=\"#employeeCarousel\"");

WriteLiteral(" data-slide-to=\"");

            
            #line 22 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
                                                                  Write(count);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("class", Tuple.Create(" class=\"", 912), Tuple.Create("\"", 932)
            
            #line 22 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
       , Tuple.Create(Tuple.Create("", 920), Tuple.Create<System.Object, System.Int32>(ActiveSlide
            
            #line default
            #line hidden
, 920), false)
);

WriteLiteral("></li>\r\n");

            
            #line 23 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
                    count++;

                }

            
            #line default
            #line hidden
WriteLiteral("\r\n            </ol>\r\n            <div");

WriteLiteral(" class=\"carousel-inner\"");

WriteLiteral(">\r\n\r\n");

            
            #line 30 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 30 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
                 foreach (var item in Model.GetList())
                {
                    if (cnt == 1)
                    {
                        className = "carousel-item active";
                        cnt++;
                    }
                    else
                    {
                        className = "carousel-item";
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1456), Tuple.Create("\"", 1474)
            
            #line 41 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1464), Tuple.Create<System.Object, System.Int32>(className
            
            #line default
            #line hidden
, 1464), false)
);

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"row no-gutters\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"box_img\"");

WriteLiteral(">\r\n                                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1679), Tuple.Create("\"", 1707)
            
            #line 45 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1685), Tuple.Create<System.Object, System.Int32>(item.SelectedImageSrc
            
            #line default
            #line hidden
, 1685), false)
);

WriteLiteral(" alt=\"image\"");

WriteLiteral(" class=\"img-fluid\"");

WriteLiteral(">\r\n                                </div>\r\n                            </div>\r\n  " +
"                          <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"box_content\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"content text-white\"");

WriteLiteral(">\r\n                                        <h2>");

            
            #line 51 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
                                       Write(Html.Raw(item.Description));

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                                    </div>\r\n                              " +
"  </div>\r\n                            </div>\r\n                        </div>\r\n  " +
"                  </div>\r\n");

            
            #line 57 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n            <a");

WriteLiteral(" class=\"carousel-control-prev\"");

WriteLiteral(" href=\"#employeeCarousel\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" data-slide=\"prev\"");

WriteLiteral(">\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2421), Tuple.Create("\"", 2470)
, Tuple.Create(Tuple.Create("", 2427), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/BT/images/left_arrow.svg")
, 2427), false)
);

WriteLiteral(" alt=\"icon\"");

WriteLiteral(" class=\"img-fluid\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">Previous</span>\r\n            </a>\r\n            <a");

WriteLiteral(" class=\"carousel-control-next\"");

WriteLiteral(" href=\"#employeeCarousel\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" data-slide=\"next\"");

WriteLiteral(">\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2700), Tuple.Create("\"", 2750)
, Tuple.Create(Tuple.Create("", 2706), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/BT/images/right_arrow.svg")
, 2706), false)
);

WriteLiteral(" alt=\"icon\"");

WriteLiteral(" class=\"img-fluid\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">Next</span>\r\n            </a>\r\n        </div>\r\n    </section>\r\n</main>\r\n");

WriteLiteral("\r\n");

            
            #line 72 "..\..\MVC\Views\FullwidthFiftyFiftyCarousel\Index.cshtml"
Write(Html.Script(Url.WidgetContent("~/ResourcePackages/BT/js/bootstrap.bundle.min.js"), "bottom"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
