#pragma checksum "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Sinav\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb585172baa4ccb9073eaefa0beb3df6f9fd8855"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sinav_Index), @"mvc.1.0.view", @"/Views/Sinav/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb585172baa4ccb9073eaefa0beb3df6f9fd8855", @"/Views/Sinav/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7c4a197bc1a4a4039cebf819a1b638ce71c1bf5", @"/Views/_ViewImports.cshtml")]
    public class Views_Sinav_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Sinav>>
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
#nullable restore
#line 5 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Sinav\Index.cshtml"
  
    ViewBag.Title = "Sınav";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb585172baa4ccb9073eaefa0beb3df6f9fd88553594", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <a class=""btn btn-primary"" href=""/Sinav/SinavOlustur"">Sınav ekle</a>
    </div>
    <div class=""row"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Adı</th>
                    <th>Süresi</th>
                    <th>Başarı Puanı</th>
                    <th>Sorular</th>
                    <th>Soru Ekle</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 25 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Sinav\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <th>");
#nullable restore
#line 28 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Sinav\Index.cshtml"
                       Write(item.SinavAdi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Sinav\Index.cshtml"
                       Write(item.SinavSuresi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Sinav\Index.cshtml"
                       Write(item.BasariPuani);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 977, "\"", 1004, 2);
                WriteAttributeValue("", 984, "/Soru/Index/", 984, 12, true);
#nullable restore
#line 31 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Sinav\Index.cshtml"
WriteAttributeValue("", 996, item.Id, 996, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Sorular</a></td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 1054, "\"", 1087, 2);
                WriteAttributeValue("", 1061, "/Soru/SoruOlustur/", 1061, 18, true);
#nullable restore
#line 32 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Sinav\Index.cshtml"
WriteAttributeValue("", 1079, item.Id, 1079, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Soru Ekle</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Lenovo\Desktop\projeörnek\Project\InfinityProject\InfinityProject\Views\Sinav\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Sinav>> Html { get; private set; }
    }
}
#pragma warning restore 1591