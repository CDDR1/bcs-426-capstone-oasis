#pragma checksum "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6611a59f757bb36a0bc4ceee3123c411ae395d25"
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
#nullable restore
#line 1 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    public partial class AccountForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"./css/general-styles.css\" rel=\"stylesheet\">\r\n<link href=\"./css/AccountForm.css\" rel=\"stylesheet\">\r\n<link href=\"./css/LogInCreateAccountTab.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "TabContainer");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "LogInTab");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "LogInButton");
            __builder.AddAttribute(9, "id", 
#nullable restore
#line 16 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                         LogInButtonStatus

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                      TabSwitchLogIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Log In!");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "CreateAccountTab");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "CreateAccountButton");
            __builder.AddAttribute(19, "id", 
#nullable restore
#line 19 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                 CreateAccountButtonStatus

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                      TabSwitchCreateAccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Create Account!");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "AccountContainer");
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.AddMarkupContent(28, "<div class=\"FarmingdaleLogoContainer\">\r\n        <img class=\"FarmingdaleLogo\" src=\"Assets/farmingdaleLogoWord.png\">\r\n    </div>\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "AccountFormContainer");
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "form");
            __builder.AddAttribute(33, "class", "AccountForm");
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "Inputs");
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 30 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                 if (activeTab == 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "FormItem");
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.AddMarkupContent(42, "<label for=\"email\" class=\"FormLabel\">Email Address</label><br>\r\n                        ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "email");
            __builder.AddAttribute(45, "name", "email");
            __builder.AddAttribute(46, "class", "FormInput");
            __builder.AddAttribute(47, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                                           (e) => { loginEmail=(string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "required", true);
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                   loginEmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loginEmail = __value, loginEmail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "FormItem");
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.AddMarkupContent(56, "<label for=\"password\" class=\"FormLabel\">Password</label><br>\r\n                        ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "password");
            __builder.AddAttribute(59, "name", "password");
            __builder.AddAttribute(60, "class", "FormInput");
            __builder.AddAttribute(61, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                                                    (e) => { loginPassword=(string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "required", true);
            __builder.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                         loginPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loginPassword = __value, loginPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "FormSubmitContainer");
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "class", "FormSubmitButton");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                   Login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(73, "Log In!");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 43 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                 if (activeTab == 1)
                {
                    // @bind is binding the value inside of the input field to a variable so variable name in the code and the binded value must match
                    // @oninput is an event which is setting the binded variable to the value inside the input field

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "                    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "FormItem");
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.AddMarkupContent(80, "<label for=\"fName\" class=\"FormLabel\">First Name</label><br>\r\n                        ");
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "type", "text");
            __builder.AddAttribute(83, "name", "fName");
            __builder.AddAttribute(84, "class", "FormInput");
            __builder.AddAttribute(85, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                                                 (e) => { registerFirstName=(string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "required", true);
            __builder.AddAttribute(87, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                  registerFirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerFirstName = __value, registerFirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                    ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "FormItem");
            __builder.AddMarkupContent(93, "\r\n                        ");
            __builder.AddMarkupContent(94, "<label for=\"lName\" class=\"FormLabel\">Last Name</label><br>\r\n                        ");
            __builder.OpenElement(95, "input");
            __builder.AddAttribute(96, "type", "text");
            __builder.AddAttribute(97, "name", "lName");
            __builder.AddAttribute(98, "class", "FormInput");
            __builder.AddAttribute(99, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                                                (e) => { registerLastName=(string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(100, "required", true);
            __builder.AddAttribute(101, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                  registerLastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerLastName = __value, registerLastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                    ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "FormItem");
            __builder.AddMarkupContent(107, "\r\n                        ");
            __builder.AddMarkupContent(108, "<label for=\"email\" class=\"FormLabel\">Email Address</label><br>\r\n                        ");
            __builder.OpenElement(109, "input");
            __builder.AddAttribute(110, "type", "email");
            __builder.AddAttribute(111, "name", "email");
            __builder.AddAttribute(112, "class", "FormInput");
            __builder.AddAttribute(113, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                                              (e) => { registerEmail=(string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(114, "required", true);
            __builder.AddAttribute(115, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                   registerEmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(116, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerEmail = __value, registerEmail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                    ");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "FormItem");
            __builder.AddMarkupContent(121, "\r\n                        ");
            __builder.AddMarkupContent(122, "<label for=\"password\" class=\"FormLabel\">Password</label><br>\r\n                        ");
            __builder.OpenElement(123, "input");
            __builder.AddAttribute(124, "type", "password");
            __builder.AddAttribute(125, "name", "password");
            __builder.AddAttribute(126, "class", "FormInput");
            __builder.AddAttribute(127, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                                                       (e) => { registerPassword=(string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(128, "required", true);
            __builder.AddAttribute(129, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                         registerPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(130, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerPassword = __value, registerPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                    ");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "FormItem");
            __builder.AddMarkupContent(135, "\r\n                        ");
            __builder.AddMarkupContent(136, "<label for=\"phoneNumber\" class=\"FormLabel\">Phone Number</label><br>\r\n                        ");
            __builder.OpenElement(137, "input");
            __builder.AddAttribute(138, "type", "text");
            __builder.AddAttribute(139, "name", "phoneNumber");
            __builder.AddAttribute(140, "class", "FormInput");
            __builder.AddAttribute(141, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                                                         (e) => { registerPhoneNumber=(string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(142, "required", true);
            __builder.AddAttribute(143, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                        registerPhoneNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(144, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerPhoneNumber = __value, registerPhoneNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n                    ");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "FormItem");
            __builder.AddMarkupContent(149, "\r\n                        ");
            __builder.AddMarkupContent(150, "<label for=\"major\" class=\"FormLabel\">Major</label><br>\r\n                        ");
            __builder.OpenElement(151, "input");
            __builder.AddAttribute(152, "type", "text");
            __builder.AddAttribute(153, "name", "mahor");
            __builder.AddAttribute(154, "class", "FormInput");
            __builder.AddAttribute(155, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                                             (e) => { registerMajor=(string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(156, "required", true);
            __builder.AddAttribute(157, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                                  registerMajor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(158, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerMajor = __value, registerMajor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n                    ");
            __builder.OpenElement(161, "div");
            __builder.AddAttribute(162, "class", "FormSubmitContainer");
            __builder.AddMarkupContent(163, "\r\n                        ");
            __builder.OpenElement(164, "button");
            __builder.AddAttribute(165, "class", "FormSubmitButton");
            __builder.AddAttribute(166, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                                                                   Register

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(167, "Register");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n");
#nullable restore
#line 75 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(170, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor"
       
    private int activeTab = 0;
    private string LogInButtonStatus = "";
    private string CreateAccountButtonStatus = "InActive";

    // Variables needed for using the values in the email and password input of the login screen
    private string loginEmail;
    private string loginPassword;

    // Variables needed for using the values in the first name, last name, email, password, phone number and major of the registration screen
    private string registerFirstName;
    private string registerLastName;
    private string registerEmail;
    private string registerPassword;
    private string registerPhoneNumber;
    private string registerMajor;

    void TabSwitchLogIn()
    {
        CreateAccountButtonStatus = "InActive";
        LogInButtonStatus = "";
        activeTab = 0;
    }

    void TabSwitchCreateAccount()
    {
        LogInButtonStatus = "InActive";
        CreateAccountButtonStatus = "";
        activeTab = 1;
    }

    /// <summary>
    /// Logs into the system
    /// Does this by first building and executing a query to get the student data.
    /// Then the password for the retrieved student data is compared to the password input.
    ///
    /// If the passwords match then tell the user they successfully logged on and move onto the next screen.
    /// </summary>
    async void Login()
    {
        List<Students> students;
        string sql = "SELECT * FROM Student WHERE Email = @LoginEmail";

        students = await _data.LoadData<Students, dynamic>(sql, new { LoginEmail = loginEmail }, _config.GetConnectionString("DataConnection"));

        if (students[0].Password.Equals(loginPassword))
        {
            Console.WriteLine("Login Successful");

            // Switch to the home page for students
            NavManager.NavigateTo("/home");

        }
        else
        {
            // TO DO: Display and error telling the user their email or password is incorrect
            Console.WriteLine("Wrong Password or Email!");
        }
    }

    /// <summary>
    /// This method will check the input fields of the registration inputs.
    /// It will check that the inputs are valid for registration.
    ///
    /// </summary>
    bool inputsAreValid()
    {
        // Checking if any of the input fields are empty
        if (registerFirstName == null || registerLastName == null || registerEmail == null || registerMajor == null || registerPassword == null || registerPhoneNumber == null)
        {
            // TO DO: Alert the user that the input fields must be filled out

            Console.WriteLine("All input fields must be filled out!");
            return false;
        }
        // Checking non-numerical fields such as names or major if there are any numerical values in it.
        // Alert the user if there are any numerical values
        if (registerFirstName.All(char.IsDigit))
        {
            // TO DO: Display error message for first name
            Console.WriteLine("Invalid First Name! Your first name can not contain a numeric value!");
            return false;
        }

        if (registerLastName.All(char.IsDigit))
        {
            // TO DO: Display error message for last name
            Console.WriteLine("Invalid Last Name! Your last name can not contain a numeric value!");
            return false;
        }

        if (registerMajor.All(char.IsDigit))
        {
            // TO DO: Display error message for major
            Console.WriteLine("Invalid Major! Your major can not contain a numeric value!");
            return false;
        }

        // Checking if the password length is less than 8 characters. If it is then alert the user
        if (registerPassword.Length < 8)
        {
            // TO DO: Display error message for password
            Console.WriteLine("Your password must be longer than 8 digits!");
            return false;
        }

        // TO DO: Check if the email format is correct

        return true;
    }

    /// <summary>
    /// Registers a new student to the database if the inputted values are valid.
    /// </summary>
    async void Register()
    {
        // Checking if the inputs are valid. Only register the user if the inputs are value
        if (inputsAreValid())
        {
            // Building the query
            string registerQuery = "INSERT INTO Student (Email, First_Name, Last_Name, Password, Phone_Number, Major) VALUES (@Email, @FirstName, @LastName, @Password, @PhoneNumber, @Major)";

            // TO DO: Do some error checking. Check if the student is already in the database by checking their email.

            // Executing the query and setting the parameters from above
            await _data.SaveData(registerQuery, new
            {

                // Setting the parameters
                Email = registerEmail,
                FirstName = registerFirstName,
                LastName = registerLastName,
                Password = registerPassword,
                PhoneNumber = registerPhoneNumber,
                Major = registerMajor
            }, _config.GetConnectionString("DataConnection"));

            // Switch to the home page for students
            NavManager.NavigateTo("/home");

            Console.WriteLine("You have successfully registered");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
