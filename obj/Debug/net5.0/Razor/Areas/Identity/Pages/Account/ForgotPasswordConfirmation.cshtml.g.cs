#pragma checksum "E:\.net core\Udemy_ASP.NET_Core_MVC_Up_and_Running_Part_1_.NET_5_2\Udemy - ASP.NET Core MVC - Up and Running Part 1 (.NET 5) 2020-10\Rocky2\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9048cc10306d72db4c68b675781ae3f0fc5b654d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_ForgotPasswordConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
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
#line 1 "E:\.net core\Udemy_ASP.NET_Core_MVC_Up_and_Running_Part_1_.NET_5_2\Udemy - ASP.NET Core MVC - Up and Running Part 1 (.NET 5) 2020-10\Rocky2\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.net core\Udemy_ASP.NET_Core_MVC_Up_and_Running_Part_1_.NET_5_2\Udemy - ASP.NET Core MVC - Up and Running Part 1 (.NET 5) 2020-10\Rocky2\Areas\Identity\Pages\_ViewImports.cshtml"
using Rocky2.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\.net core\Udemy_ASP.NET_Core_MVC_Up_and_Running_Part_1_.NET_5_2\Udemy - ASP.NET Core MVC - Up and Running Part 1 (.NET 5) 2020-10\Rocky2\Areas\Identity\Pages\_ViewImports.cshtml"
using Rocky2.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\.net core\Udemy_ASP.NET_Core_MVC_Up_and_Running_Part_1_.NET_5_2\Udemy - ASP.NET Core MVC - Up and Running Part 1 (.NET 5) 2020-10\Rocky2\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Rocky2.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9048cc10306d72db4c68b675781ae3f0fc5b654d", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3da6e77c273610bcea395e65d5c30c4ecb49ba6", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19b1b812b2b8d38554382fdef6e6ff48d59bd705", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\.net core\Udemy_ASP.NET_Core_MVC_Up_and_Running_Part_1_.NET_5_2\Udemy - ASP.NET Core MVC - Up and Running Part 1 (.NET 5) 2020-10\Rocky2\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Forgot password confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "E:\.net core\Udemy_ASP.NET_Core_MVC_Up_and_Running_Part_1_.NET_5_2\Udemy - ASP.NET Core MVC - Up and Running Part 1 (.NET 5) 2020-10\Rocky2\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p>\r\n    Please check your email to reset your password.\r\n</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForgotPasswordConfirmation> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation>)PageContext?.ViewData;
        public ForgotPasswordConfirmation Model => ViewData.Model;
    }
}
#pragma warning restore 1591
