#pragma checksum "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Pages\SchedulePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0ec0ffe6763ca2fa73fa8e6823f5d74908165aa"
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
#line 1 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\_Imports.razor"
using EnhancedOasis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\_Imports.razor"
using EnhancedOasis.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\_Imports.razor"
using EnhancedOasis.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/schedule")]
    public partial class SchedulePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"./css/general-styles.css\" rel=\"stylesheet\">\r\n<link href=\"./css/SchedulePage.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<EnhancedOasis.Shared.NavBar>(4);
            __builder.AddAttribute(5, "PageTitle", "Your Schedule");
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.AddMarkupContent(7, @"<div class=""container"">
        <div class=""schedule schedule-grid"">
            <div class=""grid-row grid-header"">
                <div class=""gi gi-1 gi-header"">Course</div>
                <div class=""gi gi-2 gi-header"">Professor</div>
                <div class=""gi gi-3 gi-header"">Department</div>
                <div class=""gi gi-4 gi-header"">Start time</div>
                <div class=""gi gi-5 gi-header"">End Time</div>
                <div class=""gi gi-6 gi-header"">Day</div>
            </div>
            <div class=""grid-row"">
                <div class=""gi"">C# Programming</div>
                <div class=""gi"">Ilknur Aydin</div>
                <div class=""gi"">Computer Science</div>
                <div class=""gi"">12:15pm</div>
                <div class=""gi"">1:30pm</div>
                <div class=""gi"">M/W</div>
                <button class=""delete-btn""><img class=""solid trash-can"" src=""/Assets/Trash Can.svg""></button>
            </div>

        </div>
    </div>
");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
