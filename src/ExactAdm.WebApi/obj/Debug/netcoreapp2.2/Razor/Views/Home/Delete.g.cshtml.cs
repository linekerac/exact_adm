#pragma checksum "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5ff190a665a46e91e753841c7988cc087d976cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Delete), @"mvc.1.0.view", @"/Views/Home/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Delete.cshtml", typeof(AspNetCore.Views_Home_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ff190a665a46e91e753841c7988cc087d976cf", @"/Views/Home/Delete.cshtml")]
    public class Views_Home_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExactAdm.Application.DTO.UserDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 146, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(277, 42, false);
#line 14 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.USERID));

#line default
#line hidden
            EndContext();
            BeginContext(319, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(365, 38, false);
#line 18 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.USERID));

#line default
#line hidden
            EndContext();
            BeginContext(403, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(449, 44, false);
#line 22 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(493, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(539, 40, false);
#line 26 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(579, 30, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n");
            EndContext();
#line 30 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(656, 23, false);
#line 32 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(683, 135, true);
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
            EndContext();
            BeginContext(819, 48, false);
#line 36 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Delete.cshtml"
       Write(Html.ActionLink("Back to List", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(867, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 38 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(892, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExactAdm.Application.DTO.UserDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591