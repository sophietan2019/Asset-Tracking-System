#pragma checksum "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b26a42b54c7acb054c2fc809aa1c2428028dbb9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AssetsByType_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AssetsByType/Default.cshtml")]
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
#line 1 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\_ViewImports.cshtml"
using AssetTracking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\_ViewImports.cshtml"
using AssetTracking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b26a42b54c7acb054c2fc809aa1c2428028dbb9b", @"/Views/Shared/Components/AssetsByType/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b68ea3ba2d58cda3ce9e693c43d4e3b6e6571289", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AssetsByType_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AssetTracking.Models.AssetViewModel>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b26a42b54c7acb054c2fc809aa1c2428028dbb9b3823", async() => {
                WriteLiteral("\r\n<h3>Assets</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.TagNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.AssetType));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Manufacturer));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.SerialNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.TagNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.AssetType));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Manufacturer));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.SerialNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 62 "C:\Users\591052\Documents\OOSD\CPRG-214-OSD(.net web applications\Assignments\Assignment2-mvc core\MVC_Core_Assignment\AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AssetTracking.Models.AssetViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
