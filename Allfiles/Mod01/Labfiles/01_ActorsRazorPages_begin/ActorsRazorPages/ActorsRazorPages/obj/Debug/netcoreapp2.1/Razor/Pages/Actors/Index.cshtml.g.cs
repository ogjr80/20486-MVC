#pragma checksum "C:\Users\phill\OneDrive\Desktop\MCSD\MVC\20486D-DevelopingASPNETMVCWebApplications\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_begin\ActorsRazorPages\ActorsRazorPages\Pages\Actors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a53bfc158f2e8f3b907271f94ec29d6f40b543d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ActorsRazorPages.Pages.Actors.Pages_Actors_Index), @"mvc.1.0.razor-page", @"/Pages/Actors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Actors/Index.cshtml", typeof(ActorsRazorPages.Pages.Actors.Pages_Actors_Index), null)]
namespace ActorsRazorPages.Pages.Actors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\phill\OneDrive\Desktop\MCSD\MVC\20486D-DevelopingASPNETMVCWebApplications\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_begin\ActorsRazorPages\ActorsRazorPages\Pages\_ViewImports.cshtml"
using ActorsRazorPages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a53bfc158f2e8f3b907271f94ec29d6f40b543d7", @"/Pages/Actors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1881739dfeb8e15a9e209a6efbe3d40e3613740", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Actors_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\phill\OneDrive\Desktop\MCSD\MVC\20486D-DevelopingASPNETMVCWebApplications\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_begin\ActorsRazorPages\ActorsRazorPages\Pages\Actors\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 104, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(202, 55, false);
#line 13 "C:\Users\phill\OneDrive\Desktop\MCSD\MVC\20486D-DevelopingASPNETMVCWebApplications\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_begin\ActorsRazorPages\ActorsRazorPages\Pages\Actors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Actors[0].FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(257, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(313, 54, false);
#line 16 "C:\Users\phill\OneDrive\Desktop\MCSD\MVC\20486D-DevelopingASPNETMVCWebApplications\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_begin\ActorsRazorPages\ActorsRazorPages\Pages\Actors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Actors[0].LastName));

#line default
#line hidden
            EndContext();
            BeginContext(367, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 22 "C:\Users\phill\OneDrive\Desktop\MCSD\MVC\20486D-DevelopingASPNETMVCWebApplications\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_begin\ActorsRazorPages\ActorsRazorPages\Pages\Actors\Index.cshtml"
         foreach (var item in Model.Actors)
        {

#line default
#line hidden
            BeginContext(509, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(570, 44, false);
#line 26 "C:\Users\phill\OneDrive\Desktop\MCSD\MVC\20486D-DevelopingASPNETMVCWebApplications\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_begin\ActorsRazorPages\ActorsRazorPages\Pages\Actors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(614, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(682, 43, false);
#line 29 "C:\Users\phill\OneDrive\Desktop\MCSD\MVC\20486D-DevelopingASPNETMVCWebApplications\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_begin\ActorsRazorPages\ActorsRazorPages\Pages\Actors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(725, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(792, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9babb07135324a50a12b8cc8d8e745a7", async() => {
                BeginContext(840, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "C:\Users\phill\OneDrive\Desktop\MCSD\MVC\20486D-DevelopingASPNETMVCWebApplications\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_begin\ActorsRazorPages\ActorsRazorPages\Pages\Actors\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(851, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 35 "C:\Users\phill\OneDrive\Desktop\MCSD\MVC\20486D-DevelopingASPNETMVCWebApplications\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_begin\ActorsRazorPages\ActorsRazorPages\Pages\Actors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(906, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActorsRazorPages.Pages.Actors.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActorsRazorPages.Pages.Actors.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActorsRazorPages.Pages.Actors.IndexModel>)PageContext?.ViewData;
        public ActorsRazorPages.Pages.Actors.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
