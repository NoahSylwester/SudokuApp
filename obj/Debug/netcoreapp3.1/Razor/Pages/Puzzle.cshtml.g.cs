#pragma checksum "/Users/miguel/Desktop/code/SudokuApp/Pages/Puzzle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "757f8618bb4777e52136cd78ef453306c2953aa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SudokuApp.Pages.Pages_Puzzle), @"mvc.1.0.razor-page", @"/Pages/Puzzle.cshtml")]
namespace SudokuApp.Pages
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
#line 1 "/Users/miguel/Desktop/code/SudokuApp/Pages/_ViewImports.cshtml"
using SudokuApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"757f8618bb4777e52136cd78ef453306c2953aa8", @"/Pages/Puzzle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b393e9a84ee798666b054c4cb7a710cdf5b0fcd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Puzzle : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/miguel/Desktop/code/SudokuApp/Pages/Puzzle.cshtml"
  
    ViewData["Title"] = "Puzzle";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Solve this puzzle!!</h1><br/>
<span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><br/>
<span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><br/>
<span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><br/>
<span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><br/>
<span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><br/>
<span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><br/>
<span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span>");
            WriteLiteral(@"<br/>
<span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><br/>
<span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><span>[]</span><br/>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SudokuApp.Pages.PuzzleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SudokuApp.Pages.PuzzleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SudokuApp.Pages.PuzzleModel>)PageContext?.ViewData;
        public SudokuApp.Pages.PuzzleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591