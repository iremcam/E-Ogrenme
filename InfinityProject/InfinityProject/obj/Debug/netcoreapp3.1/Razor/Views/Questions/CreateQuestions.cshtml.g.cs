#pragma checksum "C:\Users\Lenovo\source\repos\InfinityProject\InfinityProject\Views\Questions\CreateQuestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e270cd24aaa1e8d9e519a37d930ef9a4890a1351"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_CreateQuestions), @"mvc.1.0.view", @"/Views/Questions/CreateQuestions.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\InfinityProject\InfinityProject\Views\_ViewImports.cshtml"
using InfinityProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\InfinityProject\InfinityProject\Views\_ViewImports.cshtml"
using InfinityProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\InfinityProject\InfinityProject\Views\_ViewImports.cshtml"
using InfinityProject.Models.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e270cd24aaa1e8d9e519a37d930ef9a4890a1351", @"/Views/Questions/CreateQuestions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7c4a197bc1a4a4039cebf819a1b638ce71c1bf5", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_CreateQuestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateQuestionsDTO>
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
#line 3 "C:\Users\Lenovo\source\repos\InfinityProject\InfinityProject\Views\Questions\CreateQuestions.cshtml"
  
    ViewData["Title"] = "CreateQuestions";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    body {
        font-family: Lato, Arial;
        text-align: center;
        color: #eee;
        background-color: #eee;
    }

    .row {
        margin: auto;
        text-align: center;
        display: block;
        background-color: #6f92dc;
        width: 60%;
        height: auto;
    }

    #btn_Kaydet {
        display: block;
        width: 100%;
        height: 40px;
        margin-top: 2.0em;
        border-radius: 4px;
        background-color: #3366cc;
        color: #fff;
    }

    .create {
        display: block;
        margin: auto;
        background: #6f92dc;
        border-radius: 5px;
        width: 50%;
        height: 20em;
        height: auto;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e270cd24aaa1e8d9e519a37d930ef9a4890a13514397", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"create\">\r\n            <input placeholder=\"ders\">");
#nullable restore
#line 47 "C:\Users\Lenovo\source\repos\InfinityProject\InfinityProject\Views\Questions\CreateQuestions.cshtml"
                                 Write(Model.SubCaregory);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input placeholder=\"soru\" />");
#nullable restore
#line 48 "C:\Users\Lenovo\source\repos\InfinityProject\InfinityProject\Views\Questions\CreateQuestions.cshtml"
                                   Write(Model.Contents);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input placeholder=\"A\" />");
#nullable restore
#line 49 "C:\Users\Lenovo\source\repos\InfinityProject\InfinityProject\Views\Questions\CreateQuestions.cshtml"
                                Write(Model.chic_a);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input placeholder=\"B\" />");
#nullable restore
#line 50 "C:\Users\Lenovo\source\repos\InfinityProject\InfinityProject\Views\Questions\CreateQuestions.cshtml"
                                Write(Model.chic_b);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input placeholder=\"C\" />");
#nullable restore
#line 51 "C:\Users\Lenovo\source\repos\InfinityProject\InfinityProject\Views\Questions\CreateQuestions.cshtml"
                                Write(Model.chic_c);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input placeholder=\"D\" />");
#nullable restore
#line 52 "C:\Users\Lenovo\source\repos\InfinityProject\InfinityProject\Views\Questions\CreateQuestions.cshtml"
                                Write(Model.chic_d);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <button id=\"btn_Kaydet\"> Kaydet </button>\r\n        </div>\r\n\r\n    </div>\r\n    <div>\r\n\r\n\r\n    </div>\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateQuestionsDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591