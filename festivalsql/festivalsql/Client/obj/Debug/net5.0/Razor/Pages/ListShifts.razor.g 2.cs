#pragma checksum "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9074037e2f72cae091430ca7182be6e0d4388d0"
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
#line 1 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using festivalsql.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/_Imports.razor"
using festivalsql.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
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
            __builder.AddMarkupContent(0, "<h1>Shifts</h1>");
#nullable restore
#line 7 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
 if (shifts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 10 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Start time</th>\n                <th>End time</th>\n                <th>Job</th>\n                <th>User</th>\n                <th>Edit</th>\n                <th>Delete</th></tr></thead>\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 25 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
             foreach (var shift in shifts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 28 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
                         shift.starttid

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 29 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
                         shift.sluttid

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 30 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
                         shift.opgave_id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 31 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
                         shift.bruger_id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
                                                                           () => GetShift(@shift.vagt_id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
                                                                           () => DeleteShift(@shift.vagt_id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<h4>Submit user</h4>\n\n");
            __builder.OpenElement(31, "form");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group");
            __builder.AddMarkupContent(34, "<label>Start time</label>\n        ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "class", "form-control col-sm-3");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
                                                    newShift.starttid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newShift.starttid = __value, newShift.starttid));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "form-group");
            __builder.AddMarkupContent(42, "<label>End time</label>\n        ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "class", "form-control col-sm-3");
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
                                                    newShift.sluttid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newShift.sluttid = __value, newShift.sluttid));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "form-group");
            __builder.AddMarkupContent(50, "<label>Job</label>\n        ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "class", "form-control col-sm-3");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
                                                    newShift.opgave_id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newShift.opgave_id = __value, newShift.opgave_id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "form-group");
            __builder.AddMarkupContent(58, "<label>User</label>\n        ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "class", "form-control col-sm-3");
            __builder.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
                                                    newShift.bruger_id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newShift.bruger_id = __value, newShift.bruger_id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n    ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "class", "btn btn-primary");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
                                              SubmitShift

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(67, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql/festivalsql/Client/Pages/ListShifts.razor"
       
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