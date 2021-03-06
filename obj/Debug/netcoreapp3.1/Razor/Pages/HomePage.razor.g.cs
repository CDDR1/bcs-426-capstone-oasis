#pragma checksum "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\Pages\HomePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d8e7aa205824da4e6b94d9af0463e66336344b1"
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
#nullable restore
#line 2 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\Pages\HomePage.razor"
using EnhancedOasis.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    public partial class HomePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"./css/general-styles.css\" rel=\"stylesheet\">\r\n<link href=\"./css/HomePage.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 9 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\Pages\HomePage.razor"
     if (_ActiveAccount.ID != 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenComponent<EnhancedOasis.Shared.NavBar>(5);
            __builder.AddAttribute(6, "PageTitle", "Home");
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n         ");
            __builder.OpenElement(8, "h1");
            __builder.AddAttribute(9, "class", "WelcomeMessage");
            __builder.AddContent(10, "Welcome ");
            __builder.AddContent(11, 
#nullable restore
#line 12 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\Pages\HomePage.razor"
                                             _ActiveAccount.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, "!");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.AddMarkupContent(14, @"<div class=""container"">
            <div class=""option-container"">
                <div class=""option-title-container"">
                    <h2 class=""option-title"">Schedule</h2>
                </div>
                <a class=""option-img-container"" href=""/schedule"">
                    <img class=""option-img"" src=""./Assets/schedule-img.jpg"" alt>
                </a>
            </div>

            <div class=""option-container"">
                <div class=""option-title-container"">
                    <h2 class=""option-title"">Register</h2>
                </div>
                <a class=""option-img-container"" href=""/register"">
                   <img class=""option-img img-hover-zoom"" src=""./Assets/register-img.jpg"" alt>
                </a>
            </div>
        </div>
");
#nullable restore
#line 34 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\Pages\HomePage.razor"
    } else { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "        ");
            __builder.OpenComponent<EnhancedOasis.Shared.LogInMessage>(16);
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 36 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\Pages\HomePage.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ActiveAccount _ActiveAccount { get; set; }
    }
}
#pragma warning restore 1591
