#pragma checksum "C:\devbuild4\Random Exercises_Classwork\PetStore\Views\Home\EditPrice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5043f0dff34b5e1a3891a1a44da0cde01409d3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditPrice), @"mvc.1.0.view", @"/Views/Home/EditPrice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/EditPrice.cshtml", typeof(AspNetCore.Views_Home_EditPrice))]
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
#line 1 "C:\devbuild4\Random Exercises_Classwork\PetStore\Views\_ViewImports.cshtml"
using PetStore;

#line default
#line hidden
#line 2 "C:\devbuild4\Random Exercises_Classwork\PetStore\Views\_ViewImports.cshtml"
using PetStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5043f0dff34b5e1a3891a1a44da0cde01409d3b", @"/Views/Home/EditPrice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f074bd498ab3477b7c3a87bf830928496b90bfb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditPrice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PetStore.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\devbuild4\Random Exercises_Classwork\PetStore\Views\Home\EditPrice.cshtml"
  
    ViewData["Title"] = "EditPrice";

#line default
#line hidden
            BeginContext(77, 86, true);
            WriteLiteral("<h2>Edit Prices:</h2>\r\n\r\n<table class=\"table-bordered table-hover table-responsive\">\r\n");
            EndContext();
#line 8 "C:\devbuild4\Random Exercises_Classwork\PetStore\Views\Home\EditPrice.cshtml"
     foreach (Product product in Product.Read())
    {

#line default
#line hidden
            BeginContext(220, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(269, 10, false);
#line 12 "C:\devbuild4\Random Exercises_Classwork\PetStore\Views\Home\EditPrice.cshtml"
           Write(product.id);

#line default
#line hidden
            EndContext();
            BeginContext(279, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n                ");
            EndContext();
            BeginContext(337, 12, false);
#line 16 "C:\devbuild4\Random Exercises_Classwork\PetStore\Views\Home\EditPrice.cshtml"
           Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(349, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n                ");
            EndContext();
            BeginContext(407, 13, false);
#line 20 "C:\devbuild4\Random Exercises_Classwork\PetStore\Views\Home\EditPrice.cshtml"
           Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(420, 684, true);
            WriteLiteral(@"
            </td>
            <td>

                <input type=""button"" value=""Edit"" name=""Edit"" onclick=""MyFunction()"">
                <script>
                    function MyFunction() {
                        var x = document.getElementById(""Field"");
                        if (x.type == """") {
                            x.type = ""text"";
                        }
                        else {
                            x.type = """";
                        }

                    }
                </script>

            </td>
            <td>

                <input type=""button"" value=""Remove"" name=""Remove"">

            </td>

        </tr>
");
            EndContext();
#line 46 "C:\devbuild4\Random Exercises_Classwork\PetStore\Views\Home\EditPrice.cshtml"
    }

#line default
#line hidden
            BeginContext(1111, 87, true);
            WriteLiteral("\r\n\r\n</table>\r\n\r\n<a href=\"/Home/Add\">  <input type=\"button\" value=\"Add\" name=\"Add\"> </a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PetStore.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
