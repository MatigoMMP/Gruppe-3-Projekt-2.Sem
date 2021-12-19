// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace festivalsql.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using festivalsql.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using festivalsql.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Npgsql;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/Pages/PartoutTicket.razor"
using festivalsql.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/partoutbillet")]
    public partial class PartoutTicket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/Pages/PartoutTicket.razor"
       
    private List<Partout> partout;

    private Partout newPartout = new Partout();

    private bool edit = false;

    protected override async Task OnInitializedAsync()
    {
        partout = await Http.GetFromJsonAsync<List<Partout>>("api/partout");
    }

    private async Task GetPartout(int id)
    {
        newPartout = await Http.GetFromJsonAsync<Partout>("api/partout/detail/" + id);
        edit = true;
    }

    private async Task SubmitPartout()
    {
        NavigationManager.NavigateTo("/");
        if (edit == false)
        {
            await Http.PostAsJsonAsync<Partout>("api/partout/create", newPartout);
            await OnInitializedAsync();
        }
        else
        {
            await Http.PutAsJsonAsync<Partout>("api/partout/edit", newPartout);
            edit = false;
            await OnInitializedAsync();
        }
        await IJRuntime.InvokeVoidAsync("alert", "Tak for din bestilling");
    }

    private async Task DeletePartout(int id)
    {
        await Http.DeleteAsync("api/partout/delete" + id);
        await OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
