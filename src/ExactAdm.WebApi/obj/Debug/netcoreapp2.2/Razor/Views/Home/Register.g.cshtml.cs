#pragma checksum "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abe8276927d279a443b3c339fda52b1b93a46714"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Register.cshtml", typeof(AspNetCore.Views_Home_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abe8276927d279a443b3c339fda52b1b93a46714", @"/Views/Home/Register.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExactAdm.Domain.Models.RegisterUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Register.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 162, true);
            WriteLiteral("\r\n<div style=\"padding-top:50px;\"></div>\r\n<div style=\"padding:50px;\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-4 col-md-4 col-sm-4\">\r\n            <div>\r\n");
            EndContext();
#line 12 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Register.cshtml"
                 using (Html.BeginForm("Register", "Home", FormMethod.Post, new { role = "form" }))
                {

#line default
#line hidden
            BeginContext(419, 43, true);
            WriteLiteral("                <div>\r\n                    ");
            EndContext();
            BeginContext(463, 23, false);
#line 15 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Register.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(486, 162, true);
            WriteLiteral("\r\n                    <div>\r\n                        <label>User ID</label><br />\r\n                    </div>\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(649, 70, false);
#line 20 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.USERID, new { @class = "form-control txtbox" }));

#line default
#line hidden
            EndContext();
            BeginContext(719, 250, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div style=\"padding-top:20px;\"></div>\r\n                    <div>\r\n                        <label>Password</label><br />\r\n                    </div>\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(970, 73, false);
#line 27 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Register.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { @class = "form-control txtbox" }));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 258, true);
            WriteLiteral(@"
                    </div>
                    <div style=""padding-top:20px;""></div>
                    <div>
                        <label>Confirm Password</label><br />
                    </div>
                    <div>
                        ");
            EndContext();
            BeginContext(1302, 80, false);
#line 34 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Register.cshtml"
                   Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control txtbox" }));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 247, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div style=\"padding-top:20px;\"></div>\r\n                    <div>\r\n                        <label>Setor</label><br />\r\n                    </div>\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1630, 69, false);
#line 41 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.Setor, new { @class = "form-control txtbox" }));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 102, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(1802, 94, false);
#line 45 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Register.cshtml"
                   Write(Html.LabelFor(model => model.Admin, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1896, 135, true);
            WriteLiteral("\r\n                        <div class=\"col-md-10\">\r\n                            <div class=\"checkbox\">\r\n                                ");
            EndContext();
            BeginContext(2032, 36, false);
#line 48 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Register.cshtml"
                           Write(Html.EditorFor(model => model.Admin));

#line default
#line hidden
            EndContext();
            BeginContext(2068, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2103, 83, false);
#line 49 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Register.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Admin, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2186, 421, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
                    <div style=""padding-left:35%;width:40%;"">
                        <div style=""padding-top:20px;"">
                            <input class=""btn btn-primary btn-lg rph-login-button"" type=""submit"" value=""Registrar"" />
                        </div>
                    </div>
");
            EndContext();
#line 59 "C:\Users\landrade.EXACTSALES\Documents\exact_adm\src\ExactAdm.WebApi\Views\Home\Register.cshtml"
                }

#line default
#line hidden
            BeginContext(2626, 58, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExactAdm.Domain.Models.RegisterUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
