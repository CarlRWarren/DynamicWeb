#pragma checksum "C:\Users\Carl\OneDrive - Neumont University\Q8\DynamicWeb\DynamicWeb\VideoGameLibraryPt1\VideoGameLibraryPt1\Views\Home\DisplayGames.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc6d2ef1b8e0afe3ea49d84c5dbe5d8d5cdfd667"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayGames), @"mvc.1.0.view", @"/Views/Home/DisplayGames.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DisplayGames.cshtml", typeof(AspNetCore.Views_Home_DisplayGames))]
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
#line 1 "C:\Users\Carl\OneDrive - Neumont University\Q8\DynamicWeb\DynamicWeb\VideoGameLibraryPt1\VideoGameLibraryPt1\Views\Home\DisplayGames.cshtml"
using VideoGameLibraryPt1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc6d2ef1b8e0afe3ea49d84c5dbe5d8d5cdfd667", @"/Views/Home/DisplayGames.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayGames : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Game>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DisplayGamesPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Title", async() => {
                BeginContext(69, 13, true);
                WriteLiteral("\r\n    Games\r\n");
                EndContext();
            }
            );
            BeginContext(148, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Carl\OneDrive - Neumont University\Q8\DynamicWeb\DynamicWeb\VideoGameLibraryPt1\VideoGameLibraryPt1\Views\Home\DisplayGames.cshtml"
 if (Model == null || Model.Count == 0)
{

#line default
#line hidden
            BeginContext(194, 60, true);
            WriteLiteral("    <h1 class=\"urgentMessage\">There are no games here</h1>\r\n");
            EndContext();
#line 10 "C:\Users\Carl\OneDrive - Neumont University\Q8\DynamicWeb\DynamicWeb\VideoGameLibraryPt1\VideoGameLibraryPt1\Views\Home\DisplayGames.cshtml"
}
else
{
    for (int i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
            BeginContext(316, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(324, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2d47ecdf2dac489e89c0e69b2a85304f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 15 "C:\Users\Carl\OneDrive - Neumont University\Q8\DynamicWeb\DynamicWeb\VideoGameLibraryPt1\VideoGameLibraryPt1\Views\Home\DisplayGames.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model[i];

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(381, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\Users\Carl\OneDrive - Neumont University\Q8\DynamicWeb\DynamicWeb\VideoGameLibraryPt1\VideoGameLibraryPt1\Views\Home\DisplayGames.cshtml"
    }
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Game>> Html { get; private set; }
    }
}
#pragma warning restore 1591
