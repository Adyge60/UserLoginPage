#pragma checksum "C:\Users\TARIK GULEC\source\repos\Modelleme\Modelleme\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02cc5203638586881c4970cae5a059a8243c7d11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\TARIK GULEC\source\repos\Modelleme\Modelleme\Views\_ViewImports.cshtml"
using Modelleme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TARIK GULEC\source\repos\Modelleme\Modelleme\Views\_ViewImports.cshtml"
using Modelleme.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02cc5203638586881c4970cae5a059a8243c7d11", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf392bcbe7773ab50ebc24d1826279374495d8fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\TARIK GULEC\source\repos\Modelleme\Modelleme\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container w-50 mt-3 shadow border-2 bg-transparent opacity-75 "" style=""max-width: 400px; border-radius: 10%;"">
    <div class=""d-flex justify-content-center pb-2"" >
        <i class=""fas fa-user mt-3 fa-5x""></i>
    </div>
    <div class=""form-group "">
        <label for=""exampleTextarea"" class=""form-label mt-3 position-relative"">Kullanıcı:</label>
        <textarea class=""form-control"" id=""exampleTextarea"" rows=""1"" style=""resize:none;""></textarea>
    </div>
    <div class=""form-group pb-2 "">
        <label for=""exampleTextarea"" class=""form-label "">Şifre:</label>
        <textarea class=""form-control "" id=""exampleTextarea"" rows=""1"" style=""resize:none; ""></textarea>
    </div>
    <div class=""d-flex justify-content-center pb-2"">
        <button type=""button"" class=""btn btn-outline-primary"">Giriş</button>
    </div>
    
</div>    
");
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