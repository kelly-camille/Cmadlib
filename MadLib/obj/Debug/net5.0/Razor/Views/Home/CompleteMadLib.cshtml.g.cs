#pragma checksum "C:\Users\kelly\OneDrive\Desktop\MadLib.Solution\MadLib\Views\Home\CompleteMadLib.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2ff8871d43d18b4f3cc46a4b5ace0bb758b191f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CompleteMadLib), @"mvc.1.0.view", @"/Views/Home/CompleteMadLib.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2ff8871d43d18b4f3cc46a4b5ace0bb758b191f", @"/Views/Home/CompleteMadLib.cshtml")]
    public class Views_Home_CompleteMadLib : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2ff8871d43d18b4f3cc46a4b5ace0bb758b191f2753", async() => {
                WriteLiteral(@"
    <meta charset='utf-8'>
    <title>Completed MadLib!</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2ff8871d43d18b4f3cc46a4b5ace0bb758b191f4013", async() => {
                WriteLiteral("\r\n  <h1>Completed MadLib!</h1>\r\n  <p>Today a ");
#nullable restore
#line 10 "C:\Users\kelly\OneDrive\Desktop\MadLib.Solution\MadLib\Views\Home\CompleteMadLib.cshtml"
        Write(Model.Occupation);

#line default
#line hidden
#nullable disable
                WriteLiteral(" named ");
#nullable restore
#line 10 "C:\Users\kelly\OneDrive\Desktop\MadLib.Solution\MadLib\Views\Home\CompleteMadLib.cshtml"
                                Write(Model.Noun4);

#line default
#line hidden
#nullable disable
                WriteLiteral(" came to our school to talk to us about her job.    \r\n  </p>\r\n  <p>\r\n    She said the most important skill you need to know to do her job is to be able to ");
#nullable restore
#line 13 "C:\Users\kelly\OneDrive\Desktop\MadLib.Solution\MadLib\Views\Home\CompleteMadLib.cshtml"
                                                                                 Write(Model.Verb2);

#line default
#line hidden
#nullable disable
                WriteLiteral(" around (a) ");
#nullable restore
#line 13 "C:\Users\kelly\OneDrive\Desktop\MadLib.Solution\MadLib\Views\Home\CompleteMadLib.cshtml"
                                                                                                         Write(Model.Adjective);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\kelly\OneDrive\Desktop\MadLib.Solution\MadLib\Views\Home\CompleteMadLib.cshtml"
                                                                                                                          Write(Model.Noun3);

#line default
#line hidden
#nullable disable
                WriteLiteral(". \r\n  </p>\r\n  <p>\r\n    She said it was easy for her to learn her job because she loved to ");
#nullable restore
#line 16 "C:\Users\kelly\OneDrive\Desktop\MadLib.Solution\MadLib\Views\Home\CompleteMadLib.cshtml"
                                                                  Write(Model.Verb);

#line default
#line hidden
#nullable disable
                WriteLiteral(" when she was my age--and that helps a lot!\r\n  </p>\r\n  <p>\r\n    If you\'re considering her profession, I hope you can be near (a) ");
#nullable restore
#line 19 "C:\Users\kelly\OneDrive\Desktop\MadLib.Solution\MadLib\Views\Home\CompleteMadLib.cshtml"
                                                                Write(Model.Adjective2);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 19 "C:\Users\kelly\OneDrive\Desktop\MadLib.Solution\MadLib\Views\Home\CompleteMadLib.cshtml"
                                                                                  Write(Model.Noun);

#line default
#line hidden
#nullable disable
                WriteLiteral(".\r\n  </p>\r\n  <p>\r\n    That\'s very important! If you get too distracted in that situation you won\'t be able to ");
#nullable restore
#line 22 "C:\Users\kelly\OneDrive\Desktop\MadLib.Solution\MadLib\Views\Home\CompleteMadLib.cshtml"
                                                                                       Write(Model.Verb3);

#line default
#line hidden
#nullable disable
                WriteLiteral(" next to (a) ");
#nullable restore
#line 22 "C:\Users\kelly\OneDrive\Desktop\MadLib.Solution\MadLib\Views\Home\CompleteMadLib.cshtml"
                                                                                                                Write(Model.Noun2);

#line default
#line hidden
#nullable disable
                WriteLiteral("!\r\n  </p>\r\n  ");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591