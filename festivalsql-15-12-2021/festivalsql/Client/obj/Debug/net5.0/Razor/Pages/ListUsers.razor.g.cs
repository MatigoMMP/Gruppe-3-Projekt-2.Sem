#pragma checksum "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eee8cec2ea02df0323883438fec48e13b336017e"
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
#line 1 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using festivalsql.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using festivalsql.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "listusers_container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "listusers_list");
            __builder.AddMarkupContent(4, "<h1> Liste over frivillige </h1>");
#nullable restore
#line 9 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
         if (users == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table");
            __builder.AddMarkupContent(8, @"<thead><tr><th>First name</th>
                        <th>Last name</th>
                        <th>Date of birth</th>
                        <th>Email</th>
                        <th>Username</th>
                        <th>Edit</th>
                        <th>Delete</th></tr></thead>
                ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 28 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
                     foreach (var user in users)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 31 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
                                 user.fornavn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n                            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 32 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
                                 user.efternavn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 33 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
                                 user.foedselsdato.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                            ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 34 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
                                 user.email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                            ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 35 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
                                 user.username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                            ");
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
                                                                                   () => GetUser(@user.bruger_id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                            ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
                                                                                   () => DeleteUser(@user.bruger_id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "listusers_submit");
            __builder.AddMarkupContent(40, "<h4>Opret frivillig</h4>\n\n        ");
            __builder.OpenElement(41, "form");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.AddMarkupContent(44, "<label>First name</label>\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "class", "form-control col-sm-3");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
                                                            newUser.fornavn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.fornavn = __value, newUser.fornavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group");
            __builder.AddMarkupContent(52, "<label>Last name</label>\n                ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "class", "form-control col-sm-3");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
                                                            newUser.efternavn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.efternavn = __value, newUser.efternavn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "form-group");
            __builder.AddMarkupContent(60, "<label>Date of birth</label>\n                ");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "type", "date");
            __builder.AddAttribute(63, "class", "form-control col-sm-3");
            __builder.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
                                                                        newUser.foedselsdato

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.foedselsdato = __value, newUser.foedselsdato, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n            ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "form-group");
            __builder.AddMarkupContent(69, "<label>Email</label>\n                ");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "class", "form-control col-sm-3");
            __builder.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
                                                            newUser.email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.email = __value, newUser.email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n            ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "form-group");
            __builder.AddMarkupContent(77, "<label>Username</label>\n                ");
            __builder.OpenElement(78, "input");
            __builder.AddAttribute(79, "class", "form-control col-sm-3");
            __builder.AddAttribute(80, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
                                                            newUser.username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.username = __value, newUser.username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n            ");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "class", "btn btn-primary");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
                                                      SubmitUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(86, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListUsers.razor"
           
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
