// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace miljoefestival.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/victorpascale/Projects/miljoefestival/miljoefestival/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/victorpascale/Projects/miljoefestival/miljoefestival/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/victorpascale/Projects/miljoefestival/miljoefestival/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/victorpascale/Projects/miljoefestival/miljoefestival/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/victorpascale/Projects/miljoefestival/miljoefestival/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/victorpascale/Projects/miljoefestival/miljoefestival/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/victorpascale/Projects/miljoefestival/miljoefestival/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/victorpascale/Projects/miljoefestival/miljoefestival/Client/_Imports.razor"
using miljoefestival.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/victorpascale/Projects/miljoefestival/miljoefestival/Client/_Imports.razor"
using miljoefestival.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/victorpascale/Projects/miljoefestival/miljoefestival/Client/Pages/Index.razor"
using miljoefestival.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/Users/victorpascale/Projects/miljoefestival/miljoefestival/Client/Pages/Index.razor"
       
    private User[] userList;

    protected override async Task OnInitializedAsync()
    {
        userList = await Http.GetFromJsonAsync<User[]>("api/User/Get");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
