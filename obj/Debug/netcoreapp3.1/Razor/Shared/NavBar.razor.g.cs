#pragma checksum "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Shared\NavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "119a1b1778b3ac6defcbef885265d3dc2657c010"
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
#line 1 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\_Imports.razor"
using EnhancedOasis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\_Imports.razor"
using EnhancedOasis.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\_Imports.razor"
using EnhancedOasis.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Shared\NavBar.razor"
using EnhancedOasis.Models;

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
#line 13 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Shared\NavBar.razor"
__builder.AddContent(10, PageTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 15 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Shared\NavBar.razor"
     if(PageTitle == "Register For Courses" || PageTitle == "Your Schedule") {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "pages");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.AddMarkupContent(17, "<a class=\"pageLink\" href=\"/home\"><span class=\"pageLink-text\">Home</span></a>\r\n        ");
            __builder.AddMarkupContent(18, "<a class=\"pageLink\" href=\"/schedule\"><span class=\"pageLink-text\">Schedule</span></a>\r\n        ");
            __builder.AddMarkupContent(19, "<a class=\"pageLink\" href=\"/register\"><span class=\"pageLink-text\">Register</span></a>\r\n        ");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "class", "pageLink");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Shared\NavBar.razor"
                                      Logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "<span class=\"pageLink-text\">Log Out</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 22 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Shared\NavBar.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Shared\NavBar.razor"
     if (PageTitle == "Home")
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "pages");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "pageLink");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Shared\NavBar.razor"
                                               Logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Log Out");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "       \r\n");
#nullable restore
#line 28 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Shared\NavBar.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Shared\NavBar.razor"
       
    [Parameter]
    public string? PageTitle { get; set; }

    private void Logout() 
    {
        _ActiveAccount.ID = 0;
        _ActiveAccount.FirstName = "";
        NM.NavigateTo("/", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NM { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ActiveAccount _ActiveAccount { get; set; }
    }
}
#pragma warning restore 1591
