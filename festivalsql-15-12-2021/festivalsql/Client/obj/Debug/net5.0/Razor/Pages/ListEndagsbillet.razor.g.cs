#pragma checksum "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListEndagsbillet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1c45a8edb31f7ad23912d0aa38e9c0666e7bbfc"
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
#line 2 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListEndagsbillet.razor"
using festivalsql.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listendagsbillet")]
    public partial class ListEndagsbillet : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "billet_container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "billet_list");
            __builder.AddMarkupContent(4, "<h1> Liste over endagsbilletter </h1>");
#nullable restore
#line 9 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListEndagsbillet.razor"
         if (endags == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListEndagsbillet.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table");
            __builder.AddMarkupContent(8, "<thead><tr><th>Nummer</th>\n                        <th>Navn</th>\n                        <th>Email</th>\n                        <th>Telefon</th>\n                        <th>Edit</th>\n                        <th>Delete</th></tr></thead>\n                ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 27 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListEndagsbillet.razor"
                     foreach (var endagsbillet in endags)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
#nullable restore
#line 30 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListEndagsbillet.razor"
__builder.AddContent(12, endagsbillet.endags_id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n                            ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 31 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListEndagsbillet.razor"
__builder.AddContent(15, endagsbillet.navn);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                            ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 32 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListEndagsbillet.razor"
__builder.AddContent(18, endagsbillet.email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                            ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 33 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListEndagsbillet.razor"
__builder.AddContent(21, endagsbillet.telefon.ToString());

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
#line 35 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListEndagsbillet.razor"
                                                                                   () => GetEndags(@endagsbillet.endags_id)

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
#line 38 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListEndagsbillet.razor"
                                                                                   () => DeleteEndags(@endagsbillet.endags_id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListEndagsbillet.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListEndagsbillet.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListEndagsbillet.razor"
       
    private List<Endags> endags;

    private Endags newEndags = new Endags();

    private bool edit = false;

    protected override async Task OnInitializedAsync()
    {
        endags = await Http.GetFromJsonAsync<List<Endags>>("api/endags");
    }

    private async Task GetEndags(int id)
    {
        newEndags = await Http.GetFromJsonAsync<Endags>("api/endags/detail/" + id);
        edit = true;
    }

    private async Task SubmitEndags()
    {
        if (edit == false)
        {
            await Http.PostAsJsonAsync<Endags>("api/endags/create", newEndags);
            await OnInitializedAsync();
        }
        else
        {
            await Http.PutAsJsonAsync<Endags>("api/endags/edit", newEndags);
            edit = false;
            await OnInitializedAsync();
        }
    }

    private async Task DeleteEndags(int id)
    {
        await Http.DeleteAsync("api/endags/delete" + id);
        await OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
