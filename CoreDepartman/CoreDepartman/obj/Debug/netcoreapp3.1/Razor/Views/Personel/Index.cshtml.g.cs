#pragma checksum "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\Personel\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c2e0ff05a011446342f7ab8d7b43658d4575e8f9272d75ba252a43d304347769"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_Index), @"mvc.1.0.view", @"/Views/Personel/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\_ViewImports.cshtml"
using CoreDepartman;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\Personel\Index.cshtml"
using CoreDepartman.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c2e0ff05a011446342f7ab8d7b43658d4575e8f9272d75ba252a43d304347769", @"/Views/Personel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d6fbdd92bf16f2a8b24bbf335eaaf51f8efb874f59848815cd9586d8268ea54c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Personel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<personel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\Personel\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_supLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<br />
<table class=""table table-bordered text-center"">
    <tr>
        <th>ID</th>
        <th>AD</th>
        <th>SOYAD</th>
        <th>ŞEHİR</th>
        <th>DEPARTMAN</th>
        <th>SİL</th>
        <th>GÜNCELLE</th>
    </tr>
");
#nullable restore
#line 20 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\Personel\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\Personel\Index.cshtml"
           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\Personel\Index.cshtml"
           Write(item.ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\Personel\Index.cshtml"
           Write(item.soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\Personel\Index.cshtml"
           Write(item.sehir);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\Personel\Index.cshtml"
           Write(item.department.departmanAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 653, "\"", 690, 2);
            WriteAttributeValue("", 660, "/Personel/SilPersonel/", 660, 22, true);
#nullable restore
#line 28 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\Personel\Index.cshtml"
WriteAttributeValue("", 682, item.id, 682, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 747, "\"", 789, 2);
            WriteAttributeValue("", 754, "/Personel/GuncellePersonel/", 754, 27, true);
#nullable restore
#line 29 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\Personel\Index.cshtml"
WriteAttributeValue("", 781, item.id, 781, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\Personel\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<td><a href=\"/Personel/YeniPersonel/\" class=\"btn btn-success\">PERSONEL EKLE</a></td>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<personel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591