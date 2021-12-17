#pragma checksum "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b095a3fc9bb31b7d0530eaeb21c331a5a68a4c3"
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
#line 1 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using festivalsql.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using festivalsql.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Npgsql;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
using festivalsql.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listshifts")]
    public partial class ListShifts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "listshifts_container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "listshifts_list");
            __builder.AddMarkupContent(4, "<h1>Liste over vagter</h1>");
#nullable restore
#line 9 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
         if (shifts == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table");
            __builder.AddMarkupContent(8, "<thead><tr><th>Start time</th>\n                        <th>End time</th>\n                        <th>Job</th>\n                        <th>User</th>\n                        <th>Edit</th>\n                        <th>Delete</th></tr></thead>\n                ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 27 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
                     foreach (var shift in shifts)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
#nullable restore
#line 30 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
__builder.AddContent(12, shift.starttid);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n                            ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 31 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
__builder.AddContent(15, shift.sluttid);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                            ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 32 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
__builder.AddContent(18, shift.opgave_id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                            ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 33 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
__builder.AddContent(21, shift.bruger_id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                            ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
                                                                                   () => GetShift(@shift.vagt_id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                            ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
                                                                                   () => DeleteShift(@shift.vagt_id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "listshifts_submit");
            __builder.AddMarkupContent(37, "<h4>Opret vagt</h4>\n\n        ");
            __builder.OpenElement(38, "form");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group");
            __builder.AddMarkupContent(41, "<label>Start time</label>\n                ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "class", "form-control col-sm-3");
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
                                                            newShift.starttid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newShift.starttid = __value, newShift.starttid));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "form-group");
            __builder.AddMarkupContent(49, "<label>End time</label>\n                ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "class", "form-control col-sm-3");
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
                                                            newShift.sluttid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newShift.sluttid = __value, newShift.sluttid));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n            ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-group");
            __builder.AddMarkupContent(57, "<label>Job</label>\n                ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "class", "form-control col-sm-3");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
                                                            newShift.opgave_id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newShift.opgave_id = __value, newShift.opgave_id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n            ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form-group");
            __builder.AddMarkupContent(65, "<label>User</label>\n                ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "class", "form-control col-sm-3");
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
                                                            newShift.bruger_id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newShift.bruger_id = __value, newShift.bruger_id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n            ");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "class", "btn btn-primary");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
                                                      SubmitShift

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(74, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListShifts.razor"
               
            private List<Shift> shifts;

            private Shift newShift = new Shift();

            private bool edit = false;

            protected override async Task OnInitializedAsync()
            {
                shifts = await Http.GetFromJsonAsync<List<Shift>>("api/shift");
            }

            private async Task GetShift(int id)
            {
                newShift = await Http.GetFromJsonAsync<Shift>("api/shift/detail/" + id);
                edit = true;
            }

            private async Task SubmitShift()
            {
                if (edit == false)
                {
                    await Http.PostAsJsonAsync<Shift>("api/shift/create", newShift);
                    await OnInitializedAsync();
                }
                else
                {
                    await Http.PutAsJsonAsync<Shift>("api/shift/edit", newShift);
                    edit = false;
                    await OnInitializedAsync();
                }
            }

            private async Task DeleteShift(int id)
            {
                await Http.DeleteAsync("api/shift/delete" + id);
                await OnInitializedAsync();
            }
        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
