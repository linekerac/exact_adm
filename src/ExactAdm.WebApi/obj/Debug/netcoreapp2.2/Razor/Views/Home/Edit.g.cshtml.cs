#pragma checksum "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36dd661c38149049f03a046a459fafa420d72b74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Edit.cshtml", typeof(AspNetCore.Views_Home_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36dd661c38149049f03a046a459fafa420d72b74", @"/Views/Home/Edit.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExactAdm.Application.DTO.UserDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 21, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n\r\n");
            EndContext();
#line 11 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(186, 23, false);
#line 13 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(213, 94, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>UsuarioViewModel</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(308, 64, false);
#line 18 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(372, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(383, 33, false);
#line 19 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Edit.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(416, 50, true);
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(467, 95, false);
#line 22 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Edit.cshtml"
       Write(Html.LabelFor(model => model.USERID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(562, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(618, 95, false);
#line 24 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Edit.cshtml"
           Write(Html.EditorFor(model => model.USERID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(713, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(732, 84, false);
#line 25 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.USERID, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(816, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(903, 97, false);
#line 30 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Edit.cshtml"
       Write(Html.LabelFor(model => model.PASSWORD, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1000, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1056, 97, false);
#line 32 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Edit.cshtml"
           Write(Html.EditorFor(model => model.PASSWORD, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1172, 86, false);
#line 33 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.PASSWORD, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 253, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 43 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(1514, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1528, 48, false);
#line 46 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
