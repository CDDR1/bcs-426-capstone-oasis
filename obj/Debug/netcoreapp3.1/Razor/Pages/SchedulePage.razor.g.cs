#pragma checksum "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf930b4d877bba2b74b545d4c2a8a847eb39a696"
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
#line 2 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
using EnhancedOasis.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
using DataLibrary;

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
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 15 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
     if (_ActiveAccount.ID != 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenComponent<EnhancedOasis.Shared.NavBar>(5);
            __builder.AddAttribute(6, "PageTitle", "Your Schedule");
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 19 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
             if (registeredCourses.Count == 0)
            {
                // NO REGISTERED CLASSES MESSAGE

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.AddMarkupContent(12, "<div class=\"message\">\r\n                    <span class=\"message-text\">You have not registered for any classes yet.</span>\r\n                    <a class=\"message-link\" href=\"/Register\">Register page...</a>\r\n                </div>\r\n");
#nullable restore
#line 26 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "schedule schedule-grid");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, @"<div class=""grid-row grid-header"">
                    <div class=""gi gi-1 gi-header"">Course</div>
                    <div class=""gi gi-2 gi-header"">Professor</div>
                    <div class=""gi gi-3 gi-header"">Department</div>
                    <div class=""gi gi-4 gi-header"">Start time</div>
                    <div class=""gi gi-5 gi-header"">End Time</div>
                    <div class=""gi gi-6 gi-header"">Day</div>
                </div>
");
#nullable restore
#line 39 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
                 for (int i = 0; i < registeredCourses.Count; i++)
                {
                    Course x = registeredCourses[i];

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "grid-row");
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "gi");
#nullable restore
#line 43 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
__builder.AddContent(24, registeredCourses[i].Course_Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "gi");
#nullable restore
#line 44 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
__builder.AddContent(28, registeredCourses[i].First_Name);

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, " ");
#nullable restore
#line 44 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
__builder.AddContent(30, registeredCourses[i].Last_Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "gi");
#nullable restore
#line 45 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
__builder.AddContent(34, registeredCourses[i].Department);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "gi");
#nullable restore
#line 46 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
__builder.AddContent(38, convertTime(registeredCourses[i].StartTime));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "gi");
#nullable restore
#line 47 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
__builder.AddContent(42, convertTime(registeredCourses[i].EndTime));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "gi");
#nullable restore
#line 48 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
__builder.AddContent(46, registeredCourses[i].Days);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "delete-btn");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
                                                             () => removeCourse(x)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(51, "<img class=\"solid trash-can\" src=\"/Assets/Trash Can.svg\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 51 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 53 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 55 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "        ");
            __builder.OpenComponent<EnhancedOasis.Shared.LogInMessage>(59);
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 59 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Carlos Duque Rivera\OneDrive\Escritorio\College\BCS 426\CapstoneProject\bcs-426-capstone-oasis\Pages\SchedulePage.razor"
       
    List<Course>
    registeredCourses = new List<Course>();

    protected override async Task OnInitializedAsync()
    {
        string sql = "SELECT Course.CourseID, Course.Course_Name, Professor.First_Name, Professor.Last_Name, Course.Department, Course.StartTime, Course.EndTime, Course.Days FROM Course INNER JOIN Professor ON Course.ProfessorID = Professor.ProfessorID INNER JOIN Register ON Course.CourseID = Register.CourseID INNER JOIN Student ON Register.StudentID = Student.StudentID WHERE Student.StudentID = @ID";
        registeredCourses = await _data.LoadData<Course, dynamic>(sql, new { ID = _ActiveAccount.ID }, _config.GetConnectionString("DataConnection"));
    }

    private string convertTime(TimeSpan time)
    {
        return new DateTime().Add(time).ToShortTimeString();
    }

    async void removeCourse(Course course)
    {
        int studentId = _ActiveAccount.ID;

        string removeCourse = "DELETE FROM Register WHERE StudentID = @StudentID AND CourseID = @CourseID";

        await _data.SaveData(removeCourse, new
        {
            // Setting the parameters
            StudentID = studentId,
            CourseID = course.CourseID,
        }, _config.GetConnectionString("DataConnection"));

        // TO DO: Display message that course was removed
        Console.WriteLine("Course was removed!");
        
        registeredCourses.Remove(course);
        
        nm.NavigateTo("/schedule", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ActiveAccount _ActiveAccount { get; set; }
    }
}
#pragma warning restore 1591
