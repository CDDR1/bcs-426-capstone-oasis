#pragma checksum "C:\Users\Carlos Duque Rivera\source\repos\EnhancedOasis\EnhancedOasis\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6db0c6f1a95b0d97c95531a0bc5d3dfa12d7e4ac"
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
#line 1 "C:\Users\Carlos Duque Rivera\source\repos\EnhancedOasis\EnhancedOasis\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carlos Duque Rivera\source\repos\EnhancedOasis\EnhancedOasis\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Carlos Duque Rivera\source\repos\EnhancedOasis\EnhancedOasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Carlos Duque Rivera\source\repos\EnhancedOasis\EnhancedOasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Carlos Duque Rivera\source\repos\EnhancedOasis\EnhancedOasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Carlos Duque Rivera\source\repos\EnhancedOasis\EnhancedOasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Carlos Duque Rivera\source\repos\EnhancedOasis\EnhancedOasis\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Carlos Duque Rivera\source\repos\EnhancedOasis\EnhancedOasis\_Imports.razor"
using EnhancedOasis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Carlos Duque Rivera\source\repos\EnhancedOasis\EnhancedOasis\_Imports.razor"
using EnhancedOasis.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"./css/general-styles.css\" rel=\"stylesheet\">\r\n    \r\n");
            __builder.OpenComponent<EnhancedOasis.Shared.NavBar>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "ContentContainer");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenComponent<EnhancedOasis.Shared.AccountForm>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
