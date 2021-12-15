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
#line 2 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListJobs.razor"
using festivalsql.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listjobs")]
    public partial class ListJobs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/ListJobs.razor"
           
        private List<Job> jobs;

        private Job newJob = new Job();

        private bool edit = false;

        protected override async Task OnInitializedAsync()
        {
            jobs = await Http.GetFromJsonAsync<List<Job>>("api/job");
        }

        private async Task GetJob(int id)
        {
            newJob = await Http.GetFromJsonAsync<Job>("api/job/detail/" + id);
            edit = true;
        }

        private async Task SubmitJob()
        {
            if (edit == false)
            {
                await Http.PostAsJsonAsync<Job>("api/job/create", newJob);
                await OnInitializedAsync();
            }
            else
            {
                await Http.PutAsJsonAsync<Job>("api/job/edit", newJob);
                edit = false;
                await OnInitializedAsync();
            }
        }

        private async Task DeleteJob(int id)
        {
            await Http.DeleteAsync("api/job/delete" + id);
            await OnInitializedAsync();
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
