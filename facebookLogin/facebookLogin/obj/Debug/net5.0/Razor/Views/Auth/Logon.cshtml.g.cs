#pragma checksum "C:\Users\jbeltran\Downloads\facebookLogin\facebookLogin\Views\Auth\Logon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "953aada917984c0e0954317fdbadcd9688515356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Logon), @"mvc.1.0.view", @"/Views/Auth/Logon.cshtml")]
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
#line 1 "C:\Users\jbeltran\Downloads\facebookLogin\facebookLogin\Views\_ViewImports.cshtml"
using facebookLogin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jbeltran\Downloads\facebookLogin\facebookLogin\Views\_ViewImports.cshtml"
using facebookLogin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"953aada917984c0e0954317fdbadcd9688515356", @"/Views/Auth/Logon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80589f10d763d6c412be22859bc39e72b44c6a16", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Auth_Logon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jbeltran\Downloads\facebookLogin\facebookLogin\Views\Auth\Logon.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout-Logon.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"bLogin\">\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4 text-white titleLogin\">Login</h1>\r\n    </div>\r\n    \r\n    <div class=\"loginIndexOut\">\r\n        <div class=\"loginIndexIn\">\r\n            <p class=\"loginTitle\">facebook</p>\r\n");
#nullable restore
#line 14 "C:\Users\jbeltran\Downloads\facebookLogin\facebookLogin\Views\Auth\Logon.cshtml"
             using (Html.BeginForm("FacebookLogin", "Account"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""contBtn"">
                    <button type=""submit"" class=""btnLogin"">
                        <div class=""iconLeft"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""currentColor"" class=""bi bi-facebook"" viewBox=""0 0 16 16"">
                              <path d=""M16 8.049c0-4.446-3.582-8.05-8-8.05C3.58 0-.002 3.603-.002 8.05c0 4.017 2.926 7.347 6.75 7.951v-5.625h-2.03V8.05H6.75V6.275c0-2.017 1.195-3.131 3.022-3.131.876 0 1.791.157 1.791.157v1.98h-1.009c-.993 0-1.303.621-1.303 1.258v1.51h2.218l-.354 2.326H9.25V16c3.824-.604 6.75-3.934 6.75-7.951z""/>
                            </svg>
                        </div>
                        <p class=""textRight"">
                            Iniciar Sesión
                        </p>
                    </button>
                </div>
");
#nullable restore
#line 28 "C:\Users\jbeltran\Downloads\facebookLogin\facebookLogin\Views\Auth\Logon.cshtml"
            }    

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
