#pragma checksum "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\department\Detay.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "749b2a37cdefc9a74d52a3696478edc140e24e2e6bb4a5741e5dd90a5522915c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_department_Detay), @"mvc.1.0.view", @"/Views/department/Detay.cshtml")]
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
#line 2 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\_ViewImports.cshtml"
using CoreDepartman.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"749b2a37cdefc9a74d52a3696478edc140e24e2e6bb4a5741e5dd90a5522915c", @"/Views/department/Detay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d6fbdd92bf16f2a8b24bbf335eaaf51f8efb874f59848815cd9586d8268ea54c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_department_Detay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<departmanlar>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\department\Detay.cshtml"
  
    ViewData["Title"] = "Departman Detayı";
    Layout = "~/Views/Shared/_supLayout.cshtml"; //Varsayılan layout dosyanızı belirtin

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<div class=\"card border-primary\" style=\"max-height: 80vh; overflow-y: auto;\">\r\n    <div class=\"card-header bg-primary text-white\">Departman Detayı</div>\r\n    <div class=\"card-body\">\r\n");
#nullable restore
#line 12 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\department\Detay.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"departmentName\" class=\"font-weight-bold\">Departman Adı</label>\r\n                <input type=\"text\" class=\"form-control form-control-lg\" id=\"departmentName\"");
            BeginWriteAttribute("value", " value=\"", 624, "\"", 650, 1);
#nullable restore
#line 16 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\department\Detay.cshtml"
WriteAttributeValue("", 632, Model.departmanAd, 632, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly>
            </div>
            <div class=""form-group"">
                <label for=""departmentDescription"" class=""font-weight-bold"">Açıklama</label>
                <textarea class=""form-control form-control-lg"" id=""departmentDescription"" rows=""5"" readonly>");
#nullable restore
#line 20 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\department\Detay.cshtml"
                                                                                                       Write(Model.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n            <!-- İhtiyacınıza göre diğer departman özelliklerini buraya ekleyebilirsiniz -->\r\n");
#nullable restore
#line 23 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\department\Detay.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Belirtilen ID\'ye sahip departman bulunamadı.</p>\r\n");
#nullable restore
#line 27 "C:\Users\pc\Desktop\E-TİCARET\CoreDepartman\CoreDepartman\Views\department\Detay.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<br />\r\n<a class=\"btn btn-primary\" href=\"/department/Index\" style=\"margin-left:20px;\">Geri</a>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<departmanlar> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
