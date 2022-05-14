#pragma checksum "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\Pages\RegisterPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11cf784d42c44608e07ccfe2f06eeeda81ee52ef"
// <auto-generated/>
#pragma warning disable 1591
namespace EnhancedOasis.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\_Imports.razor"
using EnhancedOasis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\_Imports.razor"
using EnhancedOasis.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\_Imports.razor"
using EnhancedOasis.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class RegisterPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<link href=""./css/general-styles.css"" rel=""stylesheet"">
<link href=""./css/RegisterPage.css"" rel=""stylesheet"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"" integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"">

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<EnhancedOasis.Shared.NavBar>(4);
            __builder.AddAttribute(5, "PageTitle", "Register For Courses");
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.AddMarkupContent(7, "<div class=\"container\">\r\n        <form class=\"registerForm\">\r\n            <div class=\"register register-grid\">\r\n                <div class=\"grid-row grid-header\">\r\n                    <div class=\"gi gi-1 gi-header\">CRN</div>\r\n                    <div class=\"gi gi-2 gi-header\">Department</div>\r\n                    <div class=\"gi gi-3 gi-header\">Credits</div>\r\n                    <div class=\"gi gi-4 gi-header\">Course</div>\r\n                    <div class=\"gi gi-5 gi-header\">Day</div>\r\n                    <div class=\"gi gi-6 gi-header\">Start Time</div>\r\n                    <div class=\"gi gi-7 gi-header\">End Time</div>\r\n                    <div class=\"gi gi-8 gi-header\">Capacity</div>\r\n                    <div class=\"gi gi-9 gi-header\">Active</div>\r\n                    <div class=\"gi gi-10 gi-header\">Remaining</div>\r\n                </div>\r\n                <div class=\"grid-row\">\r\n                    <input type=\"checkbox\" name=\"selectItem\" class=\"selector\">\r\n                    <div class=\"gi\">1234</div>\r\n                    <div class=\"gi\">Computer Science</div>\r\n                    <div class=\"gi\">3</div>\r\n                    <div class=\"gi\">C# Programming</div>\r\n                    <div class=\"gi\">M/W</div>\r\n                    <div class=\"gi\">1:30pm</div>\r\n                    <div class=\"gi\">2:45pm</div>\r\n                    <div class=\"gi\">30</div>\r\n                    <div class=\"gi\">15</div>\r\n                    <div class=\"gi\">15</div>\r\n                </div>\r\n            </div>\r\n            <button class=\"formButton\">Register for selected courses!</button>\r\n        </form>\r\n    </div>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
