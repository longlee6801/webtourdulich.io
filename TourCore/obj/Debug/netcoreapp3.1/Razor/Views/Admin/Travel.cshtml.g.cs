#pragma checksum "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc6d9d4850ccb002a794444806b8750e11b9b5fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Travel), @"mvc.1.0.view", @"/Views/Admin/Travel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc6d9d4850ccb002a794444806b8750e11b9b5fc", @"/Views/Admin/Travel.cshtml")]
    #nullable restore
    public class Views_Admin_Travel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TourCore.Models.ViewModels.ContractDetailViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
  
    ViewData["Title"] = "Travel";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    tbody > tr > td
    {
        text-align:center;
    }
    thead > tr > th{
        text-align:center;
    }
</style>
<h1 style=""text-align:center;color:brown"">Danh sách khánh hàng Book Tour</h1>


<br />
<br />
<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 25 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
           Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
           Write(Html.DisplayNameFor(model => model.NameTour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
           Write(Html.DisplayNameFor(model => model.NameCustomer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
           Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
           Write(Html.DisplayNameFor(model => model.BeginDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
           Write(Html.DisplayNameFor(model => model.Paid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 46 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                ");
#nullable restore
#line 49 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
           Write(Html.HiddenFor(modelItem=>item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
               Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
               Write(Html.DisplayFor(modelItem => item.NameTour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
               Write(Html.DisplayFor(modelItem => item.NameCustomer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
               Write(item.Cost.Value.ToString("#,##"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
               Write(Html.DisplayFor(modelItem => item.BeginDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
               Write(item.Paid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
               Write(Html.ActionLink("Chỉnh sửa", "EditContractDetail","Admin", new {id=item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 70 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
               Write(Html.ActionLink("Chi Tiết", "SeeContractDetail","Admin", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 71 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
               Write(Html.ActionLink("Xóa", "DeleteContractDetail","Admin", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 74 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Travel.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TourCore.Models.ViewModels.ContractDetailViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
