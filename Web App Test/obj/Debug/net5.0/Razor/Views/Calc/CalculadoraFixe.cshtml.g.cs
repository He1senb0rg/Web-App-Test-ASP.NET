#pragma checksum "C:\Users\Big Boss\Desktop\ASP.NET-WebApp-AndréSantos\Web-App-Test-ASP.NET\Web App Test\Views\Calc\CalculadoraFixe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f5357fcdd639ae4f17ab0f600063de2fbc23eb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_CalculadoraFixe), @"mvc.1.0.view", @"/Views/Calc/CalculadoraFixe.cshtml")]
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
#line 1 "C:\Users\Big Boss\Desktop\ASP.NET-WebApp-AndréSantos\Web-App-Test-ASP.NET\Web App Test\Views\_ViewImports.cshtml"
using Web_App_Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Big Boss\Desktop\ASP.NET-WebApp-AndréSantos\Web-App-Test-ASP.NET\Web App Test\Views\_ViewImports.cshtml"
using Web_App_Test.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Big Boss\Desktop\ASP.NET-WebApp-AndréSantos\Web-App-Test-ASP.NET\Web App Test\Views\Calc\CalculadoraFixe.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f5357fcdd639ae4f17ab0f600063de2fbc23eb4", @"/Views/Calc/CalculadoraFixe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fab871108534aa46703edadea431e29affbf8198", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Calc_CalculadoraFixe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Calc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Big Boss\Desktop\ASP.NET-WebApp-AndréSantos\Web-App-Test-ASP.NET\Web App Test\Views\Calc\CalculadoraFixe.cshtml"
  
    ViewData["Title"] = "Exame matematica";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div >\r\n    <h1>calculadora somar pra exame MATEMATICA A DO 15º ANO</h1>\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f5357fcdd639ae4f17ab0f600063de2fbc23eb44624", async() => {
                WriteLiteral("\r\n        <input class=\"textboxfixe\" type=\"text\" name=\"op\" readonly id=\"op\"");
                BeginWriteAttribute("value", " value=\"", 298, "\"", 338, 1);
#nullable restore
#line 11 "C:\Users\Big Boss\Desktop\ASP.NET-WebApp-AndréSantos\Web-App-Test-ASP.NET\Web App Test\Views\Calc\CalculadoraFixe.cshtml"
WriteAttributeValue("", 306, Context.Session.GetString("op"), 306, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
        <br />
        <br />
        <div>
            <input class=""botaofixe"" type=""submit"" name=""sqrt"" value=""√"" formaction=""/Calc/sqrt"" />
            <input class=""botaofixe"" type=""submit"" name=""power"" value=""^"" formaction=""/Calc/power"" />
            <input class=""botaofixe"" type=""submit"" name=""fraction"" value=""1/x"" formaction=""/Calc/fraction"" />
            <input class=""botaofixe"" type=""submit"" name=""div"" value=""/"" formaction=""/Calc/div"" />
            <input class=""botaofixe"" type=""submit"" name=""factorial"" value=""x!"" formaction=""/Calc/factorial"" />
        </div>
        
        <div>
            <input class=""botaofixe"" type=""submit"" name=""num"" value=""7"" formaction=""/Calc/numero"" />
            <input class=""botaofixe"" type=""submit"" name=""num"" value=""8"" formaction=""/Calc/numero"" />
            <input class=""botaofixe"" type=""submit"" name=""num"" value=""9"" formaction=""/Calc/numero"" />
            <input class=""botaofixe"" type=""submit"" name=""mult"" value=""*"" formaction=""/Calc/mult"" />");
                WriteLiteral(@"
            <input class=""botaofixe"" type=""submit"" name=""module"" value=""|x|"" formaction=""/Calc/module"" />
        </div>

        <div>
            <input class=""botaofixe"" type=""submit"" name=""num"" value=""4"" formaction=""/Calc/numero"" />
            <input class=""botaofixe"" type=""submit"" name=""num"" value=""5"" formaction=""/Calc/numero"" />
            <input class=""botaofixe"" type=""submit"" name=""num"" value=""6"" formaction=""/Calc/numero"" />
            <input class=""botaofixe"" type=""submit"" name=""sub"" value=""-"" formaction=""/Calc/sub"" />
        </div>

        <div>
            <input class=""botaofixe"" type=""submit"" name=""num"" value=""1"" formaction=""/Calc/numero"" />
            <input class=""botaofixe"" type=""submit"" name=""num"" value=""2"" formaction=""/Calc/numero"" />
            <input class=""botaofixe"" type=""submit"" name=""num"" value=""3"" formaction=""/Calc/numero"" />
            <input class=""botaofixe"" type=""submit"" name=""add"" value=""+"" formaction=""/Calc/add"" />
        </div>

        <div>
      ");
                WriteLiteral(@"      <input class=""botaofixe"" type=""submit"" name=""inverse"" value=""+/-"" formaction=""/Calc/inverse"" />
            <input class=""botaofixe"" type=""submit"" name=""num"" value=""0"" formaction=""/Calc/numero"" />
            <input class=""botaofixe"" type=""submit"" name=""clear"" value=""C"" formaction=""/Calc/clear"" />
            <input class=""botaofixe"" type=""submit"" name=""result"" value=""="" formaction=""/Calc/result"" />
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
