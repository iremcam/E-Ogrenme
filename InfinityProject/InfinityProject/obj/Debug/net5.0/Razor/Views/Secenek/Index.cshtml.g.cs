#pragma checksum "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Secenek\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb1634493f1dc267a4f7a4aa8169b0ed1a793054"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Secenek_Index), @"mvc.1.0.view", @"/Views/Secenek/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\_ViewImports.cshtml"
using InfinityProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\_ViewImports.cshtml"
using InfinityProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\_ViewImports.cshtml"
using InfinityProject.Models.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1634493f1dc267a4f7a4aa8169b0ed1a793054", @"/Views/Secenek/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7c4a197bc1a4a4039cebf819a1b638ce71c1bf5", @"/Views/_ViewImports.cshtml")]
    public class Views_Secenek_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Secenek>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Secenek\Index.cshtml"
  
    ViewBag.Title = "Sınav";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb1634493f1dc267a4f7a4aa8169b0ed1a7930543678", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <a class=\"btn btn-primary\"");
                BeginWriteAttribute("href", " href=\"", 298, "\"", 344, 2);
                WriteAttributeValue("", 305, "/Secenek/SecenekOlustur/", 305, 24, true);
#nullable restore
#line 13 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Secenek\Index.cshtml"
WriteAttributeValue("", 329, ViewBag.SoruId, 329, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Şık ekle</a>
    </div>
    <div class=""row"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Şık İçeriği</th>
                    <th>Doğru/Yanlış</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 24 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Secenek\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Secenek\Index.cshtml"
                   Write(item.SecenekAciklamasi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 28 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Secenek\Index.cshtml"
                     if (item.DogruSecenek)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>Doğru</td>\r\n");
#nullable restore
#line 31 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Secenek\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>Yanlış</td>\r\n");
#nullable restore
#line 35 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Secenek\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Secenek\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Secenek>> Html { get; private set; }
    }
}
#pragma warning restore 1591
