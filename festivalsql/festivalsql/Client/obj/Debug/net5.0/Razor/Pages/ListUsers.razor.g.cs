#pragma checksum "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2d9825e76c7120fec2bcd75172a057fc54dbbd4"
// <auto-generated/>
#pragma warning disable 1591
namespace festivalsql.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using festivalsql.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using festivalsql.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
using festivalsql.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listusers")]
    public partial class ListUsers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Users</h1>");
#nullable restore
#line 7 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
 if (users == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 10 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>First name</th>\n                <th>Last name</th>\n                <th>Date of birth</th>\n                <th>Email</th>\n                <th>Username</th>\n                <th>Edit</th>\n                <th>Delete</th></tr></thead>\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 26 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
             foreach (var user in users)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
#nullable restore
#line 29 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
__builder.AddContent(8, user.fornavn);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n                    ");
            __builder.OpenElement(10, "td");
#nullable restore
#line 30 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
__builder.AddContent(11, user.efternavn);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                    ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 31 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
__builder.AddContent(14, user.foedselsdato.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 32 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
__builder.AddContent(17, user.email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 33 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
__builder.AddContent(20, user.username);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
                                                                           () => GetUser(@user.bruger_id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                    ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
                                                                           () => DeleteUser(@user.bruger_id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "<h4>Submit user</h4>\n\n");
            __builder.OpenElement(34, "form");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-group");
            __builder.AddMarkupContent(37, "<label>First name</label>\n        ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "class", "form-control col-sm-3");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
                                                    newUser.fornavn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.fornavn = __value, newUser.fornavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group");
            __builder.AddMarkupContent(45, "<label>Last name</label>\n        ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "class", "form-control col-sm-3");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
                                                    newUser.efternavn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.efternavn = __value, newUser.efternavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "form-group");
            __builder.AddMarkupContent(53, "<label>Date of birth</label>\n        ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "date");
            __builder.AddAttribute(56, "class", "form-control col-sm-3");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
                                                                newUser.foedselsdato

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.foedselsdato = __value, newUser.foedselsdato, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "form-group");
            __builder.AddMarkupContent(62, "<label>Email</label>\n        ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "class", "form-control col-sm-3");
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
                                                    newUser.email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.email = __value, newUser.email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "form-group");
            __builder.AddMarkupContent(70, "<label>Username</label>\n        ");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "class", "form-control col-sm-3");
            __builder.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
                                                    newUser.username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.username = __value, newUser.username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n    ");
            __builder.OpenElement(76, "button");
            __builder.AddAttribute(77, "class", "btn btn-primary");
            __builder.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
                                              SubmitUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(79, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListUsers.razor"
       
    private List<User> users;

    private User newUser = new User();

    private bool edit = false;

    protected override async Task OnInitializedAsync()
    {
        users = await Http.GetFromJsonAsync<List<User>>("api/user");
    }

    private async Task GetUser(int id)
    {
        newUser = await Http.GetFromJsonAsync<User>("api/user/detail/" + id);
        edit = true;
    }

    private async Task SubmitUser()
    {
        if (edit == false)
        {
            await Http.PostAsJsonAsync<User>("api/user/create", newUser);
            await OnInitializedAsync();
        }
        else
        {
            await Http.PutAsJsonAsync<User>("api/user/edit", newUser);
            edit = false;
            await OnInitializedAsync();
        }
    }

    private async Task DeleteUser(int id)
    {
        await Http.DeleteAsync("api/user/delete" + id);
        await OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
