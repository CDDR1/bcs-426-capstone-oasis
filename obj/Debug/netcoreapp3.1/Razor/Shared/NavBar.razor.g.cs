#pragma checksum "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\Shared\NavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "663e432584fd18236d1e196ca96699cc3bb7e408"
// <auto-generated/>
#pragma warning disable 1591
namespace EnhancedOasis.Shared
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
    public partial class NavBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"./css/NavBar.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "NavBarContainer");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"FarmingdaleEmblemContainer\">\r\n        <img class=\"FarmingdaleEmblem\" src=\"Assets/farmingdaleEmblem.png\">\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "OasisHeader");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "h2");
            __builder.AddAttribute(9, "class", "OasisDesc");
#nullable restore
#line 8 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\Shared\NavBar.razor"
__builder.AddContent(10, PageTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 10 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\Shared\NavBar.razor"
     if(PageTitle == "Register For Courses" || PageTitle == "Your Schedule") {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.AddMarkupContent(14, "<div class=\"pages\">\r\n        <a class=\"pageLink\" href=\"/home\">Home</a>\r\n        <a class=\"pageLink\" href=\"/schedule\">Schedule</a>\r\n        <a class=\"pageLink\" href=\"/register\">Register</a>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\Shared\NavBar.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\awsom\Documents\GitHub\bcs-426-capstone-oasis\Shared\NavBar.razor"
       
    [Parameter]
    public string? PageTitle { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
