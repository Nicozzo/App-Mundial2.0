<<<<<<< HEAD
#pragma checksum "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4391d1a617db602ddb485ecbb5812ab5311ef82b"
=======
#pragma checksum "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eec7dc9276f9bfedb73eb881922dbbd2529aac0d"
>>>>>>> fe867f1ff6afd4846706d728ee177587c5fe85b0
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paises_Index), @"mvc.1.0.view", @"/Views/Paises/Index.cshtml")]
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
#line 1 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4391d1a617db602ddb485ecbb5812ab5311ef82b", @"/Views/Paises/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Paises_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LogicaNegocio.Dominio.Pais>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
  
    ViewData["Title"] = "ListaPais";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ListaPais</h1>\r\n<p>\r\n");
#nullable restore
#line 11 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
     if (Context.Session.GetString("LogueadoEmail") != null)
    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4391d1a617db602ddb485ecbb5812ab5311ef82b4209", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Codigo Iso\r\n            </th>\r\n            <th>\r\n                ");
=======
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CodigoIso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
>>>>>>> fe867f1ff6afd4846706d728ee177587c5fe85b0
#nullable restore
#line 29 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pbi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Poblacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 39 "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
=======
#line 35 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
>>>>>>> fe867f1ff6afd4846706d728ee177587c5fe85b0
           Write(Html.DisplayNameFor(model => model.Imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
<<<<<<< HEAD
#line 45 "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
=======
#line 41 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
>>>>>>> fe867f1ff6afd4846706d728ee177587c5fe85b0
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 49 "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
=======
#line 45 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
>>>>>>> fe867f1ff6afd4846706d728ee177587c5fe85b0
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 52 "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
=======
#line 48 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
>>>>>>> fe867f1ff6afd4846706d728ee177587c5fe85b0
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 55 "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
=======
#line 51 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
>>>>>>> fe867f1ff6afd4846706d728ee177587c5fe85b0
           Write(Html.DisplayFor(modelItem => item.CodigoIso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 58 "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
=======
#line 54 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
>>>>>>> fe867f1ff6afd4846706d728ee177587c5fe85b0
           Write(Html.DisplayFor(modelItem => item.Pbi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 61 "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
=======
#line 57 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
>>>>>>> fe867f1ff6afd4846706d728ee177587c5fe85b0
           Write(Html.DisplayFor(modelItem => item.Poblacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 64 "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Region.Nombre));
=======
#line 60 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Imagen));
>>>>>>> fe867f1ff6afd4846706d728ee177587c5fe85b0

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1743, "\"", 1765, 2);
            WriteAttributeValue("", 1749, "img/", 1749, 4, true);
#nullable restore
<<<<<<< HEAD
#line 67 "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
WriteAttributeValue("", 1753, item.Imagen, 1753, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"60\" width=\"85\"/>\r\n            </td>\r\n\r\n");
#nullable restore
#line 70 "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
=======
#line 63 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
>>>>>>> fe867f1ff6afd4846706d728ee177587c5fe85b0
             if (Context.Session.GetString("LogueadoEmail") != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
<<<<<<< HEAD
#line 73 "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", item.Id));
=======
#line 66 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));
>>>>>>> fe867f1ff6afd4846706d728ee177587c5fe85b0

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
<<<<<<< HEAD
#line 74 "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", item.Id));
=======
#line 67 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));
>>>>>>> fe867f1ff6afd4846706d728ee177587c5fe85b0

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
<<<<<<< HEAD
#line 76 "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
=======
#line 69 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
>>>>>>> fe867f1ff6afd4846706d728ee177587c5fe85b0
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 78 "C:\Users\agust\source\repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
=======
#line 71 "C:\Users\diego\Source\Repos\App-Mundial2.0\WebApplication3\Views\Paises\Index.cshtml"
>>>>>>> fe867f1ff6afd4846706d728ee177587c5fe85b0
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LogicaNegocio.Dominio.Pais>> Html { get; private set; }
    }
}
#pragma warning restore 1591
