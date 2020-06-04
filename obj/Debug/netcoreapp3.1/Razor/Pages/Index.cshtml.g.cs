#pragma checksum "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a48bfaa76b5b5f0599f5546f2cb2fe36f62f8fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SudokuApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
#nullable restore
#line 2 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
using Puzzle.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
using RestSharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
using RestSharp.Authenticators;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a48bfaa76b5b5f0599f5546f2cb2fe36f62f8fd", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b393e9a84ee798666b054c4cb7a710cdf5b0fcd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Solve this puzzle!</h1>\r\n");
#nullable restore
#line 11 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
  
    var client = new RestClient("https://online-sudoku.p.rapidapi.com/random");
    var request = new RestRequest(Method.GET);
    request.AddHeader("x-rapidapi-host", "online-sudoku.p.rapidapi.com");
    request.AddHeader("x-rapidapi-key", "b7ece58cddmsh492adbb2d0e2f6fp19717djsnc1c02a305ff9");
    IRestResponse response = client.Execute(request);

    var responseJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
    string puzzleString = responseJson["item"];
    
    char[,] puzzleMatrix = new char[9,9];
    char[,] solutionMatrix = new char[9,9];
    System.Console.WriteLine(puzzleString);
    for (int i = 0; i < puzzleString.Length; i++ )
    {
        int y = i % 9;
        int x = i / 9;
        puzzleMatrix[x,y] = puzzleString[i];
        solutionMatrix[x,y] = puzzleString[i];
    }
    int numToHide = 1;
    for (int i = 0; i < numToHide; i++ )
    {
        Random random = new Random();
        int x = random.Next(0, 9);
        int y = random.Next(0, 9);

        puzzleMatrix[x,y] = '?';
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"puzzle\">\r\n");
#nullable restore
#line 42 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
     for (int i = 0; i < 81; i++)
    {
        int y = i % 9;
        int x = i / 9;
        char numChar = puzzleMatrix[x,y];
        var key = solutionMatrix[x,y];
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
         if (numChar == '?')
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input");
            BeginWriteAttribute("key", " key=\"", 1536, "\"", 1542, 0);
            EndWriteAttribute();
            BeginWriteAttribute("solution", " solution=\"", 1543, "\"", 1558, 1);
#nullable restore
#line 50 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
WriteAttributeValue("", 1554, key, 1554, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"puzzleCell\" />");
#nullable restore
#line 50 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
                                                                           ;
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("key", " key=\"", 1648, "\"", 1658, 1);
#nullable restore
#line 54 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
WriteAttributeValue("", 1654, key, 1654, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("solution", " solution=\"", 1659, "\"", 1674, 1);
#nullable restore
#line 54 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
WriteAttributeValue("", 1670, key, 1670, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"puzzleCell\">");
#nullable restore
#line 54 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
                                                          Write(numChar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
#nullable restore
#line 54 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
                                                                             ;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("<button id=\"solutionChecker\"");
            BeginWriteAttribute("solution", " solution=\"", 1775, "\"", 1799, 1);
#nullable restore
#line 61 "/Users/miguel/Desktop/code/SudokuApp/Pages/Index.cshtml"
WriteAttributeValue("", 1786, puzzleString, 1786, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Check solution</button>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
