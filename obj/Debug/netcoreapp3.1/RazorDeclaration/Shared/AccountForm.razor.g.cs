#pragma checksum "C:\Users\paulk\Desktop\BCS_426_Capstone\bcs-426-capstone-oasis\Shared\AccountForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6611a59f757bb36a0bc4ceee3123c411ae395d25"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
